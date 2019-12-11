using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Jysan.BLL.Abstractions;
using Jysan.BLL.Models;
using Jysan.BLL.Services;
using Jysan.DAL.Migrations;
using Microsoft.Ajax.Utilities;

public partial class LegalEntityPage : System.Web.UI.Page
{
    private readonly IIndividualService _individualService = new IndividualService();

    protected void Page_Load(object sender, EventArgs e)
    {



    }

    protected void btnSubmit_OnClick(object sender, EventArgs e)
    {
       
            var model = new IndividualModel
            {
                Iin = iin.Text,
                FirstName = fName.Text,
                LastName = lName.Text,
                Patronymic = pName.Text
            };
            _individualService.Create(model);
            IndividualsGV.DataBind();
    }
}