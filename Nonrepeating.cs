using System;

class MainClass{
    public static string NonrepeatingCharacter(string str){
        string character = "";

        var stringList = str.ToCharArray();

        for(int i=0;i<stringList.Length; i++)
        {
            bool found = false;
            for(int j=0;j<stringList.Length;j++)
            {
                if(stringList[i] == stringList[j] && i!=j)
                {
                    found = true;
                    break;
                }
            }
            if(!found)
            {
                character = stringList[i].ToString();
                break;
            }
        }
        
        return character;
    }
}