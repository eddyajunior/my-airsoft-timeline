using AirsoftTimeline.Application.Enums;

namespace AirsoftTimeline.Application.ValueObjects
{
    public class OperationVO
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public List<TeamVO> Teams { get; set; }
        public OperationType Type { get; set; }
    }
}
