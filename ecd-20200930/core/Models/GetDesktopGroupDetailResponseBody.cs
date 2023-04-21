// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetDesktopGroupDetailResponseBody : TeaModel {
        /// <summary>
        /// Details of the desktop group.
        /// </summary>
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public GetDesktopGroupDetailResponseBodyDesktops Desktops { get; set; }
        public class GetDesktopGroupDetailResponseBodyDesktops : TeaModel {
            /// <summary>
            /// Indicates whether the auto scale-out feature is enabled for the desktop group.
            /// </summary>
            [NameInMap("AllowAutoSetup")]
            [Validation(Required=false)]
            public int? AllowAutoSetup { get; set; }

            /// <summary>
            /// The number of reserved cloud desktops in the desktop group.
            /// </summary>
            [NameInMap("AllowBufferCount")]
            [Validation(Required=false)]
            public int? AllowBufferCount { get; set; }

            /// <summary>
            /// The number of sessions that are allowed for each cloud desktop in the multi-session desktop group.
            /// </summary>
            [NameInMap("BindAmount")]
            [Validation(Required=false)]
            public int? BindAmount { get; set; }

            /// <summary>
            /// The number of purchased cloud desktops. Valid values: 0 to 200.
            /// </summary>
            [NameInMap("BuyDesktopsCount")]
            [Validation(Required=false)]
            public int? BuyDesktopsCount { get; set; }

            /// <summary>
            /// The remarks on the desktop group.
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// The maximum period of time for which a session is effective. Unit: milliseconds.
            /// </summary>
            [NameInMap("ConnectDuration")]
            [Validation(Required=false)]
            public long? ConnectDuration { get; set; }

            /// <summary>
            /// The number of vCPUs.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// The time when the desktop group was created. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The user who creates the desktop group.
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// The category of the data disk.
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// The size of the data disk.
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            /// <summary>
            /// The ID of the desktop group.
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// The name of the desktop group.
            /// </summary>
            [NameInMap("DesktopGroupName")]
            [Validation(Required=false)]
            public string DesktopGroupName { get; set; }

            /// <summary>
            /// The ID of the directory, which is the same as the ID of the workspace.
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// The type of the directory.
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// The time when the desktop group expires.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The number of vGPUs.
            /// </summary>
            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

            /// <summary>
            /// The GPU specifications.
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// The maximum period of time for which a session remains idle. Unit: milliseconds.
            /// </summary>
            [NameInMap("IdleDisconnectDuration")]
            [Validation(Required=false)]
            public long? IdleDisconnectDuration { get; set; }

            /// <summary>
            /// The ID of the image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The retention period of a cloud desktop in the desktop group after the cloud desktop is disconnected. Unit: milliseconds.
            /// </summary>
            [NameInMap("KeepDuration")]
            [Validation(Required=false)]
            public long? KeepDuration { get; set; }

            /// <summary>
            /// The load balancing policy for the multi-session desktop group.
            /// 
            /// Valid values:
            /// 
            /// *   0
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     depth first
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   1
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     breadth first
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// </summary>
            [NameInMap("LoadPolicy")]
            [Validation(Required=false)]
            public int? LoadPolicy { get; set; }

            /// <summary>
            /// The maximum number of cloud desktops that the desktop group can contain.
            /// </summary>
            [NameInMap("MaxDesktopsCount")]
            [Validation(Required=false)]
            public int? MaxDesktopsCount { get; set; }

            /// <summary>
            /// The memory size.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// The minimum number of cloud desktops that the desktop group must retain.
            /// </summary>
            [NameInMap("MinDesktopsCount")]
            [Validation(Required=false)]
            public int? MinDesktopsCount { get; set; }

            /// <summary>
            /// The ID of the Apsara File Storage NAS (NAS) file system.
            /// </summary>
            [NameInMap("NasFileSystemID")]
            [Validation(Required=false)]
            public string NasFileSystemID { get; set; }

            /// <summary>
            /// The name of the NAS file system.
            /// </summary>
            [NameInMap("NasFileSystemName")]
            [Validation(Required=false)]
            public string NasFileSystemName { get; set; }

            /// <summary>
            /// The ID of the workspace.
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// The name of the workspace.
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// The type of the workspace.
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// The ID of the desktop template.
            /// </summary>
            [NameInMap("OwnBundleId")]
            [Validation(Required=false)]
            public string OwnBundleId { get; set; }

            /// <summary>
            /// The name of the desktop template.
            /// </summary>
            [NameInMap("OwnBundleName")]
            [Validation(Required=false)]
            public string OwnBundleName { get; set; }

            /// <summary>
            /// The type of the desktop group.
            /// 
            /// Valid values:
            /// 
            /// *   0
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     personal desktop group
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   1
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     shared desktop group (multi-session)
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public int? OwnType { get; set; }

            /// <summary>
            /// The billing method.
            /// 
            /// Valid values:
            /// 
            /// *   PostPaid
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     pay-as-you-go
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   PrePaid
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     subscription
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The ID of the security policy group.
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// The IDs of the policies with which the desktop group is associated.
            /// </summary>
            [NameInMap("PolicyGroupIds")]
            [Validation(Required=false)]
            public List<string> PolicyGroupIds { get; set; }

            /// <summary>
            /// The name of the security policy group.
            /// </summary>
            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            /// <summary>
            /// The names of the policies.
            /// </summary>
            [NameInMap("PolicyGroupNames")]
            [Validation(Required=false)]
            public List<string> PolicyGroupNames { get; set; }

            /// <summary>
            /// Indicates whether data roaming is enabled.
            /// </summary>
            [NameInMap("ProfileFollowSwitch")]
            [Validation(Required=false)]
            public bool? ProfileFollowSwitch { get; set; }

            /// <summary>
            /// The session usage threshold for the multi-session desktop group that has an auto scaling policy in effect.
            /// </summary>
            [NameInMap("RatioThreshold")]
            [Validation(Required=false)]
            public float? RatioThreshold { get; set; }

            /// <summary>
            /// The type of the resource. Only Elastic Compute Service (ECS) instances are supported.
            /// 
            /// Valid values:
            /// 
            /// *   0
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     ECS
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// </summary>
            [NameInMap("ResType")]
            [Validation(Required=false)]
            public int? ResType { get; set; }

            /// <summary>
            /// Indicates which type of disk is reset for cloud desktops in the desktop group.
            /// 
            /// Valid values:
            /// 
            /// *   0
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     No disks are reset
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   1
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     Only the system disk is reset
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   2
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     Only the data disk is reset
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   3
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     Both the system disk and data disk are reset
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// </summary>
            [NameInMap("ResetType")]
            [Validation(Required=false)]
            public int? ResetType { get; set; }

            /// <summary>
            /// Details of the scheduled tasks.
            /// </summary>
            [NameInMap("ScaleTimerInfos")]
            [Validation(Required=false)]
            public List<GetDesktopGroupDetailResponseBodyDesktopsScaleTimerInfos> ScaleTimerInfos { get; set; }
            public class GetDesktopGroupDetailResponseBodyDesktopsScaleTimerInfos : TeaModel {
                /// <summary>
                /// The number of purchased cloud desktops during the scaling event. Valid values: 0 to 200.
                /// </summary>
                [NameInMap("BuyResAmount")]
                [Validation(Required=false)]
                public int? BuyResAmount { get; set; }

                /// <summary>
                /// The type of the CRON expression that is specified for the scheduled task.
                /// </summary>
                [NameInMap("Cron")]
                [Validation(Required=false)]
                public string Cron { get; set; }

                /// <summary>
                /// The retention period of a cloud desktop in the desktop group after the cloud desktop is disconnected. Unit: milliseconds.
                /// </summary>
                [NameInMap("KeepDuration")]
                [Validation(Required=false)]
                public long? KeepDuration { get; set; }

                /// <summary>
                /// The load balancing policy for the multi-session desktop group.
                /// </summary>
                [NameInMap("LoadPolicy")]
                [Validation(Required=false)]
                public int? LoadPolicy { get; set; }

                /// <summary>
                /// The maximum number of cloud desktops that the system can scale. Valid values: 0 to 200.
                /// </summary>
                [NameInMap("MaxResAmount")]
                [Validation(Required=false)]
                public int? MaxResAmount { get; set; }

                /// <summary>
                /// The minimum number of cloud desktops that the system must scale. Valid values: 0 to 200.
                /// </summary>
                [NameInMap("MinResAmount")]
                [Validation(Required=false)]
                public int? MinResAmount { get; set; }

                /// <summary>
                /// The threshold for the ratio of connected sessions. This parameter is the condition that triggers auto scaling in a multi-session desktop group. `Ratio of connected sessions = Number of connected sessions/(Total number of cloud desktops × Maximum number of sessions allowed for each cloud desktop) × 100%`. If the specified threshold is reached, new cloud desktops are automatically created. If the specified threshold is not reached, idle cloud desktops are released.
                /// </summary>
                [NameInMap("RatioThreshold")]
                [Validation(Required=false)]
                public float? RatioThreshold { get; set; }

                /// <summary>
                /// The type of the scheduled task.
                /// 
                /// Valid values:
                /// 
                /// *   drop
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     decline policy
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// 
                /// *   normal
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     normal policy
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// 
                /// *   peak
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     peak hour policy
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// 
                /// *   rise
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     rise policy
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The status of the desktop group.
            /// 
            /// Valid values:
            /// 
            /// *   0
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     The desktop group is unpaid
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   1
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     The desktop group is paid
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   2
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     The desktop group has an overdue payment or expired
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The period of time before an idle cloud desktop enters the Stopped state. When the specified period of time is reached, the idle cloud desktop automatically stops. If an end user connects to a stopped cloud desktop, the cloud desktop automatically starts. Unit: milliseconds.
            /// </summary>
            [NameInMap("StopDuration")]
            [Validation(Required=false)]
            public long? StopDuration { get; set; }

            /// <summary>
            /// The category of the system disk.
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// The size of the system disk.
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// The list of scheduled points in time for desktop group tasks.
            /// </summary>
            [NameInMap("TimerInfos")]
            [Validation(Required=false)]
            public List<GetDesktopGroupDetailResponseBodyDesktopsTimerInfos> TimerInfos { get; set; }
            public class GetDesktopGroupDetailResponseBodyDesktopsTimerInfos : TeaModel {
                /// <summary>
                /// The CRON expression of the scheduled task.
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// Indicates whether the scheduled task is forcibly executed.
                /// </summary>
                [NameInMap("Forced")]
                [Validation(Required=false)]
                public bool? Forced { get; set; }

                /// <summary>
                /// The status of the scheduled task.
                /// 
                /// Valid values:
                /// 
                /// *   1
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     The scheduled task is enabled
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// 
                /// *   2
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     The scheduled task is disabled
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// 
                /// *   3
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     The scheduled task is deleted
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The type of the scheduled task.
                /// 
                /// Valid values:
                /// 
                /// *   1
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     scheduled reset
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// 
                /// *   2
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     scheduled startup
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// 
                /// *   3
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     scheduled stop
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// 
                /// *   4
                /// 
                ///     <!-- -->
                /// 
                ///     :
                /// 
                ///     <!-- -->
                /// 
                ///     scheduled restart
                /// 
                ///     <!-- -->
                /// 
                ///     .
                /// </summary>
                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public int? TimerType { get; set; }

            }

            /// <summary>
            /// The information about the scheduling policy.
            /// </summary>
            [NameInMap("TimingStrategyInfo")]
            [Validation(Required=false)]
            public string TimingStrategyInfo { get; set; }

            /// <summary>
            /// The version number of the desktop group.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
