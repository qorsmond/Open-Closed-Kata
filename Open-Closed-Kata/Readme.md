# SOLID Serializer

Build a library that has 2 different methods of serialization. It should be able to serialize to JSON and XML.

It should have a class (Serializer) with a method (Serialize) that I can call with for different instances of POCO classes:
•	Settings,
•	Config,
•	Data and
•	Content

The POCO class should only have properties, no logic.
The function should take the POCO classes and serialize them to a file that has the same name as the POCO class.

•	Settings should serialize to XML
•	Config should serialize to XML
•	Data to JSON
•	Content to JSON

No conditional if, switch or LINQ statements should be used.

After you are done, you should be able to add a new serialization type, Binary. 
The POCO class for this type should be “BinaryContent”. 

The catch is you are only allowed to add new classes and add the IOC binding. NO EXISTING LOGIC SHOULD CHANGE.

