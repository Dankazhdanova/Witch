
public abstract class SportEquipmentBase    
{
    public double Massa{ get; set;}        //масса
}


public abstract class ElectroEquipment: SportEquipmentBase{  
    public int Naprizhenie { get; set;}      // напряжение
    public string Rezhim {get; set;}      // режимы
}
public class ExerciseBike: ElectroEquipment{  
    public string Nagryzka {get; set;}   //нагрузка
}

public class RunningTrack: ElectroEquipment{     
    public string Nagryzka {get; set;}  //свойтво нагрузка 
    public double Dlina {get; set;}     //длинна
}


public abstract class SlopeProperty: SportEquipmentBase{ // свойство наклон
    public int Naklon {get; set;}  //наклон
}
public class Bench: SlopeProperty{  
    public string Nagryzka {get; set;}  //нагрузка
    public double MaxUsWeightWithWeights {get; set;} 
}
public class RomanChair: SlopeProperty{   
    public string Nagryzka {get; set;}    
    public double Dlina {get; set;}   

}
public abstract class Tyrnic: SportEquipmentBase{   
    public bool Perecladina {get; set;} 
    public bool Brusia {get; set;}  
    }

    public abstract class Program{
        static void Main(string[] args){
            
        }
    }