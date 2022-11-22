# Solutions

---

##### 1.Review folder "Development_Test_1" and run:

---

    dotnet run

---

##### 2.The answer is C because destructor is the method we use to evoke the proper clean up of the garbage collector before we run some clean method

---

> Check  "Development_Test_2"

---

##### 3.The answer is D. Review folder "Development_Test_3"

---

##### 4. The answer is D since just one single exception occurs, not two. Then we can run the "finally" procedure , and not the code after finally.

---

##### 5. The answers are A and E. First we use the following code in order to get the transparent back color:

---

    this.setStyle(ControlStyles.SupportsTransparentBackColor, true);

---    

##### 6. The answer is B since the LostFocus event occurs for the first form before the Deactivate event so we have to do it with every class.

---

##### 7. The answer is B because WaitAny implementation will throw error as well it depends what task will complete first. we need to:

---

>Grab the XML payload
>Get that deserialized into an object instance so you can work with it
>Pick out the data you are interested in and persist it

---

##### 8. The answers are A and B.

---

    public static int Main() {
       /* Adds the event and the event handler for the method that will 
          process the timer event to the timer. */
       myTimer.Tick += new EventHandler(TimerEventProcessor);
 
       // Sets the timer interval to 5 seconds.
       myTimer.Interval = 5000;
       myTimer.Start();
 
       // Runs the timer, and raises the event.
       while(exitFlag == false) {
         
          RedrawControl(); //A. Processes the event in the queue.
       }
         
    this.Invalidate(); //B. Force the form to be redrawn with the image.
    return 0;
    }

---    
    
##### 9. This would be my version to get the same aproach.

---

    SELECT SH.SalesOrder_int, SUM(SELECT Total_flt FROM tblSalesDetails WHERE kSalesHeader=SH.kSalesHeader)
    FROM  tblSalesHeaders SH
    Group by SalesOrderID
    WHERE SH.kClient=C.kClient
    FROM TBLCLIENTS C WHERE Name_str='SK'

---