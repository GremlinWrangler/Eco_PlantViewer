  //String filepath = "D:\steam\steamapps\common\Eco\Eco_Data\Server\Mods\AutoGen\Plant\";
  
  int []clickmarkers={180,200,220,240,250,260,280,300,320,360,400,440,480,520,560,600,640,700,740,800,840};
  
  String []fileNamesToUse = {
  "Pumpkin.cs","Redwood.cs","Rice.cs","SaguaroCactus.cs","Salal.cs","Saxifrage.cs","Seagrass.cs","Spruce.cs","Sunflower.cs","Switchgrass.cs","Taro.cs","Tomatoes.cs","Trillium.cs","Urchin.cs","Waterweed.cs","Wheat.cs","WhiteBursage.cs","Agave.cs","ArcticWillow.cs","BarrelCactus.cs","Beans.cs","Beets.cs","BigBluestem.cs","Birch.cs","BoleteMushroom.cs","Bunchgrass.cs","Camas.cs","Cedar.cs","Ceiba.cs","Clam.cs","CommonGrass.cs","CookeinaMushroom.cs","Corn.cs","CreosoteBush.cs","CriminiMushroom.cs","DeerLichen.cs","DesertMoss.cs","DwarfWillow.cs","Fern.cs","FilmyFern.cs","Fir.cs","Fireweed.cs","Heliconia.cs","Huckleberry.cs","Jointfir.cs","Joshua.cs","Kelp.cs","KingFern.cs","LatticeMushroom.cs","Lupine.cs","Oak.cs","OceanSpray.cs","OldGrowthRedwood.cs","Orchid.cs","Palm.cs","Papaya.cs","PeatMoss.cs","Pineapple.cs","PricklyPear.cs"
  };
  int []biome = {
  1 ,2,1,3,2,6,4,2,1,1,5,1,1,4,4,1,3,3,6,3,2,1,1,2,5,1,2,2,5,4,1,5,1,3,5,6,3,6,2,5,6,6,5,2,3,3,4,5,5,6,1,1,6,5,5,5,6,5,3
        
  };
 //1 plain 2high grass, 3 desert, 4 ocean, 5 tropic,6 mountain 
 String []ButtonLabels ={"detail","plain","forest","dessert","ocean","tropics","mountain"};
  int []buttonState = {    0,       1,      0,       0,        0,        0,       0};
                          //grassland               desert                tundra            wetland            warmforest               taiga              rainforest
 String []biomeLabels =     {"grassland",          "deset",            "tundra",          "wetland",        "warmforest",          "taiga"                ,"rainforest"};
  float[][]biomesranges =  { {0.25,0.55,0.4,0.8}, {0.0,0.35,0.7,1.0}, {0,0.65,0.1,0.2},  {0.6,0.8,0.4,0.6}, {0.45,0.65,0.6,0.8} , {0.15,0.55,0.2,0.4} , {0.65,1.05,0.6,0.8}  }; 
   float [][] plantvalues = new float[60][21];
   int []maxvalues = {1,1,1,1 ,1,1,1,1, 20,1,1,1, 1,1,1,1, 1,1};
   int selectedRow=-1;
  PFont mainFont;
void setup() {
  size(1400, 1000);
    background(0);
    mainFont = createFont("Comic Sans MS", 12);
   textFont(mainFont);
  int numberOfFiles= fileNamesToUse.length;
  for (int fileCounter=0;fileCounter<numberOfFiles;fileCounter++)
  {
      String[] lines;
      lines = loadStrings(fileNamesToUse [fileCounter]);
        for (int counter=0;counter<lines.length;counter++)
        {
          String tempString = lines[counter];
          if (tempString.indexOf("this.IdealMoistureRange ")>-1){setNumbers(fileCounter,2,tempString);}
          if (tempString.indexOf("this.MoistureExtremes ")>-1){setNumbers(fileCounter,0,tempString);}
          if (tempString.indexOf("this.IdealTemperatureRange ")>-1){setNumbers(fileCounter,6,tempString);}
          if (tempString.indexOf("this.TemperatureExtremes ")>-1){setNumbers(fileCounter,4,tempString);}
          if (tempString.indexOf("this.TemperatureExtremes ")>-1){setNumbers(fileCounter,4,tempString);}
         // if (tempString.indexOf("this.IdealMoistureRange ")>-1){setNumbers(fileCounter,1,tempString);}
         if (tempString.indexOf("this.MaturityAgeDays")>-1){setOneNumber(fileCounter,8,tempString);} 
         if (tempString.indexOf("this.MaxGrowthRate")>-1){setOneNumber(fileCounter,9,tempString);} 
         if (tempString.indexOf("this.MaxDeathRate")>-1){setOneNumber(fileCounter,10,tempString);} 
         if (tempString.indexOf("this.SpreadRate")>-1){setOneNumber(fileCounter,11,tempString);} 
         if (tempString.indexOf("FertileGround")>-1){setOneNumber(fileCounter,12,tempString);}
         if (tempString.indexOf("ShrubSpace")>-1){setOneNumber(fileCounter,13,tempString);}
         if (tempString.indexOf("CanopySpace")>-1){setOneNumber(fileCounter,14,tempString);}
         if (tempString.indexOf("this.GenerationSpawnPointMultiplier")>-1){setOneNumber(fileCounter,15,tempString);}
         if (tempString.indexOf("this.GenerationSpawnCountPerPoint ")>-1){setNumbers(fileCounter,16,tempString);}
         if (tempString.indexOf("this.BlanketSpawnPercent")>-1){setOneNumber(fileCounter,18,tempString);}
          // if (tempString.indexOf("new SpeciesResource(typeof(")>-1){setNumbers(fileCounter,19,tempString);println("d"+plantvalues[fileCounter][19]+" "+plantvalues[fileCounter][20]);}
        }
    
    
  }    
  drawbars();
}

void setOneNumber(int Plantindex,int valueindex,String inPutString){
  String tempString = inPutString;
   int index=tempString.indexOf("=")+1;
   tempString= tempString.substring( index);
   if (tempString.indexOf("=")>0){// trap for lines with two equals signs
       index=tempString.indexOf("=")+1;
       tempString= tempString.substring( index);     
     }
   
   index=tempString.indexOf("f"); //because these are floating point
   if (index==-1||index>5)index= tempString.indexOf("}");
   if (index==-1||index>5)index= tempString.indexOf(";");
   
   tempString= tempString.substring(0, index);
   
   
     plantvalues[Plantindex][valueindex]=float(tempString);
}

void setNumbers(int Plantindex,int valueindex,String inPutString)
{
 // println(fileNamesToUse[Plantindex]," ",valueindex);
  String tempString = inPutString;
   int index=tempString.indexOf("(")+1;
   tempString= tempString.substring( index);
    
   index=tempString.indexOf("f"); //because these are floating point
 //  if (index==-1)index=tempString.indexOf("F");
   if (index==-1||index>4)index= tempString.indexOf(","); //except when they don't! 
   //print(tempString);
   tempString= tempString.substring(0, index); 
 //  print("index "+index+"value="+tempString+" ");
   plantvalues[Plantindex][valueindex]=float(tempString);
   tempString = inPutString;
   index=tempString.indexOf(",")+1;
   tempString= tempString.substring( index);
   index=tempString.indexOf("f"); //because these are floating point
   
   if (index==-1) index= tempString.indexOf(")"); //except when they don't!
   tempString= tempString.substring(0, index); 
   
   plantvalues[Plantindex][valueindex+1]=float(tempString);
  // print(plantvalues[Plantindex][valueindex]+" ");
  // println(plantvalues[Plantindex][valueindex+1]);
 
}

void draw(){}
//drawbars();
boolean testmouse(int xval1,int xval2){
  boolean tempvalue=false;
  if (mouseX<xval2&&mouseX>xval1) tempvalue=true;
  return tempvalue;
}

int returnClickBox(int mouseXpos){
  int boxIndex=-1;
   int lengthOfClickMarkers = clickmarkers.length;
  for (int i=0;i<lengthOfClickMarkers-1;i++){
   if (mouseXpos>clickmarkers[i]&&mouseXpos<clickmarkers[i+1]) boxIndex=i;
  }
  return boxIndex;
}

int returnYrow(int mouseYpos){
 int rowFound=-1;
    mouseYpos=mouseYpos-28;
    mouseYpos=mouseYpos/15;
    if (mouseYpos<fileNamesToUse.length) rowFound=mouseYpos;
    
 return rowFound;
}
void updatevalue(int line,int index,float stepsize){
  plantvalues[line][index]=plantvalues[line][index]+stepsize;
  if (plantvalues[line][index]<0) plantvalues[line][index]=0;
  if (plantvalues[line][index]>maxvalues[index]) plantvalues[line][index]=maxvalues[index];
  if (index<8){//we have a paired value
    
    if (index%2==0) {//we have a min value going bigger than a max
      if (plantvalues[line][index]>plantvalues[line][index+1]) plantvalues[line][index]=plantvalues[line][index+1];
    } else{ //we have a max value trying to be less than a min 
      if (plantvalues[line][index]<plantvalues[line][index-1]) plantvalues[line][index]=plantvalues[line][index-1];
    }
    
  }
}

void mousePressed() {
  if (mouseX<60&&mouseY<20)saveData();
  int yoffset=34;
  if (returnYrow(mouseY)>-1){
    int clickedRow=returnYrow(mouseY);
    if (mouseX<180){//clicked a name
        if (selectedRow==clickedRow) selectedRow=-1; else selectedRow=clickedRow; 
    }
    int clicktype =0;
    if (mouseButton == RIGHT) clicktype=2;
    if (returnClickBox(mouseX)==0)updatevalue(clickedRow,0+clicktype,-0.05);
    if (returnClickBox(mouseX)==1)updatevalue(clickedRow,0+clicktype,0.05);
    if (returnClickBox(mouseX)==2)updatevalue(clickedRow,1+clicktype,-0.05);
    if (returnClickBox(mouseX)==3)updatevalue(clickedRow,1+clicktype,0.05);
    
     if (returnClickBox(mouseX)==4)updatevalue(clickedRow,4+clicktype,-0.05);
     if (returnClickBox(mouseX)==5)updatevalue(clickedRow,4+clicktype,0.05);
     if (returnClickBox(mouseX)==6)updatevalue(clickedRow,5+clicktype,-0.05);
     if (returnClickBox(mouseX)==7)updatevalue(clickedRow,5+clicktype,0.05);
     clicktype =1;
     if (mouseButton == RIGHT) clicktype=-1;
     if (returnClickBox(mouseX)==8)updatevalue(clickedRow,8,0.2*clicktype);
     if (returnClickBox(mouseX)==9)updatevalue(clickedRow,9,0.05*clicktype);
     if (returnClickBox(mouseX)==10)updatevalue(clickedRow,10,0.005*clicktype);
     if (returnClickBox(mouseX)==11)updatevalue(clickedRow,11,0.001*clicktype);
     
  }
  if (mouseY>950&&mouseY<970){
      int tempvalue=mouseX/60;
      print (tempvalue);
      if (tempvalue<7){
        if (buttonState[tempvalue]==1) buttonState[tempvalue]=0; else buttonState[tempvalue]=1;
      }
  }
  drawbars(); 
}