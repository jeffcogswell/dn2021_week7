let n: number | string = 'hello'; // If we want, we can say a variable is allowed to hold more than one type
                                  // This is known as a "union type"

interface Movie {
    title: string;
    description: string;
    release: number;
}

let movie1: Movie = {
    title: 'Star Wars',
    description: 'Luke saves the universe',
    release: 1977
};

let movie2: Movie = {
    title: 'Adaptation',
    description: 'Orchids',
    release: 1999
};

let movie3: Movie = {
    title: 'Being John Malkovich',
    description: 'Malkovich gets possessed',
    release: 2000
}

let movie4: Movie = {
    title: 'The Godfather',
    description: 'Young mafia guy becomes boss',
    release: 1972
}

let stuff = {
    a:10, b: 20
}

let allmovies: Movie[] = [movie1, movie2, movie3, movie4];

let earliest: number = 3000;
for (let i:number = 0; i < allmovies.length; i++) {
    if (allmovies[i].release < earliest) {
        earliest = allmovies[i].release;
    }
}
console.log(earliest);

console.log("Let's try out forEach! (version 1 -- regular function)");
let latest: number = 0;
function check(item: Movie) {
    //console.log(item);
    if (item.release > latest) {
        latest = item.release;
    }
}
allmovies.forEach(check);
console.log(latest);

console.log("Let's try out forEach! (version 2 -- anonymous function)");
latest = 0;
allmovies.forEach(function(item: Movie) {
    //console.log(item);
    if (item.release > latest) {
        latest = item.release;
    }
});
console.log(latest);

console.log("Let's try out forEach! (version 3 -- arrow function)");
latest = 0;
allmovies.forEach((item: Movie) => {
    if (item.release > latest) {
        latest = item.release;
    }
});
console.log(latest);

function SearchName(name: string):Movie | null  {
    for (let i:number = 0; i < allmovies.length; i++) {
        if (allmovies[i].title == name) {
            return allmovies[i];
        }
    }
    return null;
}

let found: Movie | null = SearchName('Star Wars');

let found2: any = SearchName('The Godfather'); // Try to avoid doing this. 'any' kind of overrides the types

console.log(found);
console.log(found2);

found = SearchName('The Avengers');
console.log(found);

//
// Play with classes
//

class Rectangle {
    length: number = 0;
    width: number = 0;
    constructor() {
        this.length = 10;
        this.width = 10;
    };

}

let r1:Rectangle = new Rectangle();
//r1.length = 10;
//r1.width = 20;

console.log(r1);


