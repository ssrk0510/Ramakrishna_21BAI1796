const connection = new signalR.HubConnectionBuilder()
    .withUrl("/gamehub")
    .build();

connection.on("ReceiveMove", (fromX, fromY, toX, toY) => {
    // Update the game board based on the move
});

async function makeMove(fromX, fromY, toX, toY) {
    await connection.invoke("SendMove", fromX, fromY, toX, toY);
}

connection.start().catch(err => console.error(err.toString()));