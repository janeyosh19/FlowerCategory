using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;
using System.Data.Entity;



namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {



        List<Flower> listofflowers = new List<Flower>();

        public ActionResult Admin()
        {

            return View();
        }

        public ActionResult Index(Occasion events)
        {
            
          return View();
        }


        [HttpPost]
        public ActionResult Submit(string occassionId)
        {
            if (occassionId == "1")
            {
                return RedirectToAction("Birthday");
            }
            if (occassionId == "2")
            {
                return RedirectToAction("Goodbye");

            }
            if (occassionId == "3")
            {
                return RedirectToAction("Mothersday");

            }
            if (occassionId == "4")
            {
                return RedirectToAction("Wedding");
            }
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Birthday()
        {

            var carnation = new Flower("carnation");
            var violet = new Flower("violet");
            var iris = new Flower("iris");
            var daffodil = new Flower("daffodil");
            var sweetPea = new Flower("sweetPea");
            var daisy = new Flower("daisy");
            var lilyoftheValley = new Flower("lilyoftheValley ");
            var rose = new Flower(" rose");
            var larkspur = new Flower("larkspur");
            var gladiolus = new Flower("gladiolus");
            var aster = new Flower("aster");
            var forgetMeNot = new Flower("forgetMeNot");
            var marigold = new Flower("marigold");
            var chrysanthemum = new Flower("chrysanthemum");
            var poinsettia = new Flower("poinsettia");

            listofflowers.Add(carnation);
            listofflowers.Add(violet);
            listofflowers.Add(iris);
            listofflowers.Add(daffodil);
            listofflowers.Add(sweetPea);
            listofflowers.Add(daisy);
            listofflowers.Add(lilyoftheValley);
            listofflowers.Add(rose);
            listofflowers.Add(larkspur);
            listofflowers.Add(gladiolus);
            listofflowers.Add(aster);
            listofflowers.Add(forgetMeNot);
            listofflowers.Add(marigold);
            listofflowers.Add(chrysanthemum);
            listofflowers.Add(poinsettia);

            carnation.FlowerType = FlowerType.Birthday;
            violet.FlowerType = FlowerType.Birthday;
            iris.FlowerType = FlowerType.Birthday;
            daffodil.FlowerType = FlowerType.Birthday;
            sweetPea.FlowerType = FlowerType.Birthday;
            daisy.FlowerType = FlowerType.Birthday;
            lilyoftheValley.FlowerType = FlowerType.Birthday;
            rose.FlowerType = FlowerType.Birthday;
            larkspur.FlowerType = FlowerType.Birthday;
            gladiolus.FlowerType = FlowerType.Birthday;
            aster.FlowerType = FlowerType.Birthday;
            forgetMeNot.FlowerType = FlowerType.Birthday;
            marigold.FlowerType = FlowerType.Birthday;
            chrysanthemum.FlowerType = FlowerType.Birthday;
            poinsettia.FlowerType = FlowerType.Birthday;

            using (var db = new OccasionsContext())
            {

                
                db.Flowers.AddRange(listofflowers);
                db.SaveChanges();

                var flowersbirthday = db.Flowers.Where(flower => flower.FlowerType == FlowerType.Birthday);
            }



            return View(listofflowers);
        }

      
        public ActionResult Goodbye()
        {


            var redspiderlily = new Flower("redspiderlily");
            var whiterose = new Flower("whiterose");
            var yellowtulip = new Flower("yellowtulip");
            var sweetpea = new Flower("sweetpea");
            var yellowcamelia = new Flower("yellowcamelia");
            var whitechrysanthemumm = new Flower("whitechrysanthemumm");

            listofflowers.Add(redspiderlily);
            listofflowers.Add(whiterose);
            listofflowers.Add(yellowtulip);
            listofflowers.Add(sweetpea);
            listofflowers.Add(yellowcamelia);
            listofflowers.Add(whitechrysanthemumm);

            redspiderlily.FlowerType = FlowerType.Goodbye;
            whiterose.FlowerType = FlowerType.Goodbye;
            yellowtulip.FlowerType = FlowerType.Goodbye;
            sweetpea.FlowerType = FlowerType.Goodbye;
            yellowcamelia.FlowerType = FlowerType.Goodbye;
            whitechrysanthemumm.FlowerType = FlowerType.Goodbye;
            
            

            using (var db = new OccasionsContext())
            {
                var flowersbirthday = db.Flowers.Where(flower => flower.FlowerType == FlowerType.Goodbye);
            }
            return View(listofflowers);
        }

        public ActionResult Mothersday()
        {

            var carnation = new Flower("carnation");
            var redtulip = new Flower("redtulip");
            var whiterose= new Flower("whiterose");
            var primrose = new Flower("primrose");
            var bluebell = new Flower("bluebell");
            var cactus = new Flower("cactus"); ;
            var daffodil = new Flower("daffodil");
            var pinkrose = new Flower("pinkrose");

            listofflowers.Add(carnation);
            listofflowers.Add(redtulip);
            listofflowers.Add(whiterose);
            listofflowers.Add(primrose);
            listofflowers.Add(bluebell);
            listofflowers.Add(cactus);
            listofflowers.Add(daffodil);
            listofflowers.Add(pinkrose);

            carnation.FlowerType = FlowerType.Wedding;
            redtulip.FlowerType = FlowerType.Wedding;
            whiterose.FlowerType = FlowerType.Wedding;
            primrose.FlowerType = FlowerType.Wedding;
            bluebell.FlowerType = FlowerType.Wedding;
            cactus.FlowerType = FlowerType.Wedding;
            daffodil.FlowerType = FlowerType.Wedding;
            pinkrose.FlowerType = FlowerType.Wedding;

            using (var db = new OccasionsContext())
            {
                var flowersbirthday = db.Flowers.Where(flower => flower.FlowerType == FlowerType.Mothersday);
            }
            return View(listofflowers);

        }


         public ActionResult Wedding()
            {


            var rose = new Flower("rose");
            var callalily = new Flower("callalily");
            var lilyofthevaley = new Flower("lilyofthevaley");
            var hydrangeas = new Flower("hydrangeas");
            var ranuclus = new Flower("ranuclus");
            var peony = new Flower("peony"); ;
            var sweetpeas = new Flower("sweetpeas");
            var stephanotis = new Flower("stephanotis");
            var gardenia = new Flower("gardenia");

            listofflowers.Add(rose);
            listofflowers.Add(callalily);
            listofflowers.Add(lilyofthevaley);
            listofflowers.Add(hydrangeas);
            listofflowers.Add(ranuclus);
            listofflowers.Add(peony);
            listofflowers.Add(sweetpeas);
            listofflowers.Add(stephanotis);
            listofflowers.Add(gardenia);

            rose.FlowerType = FlowerType.Wedding;
            callalily.FlowerType = FlowerType.Wedding;
            lilyofthevaley.FlowerType = FlowerType.Wedding; 
            hydrangeas.FlowerType = FlowerType.Wedding;
            ranuclus.FlowerType = FlowerType.Wedding;
            peony.FlowerType = FlowerType.Wedding;
            sweetpeas.FlowerType = FlowerType.Wedding;
            stephanotis.FlowerType = FlowerType.Wedding;
            gardenia.FlowerType = FlowerType.Wedding;

            using (var db = new OccasionsContext())
            {
                var flowersbirthday = db.Flowers.Where(flower => flower.FlowerType == FlowerType.Wedding);
                return View(listofflowers);
            }


           

            }

            
            
    }

   
}

