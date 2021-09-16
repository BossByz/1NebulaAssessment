1) The function will be parsed correctly because javascript is not a statically typed language. Parameters in functions do not have a specific type. If a type needs to be checked, it is done in the body of the function. 

The 'var x;' line will simply store the passed in x variable. The 'var x;' is unused in this code snippet but it will still compile and run just fine.

2) As for variable/function declaration, you can do one of three things. 

One option is to give the variable a value, allowing the javascript compiler to automatically know what type it is. The problem with this is that variables can change types if re-assigned.

The second option is to verify the type of the variable through the 'typeof' keyword. This returns the type of a variable at any given time.

The third and best way is to use a language such as TypeScript, where variables can have static types, and cannot be dynamically changed if needed. This also works with function types, to ensure only valid values can be passed in.