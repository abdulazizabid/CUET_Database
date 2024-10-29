using System;
using System.Data.Common;
 class student{
    public string StudentID;
    string Name;
    protected String ContactNo;
     public int Batch19=0,Batch20=0,Batch21=0,Batch22=0,CE=0,EEE=0,ME=0,CSE=0;
    public  string name{
        set{ 
        nm.Add(value);
        Name=value; 
        }
        get{ return Name;}
    }
    public string contactnum{
        set{
            cn.Add(value);
            ContactNo=value;
        }
        get{ return ContactNo; }
    }
    public string stuID{
        set{
            id.Add(value);
            StudentID=value;
        }
    }
   List<string>id=new List<string>();
   List<string>nm=new List<string>();
   List<string>cn=new List<string>(); 
   
   public void summary(){
        int size=id.Count;
          Console.WriteLine("    ID           Name        Contact Number      ");
        for(int i=0;i<size;i++){
          
            Console.WriteLine(id[i]+"    "+nm[i]+"      "+cn[i]);
        }
   }
    public void searchStudent(){
        Console.Write("Give The Id:");
         string s=Console.ReadLine();
        int index=id.IndexOf(s);
        if(index!=-1) Console.WriteLine("Student Name: "+nm[index]+"\nContact Number: "+cn[index]);
        else Console.WriteLine("There is no student with id :"+s);
    }
    public void updateContact (){
         Console.Write("Give The Id:");
        string i=Console.ReadLine();
        int index=id.IndexOf(i);
        Console.WriteLine("Give new Contact Number of id:"+i);
        string num=Console.ReadLine();
        cn[index]=num;
        Console.WriteLine("Number added successfully");
    }
    public void delteID(){
         Console.Write("Give The Id to remove:");
         string i=Console.ReadLine();
         int index=id.IndexOf(i);
         if(index!=-1){
            id.RemoveAt(index);
            nm.RemoveAt(index);
            cn.RemoveAt(index);
            Console.WriteLine("Removed Successful");
         }
         else Console.WriteLine("Invalid ID");

         if(i.Substring(0,2)=="19") Batch19--;
        if(i.Substring(0,2)=="20") Batch20--;
        if(i.Substring(0,2)=="21") Batch21--;
        if(i.Substring(0,2)=="22") Batch22--;

        if(i.Substring(2,2)=="01") CE--;
        if(i.Substring(2,2)=="02") EEE--;
        if(i.Substring(2,2)=="03") ME--;
        if(i.Substring(2,2)=="04") CSE--;

    }
}
class Admin:student{
      
    
    public void AddStudent(string i,string n,string c){
        contactnum=c;
        stuID=i;
        name=n;

        if(i.Substring(0,2)=="19") Batch19++;
        if(i.Substring(0,2)=="20") Batch20++;
        if(i.Substring(0,2)=="21") Batch21++;
        if(i.Substring(0,2)=="22") Batch22++;

        if(i.Substring(2,2)=="01") CE++;
        if(i.Substring(2,2)=="02") EEE++;
        if(i.Substring(2,2)=="03") ME++;
        if(i.Substring(2,2)=="04") CSE++;

    }
    public void summaryBatch(){
        Console.WriteLine("Total students (Batch wise) : ");
        Console.WriteLine("19 - "+Batch19);
        Console.WriteLine("20 - "+Batch20);
        Console.WriteLine("21 - "+Batch21);
        Console.WriteLine("22 - "+Batch22);
        Console.WriteLine("Total students (Department wise) : ");
        Console.WriteLine("CE - "+CE);
        Console.WriteLine("EEE - "+EEE);
        Console.WriteLine("ME - "+ME);
        Console.WriteLine("CSE - "+CSE);
    }
}
class CUET_DATABASE{
    public static void Main(string[] args){
        Admin a1=new Admin();
        while(true){
            Console.WriteLine("1. Add student \n2. Student Summary \n3. Search Student\n4. Update Contact no\n5. Exit\n6. Delete student\n7. Student Summary BatchWise");
           int x=Convert.ToInt32(Console.ReadLine());
           if(x==1){

            
            Console.Write("Student Name - ");
            string n=Console.ReadLine();
            Console.Write("Student Id - ");
            string i=Console.ReadLine();
             Console.Write("Student Contact Number - ");
            string c=Console.ReadLine();
            a1.AddStudent(i,n,c);
            
           }
           else if(x==2){
                a1.summary();
           }
           else if(x==3){
            a1.searchStudent();
           }
           else if(x==4){
            a1.updateContact();
           }
           else if(x==5){
            break;
           }
           else if(x==6){
            a1.delteID();
           }
           else if(x==7){
            a1.summaryBatch();
           }
        }
    }
}
