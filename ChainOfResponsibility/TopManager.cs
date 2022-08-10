namespace ChainOfResponsibility
{
    internal class TopManager : Approver
    {
        public override void Approve(Vacation vacation)
        {
            if (vacation.Days > 5)
                vacation.Approved = false;
        
            DelegateToNextManager(vacation);
        }
    }
}