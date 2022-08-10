
    internal class Vacation
    {
        public string RequestData { get; set; }
        public bool isFromManager { get; set; }
        public bool Approved { get; set; } = false;
        public int Days { get; set; }

        public override string ToString()
        {
            if (Approved == true)
            {
                return "Vacation has been approved";
            }

            return "Vacation has been rejected";
        }
    }