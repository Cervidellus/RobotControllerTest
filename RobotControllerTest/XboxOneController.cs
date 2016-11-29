using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.XInput;
using System.Diagnostics;

namespace RobotControllerTest
{
    class XboxOneController : IRobotInputDevice
    {
        //This will handle polling of the gamepad and calculating deadzones, etc. 
        //It should maybe be overloaded so that one could send a deadzone to it
        //It will output the joystick as a % of range rather than the value given by the controller to make it easy to plug other kinds of controllers into software
        //This class will serve as a template for creating a Warthog Joystick class

        //my idea here is to first implement things with polling, then switch over to event based stuff... 
        //and have the events or the joystick incorporate a polling rate.
        //an example of using events comes from here: www.codeproject.com/tips/858059/xbox-controller-class

        private SharpDX.XInput.State state;
        private SharpDX.XInput.State lastState;

        SharpDX.XInput.Controller xBoxController;
        
        public bool connected = false;


        //Constructor to initialize the controller as an iRobotInputDevice interface

        public XboxOneController()
        {

            xBoxController = new SharpDX.XInput.Controller(UserIndex.One);
            Debug.WriteLine("Is it connected? " + xBoxController.IsConnected);
        }

        public int leftX()
        {
            state = xBoxController.GetState();
            int _leftX = state.Gamepad.LeftThumbX;
            return _leftX;
        }


        //Check if polling time is exceeded, if not update the state. This is a private method called by other methods in the class.

        //...





        //Left Joystick X axis magnitude expressed as a percentage, with 50 in the middle



    }
} 
