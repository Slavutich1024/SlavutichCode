﻿using System;
using System.Collections;



namespace RemoveDupFromSortList {
    public class ListNode {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }

    class Solution {
        public ListNode DeleteDuplicates(ListNode head) {
            if(head == null)
                return head;

            ListNode current = head;

            while(current.next != null) {
                if(current.val == current.next.val) 
                    current.next = current.next.next;
                else
                    current = current.next;
            }
            return head;
        }
                
        class Programm {
            static void Main(string[] args) {
               





            }
        }
    }
}
                   






            
















