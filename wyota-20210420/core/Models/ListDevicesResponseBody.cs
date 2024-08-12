// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListDevicesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDevicesResponseBodyData> Data { get; set; }
        public class ListDevicesResponseBodyData : TeaModel {
            [NameInMap("ActiveTime")]
            [Validation(Required=false)]
            public string ActiveTime { get; set; }

            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("AutoLockScreenTime")]
            [Validation(Required=false)]
            public int? AutoLockScreenTime { get; set; }

            [NameInMap("AutoLogin")]
            [Validation(Required=false)]
            public int? AutoLogin { get; set; }

            [NameInMap("AutoType")]
            [Validation(Required=false)]
            public string AutoType { get; set; }

            [NameInMap("Bluetooth")]
            [Validation(Required=false)]
            public string Bluetooth { get; set; }

            [NameInMap("BuildId")]
            [Validation(Required=false)]
            public string BuildId { get; set; }

            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            [NameInMap("ConnectConfigs")]
            [Validation(Required=false)]
            public List<ListDevicesResponseBodyDataConnectConfigs> ConnectConfigs { get; set; }
            public class ListDevicesResponseBodyDataConnectConfigs : TeaModel {
                [NameInMap("ConnectScript")]
                [Validation(Required=false)]
                public string ConnectScript { get; set; }

                [NameInMap("PeripheralPid")]
                [Validation(Required=false)]
                public string PeripheralPid { get; set; }

                [NameInMap("PeripheralVid")]
                [Validation(Required=false)]
                public string PeripheralVid { get; set; }

                [NameInMap("RedirectPolicy")]
                [Validation(Required=false)]
                public int? RedirectPolicy { get; set; }

            }

            [NameInMap("CustomIdleAction")]
            [Validation(Required=false)]
            public int? CustomIdleAction { get; set; }

            [NameInMap("CustomPowerOn")]
            [Validation(Required=false)]
            public int? CustomPowerOn { get; set; }

            [NameInMap("CustomProperty")]
            [Validation(Required=false)]
            public string CustomProperty { get; set; }

            [NameInMap("CustomResourcePackage")]
            [Validation(Required=false)]
            public ListDevicesResponseBodyDataCustomResourcePackage CustomResourcePackage { get; set; }
            public class ListDevicesResponseBodyDataCustomResourcePackage : TeaModel {
                [NameInMap("ConfigAboutLogo")]
                [Validation(Required=false)]
                public string ConfigAboutLogo { get; set; }

                [NameInMap("DesktopWallpaper")]
                [Validation(Required=false)]
                public string DesktopWallpaper { get; set; }

                [NameInMap("LoginPageBackground")]
                [Validation(Required=false)]
                public string LoginPageBackground { get; set; }

                [NameInMap("LoginPageLogo")]
                [Validation(Required=false)]
                public string LoginPageLogo { get; set; }

                [NameInMap("PersonalCenterLogo")]
                [Validation(Required=false)]
                public string PersonalCenterLogo { get; set; }

                [NameInMap("StartLogo")]
                [Validation(Required=false)]
                public string StartLogo { get; set; }

                [NameInMap("StartMenuLogo")]
                [Validation(Required=false)]
                public string StartMenuLogo { get; set; }

                [NameInMap("UpgradeLogo")]
                [Validation(Required=false)]
                public string UpgradeLogo { get; set; }

            }

            [NameInMap("DefinePowerButton")]
            [Validation(Required=false)]
            public int? DefinePowerButton { get; set; }

            [NameInMap("DeviceIpV4")]
            [Validation(Required=false)]
            public string DeviceIpV4 { get; set; }

            [NameInMap("DeviceLock")]
            [Validation(Required=false)]
            public int? DeviceLock { get; set; }

            [NameInMap("DeviceMqttConnectionStatus")]
            [Validation(Required=false)]
            public int? DeviceMqttConnectionStatus { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("DeviceOS")]
            [Validation(Required=false)]
            public string DeviceOS { get; set; }

            [NameInMap("DevicePlatform")]
            [Validation(Required=false)]
            public string DevicePlatform { get; set; }

            [NameInMap("DisplayLayout")]
            [Validation(Required=false)]
            public string DisplayLayout { get; set; }

            [NameInMap("DisplayResolution")]
            [Validation(Required=false)]
            public string DisplayResolution { get; set; }

            [NameInMap("DisplayScaleRatio")]
            [Validation(Required=false)]
            public string DisplayScaleRatio { get; set; }

            [NameInMap("EnableAdb")]
            [Validation(Required=false)]
            public int? EnableAdb { get; set; }

            [NameInMap("EnableAutoLockScreen")]
            [Validation(Required=false)]
            public int? EnableAutoLockScreen { get; set; }

            [NameInMap("EnableBluetooth")]
            [Validation(Required=false)]
            public int? EnableBluetooth { get; set; }

            [NameInMap("EnableLockScreenPassword")]
            [Validation(Required=false)]
            public int? EnableLockScreenPassword { get; set; }

            [NameInMap("EnableModifyPassword")]
            [Validation(Required=false)]
            public int? EnableModifyPassword { get; set; }

            [NameInMap("EnableScheduledPowerOff")]
            [Validation(Required=false)]
            public int? EnableScheduledPowerOff { get; set; }

            [NameInMap("EnableUnlockPassword")]
            [Validation(Required=false)]
            public int? EnableUnlockPassword { get; set; }

            [NameInMap("EnableWlan")]
            [Validation(Required=false)]
            public int? EnableWlan { get; set; }

            [NameInMap("EndUserList")]
            [Validation(Required=false)]
            public List<ListDevicesResponseBodyDataEndUserList> EndUserList { get; set; }
            public class ListDevicesResponseBodyDataEndUserList : TeaModel {
                [NameInMap("AdDomain")]
                [Validation(Required=false)]
                public string AdDomain { get; set; }

                [NameInMap("BindTime")]
                [Validation(Required=false)]
                public string BindTime { get; set; }

                [NameInMap("DirectoryId")]
                [Validation(Required=false)]
                public string DirectoryId { get; set; }

                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("SerialNo")]
                [Validation(Required=false)]
                public string SerialNo { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

            [NameInMap("EtherMac")]
            [Validation(Required=false)]
            public string EtherMac { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("GmtSync")]
            [Validation(Required=false)]
            public string GmtSync { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IdleTime")]
            [Validation(Required=false)]
            public int? IdleTime { get; set; }

            [NameInMap("IsActive")]
            [Validation(Required=false)]
            public string IsActive { get; set; }

            [NameInMap("LabelList")]
            [Validation(Required=false)]
            public List<ListDevicesResponseBodyDataLabelList> LabelList { get; set; }
            public class ListDevicesResponseBodyDataLabelList : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("LabelId")]
                [Validation(Required=false)]
                public string LabelId { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

            [NameInMap("LastLoginUser")]
            [Validation(Required=false)]
            public string LastLoginUser { get; set; }

            [NameInMap("LocalUsbPrint")]
            [Validation(Required=false)]
            public int? LocalUsbPrint { get; set; }

            [NameInMap("LocationInfo")]
            [Validation(Required=false)]
            public string LocationInfo { get; set; }

            [NameInMap("LockPassword")]
            [Validation(Required=false)]
            public string LockPassword { get; set; }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("PeripheralConfig")]
            [Validation(Required=false)]
            public ListDevicesResponseBodyDataPeripheralConfig PeripheralConfig { get; set; }
            public class ListDevicesResponseBodyDataPeripheralConfig : TeaModel {
                [NameInMap("DefaultPolicy")]
                [Validation(Required=false)]
                public int? DefaultPolicy { get; set; }

                [NameInMap("PolicyStrategy")]
                [Validation(Required=false)]
                public int? PolicyStrategy { get; set; }

                [NameInMap("UsbAndInternalCamera")]
                [Validation(Required=false)]
                public int? UsbAndInternalCamera { get; set; }

                [NameInMap("UsbPrinter")]
                [Validation(Required=false)]
                public int? UsbPrinter { get; set; }

                [NameInMap("UsbStorage")]
                [Validation(Required=false)]
                public int? UsbStorage { get; set; }

            }

            [NameInMap("ScheduledPowerOff")]
            [Validation(Required=false)]
            public string ScheduledPowerOff { get; set; }

            [NameInMap("SecureNetworkType")]
            [Validation(Required=false)]
            public string SecureNetworkType { get; set; }

            [NameInMap("SerialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

            [NameInMap("SleepTime")]
            [Validation(Required=false)]
            public int? SleepTime { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("UsbStorage")]
            [Validation(Required=false)]
            public int? UsbStorage { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("Wlan")]
            [Validation(Required=false)]
            public string Wlan { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
