internal class SimpleManager : Approver
{
    public override void Approve(Vacation vacation)
    {
        if (!vacation.isFromManager)
            vacation.Approved = true;
        
        DelegateToNextManager(vacation);
    }
}