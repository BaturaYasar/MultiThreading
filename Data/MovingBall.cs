using System;
namespace tutorialParallelism.Data
{
public class MovingBall
{
public int x { get; set; }
public int y { get; set; }
public string color { get; set; } ="#0000BB";
private int delthaX, delthaY;
private int limitMinX, limitMaxX;
private int limitMinY, limitMaxY;
public MovingBall(int initialX, int initialY) {
this.x = initialX;
this.y = initialY;
this.delthaX=1;
this.delthaY=1;
this.limitMinX=0;
this.limitMaxX=100;
}
public void setVelocity(int diffX,int diffY) {
this.delthaX = diffX;
this.delthaY = diffY;
}
public void setLimitX(int min,int max) {
this.limitMinX = min;
this.limitMaxX = max;
}
public void setLimitY(int min,int max) {
this.limitMinY = min;
this.limitMaxY = max;
}
public void next() {
this.x += this.delthaX;
this.y += this.delthaY;
if(this.x<this.limitMinX || this.x>this.limitMaxX)
this.delthaX *= -1;
if(this.y<this.limitMinY || this.y>this.limitMaxY)
this.delthaY *= -1;
}
}
}