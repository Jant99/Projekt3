
Name and Age Table Application
This project is a simple application developed in C# using .NET technology. The application features a table for storing names and ages with additional functionalities such as reading and writing data to a CSV file, XML serialization for file saving, deserialization for loading, and interactive features like searching and saving data on program exit.

Features
Table for Names and Ages: The application contains a table to store names and corresponding ages.
CSV File Operations: Users can read from and write to a CSV file to store and retrieve data.
XML Serialization: The file saving functionality is converted to use XML serialization for data persistence.
Deserialization: Loading of data is performed by deserializing the XML file.
Interactive Features:
Popup for Saving: A popup appears when the program is closed, asking users if they want to save the content.
Data Restoration: Upon program startup, data from the last open location is loaded automatically.
Search Functionality: Users can search by name or age count, with results displayed either in a separate window.
Dynamic Searching: The application intelligently searches by numbers when numeric input is entered and by names when text input is provided.
Requirements
.NET Framework (version 4.7.2 or higher)
Visual Studio (optional, for development)
Installation
Clone the repository to your local machine.
Open the solution file (WpfApp3.sln) in Visual Studio.
Build the solution to restore NuGet packages and compile the application.
Run the application.
Usage
Upon launching the application, you will see a table displaying the existing names and ages.
To add a new record, click on the "Dodaj" button and input the name and age in the provided fields.
To save the data, click on the "Zapis do pliku csv" button. The data will be serialized and saved to an XML file.
To load previously saved data from a csv file, click on the "Odczyt z pliku csv" button. The application will deserialize the XML file and display the stored records.
To search for a specific record, click the "Wyszukaj" button and then enter the name or age count in the search textbox and click the "Zatwierdz" button. The results will be displayed in a main table in the separate window.
Upon closing the application, a popup will appear asking if you want to save the content. Choose an option accordingly.
Contributing
Contributions are welcome! If you'd like to contribute to this project, please fork the repository and submit a pull request. For major changes, please open an issue first to discuss what you would like to change.

License
This project is licensed under the MIT License - see the LICENSE file for details.

Acknowledgements
This project was inspired by the need for a simple application to manage names and ages with additional file handling functionalities.
Special thanks to the contributors and developers who helped make this project possible.
