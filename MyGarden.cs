function setup() {
  createCanvas(600, 400);
}

function draw() {
  background(135, 206, 235);

  fill(80, 180, 80);
  rect(0, 320, 600, 80);

  drawTree(150, 250, 100);
  drawTree(80, 270, 70);
  drawTree(220, 270, 70);

  drawHouse(400, 220);

  fill(255);
  textSize(20);
  textAlign(CENTER);
  text("My Garden", 300, 40);
}

function drawTree(x, y, size) {
  let trunkSize = size * 0.2;

  fill(120, 70, 30);
  rect(x - trunkSize / 2, y, trunkSize, size);

  fill(30, 140, 50);
  ellipse(x, y - 20, size, size);

  drawApple(x - 20, y - 25, 10);
  drawApple(x + 20, y - 35, 10);
  drawApple(x, y + 5, 10);
}

function drawApple(x, y, size) {
  let appleSize = getAppleSize(size);

  fill(255, 0, 0);
  ellipse(x, y, appleSize, appleSize);

  fill(50, 100, 20);
  rect(x, y - appleSize / 2, 3, appleSize / 2);
}

function drawHouse(x, y) {
  fill(240, 190, 120);
  rect(x, y, 130, 100);

  fill(180, 50, 50);
  triangle(x - 10, y, x + 65, y - 60, x + 140, y);

  fill(100, 60, 30);
  rect(x + 50, y + 50, 30, 50);

  fill(120, 200, 255);
  rect(x + 10, y + 20, 25, 25);
  rect(x + 95, y + 20, 25, 25);
}

function getAppleSize(size) {
  let appleSize = size * 2;
  return appleSize;
}
