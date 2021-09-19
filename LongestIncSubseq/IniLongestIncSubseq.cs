namespace LongestIncSubseqApi
{
    public interface IniLongestIncSubseq
    {
        string input { get; set; }
        string output { get; set; }

        void Solve(int[] arr);
    }
}