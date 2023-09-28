﻿using eticaret34.Dto.AppUserDto;
using eticaret34.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Net.Mail;

namespace eticaret34.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUserRegisterDto appUserRegisterDto)
        {
            if(ModelState.IsValid) {
                Random random = new Random();
                int code;
                code = random.Next(100000, 1000000);

				AppUser appuser = new AppUser()
                {
                    UserName = appUserRegisterDto.UserName,
                    FirstName = appUserRegisterDto.FirstName,
                    LastName = appUserRegisterDto.LastName,
                    Email = appUserRegisterDto.Email,
                    ConfirmCode=code
                    
                };
                 
                var result=await _userManager.CreateAsync(appuser,appUserRegisterDto.Password);
                if (result.Succeeded)
                {
					MimeMessage mimeMessage = new MimeMessage();
					MailboxAddress mailboxAddressFrom = new MailboxAddress("Kurs Uygulaması", "muratciplak917@gmail.com");
					MailboxAddress mailboxAddressTo = new MailboxAddress("User", appuser.Email);

					mimeMessage.From.Add(mailboxAddressFrom);
					mimeMessage.To.Add(mailboxAddressTo);

					var bodyBuilder = new BodyBuilder();
					bodyBuilder.TextBody = "Kayıt işlemini gerçekleştirmek için onay kodunuz:" + code;
					mimeMessage.Body = bodyBuilder.ToMessageBody();

					mimeMessage.Subject = "Easy Cash Onay Kodu";

					SmtpClient client = new SmtpClient();
                    
					client.Connect("smtp.gmail.com", 587, false);
					client.Authenticate("projekursapi@gmail.com", "btfcoirevejxphfr");
					client.Send(mimeMessage);
					client.Disconnect(true);

					TempData["Mail"] = appUserRegisterDto.Email;




					return RedirectToAction("Index","ConfirmMail");

                }
				else
				{
					foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                        return View();
                    }

			    }

			}
            
            return View();
        }
    }
}
