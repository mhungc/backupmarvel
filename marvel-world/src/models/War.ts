import { Hero } from "./Hero";
import { Villain } from "./Villain";

export interface War {
    hero: Hero;
    villain: Villain;
    fightResult: number;
    showResult: string;
}