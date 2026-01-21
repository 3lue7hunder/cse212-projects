using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities
    // Expected Result: Highest priority item is dequeued first
    // Defect(s) Found:
    // - Dequeue returned the value but did not remove it from the queue
    public void TestPriorityQueue_HighestPriority()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("Low", 1);
        queue.Enqueue("Medium", 5);
        queue.Enqueue("High", 10);

        Assert.AreEqual("High", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority
    // Expected Result: FIFO order is preserved among equal priorities
    // Defect(s) Found:
    // - Later items with equal priority were incorrectly selected first
    public void TestPriorityQueue_FIFO_SamePriority()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("First", 5);
        queue.Enqueue("Second", 5);

        Assert.AreEqual("First", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: Multiple dequeues with different priorities
    // Expected Result: Items dequeued in correct priority order
    // Defect(s) Found:
    // - Items were not removed after being dequeued
    public void TestPriorityQueue_MultipleDequeues()
    {
        var queue = new PriorityQueue();
        queue.Enqueue("A", 1);
        queue.Enqueue("B", 3);
        queue.Enqueue("C", 2);

        Assert.AreEqual("B", queue.Dequeue());
        Assert.AreEqual("C", queue.Dequeue());
        Assert.AreEqual("A", queue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found:
    // - No defects found
    public void TestPriorityQueue_Empty()
    {
        var queue = new PriorityQueue();

        try
        {
            queue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}
