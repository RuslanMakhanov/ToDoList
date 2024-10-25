using MedicalAppointmentSetter;

var medicalAppointment = new MedicalAppointment(
    "John Smith", new DateTime(2023, 4, 3));
var medicalAppointment1 = new MedicalAppointment("Jogn");
var medicalAppointment2 = new MedicalAppointment(2);

medicalAppointment.OverrideMonthAndDay(5, 1);

medicalAppointment.MoveByMonthAndDay(1, 2);

Console.WriteLine("Methods_Overloading");
Console.ReadKey();