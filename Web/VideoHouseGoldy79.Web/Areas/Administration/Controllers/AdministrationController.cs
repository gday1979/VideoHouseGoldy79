namespace VideoHouseGoldy79.Web.Areas.Administration.Controllers
{
    using VideoHouseGoldy79.Common;
    using VideoHouseGoldy79.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
