### System Overview ###

This section is to overview the way a system works in an entity component system. Because I've just scratched the surface of ECS this explanation will be simplistic, but helpful nonetheless. I'll try to improve my writing style, bear with me.

If you look to the left you'll see a basic drawing of a system
<a href="url"><img src="http://i.imgur.com/XducCqe.png" align="left" height="500"></a>


The update() and render() sections are function calls that the game makes in one loop of a running game. The name E1 refers to an entity which is simply an number! The components ONLY hold data, making Morinda effectively data driven. Now that this is a page for Systems, I'll talk about them a bit more.

Simply put, Systems control components. They take a list of components (derived from entities) and perform the same procedure on each entity. Like a conveyer belt, every game tick a system takes your components (which is just data) and modifies it to procure the illusion of movement or AI. 

[pic1]: http://i.imgur.com/XducCqe.png "System Diagram"
