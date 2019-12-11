using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Jysan.BLL.Abstractions;
using Jysan.BLL.Models;
using Jysan.BLL.Services;

public partial class LegalEntityPage : System.Web.UI.Page
{
    private readonly ILegalEntityService _legalEntityService = new LegalEntityService();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

 
    protected void OnSelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedId = ((GridView)sender).SelectedValue.ToString();
        var contacts = _legalEntityService.GetContactsByLegalEntity(int.Parse(selectedId));
        contactsGrid.DataSource = contacts;
        contactsGrid.DataBind();
    }

    protected void btnSubmit_OnClick(object sender, EventArgs e)
    {
        var model = new LegalEntityModel
        {
            Name = name.Text,
            Iin = iin.Text
        };
        _legalEntityService.Create(model);
        legalEntityGrid.DataBind();
    }
}