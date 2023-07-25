using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using My_Tables.Entities;
using MyDbProject;
using NToastNotify;
using OurHotels.Dto;
using OurHotels.Dto.Customer;
using OurHotels.Dto.Room;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Our_Hotels1.Controllers
{
    public class CustomerController : Controller
    {
        public readonly ApplicationDbContext _applicationDbContext;
        private readonly IToastNotification _toastNotification;
        //private readonly IRoomRepo _Iroom;
        private readonly IHostEnvironment hostEnvironment;
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;

        public CustomerController(ApplicationDbContext applicationDbContext,
            IToastNotification toastNotification, UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager, IHostEnvironment hostEnvironment)
        {
            _applicationDbContext = applicationDbContext;
            _toastNotification = toastNotification;
            _userManager = userManager;
          
            _signInManager = signInManager;
            this.hostEnvironment = hostEnvironment;
        }

        public IActionResult SearchHotel()
        {

            var roomDetailsList = _applicationDbContext.RoomEntities
            .Select(room => new RoomDetailsDto
            {
                RoomEntityId = room.RoomEntityId,
                RoomNum = room.RoomNum,
                Suite = room.suite,
                NumOfBeds = room.numOfBeds,
                Price = room.Price,
               Sea= room.sea,
                RoomImagesUrls = room.Images.Select(image => new RoomImageDto
                {
                    Id = image.Id,
                    Url = image.Url,
                    RoomEntityId = image.RoomEntityId
                }).ToList(),
                HotelEntityId = room.HotelEntity.HotelEntityId,
                HotelName = room.HotelEntity.HotelName,
                City = (OurHotels.Dto.Hotel.City)room.HotelEntity.City,
                NumOfStars = room.HotelEntity.numOfStars,
                HotelPicture = room.HotelEntity.HotelPicture,
                Address = room.HotelEntity.HotelAddress
            })
            .ToList();

            return View(roomDetailsList);
        }
    }
            
        }
    
