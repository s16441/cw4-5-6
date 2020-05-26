using System;

public class EnrollmentsController
{
    [ApiController]
    [Route("api/enrollments")]

    public class EnrollmentsController : ControllerBase
    {

        private IStudentsDbService _dbService;

        public EnrollmentsController(IStudentsDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpPost]
        [Route("promotions")]
        public IActionResult PromoteStudents(PromoteRequest request)
        {

            try
            {
                return Ok(_dbService.PromoteStudents(request));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.Message);
            }

        }
        [HttpPost]
        public IActionResult AddStudent(EnrollRequest request)
        {

            try
            {
                return Ok(_dbService.EnrollStudent(request));
            }
            catch (Exception exc)
            {
                return BadRequest(exc.Message);
            }

        }

     
    }
}