## gRPC Message Examples:

    message Person {
        string name = 1;
        int32 id = 2;  // Unique ID number for this person.
        string email = 3;
		
        enum PhoneType {
            MOBILE = 0;
            HOME = 1;
            WORK = 2;
         }

         message PhoneNumber {
             string number = 1;
             PhoneType type = 2;
         }

         repeated PhoneNumber phones = 4;

         google.protobuf.Timestamp last_updated = 5;
    }

    // Our address book file is just one of these.
    message AddressBook {
      repeated Person people = 1;
    }

In the above example, the Person message contains PhoneNumber messages, while the AddressBook message contains Person messages. You can even define message types nested inside other messages – as you can see, the PhoneNumber type is defined inside Person. You can also define enum types if you want one of your fields to have one of a predefined list of values – here you want to specify that a phone number can be one of MOBILE, HOME, or WORK.

The " = 1", " = 2" markers on each element identify the unique "tag" that field uses in the binary encoding. Tag numbers 1-15 require one less byte to encode than higher numbers, so as an optimization you can decide to use those tags for the commonly used or repeated elements, leaving tags 16 and higher for less-commonly used optional elements. Each element in a repeated field requires re-encoding the tag number, so repeated fields are particularly good candidates for this optimization.

If a field value isn't set, a default value is used: zero for numeric types, the empty string for strings, false for bools. For embedded messages, the default value is always the "default instance" or "prototype" of the message, which has none of its fields set. Calling the accessor to get the value of a field which has not been explicitly set always returns that field's default value.

If a field is repeated, the field may be repeated any number of times (including zero). The order of the repeated values will be preserved in the protocol buffer. Think of repeated fields as dynamically sized arrays.

You'll find a complete guide to writing .proto files – including all the possible field types – in the [Protocol Buffer Language Guide](https://developers.google.com/protocol-buffers/docs/proto3). Don't go looking for facilities similar to class inheritance, though – protocol buffers don't do that.