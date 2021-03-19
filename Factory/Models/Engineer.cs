using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId {get; set;}
    public string EngineerName {get; set; }
    public string EngineerStatus {get; set;}
    public string LicenseExpDate {get; set;}
    public virtual ICollection<EngineerMachine> JoinEntities {get;}
    public Engineer()
    {
      JoinEntities = new HashSet<EngineerMachine>();
    }
  }
}