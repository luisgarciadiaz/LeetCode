internal class Program
{
    private static void Main(string[] args)
    {
        ListNode l1= new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode l2= new ListNode(5, new ListNode(6, new ListNode(4,new ListNode(9))));
        ListNode l3= new ListNode(0);

        ListNode result=ListNode.AddTwoNumbers(l1,l2);

    }
}