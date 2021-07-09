void saveData(){
  int numberOfFiles= fileNamesToUse.length;
  println("saved started");
  for (int fileCounter=0;fileCounter<numberOfFiles;fileCounter++)
  {
      String[] lines;
      lines = loadStrings(fileNamesToUse [fileCounter]);
        for (int counter=0;counter<lines.length;counter++)
        {
          String tempString = lines[counter];
          if (tempString.indexOf("this.IdealMoistureRange ")>-1){lines[counter]=returnTwoItemString("this.IdealMoistureRange ",fileCounter,2);}
          if (tempString.indexOf("this.MoistureExtremes ")>-1){lines[counter]=returnTwoItemString("this.MoistureExtremes ",fileCounter,0);}
          if (tempString.indexOf("this.IdealTemperatureRange ")>-1){lines[counter]=returnTwoItemString("this.IdealTemperatureRange ",fileCounter,6);}
          if (tempString.indexOf("this.TemperatureExtremes ")>-1){lines[counter]=returnTwoItemString("this.TemperatureExtremes ",fileCounter,4);}
          
         // if (tempString.indexOf("this.IdealMoistureRange ")>-1){setNumbers(fileCounter,1,tempString);}
         if (tempString.indexOf("this.MaturityAgeDays")>-1){lines[counter]=returnOneiTemString("this.MaturityAgeDays",fileCounter,8);}
         if (tempString.indexOf("this.MaxGrowthRate")>-1){lines[counter]=returnOneiTemString("this.MaxGrowthRate",fileCounter,9);} 
         if (tempString.indexOf("this.MaxDeathRate")>-1){lines[counter]=returnOneiTemString("this.MaxDeathRate",fileCounter,10);}
         if (tempString.indexOf("this.SpreadRate")>-1){lines[counter]=returnOneiTemString("this.SpreadRate",fileCounter,11);} 
        }
    
    saveStrings(fileNamesToUse [fileCounter], lines);
  }  
}

String returnOneiTemString(String bodyString,int filecounter, int index)
{
  String returnString = "               "+bodyString +" = ";
 String subString = str(plantvalues[filecounter][index])+"f";
  if (plantvalues[filecounter][index]<=0) subString="0";
 if (plantvalues[filecounter][index]>=1&&index!=8) subString="1";
 returnString = returnString+subString +";  ";
 // print(returnString);
  return returnString;
 
}

String returnTwoItemString(String bodyString,int filecounter, int index)
{
 String returnString ="                "+bodyString +"= new Range(";
 String subString = str(plantvalues[filecounter][index])+"f";
 if (plantvalues[filecounter][index]<=0) subString="0";
 if (plantvalues[filecounter][index]>=maxvalues[index]) subString=str(maxvalues[index]);
 returnString = returnString+subString +",  ";
 subString = str(plantvalues[filecounter][index+1])+"f";
  if (plantvalues[filecounter][index+1]<=0) subString="0";
 if (plantvalues[filecounter][index+1]>=1) subString="1";
 returnString = returnString+subString +");  ";
 return returnString;
}