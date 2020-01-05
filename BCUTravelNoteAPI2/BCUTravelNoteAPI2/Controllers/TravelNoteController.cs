using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BCUTravelNoteAPI2.Controllers
{
    public class TravelNoteController : Controller
    {
        public JsonResult GetTravelNotes()
        {
            return new JsonResult(new List<object>()
            {
                new
                {
                    TravelNoteId = 1,
                    TravelNoteParentId = 1,
                    CardNumEncrypted = "cnxxxx1",
                    CardNumDecrypted = "cn00001",
                    CardDescription = "TestCardDesc",
                    Note = "TestNote",
                    CreationDate = DateTime.Now,
                    DepartureDate = DateTime.Parse("01/28/2020"),
                    ReturnDate = DateTime.Parse("02/04/2020"),
                    TravelType = 1,
                    PendingAction = 4, //ActiveNotify
                    IsPendingActionFromBatch = bool.Parse("0") // = False


                }
            });
        }
    }
}
