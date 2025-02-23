Project Name Revenue Calculation
===============================
Revenue Calculation project consist of below features
- **Revenue Calculations:**
    - **Total Revenue:** (For a date range)
    - **Total Revenue by ProductId:** (For a date range)
    - **Total Revenue by CustomerId:** (For a date range)
    - **Total Revenue by OrderId:** (For a date range)

  Data Loading
  ============
  Data Loading done by SSIS package
  Git Repo: https://github.com/varsha-RD/SSIS-Package/tree/main
  

  Data Refresh Mechanism:
  ======================
  The data refresh mechanism is handled by SQL jobs scheduled to run daily, with logs captured before and after the SQL jobs execute.
  Git link:
  
  https://github.com/varsha-RD/Products-CSV/blob/main/SQL%20Jobs/Refresh.sql
  
  Execute the above scripts in the sql server.
  



  
