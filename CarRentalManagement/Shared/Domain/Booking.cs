namespace CarRentalManagement.Shared.Domain
{
	public class Booking : BaseDomainModel
	{
		public int? VehicleID { get; set; }
		public virtual Vehicle? Vehicle { get; set; }
		public DateTime Dateout { get; set; }
		public virtual DateTime Datein { get; set;}
		public virtual Customer? Customer { get; set; }
		public int CustomerId { get; set; }
	}
}