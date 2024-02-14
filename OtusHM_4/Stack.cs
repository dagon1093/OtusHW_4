
namespace OtusHM_4
{
    public class Stack
    {
        
        public List<string> Elements { get; }
        public int Size
        {
            get => Elements.Count;
        }

        public string? Top 
        { 
            get 
            { 
                if (Elements.Count == 0)
                    return null;
                return Elements[^1];
            } 
        }


        public Stack(params string[] elements) {
            
            this.Elements = new List<string>();
            foreach (string element in elements)
            {
                this.Elements.Add(element);
            }
        }

        public void Add(string element) 
        {
            this.Elements.Add(element);
        }

        public string? Pop()
        {
            if (this.Size == 0)
            {
                return null;
            }

            int index = this.Elements.Count - 1;
            string element = this.Elements[index];
            this.Elements.RemoveAt(index);


            return element;
        }

        public static Stack Concat(params Stack[] stacks)
        {
            if (stacks.Length == 0) return new Stack();
            
            var result = new Stack();
            foreach (Stack stack in stacks)
            {
                for(int i = stack.Size;  i > 0; i--)
                {
                    result.Add(stack.Elements[i - 1]);
                }
            }
            return result;
        }


    }
}
