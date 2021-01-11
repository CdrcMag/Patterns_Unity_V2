using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour
{

    private static CommandManager _instance;
    public static CommandManager Instance
    {
        get
        {
            if (!_instance)
                Debug.LogError("The command manager is missing.");
            return _instance;
        }

    }

    private List<ICommand> _commandsBuffer = new List<ICommand>();

    //External method to view the buffer in the console
    [ContextMenu("Show list")]
    public void ShowList()
    {
        print("List count : " + _commandsBuffer.Count);
        for(int i = 0; i < _commandsBuffer.Count; i++)
        {
            print(i + " : " + _commandsBuffer[i]);
        }
    }


    private void Awake()
    {
        _instance = this;
    }

    //Adds a command to the buffer
    public void AddCommand(ICommand cmd)
    {
        _commandsBuffer.Add(cmd);
    }


    //Play every actions from the beggining
    public void Play() => StartCoroutine(iPlay());
    IEnumerator iPlay()
    {
        foreach(ICommand cmd in _commandsBuffer)
        {
            cmd.Execute();
            yield return new WaitForSeconds(1f);
        }
        
    }

    //Rewind every actions made
    public void Rewind() => StartCoroutine(iRewind());
    IEnumerator iRewind()
    {
        for(int i = _commandsBuffer.Count-1; i >= 0; --i)
        {
            _commandsBuffer[i].Undo();
            yield return new WaitForSeconds(1f);
        }
    }
    
    //When done, clear all colors
    public void Done()
    {
        for(int i = 0; i < _commandsBuffer.Count; i++)
        {
            _commandsBuffer[i].ResetColor();
        }
    }

    //Resets the command buffer
    public void ResetCommands()
    {
        _commandsBuffer.Clear();
    }





}
