namespace FreeCam
{
    public interface IFreeCamAPI
    {
        bool IsInFreeCam();
        void ToggleFreeCam();
        void EnterFreeCam();
        void ExitFreeCam();
    }
}
