using Windows.Devices.Gpio;

namespace BOT
{
    public sealed class MyBot
    {
        // Get the default GPIO controller on the system
        GpioController gpio;

        const int PIN_MOTOR_LEFT_FORWARD = 27;
        const int PIN_MOTOR_LEFT_BACKWARD = 22;

        const int PIN_MOTOR_RIGHT_FORWARD = 23;
        const int PIN_MOTOR_RIGHT_BACKWARD = 24;

        GpioPin leftwheelF, leftwheelB;
        GpioPin rightwheelF, rightwheelB;

        public MyBot()
        {
            // Get the default GPIO controller on the system
            gpio = GpioController.GetDefault();

            if (gpio == null)
                return; // GPIO not available on this system

            leftwheelF = gpio.OpenPin(PIN_MOTOR_LEFT_FORWARD);
            leftwheelB = gpio.OpenPin(PIN_MOTOR_LEFT_BACKWARD);

            rightwheelF = gpio.OpenPin(PIN_MOTOR_RIGHT_FORWARD);
            rightwheelB = gpio.OpenPin(PIN_MOTOR_RIGHT_BACKWARD);

            leftwheelF.Write(GpioPinValue.Low);
            leftwheelB.Write(GpioPinValue.Low);

            rightwheelF.Write(GpioPinValue.Low);
            rightwheelB.Write(GpioPinValue.Low);

            leftwheelF.SetDriveMode(GpioPinDriveMode.Output);
            leftwheelB.SetDriveMode(GpioPinDriveMode.Output);

            rightwheelF.SetDriveMode(GpioPinDriveMode.Output);
            rightwheelB.SetDriveMode(GpioPinDriveMode.Output);
        }

        private void leftWheelGoForward()
        {
            leftwheelF.Write(GpioPinValue.High);
            leftwheelB.Write(GpioPinValue.Low);
        }

        private void rightWheelGoForward()
        {
            rightwheelF.Write(GpioPinValue.High);
            rightwheelB.Write(GpioPinValue.Low);
        }

        private void leftWheelGoBackward()
        {
            leftwheelF.Write(GpioPinValue.Low);
            leftwheelB.Write(GpioPinValue.High);
        }

        private void rightWheelGoBackward()
        {
            rightwheelF.Write(GpioPinValue.Low);
            rightwheelB.Write(GpioPinValue.High);
        }

        private void leftWheelStop()
        {
            leftwheelF.Write(GpioPinValue.Low);
            leftwheelB.Write(GpioPinValue.Low);
        }

        private void rightWheelStop()
        {
            rightwheelF.Write(GpioPinValue.Low);
            rightwheelB.Write(GpioPinValue.Low);
        }

        public void exit()
        {
            leftwheelF.Write(GpioPinValue.Low);
            leftwheelB.Write(GpioPinValue.Low);

            leftwheelB.Dispose();
            leftwheelF.Dispose();

            rightwheelF.Write(GpioPinValue.Low);
            rightwheelB.Write(GpioPinValue.Low);

            rightwheelB.Dispose();
            rightwheelF.Dispose();
        }

        public void moveBackward()
        {
            leftWheelGoForward();
            rightWheelGoForward();
        }

        public void moveForward()
        {
            leftWheelGoBackward();
            rightWheelGoBackward();
        }

        public void stop()
        {
            rightWheelStop();
            leftWheelStop();
        }

        public void turnLeft()
        {
            leftwheelF.Write(GpioPinValue.Low);
            leftwheelB.Write(GpioPinValue.Low);

            rightwheelF.Write(GpioPinValue.Low);
            rightwheelB.Write(GpioPinValue.Low);

            rightWheelGoForward();
            //await Task.Delay(TimeSpan.FromSeconds(2));
            leftWheelGoBackward();
            //await Task.Delay(TimeSpan.FromSeconds(2));
        }

        public void turnRight()
        {
            leftwheelF.Write(GpioPinValue.Low);
            leftwheelB.Write(GpioPinValue.Low);

            rightwheelF.Write(GpioPinValue.Low);
            rightwheelB.Write(GpioPinValue.Low);

            rightWheelGoBackward();
            //await Task.Delay(TimeSpan.FromSeconds(2));
            leftWheelGoForward();
            //await Task.Delay(TimeSpan.FromSeconds(2));
        }
    }
}
