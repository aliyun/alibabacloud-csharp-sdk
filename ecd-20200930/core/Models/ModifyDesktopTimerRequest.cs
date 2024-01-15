// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopTimerRequest : TeaModel {
        /// <summary>
        /// The cloud computer ID. You can specify 1 to 20 IDs.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// The details of the scheduled task for the cloud desktops.
        /// </summary>
        [NameInMap("DesktopTimers")]
        [Validation(Required=false)]
        public List<ModifyDesktopTimerRequestDesktopTimers> DesktopTimers { get; set; }
        public class ModifyDesktopTimerRequestDesktopTimers : TeaModel {
            /// <summary>
            /// Specifies whether to allow end users to configure scheduled tasks on an Alibaba Cloud Workspace client.
            /// </summary>
            [NameInMap("AllowClientSetting")]
            [Validation(Required=false)]
            public bool? AllowClientSetting { get; set; }

            /// <summary>
            /// The cron expression of the scheduled task.
            /// 
            /// >  You must specify the time in UTC format. For example, if you want to specify 00:00 of UTC+8, use the following cron expression: 0 0 16. \* 1,2,3,4,5,6,7
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// Specifies whether to forcefully execute the scheduled task. A value of true indicates that the system forcefully executes the scheduled task regardless of the connection status of the cloud desktop.
            /// </summary>
            [NameInMap("Enforce")]
            [Validation(Required=false)]
            public bool? Enforce { get; set; }

            /// <summary>
            /// The interval. Unit: minutes.
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// The type of the scheduled operation. This parameter is valid only when TimerType is set to NoConnect.
            /// 
            /// Valid values:
            /// 
            /// *   Hibernate
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     hibernates the cloud desktops
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   Shutdown
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     stops the cloud desktops
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// Indicates which type of disk that is used by the cloud desktop is reset.
            /// 
            /// Valid values:
            /// 
            /// *   RESET_TYPE_SYSTEM
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     resets the system disks
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   RESET_TYPE_BOTH
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     resets the data disks and system disks.
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ResetType")]
            [Validation(Required=false)]
            public string ResetType { get; set; }

            /// <summary>
            /// The type of the scheduled task.
            /// 
            /// Valid values:
            /// 
            /// *   NoOperationDisconnect: Disconnects the cloud desktops when no operations are performed on the cloud desktops.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   LogoutShutdown: Stops the cloud desktops when end users log out of Alibaba Cloud Workspace clients.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NoConnect: Disconnets the cloud desktops when end users perform one of the actions that is specified by the OperationType parameter.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   TimerBoot: Starts the cloud desktops at a scheduled point in time.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   TimerReset: Resets the cloud desktops at a scheduled point in time.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   LoginAutoConnect: automatically connects to cloud desktops when end users log on to Alibaba Cloud Workspace clients.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NoOperationShutdown: Stops the cloud desktops when no operations are performed on the cloud desktops.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   TimerShutdown: Stops the cloud desktops at a scheduled point in time.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NoOperationReboot: Restarts the cloud desktops when no operations are performed on the cloud desktops.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   TimerReboot: Restarts the cloud desktops at a scheduled point in time.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("TimerType")]
            [Validation(Required=false)]
            public string TimerType { get; set; }

        }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to use DesktopTimers. If you want to use a timer, **set this parameter to true**.
        /// </summary>
        [NameInMap("UseDesktopTimers")]
        [Validation(Required=false)]
        public bool? UseDesktopTimers { get; set; }

    }

}
