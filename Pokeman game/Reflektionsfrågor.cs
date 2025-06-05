/*❓ Reflection Questions
 
F: When you create a Pokémon and try to access its fields directly – does it work? Why or why not?
A: Pga inkapsling och validering via properties. Du kan inte direkt komma åt fälten, utan måste använda egenskaperna

F: If you later want to add a new property that applies to all Electric-type Pokémon, where should you place it to avoid repetition?
A: I electricPokemon.cs

F: If instead the new property should apply to all Pokémon, where would be the correct place to define it?
A: I pokemon.cs

F: What happens if you try to add a Charmander to a list that only allows WaterPokemon?
A: Kompilatorfel, olika typer

F: You want to store different types of Pokémon – Charmander, Squirtle, and Pikachu – in the same list. What type should the list have for that to work?
A: List<pokemon>

F: When you loop through the list and call Attack(), what ensures that the correct attack behavior is executed for each Pokémon?
A: Polymorfism. Varje Pokémon har sin egen implementation av Attack()

F: If you create a method that only exists on Pikachu, why can’t you call it directly when it’s stored in a List<Pokemon>? How could you still access it?
A: Listan känner bara till pokemon typen. Typkontroll + castning till Pikachu krävs för att komma åt metoden

*/