Download the code : By Clicking on Code dropdowm and then click on Download ZIP.
Open the solution : Extract the Downloaded ZIP and open the solution in VS 2019 and then right click on the ProfileSeeker.UI project and click on the Set as start up project.
Run the Project.
Enter username in input box and press submit button.
In case of username exists,
On left side: You will get user profile picture, name and location information.
On right side: You will get user repositories info like repository name, description and stargazer count.
In case of username does not exists,
You will get error message "Search result not found." error message.
In case of user dont have any repository,
You will get "user name doesn't have any public repositories yet." error message.
In case of git api quota limit exceeded,
You will get "Request rate limit exceeded." error message.
In any other case like something went wrong,
You will get "Something went wrong, please try again later." error message.
In case of exception occurs,
You will get redirected to application error page.
