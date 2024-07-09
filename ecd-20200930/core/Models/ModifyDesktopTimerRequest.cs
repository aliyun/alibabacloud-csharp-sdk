// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopTimerRequest : TeaModel {
        /// <summary>
        /// The IDs of the cloud computers.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// The details of the scheduled task on cloud computers.
        /// </summary>
        [NameInMap("DesktopTimers")]
        [Validation(Required=false)]
        public List<ModifyDesktopTimerRequestDesktopTimers> DesktopTimers { get; set; }
        public class ModifyDesktopTimerRequestDesktopTimers : TeaModel {
            /// <summary>
            /// Specifies whether to allow end users to configure the scheduled task.
            /// </summary>
            [NameInMap("AllowClientSetting")]
            [Validation(Required=false)]
            public bool? AllowClientSetting { get; set; }

            /// <summary>
            /// The cron expression of the schedule.
            /// 
            /// > The time must be in UTC. For example, for 24:00 (UTC+8), you must set the value to 0 0 16 ? \\* 1,2,3,4,5,6,7
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// Specifies whether to forcibly execute the scheduled task.
            /// 
            /// Valid values:
            /// 
            /// *   true: forcibly executes the scheduled task regardless of the status and connection of the cloud computers.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   false: does not forcibly execute the scheduled task.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Enforce")]
            [Validation(Required=false)]
            public bool? Enforce { get; set; }

            /// <summary>
            /// The interval at which the scheduled task is executed. Unit: minutes.
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// The operations that scheduled tasks support. This parameter is valid only when TimerType is set to NoConnect.
            /// 
            /// Valid values:
            /// 
            /// *   Hibernate: hibernates the cloud computers.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Shutdown: stops the cloud computers.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// The reset type of the cloud computers.
            /// 
            /// Valid values:
            /// 
            /// *   RESET_TYPE_SYSTE: resets the system disk.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   RESET_TYPE_BOTH: resets data and user disks.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
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
            /// *   NoOperationDisconnect: Disconnects the cloud computers without performing operations on the cloud computers.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   LogoutShutdown: Stops the cloud computers when end users log out Alibaba Cloud Workspace clients.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NoConnect: Disconnects the cloud computers when end users perform one of the actions that is specified by the OperationType parameter.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   TimerBoot: Starts the cloud computers on schedule.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   TimerReset: Resets the cloud computers on schedule.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   LoginAutoConnect: automatically connects to the cloud computers when end users log on to Alibaba Cloud Workspace clients.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NoOperationShutdown: Stops the cloud computers without performing operations on the cloud computers.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   TimerShutdown: Stops the cloud computers on schedule.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NoOperationReboot: Restarts the cloud computers without performing operations on the cloud computers.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   TimerReboot: Restarts the cloud computers on schedule.
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
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/196646.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to use the `DesktopTimers`** parameter. Set the value to `true`**.
        /// </summary>
        [NameInMap("UseDesktopTimers")]
        [Validation(Required=false)]
        public bool? UseDesktopTimers { get; set; }

    }

}
