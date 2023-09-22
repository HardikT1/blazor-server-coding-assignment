using BlazorServerCoding.Models;

namespace BlazorServerCoding.Data
{
    public static class OperationService
    {
        public static async Task<List<Operation>> GetOperationList()
        {
            await Task.Delay(100);

            return new List<Operation>
            {
                new Operation
                {
                    OperationID = 1,
                    Name = "Operation 1",
                    OrderInWhichToPerform = 1,
                    ImageData = File.ReadAllBytes("images/barcodescanner.jpg"),
                   // Device = new Device { DeviceID = 1, Name = "Device 1", DeviceType = DeviceType.BarcodeScanner }
                    Device = new Device()
                },
                new Operation
                {
                    OperationID = 2,
                    Name = "Operation 2",
                    OrderInWhichToPerform = 2,
                    ImageData = File.ReadAllBytes("images/printer.jpg"),
                    //Device = new Device { DeviceID = 2, Name = "Device 2", DeviceType = DeviceType.Printer }
                    Device = new Device()
                },
                new Operation
                {
                    OperationID = 3,
                    Name = "Operation 3",
                    OrderInWhichToPerform = 3,
                    ImageData = File.ReadAllBytes("images/camera.jpg"),
                    //Device = new Device { DeviceID = 3, Name = "Device 3", DeviceType = DeviceType.Camera }
                    Device = new Device()
                },
                new Operation
                {
                    OperationID = 4,
                    Name = "Operation 4",
                    OrderInWhichToPerform = 4,
                    ImageData = File.ReadAllBytes("images/SocketTray.jpg"),
                    //Device = new Device { DeviceID = 4, Name = "Device 4", DeviceType = DeviceType.SocketTray }
                    Device = new Device()
                }
            };
        }
    }
}
