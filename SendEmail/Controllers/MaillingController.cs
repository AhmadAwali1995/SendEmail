using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendEmail.Dtos;
using SendEmail.Services;

namespace SendEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaillingController : ControllerBase
    {
        private readonly IMaillingServices _maillingServices;
        public MaillingController(IMaillingServices maillingServices)
        {
            _maillingServices = maillingServices;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromForm] MailRequestDto dto)
        {
            await _maillingServices.SendEmailAsync(dto.ToEmail, dto.Subject, dto.Body, dto.Attachments);
            return Ok();
        }
    }
}
