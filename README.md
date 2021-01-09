# Patterns sur Unity

* Observer
* Command
* Strategy

## Explications

### Observer

Ce pattern est utilisé quand un objet doit recevoir des informations d'une quantité importante d'objets. 
Dans l'exemple de ce repository, la scène contient 9 cubes. Lorsqu'on clic sur un cube, il change de couleur. 
Le cube appelle alors l'event abonné correspondant. Dans ce cas, une méthode incrémentant le nombre de clics
sur cube réalisés depuis le début. 

### Command

Le command pattern est utilisé pour enregistrer les actions ou évènements réalisées. En utilisant le polymorphisme, il isole les features dans leurs
propres classes, ce qui permet leurs enregistrements pour diverses implémentations comme un système de rewind (retour en arrière) ou mise en liste d'attente.
Dans cet exemple, l'interface "ICommand" comportant les méthodes Execute() et Undo() est implémentée. 
Execute() change la couleur du cube cliqué, et Undo retourne à la couleur précédente.
Une commande est alors créée à partir de cette interface, incluant les implémentations de Execute() et Undo(). 
Execute() est appelée dans UserInput.cs, ce script associe le cube sur lequel l'utilisateur clic avec la commande, puis execute cette commande.
Le singleton CommandManager.cs comporte une liste dans lesquelles ces commandes sont enregistrées, permettant donc de parcourir les actions faites, grâce aux appels des méthodes Execute() et Undo(). 
Ce pattern est par exemple utilisé dans des jeux de stratégies, où des queues d'actions sont requises, des rewinds, etc..

### Strategy

Le pattern Strategy permet d'assigner dynamiquement des composants aux objets, ce qui permet d'être modulaire, donc de pouvoir implémenter des features facilement plus tard dans le développement. Ce pattern est utilisé quand l'héritage ne suffit plus à combler les besoins d'un produit. Par exemple, si un vaisseau tire plusieurs types de missiles différemment. Ce pattern est donc utilisé quand nous avons plusieurs choix de comportements pour un seul objet. 
Dans cet exemple, le joueur peut choisir son type d'armes et de feux. Grâce à l'implémentation d'interfaces et du polymorphisme, cette méthode permet de rester
performant et facilite l'ajout du nouveau types de missiles ou feux. 