class BankAccount {
    balance: number = 0;
    interestRate: number = 0;
    addInterest() : void {
        let interest: number = this.balance * this.interestRate / 100;
        this.balance += interest;
    }
}

class BankAccountWithFee extends BankAccount {
    fee: number = 0;
    applyFee() : void {
        this.balance -= this.fee;
    }
}

let b1 = new BankAccount();
b1.balance = 100;
b1.interestRate = 2.5;
b1.addInterest();
console.log(b1);
b1.addInterest();
console.log(b1);

let b2 = new BankAccountWithFee();
b2.balance = 100;
b2.fee = 5;
b2.interestRate = 1.5;
b2.addInterest();
b2.applyFee();
console.log(b2);
