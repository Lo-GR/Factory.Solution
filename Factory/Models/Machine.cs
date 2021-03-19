using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId {get; set;}
    public string MachineName {get; set;}
    public string MachineStatus {get; set;}
    public string InspectionDate {get; set;}
    public virtual ICollection<EngineerMachine> JoinEntities {get;}
    public Machine()
    {
      JoinEntities = new HashSet<EngineerMachine>();
    }
  }
  public enum MachStatus
  {
    Operational,
    Malfunctioning,
    Repairing
  }
}