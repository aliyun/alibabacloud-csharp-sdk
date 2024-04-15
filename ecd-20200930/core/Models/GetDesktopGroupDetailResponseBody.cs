// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetDesktopGroupDetailResponseBody : TeaModel {
        /// <summary>
        /// The information about the cloud computer pool.
        /// </summary>
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public GetDesktopGroupDetailResponseBodyDesktops Desktops { get; set; }
        public class GetDesktopGroupDetailResponseBodyDesktops : TeaModel {
            /// <summary>
            /// Indicates whether cloud computers can be automatically created in the subscription cloud computer pool.
            /// 
            /// Valid values:
            /// 
            /// *   0: false
            /// *   1: true
            /// </summary>
            [NameInMap("AllowAutoSetup")]
            [Validation(Required=false)]
            public int? AllowAutoSetup { get; set; }

            /// <summary>
            /// The number of cloud computers that is allowed to be reserved in the pay-as-you-go cloud computer pool. Valid values:
            /// 
            /// *   0: does not allow the system to reserve cloud computers.
            /// *   N: allows the system to reserve N cloud computers. (1≤ N ≤ 100)
            /// </summary>
            [NameInMap("AllowBufferCount")]
            [Validation(Required=false)]
            public int? AllowBufferCount { get; set; }

            /// <summary>
            /// The number of concurrent sessions that is allowed for each cloud computer in a multi-session cloud computer pool.
            /// </summary>
            [NameInMap("BindAmount")]
            [Validation(Required=false)]
            public int? BindAmount { get; set; }

            /// <summary>
            /// *   This parameter has different meanings based on the billing method of the cloud computer pool. For a subscription pool, this parameter indicates the number of cloud computers that you purchase in the pool. Valid values: 0 to 200.
            /// *   For a pay-as-you-go pool, this parameter indicates the minimum number of cloud computers that you can create in the pool. Default value: 1. Valid values: 0 to `MaxDesktopsCount`.
            /// </summary>
            [NameInMap("BuyDesktopsCount")]
            [Validation(Required=false)]
            public int? BuyDesktopsCount { get; set; }

            /// <summary>
            /// The remarks.
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// The maximum period of time during which the session is connected. When the specified maximum period of time is reached, the session is automatically disconnected. Unit: milliseconds.
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
            /// The Alibaba Cloud account that creates the cloud computer pool.
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// The category of the user disk.
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// The user disk capacity. Unit: GiB.
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            /// <summary>
            /// The ID of the cloud computer pool.
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// The name of the cloud computer pool that is queried.
            /// </summary>
            [NameInMap("DesktopGroupName")]
            [Validation(Required=false)]
            public string DesktopGroupName { get; set; }

            /// <summary>
            /// The ID of the directory or office network.
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
            /// The time when the subscription cloud computer pool expires.
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
            /// After an end user connects to a cloud computer, the session is established. If the system does not detect any inputs from the keyboard or mouse within the specified period of time, the session is closed. Unit: milliseconds.
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
            /// The amount of time to retain a session after it is disconnected. Unit: milliseconds. Valid values: 180000 to 345600000. That is, the session can be retained for 3 to 5760 minutes (4 days). If you specify the value to 0, the session is permanently retained.
            /// 
            /// When a session is disconnected, take note of the following situations: If an end user does not resume the session within the specified duration, the session is closed and all unsaved data is cleared. If the end user resumes the session within the specified duration, the end user can still access data of the session.
            /// </summary>
            [NameInMap("KeepDuration")]
            [Validation(Required=false)]
            public long? KeepDuration { get; set; }

            /// <summary>
            /// The load balancing policy of the multi-session cloud computer pool.
            /// 
            /// Valid values:
            /// 
            /// *   0: depth-first
            /// *   1: breadth-first
            /// </summary>
            [NameInMap("LoadPolicy")]
            [Validation(Required=false)]
            public int? LoadPolicy { get; set; }

            /// <summary>
            /// The maximum number of cloud computers that can be housed in the pay-as-you-go cloud computer pool.
            /// </summary>
            [NameInMap("MaxDesktopsCount")]
            [Validation(Required=false)]
            public int? MaxDesktopsCount { get; set; }

            /// <summary>
            /// The memory size. Unit: MiB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// The maximum number of cloud computers that can be automatically created in the subscription cloud computer pool.
            /// </summary>
            [NameInMap("MinDesktopsCount")]
            [Validation(Required=false)]
            public int? MinDesktopsCount { get; set; }

            /// <summary>
            /// The ID of the Apsara File Storage NAS (NAS) file system for the user data roaming feature.
            /// </summary>
            [NameInMap("NasFileSystemID")]
            [Validation(Required=false)]
            public string NasFileSystemID { get; set; }

            /// <summary>
            /// The name of the NAS file system for the user data roaming feature.
            /// </summary>
            [NameInMap("NasFileSystemName")]
            [Validation(Required=false)]
            public string NasFileSystemName { get; set; }

            /// <summary>
            /// The ID of the office network.
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// The name of the office network in which the cloud computer pool resides.
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// The office network type.
            /// 
            /// Valid values:
            /// 
            /// *   PERSONAL: individual office network
            /// *   SIMPLE: convenience office network
            /// *   AD_CONNECTOR: enterprise Active Directory (AD) office network
            /// *   RAM: Resource Access Management (RAM)-based office network
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// The ID of the cloud computer template.
            /// </summary>
            [NameInMap("OwnBundleId")]
            [Validation(Required=false)]
            public string OwnBundleId { get; set; }

            /// <summary>
            /// The name of the cloud computer template.
            /// </summary>
            [NameInMap("OwnBundleName")]
            [Validation(Required=false)]
            public string OwnBundleName { get; set; }

            /// <summary>
            /// The type of the cloud computer pool.
            /// 
            /// Valid values:
            /// 
            /// *   0: individual (single session)
            /// *   1: shared (multiple sessions)
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public int? OwnType { get; set; }

            /// <summary>
            /// The billing method.
            /// 
            /// Valid values:
            /// 
            /// *   PostPaid: pay-as-you-go.
            /// 
            /// *   PrePaid: subscription.
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The ID of the policy that is associated with the cloud computer pool.
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// The IDs of policies that are associated with the cloud computer pool.
            /// </summary>
            [NameInMap("PolicyGroupIds")]
            [Validation(Required=false)]
            public List<string> PolicyGroupIds { get; set; }

            /// <summary>
            /// The name of the policy that is associated with the cloud computer pool.
            /// </summary>
            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            /// <summary>
            /// The names of policies that are associated with the cloud computer pool.
            /// </summary>
            [NameInMap("PolicyGroupNames")]
            [Validation(Required=false)]
            public List<string> PolicyGroupNames { get; set; }

            /// <summary>
            /// Indicates whether user data roaming is enabled.
            /// </summary>
            [NameInMap("ProfileFollowSwitch")]
            [Validation(Required=false)]
            public bool? ProfileFollowSwitch { get; set; }

            /// <summary>
            /// The threshold for the ratio of connected sessions. This parameter is the condition that triggers auto scaling in a multi-session cloud computer pool. To calculate the ratio of connected sessions, use the following formula:
            /// 
            /// `Ratio of connected sessions = Number of connected sessions/(Total number of cloud computers × Maximum number of sessions allowed for each cloud computer) × 100%`
            /// 
            /// If the ratio of connected sessions is greater than the specified value, new cloud computers are created. If the ratio of connected sessions is smaller than the specified value, idle cloud computers are deleted.
            /// </summary>
            [NameInMap("RatioThreshold")]
            [Validation(Required=false)]
            public float? RatioThreshold { get; set; }

            /// <summary>
            /// The type of the resource. Only Elastic Compute Service (ECS) instances are supported.
            /// 
            /// Valid value:
            /// 
            /// *   0: ECS
            /// </summary>
            [NameInMap("ResType")]
            [Validation(Required=false)]
            public int? ResType { get; set; }

            /// <summary>
            /// The disk reset type of the cloud computer.
            /// 
            /// Valid values:
            /// 
            /// *   0: does not reset disks.
            /// *   1: resets only the system disk.
            /// *   2: resets only the user disk.
            /// *   3: resets the system disk and the user disk.
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
                /// The number of cloud computers that you purchase in the cloud computer pool. This parameter is one of the auto scaling parameters. Valid values: 0 to 200.
                /// </summary>
                [NameInMap("BuyResAmount")]
                [Validation(Required=false)]
                public int? BuyResAmount { get; set; }

                /// <summary>
                /// The cron expression for the scheduled task.
                /// </summary>
                [NameInMap("Cron")]
                [Validation(Required=false)]
                public string Cron { get; set; }

                /// <summary>
                /// The duration that is retained after the session is disconnected. Unit: milliseconds. Valid values: 180000 to 345600000. That is, the session can be retained for 3 to 5760 minutes (4 days). If you specify the value to 0, the session is permanently retained.
                /// 
                /// When a session is disconnected, take note of the following situations: If an end user does not resume the session within the specified duration, the session is closed and all unsaved data is cleared. If the end user resumes the session within the specified duration, the end user can still access data of the session.
                /// </summary>
                [NameInMap("KeepDuration")]
                [Validation(Required=false)]
                public long? KeepDuration { get; set; }

                /// <summary>
                /// The load balancing policy of the multi-session cloud computer pool.
                /// 
                /// Valid values:
                /// 
                /// *   0: depth-first
                /// *   1: breadth-first
                /// </summary>
                [NameInMap("LoadPolicy")]
                [Validation(Required=false)]
                public int? LoadPolicy { get; set; }

                /// <summary>
                /// The maximum number of cloud computers in the cloud computer pool. This parameter is one of the auto scaling parameters. Valid values: 0 to 200.
                /// </summary>
                [NameInMap("MaxResAmount")]
                [Validation(Required=false)]
                public int? MaxResAmount { get; set; }

                /// <summary>
                /// The minimum number of cloud computers in the cloud computer pool. This parameter is one of the auto scaling parameters. Valid values: 0 to 200.
                /// </summary>
                [NameInMap("MinResAmount")]
                [Validation(Required=false)]
                public int? MinResAmount { get; set; }

                /// <summary>
                /// The threshold for the ratio of connected sessions. This parameter is the condition that triggers auto scaling in a multi-session cloud computer pool. To calculate the ratio of connected sessions, use the following formula:
                /// 
                /// `Ratio of connected sessions = Number of connected sessions/(Total number of cloud computers × Maximum number of sessions allowed for each cloud computer) × 100%`
                /// 
                /// If the ratio of connected sessions is greater than the specified value, new cloud computers are created. If the ratio of connected sessions is smaller than the specified value, idle cloud computers are deleted.
                /// </summary>
                [NameInMap("RatioThreshold")]
                [Validation(Required=false)]
                public float? RatioThreshold { get; set; }

                /// <summary>
                /// The type of the scheduled task.
                /// 
                /// Valid values:
                /// 
                /// *   drop: decline policy
                /// *   normal: normal policy
                /// *   peak: peak hour policy
                /// *   rise: rise policy
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The payment status of the cloud computer pool.
            /// 
            /// Valid values:
            /// 
            /// *   0: unpaid
            /// *   1: paid
            /// *   2: overdue or expired
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The period of time before the idle cloud computer enters the Stopped state. If the specified value is reached, the cloud computer is automatically stopped. If an end user connects to the stopped cloud computer, the cloud computer automatically starts. Unit: milliseconds.
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
            /// The system disk capacity. Unit: GiB.
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
                /// The cron expression.
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
                /// The status of the cloud computer pool.
                /// 
                /// Valid values:
                /// 
                /// *   1: enabled
                /// *   2: disabled
                /// *   3: deleted
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The type of the scheduled task.
                /// 
                /// Valid values:
                /// 
                /// *   1: scheduled reset
                /// *   2: scheduled startup
                /// *   3: scheduled stop
                /// *   4: scheduled restart
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
            /// The version number of the cloud computer pool.
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
