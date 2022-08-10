internal abstract class Approver
{
    public Approver Successor { get; set; }
    public abstract void Approve(Vacation vacation);

    protected void DelegateToNextManager(Vacation vacation)
    {
        if(Successor is {}) 
            Successor.Approve(vacation);
    }
}