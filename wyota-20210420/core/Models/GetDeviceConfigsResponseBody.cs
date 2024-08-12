// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class GetDeviceConfigsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDeviceConfigsResponseBodyData Data { get; set; }
        public class GetDeviceConfigsResponseBodyData : TeaModel {
            [NameInMap("AutoLockScreenTime")]
            [Validation(Required=false)]
            public int? AutoLockScreenTime { get; set; }

            [NameInMap("AutoLogin")]
            [Validation(Required=false)]
            public int? AutoLogin { get; set; }

            [NameInMap("AutoUpdate")]
            [Validation(Required=false)]
            public int? AutoUpdate { get; set; }

            [NameInMap("CustomIdleAction")]
            [Validation(Required=false)]
            public int? CustomIdleAction { get; set; }

            [NameInMap("CustomPowerOn")]
            [Validation(Required=false)]
            public int? CustomPowerOn { get; set; }

            [NameInMap("CustomResourcePackage")]
            [Validation(Required=false)]
            public GetDeviceConfigsResponseBodyDataCustomResourcePackage CustomResourcePackage { get; set; }
            public class GetDeviceConfigsResponseBodyDataCustomResourcePackage : TeaModel {
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

            [NameInMap("DeviceLock")]
            [Validation(Required=false)]
            public int? DeviceLock { get; set; }

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

            [NameInMap("IdleTime")]
            [Validation(Required=false)]
            public int? IdleTime { get; set; }

            [NameInMap("LocalUsbPrint")]
            [Validation(Required=false)]
            public int? LocalUsbPrint { get; set; }

            [NameInMap("LockPassword")]
            [Validation(Required=false)]
            public string LockPassword { get; set; }

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

            [NameInMap("Urcl")]
            [Validation(Required=false)]
            public string Urcl { get; set; }

            [NameInMap("UsbStorage")]
            [Validation(Required=false)]
            public int? UsbStorage { get; set; }

            [NameInMap("UserCustomId")]
            [Validation(Required=false)]
            public string UserCustomId { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
