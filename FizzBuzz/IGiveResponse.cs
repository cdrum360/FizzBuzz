namespace FizzBuzz
{
    public interface IGiveResponse
    {
        string Response { get; set; }
        void FormulateResponse(int turn);
        void OutputResponse();
    }
}