var Db  = require('./dboperations');
var Student = require('./student');
const dboperations = require('./dboperations');

var express = require('express');
var bodyParser = require('body-parser');
var cors = require('cors');
var app = express();
var router = express.Router();

app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());
app.use(cors());
app.use('/api', router);


router.use((request,response,next)=>{
   console.log('middleware');
   next();
})

router.route('/students').get((request,response)=>{

    dboperations.getStudents().then(result => {
       response.json(result[0]);
    })

})

router.route('/student/:id').get((request,response)=>{

    dboperations.getStudents(request.params.id).then(result => {
       response.json(result[0]);
    })

})

router.route('/student').post((request,response)=>{

    let student = {...request.body}

    dboperations.addStudent(student).then(result => {
       response.status(201).json(result);
    })

})

router.route('/student/:id').delete((request,response)=>{

    dboperations.deleteStudent(request.params.id).then(result => {
       response.status(201).json(result);
    })

})


var port = process.env.PORT || 8091;
app.listen(port);
console.log('Student API is runnning at ' + port);

// dboperations.getStudents().then(result=>{
//     console.log(result);
//})