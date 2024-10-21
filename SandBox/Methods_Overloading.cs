class MedicalAppointment
{
    private string _patientName;
    public DateTime _date;
    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public void Reschedule (DateTime date)
    {
        _date = date;
    } 

    public void OverrideMonthAndDay (int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    public void MoveByMonthAndDay (int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(
            _date.Year,
            _date.Month + monthsToAdd,
            _date.Day + daysToAdd);
    }
}
