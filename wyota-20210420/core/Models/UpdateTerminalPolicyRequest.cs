// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class UpdateTerminalPolicyRequest : TeaModel {
        [NameInMap("AllowManualLockScreen")]
        [Validation(Required=false)]
        public int? AllowManualLockScreen { get; set; }

        [NameInMap("BackgroundModeTitle")]
        [Validation(Required=false)]
        public string BackgroundModeTitle { get; set; }

        [NameInMap("CustomScreenCastRes")]
        [Validation(Required=false)]
        public bool? CustomScreenCastRes { get; set; }

        [NameInMap("DisplayLayout")]
        [Validation(Required=false)]
        public string DisplayLayout { get; set; }

        [NameInMap("DisplayResolution")]
        [Validation(Required=false)]
        public string DisplayResolution { get; set; }

        [NameInMap("DisplayScaleRatio")]
        [Validation(Required=false)]
        public string DisplayScaleRatio { get; set; }

        [NameInMap("EnableAutoLockScreen")]
        [Validation(Required=false)]
        public int? EnableAutoLockScreen { get; set; }

        [NameInMap("EnableAutoLogin")]
        [Validation(Required=false)]
        public int? EnableAutoLogin { get; set; }

        [NameInMap("EnableBackgroundMode")]
        [Validation(Required=false)]
        public int? EnableBackgroundMode { get; set; }

        [NameInMap("EnableBluetooth")]
        [Validation(Required=false)]
        public int? EnableBluetooth { get; set; }

        [NameInMap("EnableControlPanel")]
        [Validation(Required=false)]
        public int? EnableControlPanel { get; set; }

        [NameInMap("EnableImmersiveMode")]
        [Validation(Required=false)]
        public int? EnableImmersiveMode { get; set; }

        [NameInMap("EnableLockScreenHotKey")]
        [Validation(Required=false)]
        public int? EnableLockScreenHotKey { get; set; }

        [NameInMap("EnableModifyPassword")]
        [Validation(Required=false)]
        public int? EnableModifyPassword { get; set; }

        [NameInMap("EnableScanLogin")]
        [Validation(Required=false)]
        public int? EnableScanLogin { get; set; }

        [NameInMap("EnableScheduledReboot")]
        [Validation(Required=false)]
        public int? EnableScheduledReboot { get; set; }

        [NameInMap("EnableScheduledShutdown")]
        [Validation(Required=false)]
        public int? EnableScheduledShutdown { get; set; }

        [NameInMap("EnableSmsLogin")]
        [Validation(Required=false)]
        public int? EnableSmsLogin { get; set; }

        [NameInMap("EnableSwitchPersonal")]
        [Validation(Required=false)]
        public int? EnableSwitchPersonal { get; set; }

        [NameInMap("EnableWlan")]
        [Validation(Required=false)]
        public int? EnableWlan { get; set; }

        [NameInMap("FollowCloudReboot")]
        [Validation(Required=false)]
        public int? FollowCloudReboot { get; set; }

        [NameInMap("FollowCloudShutdown")]
        [Validation(Required=false)]
        public int? FollowCloudShutdown { get; set; }

        [NameInMap("FollowTerminalReboot")]
        [Validation(Required=false)]
        public int? FollowTerminalReboot { get; set; }

        [NameInMap("FollowTerminalShutdown")]
        [Validation(Required=false)]
        public int? FollowTerminalShutdown { get; set; }

        [NameInMap("ForceSetPinCode")]
        [Validation(Required=false)]
        public int? ForceSetPinCode { get; set; }

        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        [NameInMap("IdleTimeoutAction")]
        [Validation(Required=false)]
        public int? IdleTimeoutAction { get; set; }

        [NameInMap("LockScreenPasswordRequired")]
        [Validation(Required=false)]
        public int? LockScreenPasswordRequired { get; set; }

        [NameInMap("LockScreenTimeout")]
        [Validation(Required=false)]
        public int? LockScreenTimeout { get; set; }

        [NameInMap("MainBizType")]
        [Validation(Required=false)]
        public string MainBizType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PowerButtonDefine")]
        [Validation(Required=false)]
        public int? PowerButtonDefine { get; set; }

        [NameInMap("PowerButtonDefineForAs")]
        [Validation(Required=false)]
        public int? PowerButtonDefineForAs { get; set; }

        [NameInMap("PowerButtonDefineForNs")]
        [Validation(Required=false)]
        public int? PowerButtonDefineForNs { get; set; }

        [NameInMap("PowerOnBehavior")]
        [Validation(Required=false)]
        public int? PowerOnBehavior { get; set; }

        [NameInMap("RunningMode")]
        [Validation(Required=false)]
        public string RunningMode { get; set; }

        [NameInMap("ScheduledReboot")]
        [Validation(Required=false)]
        public string ScheduledReboot { get; set; }

        [NameInMap("ScheduledShutdown")]
        [Validation(Required=false)]
        public string ScheduledShutdown { get; set; }

        [NameInMap("ScreenCastResPaths")]
        [Validation(Required=false)]
        public List<string> ScreenCastResPaths { get; set; }

        [NameInMap("SettingLock")]
        [Validation(Required=false)]
        public int? SettingLock { get; set; }

        [NameInMap("TerminalPolicyId")]
        [Validation(Required=false)]
        public string TerminalPolicyId { get; set; }

        [NameInMap("UnlockMethod")]
        [Validation(Required=false)]
        public int? UnlockMethod { get; set; }

    }

}
