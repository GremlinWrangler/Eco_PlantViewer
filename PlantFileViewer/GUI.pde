void drawbars(){
   background(0);
  colorMode(HSB, 100);
  rectMode(CORNERS);
  stroke(50,50,50);
  fill(0,50,50);
  rect(0,0,60,20);
  fill(100);
  stroke(00);
    
   text("Save out",5,15);
     fill(50,0);

  int lengthOfClickMarkers = clickmarkers.length;
  for (int i=0;i<lengthOfClickMarkers-1;i++){
   rect(clickmarkers[i],20,clickmarkers[i+1],25); 
  }
  fill(100);
    text("water",clickmarkers[1],20);
    text("temp",clickmarkers[5],20);
    text("age",clickmarkers[8],20);
    text("rate",clickmarkers[9],20);
    text("death",clickmarkers[10],20);
    text("spread",clickmarkers[11],20);
    if (buttonState[0]==1){
        text("ground",clickmarkers[12],20);
            text("shrub",clickmarkers[13],20);
                text("canopy",clickmarkers[14],20);
                    text("spawn range",clickmarkers[15],20);
         text("coverage",clickmarkers[17],20);
    }
  int numberOfFiles= fileNamesToUse.length;
  for (int fileCounter=0;fileCounter<numberOfFiles;fileCounter++){
       
       for (int drawValues=0;drawValues<4;drawValues++){
       float xStart=200+floor(drawValues/2)*60;
       float yStart=34+fileCounter*15;
       
       fill(0,0);
       stroke(100);
       rectMode(CORNER);
       rect(xStart,yStart-6,40,15);
       
       fill(fileCounter,100,50);
       if (drawValues%2==1){yStart=yStart-4; } else fill(0,0);
        xStart=xStart+plantvalues[fileCounter][drawValues*2]*40;
       // yStart=50+fileCounter*15;
    //   println("index"+plantvalues[fileCounter][drawValues*2]);
    float xsize=(plantvalues[fileCounter][drawValues*2+1]-plantvalues[fileCounter][drawValues*2])*40;
       
       rect(xStart,yStart, xsize,8);       
            fill(0,000,100);
       if (drawValues%2==0){text(fileNamesToUse[fileCounter],10,yStart+6);  line(0,yStart+8,500,yStart+8);}      
 
       }
       for (int drawValues=8;drawValues<20;drawValues++){
         float topy = 38;
         if (plantvalues[fileCounter][drawValues]>0){
           if (drawValues<12||buttonState[0]==1)    text(plantvalues[fileCounter][drawValues],drawValues*40,topy+15*fileCounter);
         }  
         
       }
       
        if (buttonState[biome [fileCounter]]==1){
     stroke(50);
     
     int offset =500;
     int scale = 900;
     fill(fileCounter,100,100,5);
     float topx = plantvalues[fileCounter][0]*scale+offset;
     float bottomx = plantvalues[fileCounter][1]*scale+offset;
     float topy = plantvalues[fileCounter][4]*scale+10;
     float bottomy = plantvalues[fileCounter][5]*scale+10;
            rectMode(CORNERS);
    //   text(fileNamesToUse[fileCounter],topx,topy+2*fileCounter);      
           rect(topx,topy,bottomx,bottomy);
             fill(fileCounter,100,100,10);
     topx = plantvalues[fileCounter][2]*scale+offset;
     bottomx = plantvalues[fileCounter][3]*scale+offset;
     topy = plantvalues[fileCounter][6]*scale+10;
     bottomy = plantvalues[fileCounter][7]*scale+10;
     rect(topx,topy,bottomx,bottomy);
     fill(fileCounter,100,100,50);
     text(fileNamesToUse[fileCounter],topx,topy+2*fileCounter);
     }
       
       
     }
     if (selectedRow>-1){
               stroke(100);
     
     int offset =500;
     int scale = 900;
     fill(selectedRow,100,100,5);
     float topx = plantvalues[selectedRow][0]*scale+offset;
     float bottomx = plantvalues[selectedRow][1]*scale+offset;
     float topy = plantvalues[selectedRow][4]*scale+10;
     float bottomy = plantvalues[selectedRow][5]*scale+10;
            rectMode(CORNERS);
    //   text(fileNamesToUse[fileCounter],topx,topy+2*fileCounter);      
           rect(topx,topy,bottomx,bottomy);
             fill(selectedRow,100,100,10);
     topx = plantvalues[selectedRow][2]*scale+offset;
     bottomx = plantvalues[selectedRow][3]*scale+offset;
     topy = plantvalues[selectedRow][6]*scale+10;
     bottomy = plantvalues[selectedRow][7]*scale+10;
     rect(topx,topy,bottomx,bottomy);
     fill(selectedRow,100,100,50);
     text(fileNamesToUse[selectedRow],topx,topy+2*selectedRow);
     }
     for (int i=0;i<7;i++){
     stroke(100);
     noFill();
          int offset =500;
     int scale = 900;
     rectMode(CORNERS);
                 //mositer,temp,moisture,temp
    // if (i==0)rect(0.3*scale+offset,0.4*scale,0.5*scale+offset,.8*scale);
    rect(biomesranges[i][0]*scale+offset,biomesranges[i][2]*scale+10,biomesranges[i][1]*scale+offset,biomesranges[i][3]*scale+10);
   }
     
     rectMode(CORNERS);
     for(int i=0;i<ButtonLabels.length;i++){fill(50*buttonState[i],50,50);rect(i*60,950,i*60+60,970); fill(100);text(ButtonLabels[i],i*60+5,966); }
}