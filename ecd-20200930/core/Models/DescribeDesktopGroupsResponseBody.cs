// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopGroupsResponseBody : TeaModel {
        /// <summary>
        /// The cloud computer pools.
        /// </summary>
        [NameInMap("DesktopGroups")]
        [Validation(Required=false)]
        public List<DescribeDesktopGroupsResponseBodyDesktopGroups> DesktopGroups { get; set; }
        public class DescribeDesktopGroupsResponseBodyDesktopGroups : TeaModel {
            /// <summary>
            /// The number of concurrent sessions that is allowed for each cloud computer pool in a multi-session cloud computer pool.
            /// </summary>
            [NameInMap("BindAmount")]
            [Validation(Required=false)]
            public long? BindAmount { get; set; }

            /// <summary>
            /// *   This parameter has different meanings based on the billing method of the cloud computer pool. For a subscription pool, this parameter specifies the number of cloud computers to purchase in the pool. Valid values: 0 to 200.
            /// *   For a pay-as-you-go pool, this parameter specifies the minimum number of cloud computers to create in the pool. Valid values: 0 to `MaxDesktopsCount`. Default value: 1.
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
            /// The maximum period of time during which a session is connected. When the specified maximum period of time is reached, the session is automatically disconnected. Unit: milliseconds.
            /// </summary>
            [NameInMap("ConnectDuration")]
            [Validation(Required=false)]
            public long? ConnectDuration { get; set; }

            /// <summary>
            /// The number of cloud computers in each state.
            /// </summary>
            [NameInMap("CountPerStatus")]
            [Validation(Required=false)]
            public List<DescribeDesktopGroupsResponseBodyDesktopGroupsCountPerStatus> CountPerStatus { get; set; }
            public class DescribeDesktopGroupsResponseBodyDesktopGroupsCountPerStatus : TeaModel {
                /// <summary>
                /// The total number of cloud computers.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The status of the cloud computer.
                /// 
                /// Valid values:
                /// 
                /// *   Stopped
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   Starting
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   Rebuilding
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   Running
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   Stopping
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   Expired
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   Deleted
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   Pending
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The number of vCPUs.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// The time when the cloud computer pool was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The Alibaba Cloud account that creates the cloud computer pool.
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// The category of the user disk.
            /// 
            /// Valid values:
            /// 
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: standard SSD
            /// *   cloud_essd: enhanced SSD (ESSD)
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
            /// The number of cloud computers that are created.
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public int? DesktopCount { get; set; }

            /// <summary>
            /// The ID of the cloud computer pool.
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// The name of the cloud computer pool.
            /// </summary>
            [NameInMap("DesktopGroupName")]
            [Validation(Required=false)]
            public string DesktopGroupName { get; set; }

            /// <summary>
            /// The cloud computer type. You can call the [DescribeDesktopTypes](~~188882~~) operation to query the IDs of the cloud computer types supported by WUYING Workspace.
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// The number of users that are granted permissions to use the cloud computer pool.
            /// </summary>
            [NameInMap("EndUserCount")]
            [Validation(Required=false)]
            public int? EndUserCount { get; set; }

            /// <summary>
            /// The time when the subscription cloud computer pool expires.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The number of GPUs.
            /// </summary>
            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

            /// <summary>
            /// The version of the GPU driver.
            /// </summary>
            [NameInMap("GpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

            /// <summary>
            /// The GPU memory.
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// The period of time after which a session is closed. After an end user connects to a cloud computer, the session is established. If the system does not detect inputs from the keyboard or mouse within the specified period of time, the session is closed. Unit: milliseconds.
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
            /// The keep-alive duration of a session after the session is disconnected. Valid values: 180000 (3 minutes) to 345600000 (4 days). Unit: milliseconds. If you set this parameter to 0, the session is permanently retained after it is disconnected.
            /// 
            /// When a session is disconnected, take note of the following situations: If an end user does not resume the session within the specified duration, the session is closed and all unsaved data is cleared. If the end user resumes the session within the specified duration, the end user can continue to access data of the session.
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
            public long? LoadPolicy { get; set; }

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
            /// The name of the office network in which the cloud computer pool resides.
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// The ID of the office network to which the cloud computer pool belongs.
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// The account type of the office network.
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
            /// The OS.
            /// 
            /// Valid values:
            /// 
            /// *   Linux
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Windows
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

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
            public long? OwnType { get; set; }

            /// <summary>
            /// The billing method of the cloud computer pool.
            /// 
            /// Valid values:
            /// 
            /// *   PostPaid: pay-as-you-go
            /// *   PrePaid: subscription
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
            /// The name of the policy that is associated with the cloud computer pool.
            /// </summary>
            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            /// <summary>
            /// The protocol type.
            /// 
            /// Valid values:
            /// 
            /// *   HDX
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   ASP
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The threshold for the ratio of connected sessions. This parameter indicates the condition that triggers auto scaling in a multi-session cloud computer pool. The ratio of connected sessions is calculated by using the following formula:
            /// 
            /// `Ratio of connected sessions = Number of connected sessions/(Total number of cloud computers × Maximum number of sessions allowed for each cloud computer) × 100%`.
            /// 
            /// When the specified threshold is reached, new cloud computers are automatically created. When the specified threshold is not reached, idle cloud computers are released.
            /// </summary>
            [NameInMap("RatioThreshold")]
            [Validation(Required=false)]
            public float? RatioThreshold { get; set; }

            /// <summary>
            /// The disk reset type of the cloud computer pool.
            /// 
            /// Valid values:
            /// 
            /// *   0: does not reset disks
            /// *   1: resets only the system disks
            /// *   2: resets only the user disks
            /// *   3: resets the system disks and user disks
            /// </summary>
            [NameInMap("ResetType")]
            [Validation(Required=false)]
            public long? ResetType { get; set; }

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
            /// The period of time after which an idle cloud computer is stopped. When the specified period of time is reached, the cloud computer is automatically stopped. If an end user connects to the stopped cloud computer, the cloud computer is automatically started. Unit: milliseconds.
            /// </summary>
            [NameInMap("StopDuration")]
            [Validation(Required=false)]
            public long? StopDuration { get; set; }

            /// <summary>
            /// The ID of the subnet.
            /// </summary>
            [NameInMap("SubnetId")]
            [Validation(Required=false)]
            public string SubnetId { get; set; }

            /// <summary>
            /// The category of the system disk.
            /// 
            /// Valid values:
            /// 
            /// *   cloud_efficiency: ultra disk
            /// *   cloud_ssd: standard SSD
            /// *   cloud_essd: enhanced SSD (ESSD)
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
            /// The version number of the cloud computer pool.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            /// <summary>
            /// Indicates whether disk encryption is enabled.
            /// </summary>
            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// The ID of the Key Management Service (KMS) key for disk encryption.
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
