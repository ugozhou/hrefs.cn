﻿using ASY.Hrefs.Model.Models;
using AutoMapper;
using MicroServices;

namespace ASY.Hrefs.BLL.Dispatcher
{
    public static class Mapping
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Article, ArticleProto>(MemberList.None).ForAllMembers(opt => opt.Condition((source, destination, sourceMember, destMember) => sourceMember != null));
                cfg.CreateMap<Link, LinkProto>(MemberList.None).ForAllMembers(opt => opt.Condition((source, destination, sourceMember, destMember) => sourceMember != null));
                cfg.CreateMap<Account, AccountProto>(MemberList.None).ForAllMembers(opt => opt.Condition((source, destination, sourceMember, destMember) => sourceMember != null));

                cfg.CreateMap<ArticleProto, Article>(MemberList.None).ForAllMembers(opt => opt.Condition((source, destination, sourceMember, destMember) => sourceMember != null));
                cfg.CreateMap<LinkProto, Link>(MemberList.None).ForAllMembers(opt => opt.Condition((source, destination, sourceMember, destMember) => sourceMember != null));
                cfg.CreateMap<AccountProto, Account>(MemberList.None).ForAllMembers(opt => opt.Condition((source, destination, sourceMember, destMember) => sourceMember != null));
            });

            configuration.AssertConfigurationIsValid();
            return configuration;
        }
    }
}