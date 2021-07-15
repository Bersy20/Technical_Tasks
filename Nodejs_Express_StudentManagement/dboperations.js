var config = require('./dbconfig');
const sql = require('mssql');


async function getStudents() {
    try {
        let pool = await sql.connect(config);
        let students = await pool.request().query("SELECT * from tbl_student");
        return students.recordsets;
    }
    catch (error) {
        console.log(error);
    }
}

async function getStudent(StudentId) {
    try {
        let pool = await sql.connect(config);
        let student = await pool.request()
            .input('input_parameter', sql.Int, StudentId)
            .query("SELECT * from tbl_student where StudentId = @input_parameter");
        return student.recordsets;

    }
    catch (error) {
        console.log(error);
    }
}


async function addStudent(student) {

    try {
        let pool = await sql.connect(config);
        let insertStudent = await pool.request()
            .input('StudentId', sql.Int, student.StudentId)
            .input('Name', sql.NVarChar, student.Name)
            .input('ContactNo', sql.Int, student.ContactNo)
            .input('City', sql.NVarChar, student.City)
            .input('Pincode', sql.NVarChar, student.Pincode)
            .query("Insert into tbl_Student values(@Name,@ContactNo,@City,@PinCode)");
        return insertStudent.recordsets;
    }
    catch (err) {
        console.log(err);
    }

}

async function deleteStudent(StudentId) {
    try {
        let pool = await sql.connect(config);
        let student = await pool.request()
            .input('input_parameter', sql.Int, StudentId)
            .query("delete from tbl_student where StudentId = @input_parameter");
        return student.recordsets;

    }
    catch (error) {
        console.log(error);
    }
}





module.exports = {
    getStudents: getStudents,
    getStudent : getStudent,
    addStudent : addStudent,
    deleteStudent:deleteStudent
}
