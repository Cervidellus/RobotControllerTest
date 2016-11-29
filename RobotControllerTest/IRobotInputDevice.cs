using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControllerTest
{
    interface IRobotInputDevice
    {
        //This interface defines what is needed from the input device (i.e. XBOX controller) by the robot software 

        //FindInputDevice find the controller if connected and initialize
        int leftX();
        //Emergency Stop Button
        //
        //XAxisInput 1-100%, with 50 being the middle
        //YAxisInput 1-100%, with 50 being the middle
        //ZAxisInput 1-100% with 50 being middle
        //AirPufferInput    1-100%
        //ToPickupLoopState button press event
        //ToPickupSectionState button press event
        //ToDropoffLoopState button press event
    }
}
