namespace ArchitechtureUsingEvents
{
    public interface IScreen
    {
        string Answer { get; set; }
        string Warning { get; set; }
        string TextValue { get; set; }
        MLength MessageLength { get; set; }
    }
}
