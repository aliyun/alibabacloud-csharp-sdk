// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopGroupsResponseBody : TeaModel {
        /// <summary>
        /// Details of the desktop groups.
        /// </summary>
        [NameInMap("DesktopGroups")]
        [Validation(Required=false)]
        public List<DescribeDesktopGroupsResponseBodyDesktopGroups> DesktopGroups { get; set; }
        public class DescribeDesktopGroupsResponseBodyDesktopGroups : TeaModel {
            /// <summary>
            /// The number of sessions that are allowed for each cloud desktop in the multi-session desktop group.
            /// </summary>
            [NameInMap("BindAmount")]
            [Validation(Required=false)]
            public long? BindAmount { get; set; }

            /// <summary>
            /// The number of purchased cloud desktops. Valid values: 0 to 200.
            /// </summary>
            [NameInMap("BuyDesktopsCount")]
            [Validation(Required=false)]
            public int? BuyDesktopsCount { get; set; }

            /// <summary>
            /// The remarks of the desktop group.
            /// </summary>
            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// The maximum period of time during which the session is connected. When the specified maximum period of time is reached, the session is automatically disconnected. Unit: milliseconds. This parameter is required only for cloud desktops of the same desktop group.
            /// </summary>
            [NameInMap("ConnectDuration")]
            [Validation(Required=false)]
            public long? ConnectDuration { get; set; }

            [NameInMap("CountPerStatus")]
            [Validation(Required=false)]
            public List<DescribeDesktopGroupsResponseBodyDesktopGroupsCountPerStatus> CountPerStatus { get; set; }
            public class DescribeDesktopGroupsResponseBodyDesktopGroupsCountPerStatus : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

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
            /// The time when the desktop group was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to create the desktop group.
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// The category of the data disk.
            /// 
            /// Valid values:
            /// 
            /// *   cloud_efficiency
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     ultra disk
            /// 
            ///     <!-- -->
            /// 
            /// *   cloud_ssd
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     standard SSD
            /// 
            ///     <!-- -->
            /// 
            /// *   cloud_essd
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     ESSD
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// The size of the data disk. Unit: GiB.
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public int? DesktopCount { get; set; }

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

            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// The number of end users that are authorized to use the desktop group.
            /// </summary>
            [NameInMap("EndUserCount")]
            [Validation(Required=false)]
            public int? EndUserCount { get; set; }

            /// <summary>
            /// The time when the subscription cloud desktop expires.
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
            /// The maximum period of time during which the session is idle. When a session is idle, no inputs of keyboards or mouses are detected. When the specified maximum period of time is reached, the session is automatically disconnected. Unit: milliseconds. This parameter is required only for cloud desktops of the same desktop group.
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
            /// The retention period of the cloud desktop after the end user is disconnected from the cloud desktop. Unit: milliseconds.
            /// </summary>
            [NameInMap("KeepDuration")]
            [Validation(Required=false)]
            public long? KeepDuration { get; set; }

            /// <summary>
            /// The load balancing policy of the multi-session desktop group.
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
            /// </summary>
            [NameInMap("LoadPolicy")]
            [Validation(Required=false)]
            public long? LoadPolicy { get; set; }

            /// <summary>
            /// The maximum number of cloud desktops that the desktop group can contain.
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
            /// The minimum number of cloud desktops that the desktop group must contain.
            /// </summary>
            [NameInMap("MinDesktopsCount")]
            [Validation(Required=false)]
            public int? MinDesktopsCount { get; set; }

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
            /// The account type of the workspace. Possible values: -simple: convenience account type. -ad_connector: enterprise Active Directory (AD) account.
            /// 
            /// Valid values:
            /// 
            /// *   PERSONAL
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     personal account type
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   SIMPLE
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     convenience account type
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// 
            /// *   AD_CONNECTOR:
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     enterprise AD account type
            /// 
            ///     <!-- -->
            /// 
            /// *   RAM
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     Resource Access Management (RAM) account type
            /// 
            ///     <!-- -->
            /// 
            ///     .
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// The OS. Valid values:
            /// 
            /// *   Windows
            /// *   Linux
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

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
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public long? OwnType { get; set; }

            /// <summary>
            /// The billing method of the desktop group.
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
            /// The ID of the policy.
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// The name of the policy.
            /// </summary>
            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            /// <summary>
            /// The type of the protocol. Valid values:
            /// 
            /// *   ASP
            /// *   HDX
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The threshold for the ratio of connected sessions. This parameter is the condition that triggers auto scaling in a multi-session desktop group. `Ratio of connected sessions = Number of connected sessions/(Total number of cloud desktops × Maximum number of sessions allowed for each cloud desktop) × 100%`. When the specified threshold is reached, new cloud desktops are automatically created. When the specified threshold is not reached, idle cloud desktops are released.
            /// </summary>
            [NameInMap("RatioThreshold")]
            [Validation(Required=false)]
            public float? RatioThreshold { get; set; }

            /// <summary>
            /// Indicates which type of disk that is used by cloud desktops in the desktop group is reset.
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
            ///     No disks are reset.
            /// 
            ///     <!-- -->
            /// 
            /// *   1
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     Only the system disk is reset.
            /// 
            ///     <!-- -->
            /// 
            /// *   2
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     Only the data disk is reset.
            /// 
            ///     <!-- -->
            /// 
            /// *   3
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     Both the system disk and data disk are reset.
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ResetType")]
            [Validation(Required=false)]
            public long? ResetType { get; set; }

            /// <summary>
            /// The payment status of the desktop group.
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
            ///     unpaid
            /// 
            ///     <!-- -->
            /// 
            /// *   1
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     paid
            /// 
            ///     <!-- -->
            /// 
            /// *   2
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     overdue or expired
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The period of time before the idle cloud desktop enters the Stopped state. When the specified period of time is reached, the idle cloud desktop automatically enters the Stopped state. If an end user connects to a cloud desktop that is in the Stopped state, the cloud desktop automatically starts. Unit: milliseconds.
            /// </summary>
            [NameInMap("StopDuration")]
            [Validation(Required=false)]
            public long? StopDuration { get; set; }

            [NameInMap("SubnetId")]
            [Validation(Required=false)]
            public string SubnetId { get; set; }

            /// <summary>
            /// The category of the system disk.
            /// 
            /// Valid values:
            /// 
            /// *   cloud_efficiency
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     ultra disk
            /// 
            ///     <!-- -->
            /// 
            /// *   cloud_ssd
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     standard SSD
            /// 
            ///     <!-- -->
            /// 
            /// *   cloud_essd
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     ESSD
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// The size of the system disk. Unit: GiB.
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// The version number of the desktop group.
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
