**How to run tests?**

1. Install .NET SDK;
2. Fill TestProject\Tests\users.json with correct data: API key, Token, Email, Password.
3. Run TestProject\BuildAndRun.bat

In you have problem with building solution, try to restart your computer.
Then verify that you have correct value for "Path" variable in the "Environment Variables". It should looks like "C:\Program Files\dotnet\".
If you still have problems to run tests feel free to write me in Teams.

**Things to improve:**

1. Refactor:
  	* Split logic of BoardCreationTests.cs into PageObjects and Test.
  	* Uncomment code and add logic for events in DriverManager.cs.
  	* Move LoadUserData() from BaseAPITest.cs and BaseUITest.cs to Helpers.
  	* Cleaning.
  	* Etc.
2. Add parrallel test execution;
3. Add creating screenshots for failing tests;
4. Add logging;
5. Add reporter;
6. Create CI pipeline;
7. Etc.
