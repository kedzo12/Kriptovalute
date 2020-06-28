import React, { Component } from 'react';

export class Crypto extends Component {
    static displayName = Crypto.name;

    constructor(props) {
        super(props);
        this.state = { transaction: [] };
    }

    async getTransData() {
        const response = await fetch('crypto');
        const data = await response.json();
        this.setState({ transaction: data });
    }
    componentDidMount() {
        this.getTransData();
    }



    render() {
        return (
            <div>
                <h1>Transaction</h1>

                <h4>Transaction info:</h4>

                <p aria-live="polite">Transaction id: <strong>{this.state.transaction.transactionId}</strong></p>
                <p aria-live="polite">Transaction block hash: <strong>{this.state.transaction.transactionBlockHash}</strong></p>
                <p aria-live="polite">Transaction confirmations: <strong>{this.state.transaction.transactionConfirmations}</strong></p>
                <p aria-live="polite">Transaction hex: <strong>{this.state.transaction.transactionHex}</strong></p>
                <p aria-live="polite">Transaction lock time: <strong>{this.state.transaction.transactionLockTime}</strong></p>
                <p aria-live="polite">Transaction time: <strong>{this.state.transaction.transactionTime}</strong></p>
                <p aria-live="polite">Transaction version: <strong>{this.state.transaction.transactionVersion}</strong></p>
                <p aria-live="polite">Chain: <strong>{this.state.transaction.chain}</strong></p>
                <p aria-live="polite">Block Hash: <strong>{this.state.transaction.blockHash}</strong></p>
                <p aria-live="polite">Blocks: <strong>{this.state.transaction.blocks}</strong></p>
                <p aria-live="polite">Balance: <strong>{this.state.transaction.balance}</strong></p>


            </div>
        );
    }
}
