# Dependecy_Injection

1) Dependency Injection

=> What is dependency?
  =>When one class depends on another class for a property or method due to
	which coupling occurs in code.

=> What is coupling?
  => It's a measure of how connected two classes are.
  => Dependency b/w classes increase coupling.
  => High coupling increases cost of change to software.
  => A good software will have low coupling.
  
=> What is Tight Coupling?
	=>When group of classes are highly dependent on one other.
	=>Ex-> class A, class B, class C when class A creates an object for class B &
	  class C. means class A is highly dependent on class B and class C.
	  If we delete or modify any class let say class B it will directly affect
	   class A.
	=> Ex2-> class Car, class Engine, class Brakes when class Car creates an object for class Engine &
	  class Brakes. means class Car is highly dependent on class Engine and class Brakes.
	  If we delete or modify any class let say class Engine it will directly affect
	   class Car.  
	=>Disadvantages:
		=>This scenario arises when class assumes too many responsibilities.	   
		  or One concern is spread over many classes rather than having its own class.
		=> Difficult to Test.

=> What is Loose Coupling?
	=> It means classes are independent of each other.
	=> Ex-> Student, Teacher and Admin are three classes which are independent
			of each other or there is very less dependency between them.
	=> Advantages:
		=>Loose Coupling is achieved by	means of design that promotes
		  single-responsibility & separate of concerns.
		=>Easy to maintain.
		=> Easy to test.
	
=> How to avoid this tightly coupled state?
	=>By using Dependency Injection.
	=>Dependency Injection is achieved through interfaces.
	=>Interface are powerful tool for decoupling(Conversion of Tightly Couple to Loosely Couple).
	=>Classes can communicate with each other rather than other concrete classes(Specific class).
	
	
=> What is Dependency Injection(DI)?
  => DI is Software pattern/Design Pattern to reduce coupling b/w classes..
  => DI basically providing the objects that an object needs, instead of
	 having it construct the object themselves.
  => Provide dependencies to classes without high coupling.
  => Can be implemented without any third party.
  
  =>Types of Dependency Injection.
	=>Constructor Injection
	=>Setter or Property Injection.
	=>Methods Injection.
	
		=>Constructor Injection
		  =>It is nothing but the process of injecting dependent class object
		    through the constructor.
			
