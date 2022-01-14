﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_QLNH.DTO;
using WebAPI_QLNH.Models;

namespace WebAPI_QLNH.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role));

            CreateMap<Role, RoleDTO>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
               .ForMember(dest => dest.Restaurant, opt => opt.MapFrom(src => src.Restaurant));

            CreateMap<Restaurant, RestaurantDTO > ()
               .ForMember(dest => dest.Id, opt=>opt.MapFrom(src=>src.Id))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
               .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
               .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
               .ForMember(dest => dest.Deleted, opt => opt.MapFrom(src => src.Deleted))
               .ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
               .ForMember(dest => dest.Updated, opt => opt.MapFrom(src => src.Updated))
               .ForMember(dest => dest.UpdatedUser, opt => opt.MapFrom(src => src.UpdatedUser))
               .ForMember(dest => dest.CreatedUser, opt => opt.MapFrom(src => src.CreatedUser));

            CreateMap<Guest, GuestDTO>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
               .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
               .ForMember(dest => dest.Deleted, opt => opt.MapFrom(src => src.Deleted))
               .ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
               .ForMember(dest => dest.Updated, opt => opt.MapFrom(src => src.Updated))
               .ForMember(dest => dest.UpdatedUser, opt => opt.MapFrom(src => src.UpdatedUser))
               .ForMember(dest => dest.CreatedUser, opt => opt.MapFrom(src => src.CreatedUser));

            CreateMap<Status, StatusDTO>()
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
              .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
              .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
              .ForMember(dest => dest.Deleted, opt => opt.MapFrom(src => src.Deleted))
              .ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
              .ForMember(dest => dest.Updated, opt => opt.MapFrom(src => src.Updated))
              .ForMember(dest => dest.UpdatedUser, opt => opt.MapFrom(src => src.UpdatedUser))
              .ForMember(dest => dest.CreatedUser, opt => opt.MapFrom(src => src.CreatedUser));
        }
    }
}


