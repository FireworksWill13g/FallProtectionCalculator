using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallProtectionCalculator
{
    class Computation


        // Fall Clearance Calculation //
    //The Required Fall Distance(ReqDist) below the anchor point of the worker at height is calculated by adding the following 
    //variables. These variables are: Lanyard Lenght (LL) which is the length of the lanyard fully extended (not under load or extended from fall); 
    //Deceleration Distance (DD) the distance in which the lanyard extendes from normal lentgh to its full lentgh after a fall occurs (measured from Dring at normal lenght to D ring after fall)
    //Worker Height (WorkerHeight) this is natrually the height if the worker when suspended in the harness - typically measured from the Back D-Ring to the bottom of the workers Feet.
     //Safety Factor (SF) this is a little extra just in case any obstructions happen to be under the worker such as boxes, tools, etc. 

    //IMPORTNAT - It is importnant to add 1 foot to the Deceleration Distance (DD) for free-fall over 6 feet and up to 12 feet or
    // for a person over 310 lbs in weight and up to 420 lbs with 6 feet max. This is for ANSI and OSHA complianct Lanyards. 
    //  For Canadian CSA Z259.11-05 (E6) compliant Lanyards - Add 1.7ft to the Deceleration Distance.

    {
        public ReqDist int CalcFallDist(int LL, int DD, int WorkerHeight, int SF)
    {
        int ReqDist = 0;
        int FallDist = LL + DD + WorkerHeight;

        ReqDist = FallDist + SF;
        return ReqDist;
    }

        public ReqLanLeng int CalcLanyardLenght(int RD, int DD, int PersonHeight, int SafFact)
        {
            int LanLeng = RD - DD - PersonHeight - SafFact;
            ReqLanLeng = LanLeng;    
        }
}
}
