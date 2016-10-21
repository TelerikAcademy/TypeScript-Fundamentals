let animal = "cat";

switch (animal) {
    case "dog":
    case "cat":
    case "cow":
        console.log("MAMMAL");
        break;
    case "crocodile":
    case "tortoise":
    case "snake":
        console.log("REPTILE");
        break;
    case "hawk":
    case "sparrow":
    case "dove":
        console.log("BIRD");
        break;
    default:
        console.log("I don't know this animal!");
        break;
}