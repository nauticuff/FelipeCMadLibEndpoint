/*
Carlos Felipe 
10/26/22
MadLib - Endpoint
CODE: This builds a mad lib game where the user inputs the words and displays a funny story.
Peer review by : N. HARRISON WILKINS : GREAT WORK! BEST MAD LIB I HAVE SEEN SO FAR. HAS BLACK BACKGROUND WHICH ADDS INDIVIDUALITY TO THE PROJECT. VERY IMPRESSIVE!!!
*/
using Microsoft.AspNetCore.Mvc;

namespace FelipeCMadLibEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class StoryController : ControllerBase
{
   [HttpGet]
   [Route("nounOne/nounTwo/nounThree/adjOne/adjTwo/adjThree/nounFour/adverb/nounFive/adjFour/adjFive")]
   public string Instructions(){
      return "Okay now replace the URL with values starting wiht nounOne :)";
   }

   [HttpGet]
   [Route("{nounOne}/{nounTwo}/{nounThree}/{adjOne}/{adjTwo}/{adjThree}/{nounFour}/{adverb}/{nounFive}/{adjFour}/{adjFive}/")]
   public string Lib(string nounOne, string nounTwo, string nounThree, string adjOne, string adjTwo, string adjThree, string nounFour, string adverb, string nounFive, string adjFour, string adjFive){
    return $"Our dining {nounOne} use to be a war {nounTwo}. I though the battles about the correct table {nounThree} would never end. It was us kids versus Mom, and it seemed like a fight that would last to the {adjOne} end. But tonight Dad finally declared a/an {adjTwo} truce, and we negotiated a/an {adjThree} peace {nounFour}. Mom promised to no longer get {adverb} upset and shoot us dirty {nounFive} and make {adjFour} remarks when we do {adjFive} things she doesn't like.";
   }

}
