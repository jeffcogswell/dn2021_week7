interface Racer {
    team: string;
    speed: number;
    accelerate(): void;
    isFuelEmpty(): boolean;
}

class SolarCar implements Racer {
    team: string;
    speed: number = 0;
    constructor(team: string) {
        this.team = team;
    }
    accelerate() : void {
        this.speed++;
    }
    isFuelEmpty() : boolean {
        return false;
    }
}

class GasCar implements Racer {
    team: string;
    speed: number = 0;
    fuel: number;
    constructor(team: string, fuel: number) {
        this.team = team;
        this.fuel = fuel;
    }
    accelerate(): void {
        this.speed += 2;
        this.fuel--;
    }
    isFuelEmpty(): boolean {
        return this.fuel <= 0;
    }
}

function findRacersWithEmptyFuel(racers: Racer[]): Racer[] {
    let results: Racer[] = [];

    racers.forEach(
        function(item: Racer) {
            if (item.isFuelEmpty()) {
                results.push(item);
            }
        }
    );

    return results;
} 

let AllCars: Racer[] = [];

let gc1 = new GasCar('Team GC', 4);
AllCars.push(gc1);
console.log(gc1);
gc1.accelerate();
console.log(gc1);
gc1.accelerate();
console.log(gc1);
gc1.accelerate();
console.log(gc1);
gc1.accelerate();
console.log(gc1);

let ford1 = new SolarCar('Team Ford');
AllCars.push(ford1);
ford1.accelerate();
ford1.accelerate();
console.log(ford1);

let chevy1 = new GasCar('Team Chevy', 5);
AllCars.push(chevy1);

console.log('Who is out of fuel?');
console.log(findRacersWithEmptyFuel(AllCars));





