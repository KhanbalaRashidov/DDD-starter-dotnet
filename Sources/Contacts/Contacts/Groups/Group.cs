using System.Collections.Generic;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MyCompany.ECommerce.Contacts.Companies;
using MyCompany.ECommerce.TechnicalStuff.Crud;
using Newtonsoft.Json;
using P3Model.Annotations.Domain.StaticModel;

namespace MyCompany.ECommerce.Contacts.Groups;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
[AnemicEntity]
public class Group : CrudEntity
{
    public string Name { get; set; }
    public string Description { get; set; }

    [BindNever]
    [JsonIgnore]
    public List<CompanyGroup> Companies { get; set; }

    [BindNever]
    [JsonIgnore]
    public List<GroupTag> Tags { get; set; }
}