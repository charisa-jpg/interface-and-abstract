## ไม่เอาอันนี้แล้ว


# Training Registration System

## Project Description

ระบบสำหรับลงทะเบียนเข้าร่วมการอบรม โดยรองรับผู้ใช้งาน 3 ประเภท ได้แก่

- นักศึกษา (Student)
- อาจารย์ (Teacher)
- บุคคลทั่วไป (General Person)

ระบบจะเก็บข้อมูลพื้นฐานของผู้สมัคร ได้แก่ ชื่อ นามสกุล เบอร์โทรศัพท์ และอีเมล

ความสามารถของระบบ:

- นักศึกษา อาจารย์ และบุคคลทั่วไป สามารถลงทะเบียนอบรมได้
- อาจารย์ และบุคคลทั่วไป สามารถเป็นวิทยากรได้
- วิทยากรสามารถอบรมและอนุมัติผลการอบรมให้ผู้เข้าอบรมได้
- แสดงรายชื่อผู้เข้าอบรมและวิทยากรได้

ระบบออกแบบโดยใช้แนวคิด Object-Oriented Programming (OOP) ประกอบด้วย Abstract Class, Interface และ Class

---

## Class Diagram

```mermaid
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

class AcademicRank{
    <<enumeration>>
    Lecturer
    AssistantProfessor
    AssociateProfessor
    Professor
}

class Student{
    +StudentId : string
    +Major : string
    +RegisterTraining()
    +ShowInfo()
}

class Teacher{
    +Major : string
    +AcademicPosition : AcademicRank
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
