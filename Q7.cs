
//Q7
using System;

namespace ConsoleApp8;

public class Node
{
   public int? data;
   public Node? next;
   public Node(int value)
   {
       data = value;
       next = null;
   }

}

public class CirclerLinkedList
{
   public static Node? head;
   public static int count = 0;

   public CirclerLinkedList()
   {
       head = null;
   }



   public void DeleteFromEnd()
   {
       int currentPosition = 0;

       if (head == null)
       {
           Console.WriteLine("empty");
       }
       else
       {
           Node current = head;
           while (current.next.next != head)
           {
               current = current.next;

           }
           current.next.next = null;
           current.next = head;

       }
       count--;
   }

   public void AddLast(int value)
   {

       if (head == null)
       {
           head = new Node(value);
           head.next = head;
       }
       else
       {
           Node current = head;
           Node newNode = new Node(value);

           while (current.next != head)
           {
               current = current.next;

           }
           current.next = newNode;
           newNode.next = head;


       }
       count++;
   }

   public void Display()
   {
       int count = 0;
       Node currentHead = head;
       Console.WriteLine("Data entered in the list are :");

       do
       {
           Console.Write("node number {0}:", ++count);
           Console.WriteLine(currentHead.data);
           currentHead = currentHead.next;
       }
       while (currentHead != head);

   }


}

public class program
{
   public static void Main(string[] args)
   {
       CirclerLinkedList newlist = new CirclerLinkedList();
       newlist.AddLast(1);
       newlist.AddLast(2);
       newlist.AddLast(3);
       newlist.AddLast(4);
       newlist.AddLast(5);
       newlist.AddLast(6);
       newlist.AddLast(7);

       newlist.Display();

       newlist.DeleteFromEnd();
       Console.WriteLine("after delete");
       newlist.Display();
   }
}