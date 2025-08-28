public class PersonModel {
    private String firstName;
    private String lastName;

    public PersonModel(String firstName, String lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }
}
java
Copy
Edit
public class EmployeeModel {
    private String firstName;
    private String lastName;
    private String emailAddress;

    public EmployeeModel(String firstName, String lastName, String emailAddress) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = emailAddress;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public String getEmailAddress() {
        return emailAddress;
    }
}
java
Copy
Edit
public class Accounts {
    public EmployeeModel create(PersonModel person) {
        String email = (person.getFirstName().substring(0, 1) + person.getLastName() + "@acme.com").toLowerCase();
        return new EmployeeModel(person.getFirstName(), person.getLastName(), email);
    }
}
java
Copy
Edit
import java.util.ArrayList;
import java.util.List;

public class App {
    public static void main(String[] args) {
        List<PersonModel> applicants = new ArrayList<>();
        applicants.add(new PersonModel("Tim", "Cory"));
        applicants.add(new PersonModel("Sue", "Storm"));
        applicants.add(new PersonModel("Nancy", "Romo"));

        Accounts accountProcessor = new Accounts();
        List<EmployeeModel> employees = new ArrayList<>();

        for (PersonModel applicant : applicants) {
            EmployeeModel employee = accountProcessor.create(applicant);
            employees.add(employee);

            System.out.println(employee.getFirstName() + " " + employee.getLastName() +
                    " - " + employee.getEmailAddress());
        }
    }
}