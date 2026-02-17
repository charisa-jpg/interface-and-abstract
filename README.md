## Training Registration System
ระบบสำหรับลงทะเบียนเข้าร่วมการอบรม โดยรองรับ

- นักศึกษา
- อาจารย์
- บุคคลทั่วไป
- วิทยากร

ระบบสามารถ:
- ลงทะเบียนข้อมูลผู้เข้าอบรม
- แสดงรายชื่อผู้เข้าอบรม
- แสดงรายชื่อวิทยากร


classDiagram

class Person{
    <<abstract>>
    +FirstName : string
    +LastName : string
    +Phone : string
    +Email : string
    +ShowInfo()
}

class IRegistrable{
    <<interface>>
    +RegisterTraining()
}

class ISpeaker{
    <<interface>>
    +ConductTraining()
    +ApproveResult()
}

class Student{
    +StudentId : string
    +Major : string
    +RegisterTraining()
    +ShowInfo()
}

class Teacher{
    +Major : string
    +AcademicPosition : string
    +RegisterTraining()
    +ConductTraining()
    +ApproveResult()
    +ShowInfo()
}

class GeneralPerson{
    +Workplace : string
    +Position : string
    +RegisterTraining()
    +ConductTraining()
    +ApproveResult()
    +ShowInfo()
}

Person <|-- Student
Person <|-- Teacher
Person <|-- GeneralPerson

IRegistrable <|.. Student
IRegistrable <|.. Teacher
IRegistrable <|.. GeneralPerson

ISpeaker <|.. Teacher
ISpeaker <|.. GeneralPerson


## Class Description
- **Person (Abstract Class)** : เก็บข้อมูลพื้นฐานของผู้สมัคร
- **Student** : ผู้สมัครประเภทนักศึกษา
- **Teacher** : ผู้สมัครประเภทอาจารย์ และสามารถเป็นวิทยากรได้
- **GeneralPerson** : บุคคลทั่วไป และสามารถเป็นวิทยากรได้
- **IRegistrable** : ความสามารถในการลงทะเบียนอบรม
- **ISpeaker** : ความสามารถในการเป็นวิทยากร
