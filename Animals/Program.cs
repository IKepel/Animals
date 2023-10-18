using Animals.AnimalClasses;
using Animals.AnimalClasses.Fish;
using Animals.AnimalClasses.Bird;
using Animals.AnimalClasses.Mammal;


var dog = new Dog("Chappie", 3);
var shark = new Shark("Nero", 10);

dog.Move();
dog.Speak();
Console.WriteLine();
shark.Move();
shark.Speak();