namespace Refactoring.Properties_as_Validation
{
    class Solution
    {
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value > 0 && value <= 100)
                {
                    _age = value;
                }
            }
        }

        // Usually the code when user clicks the save/submit button in UI
        public void Submit()
        {
            // No need for validation code here.
            // Property will always have valid value
        }

    }
}
