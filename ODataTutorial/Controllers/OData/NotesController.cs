using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODataTutorial.Entities;

namespace ODataTutorial.Controllers.OData;

public class NotesController : ODataController
{
    [EnableQuery()]
    public IQueryable<Note> Get()
    {
        return Notes.Items.AsQueryable();
    }
}
