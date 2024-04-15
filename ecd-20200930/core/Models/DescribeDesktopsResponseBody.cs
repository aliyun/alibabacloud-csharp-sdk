// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopsResponseBody : TeaModel {
        /// <summary>
        /// The details about the cloud desktops.
        /// </summary>
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopsResponseBodyDesktops> Desktops { get; set; }
        public class DescribeDesktopsResponseBodyDesktops : TeaModel {
            /// <summary>
            /// The number of sessions that are allowed for each cloud desktop in the multi-session desktop group.
            /// </summary>
            [NameInMap("BindAmount")]
            [Validation(Required=false)]
            public int? BindAmount { get; set; }

            /// <summary>
            /// The ID of the desktop template that is used to create the cloud desktop.
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// The name of the desktop template that is used to create the cloud desktop.
            /// </summary>
            [NameInMap("BundleName")]
            [Validation(Required=false)]
            public string BundleName { get; set; }

            /// <summary>
            /// The billing method of the cloud desktop.
            /// 
            /// Default value: PostPaid. Valid values:
            /// 
            /// *   Postpaid: pay-as-you-go
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   PrePaid: subscription
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The connection status of the end user.
            /// 
            /// Valid values:
            /// 
            /// *   Unknown
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Connected
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Disconnected
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// The number of vCPUs.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// The time when the cloud desktop was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            /// <summary>
            /// The ID of the desktop group to which the cloud desktop belongs. Default value: null.
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// The cloud desktop ID.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The cloud desktop name.
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// The status of the cloud desktop.
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// The type of the cloud desktop.
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// The directory ID. The value of this parameter is the same as the workspace ID that is indicated by the OfficeSiteId parameter.
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// Details of the disks.
            /// </summary>
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsDisks> Disks { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsDisks : TeaModel {
                /// <summary>
                /// The disk ID.
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// The disk size. Unit: GiB.
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                /// <summary>
                /// The type of the disk.
                /// 
                /// Valid values:
                /// 
                /// *   SYSTEM: system disk
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                /// *   DATA: data disk
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// 
                ///     <!-- -->
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// The performance level (PL) of the disk when an enhanced SSD (ESSD) is used. Valid values:
                /// 
                /// *   PL0
                /// *   PL1
                /// *   PL2
                /// *   PL3
                /// 
                /// For more information about the differences among ESSDs at different PLs, see [Enhanced SSDs](~~122389~~).
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

            }

            /// <summary>
            /// The number of times for which the cloud desktop can be downgraded.
            /// </summary>
            [NameInMap("DowngradeQuota")]
            [Validation(Required=false)]
            public long? DowngradeQuota { get; set; }

            /// <summary>
            /// The number of times for which the cloud desktop has been downgraded.
            /// </summary>
            [NameInMap("DowngradedTimes")]
            [Validation(Required=false)]
            public long? DowngradedTimes { get; set; }

            /// <summary>
            /// The IDs of the end users who are authorized to connect to the cloud desktop.
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// The time when the subscription cloud desktop expires.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The information about the image version that the cloud desktop uses.
            /// </summary>
            [NameInMap("FotaUpdate")]
            [Validation(Required=false)]
            public DescribeDesktopsResponseBodyDesktopsFotaUpdate FotaUpdate { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsFotaUpdate : TeaModel {
                /// <summary>
                /// The current image version of the cloud desktop.
                /// </summary>
                [NameInMap("CurrentAppVersion")]
                [Validation(Required=false)]
                public string CurrentAppVersion { get; set; }

                /// <summary>
                /// The image version to which the cloud desktop can be updated.
                /// </summary>
                [NameInMap("NewAppVersion")]
                [Validation(Required=false)]
                public string NewAppVersion { get; set; }

                /// <summary>
                /// The description of the image version to which the cloud desktop can be updated.
                /// </summary>
                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }

                /// <summary>
                /// The English description of the image version to which the cloud desktop can be updated.
                /// </summary>
                [NameInMap("ReleaseNoteEn")]
                [Validation(Required=false)]
                public string ReleaseNoteEn { get; set; }

                /// <summary>
                /// The Japanese description of the image version to which the cloud desktop can be updated.
                /// </summary>
                [NameInMap("ReleaseNoteJp")]
                [Validation(Required=false)]
                public string ReleaseNoteJp { get; set; }

                /// <summary>
                /// The size of the installation package for the image to which the cloud desktop can be updated. Unit: KB.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            /// <summary>
            /// Indicates whether the cloud desktop is a GPU-accelerated desktop.
            /// </summary>
            [NameInMap("GpuCategory")]
            [Validation(Required=false)]
            public long? GpuCategory { get; set; }

            /// <summary>
            /// The number of GPU cores.
            /// </summary>
            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

            /// <summary>
            /// The version number of the GPU driver of the cloud desktop.
            /// </summary>
            [NameInMap("GpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

            /// <summary>
            /// The GPU Specifications.
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("HibernationBeta")]
            [Validation(Required=false)]
            public bool? HibernationBeta { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("HibernationOptionsConfigured")]
            [Validation(Required=false)]
            public bool? HibernationOptionsConfigured { get; set; }

            /// <summary>
            /// The hostname of the cloud desktop.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The image ID.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The flag that is used to manage the cloud desktop.
            /// 
            /// Valid values:
            /// 
            /// *   Updating: The configurations of the cloud desktop are being updated.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NoFlag: No flags are available.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("ManagementFlag")]
            [Validation(Required=false)]
            public string ManagementFlag { get; set; }

            /// <summary>
            /// The flags that are used to manage the cloud desktops.
            /// </summary>
            [NameInMap("ManagementFlags")]
            [Validation(Required=false)]
            public List<string> ManagementFlags { get; set; }

            /// <summary>
            /// The memory size. Unit: MiB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// The ID of the secondary network interface controller (NIC) created by the RAM or Active Directory (AD) user in Elastic Desktop Service (EDS). You do not have permissions to modify this parameter.
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// The IP address of the secondary NIC that is created by the RAM or AD user in EDS.
            /// </summary>
            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            /// <summary>
            /// The workspace ID.
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// The workspace name.
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// The account type of the workspace.
            /// 
            /// Valid values:
            /// 
            /// *   SIMPLE: convenience account
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   AD_CONNECTOR: enterprise AD account
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// The virtual private cloud (VPC) type of the workspace.
            /// 
            /// Valid values:
            /// 
            /// *   standard
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   customized
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   basic
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("OfficeSiteVpcType")]
            [Validation(Required=false)]
            public string OfficeSiteVpcType { get; set; }

            /// <summary>
            /// The OS that is defined in the desktop template.
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// The information about the OS platform. Valid values:
            /// 
            /// *   CentOS
            /// *   Ubuntu
            /// *   Windows Server 2016
            /// *   Windows Server 2019
            /// *   UOS
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// The policy ID.
            /// </summary>
            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            /// <summary>
            /// The policy IDs.
            /// </summary>
            [NameInMap("PolicyGroupIdList")]
            [Validation(Required=false)]
            public List<string> PolicyGroupIdList { get; set; }

            /// <summary>
            /// The policy name.
            /// </summary>
            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            /// <summary>
            /// The policy names.
            /// </summary>
            [NameInMap("PolicyGroupNameList")]
            [Validation(Required=false)]
            public List<string> PolicyGroupNameList { get; set; }

            /// <summary>
            /// The progress when the cloud desktop was created.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The protocol.
            /// 
            /// Valid values:
            /// 
            /// *   HDX: High-definition Experience (HDX) protocol
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   ASP: Adaptive Streaming Protocol (ASP) developed by Alibaba Cloud
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
            /// The type of the session.
            /// 
            /// Valid values:
            /// 
            /// *   SINGLE_SESSION
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   MULTIPLE_SESSION
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// The information about the desktop sessions of end users.
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsSessions> Sessions { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsSessions : TeaModel {
                /// <summary>
                /// The ID of the end user who logged on to the cloud desktop.
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// The time when the desktop session was established.
                /// </summary>
                [NameInMap("EstablishmentTime")]
                [Validation(Required=false)]
                public string EstablishmentTime { get; set; }

                /// <summary>
                /// The name of the external user.
                /// </summary>
                [NameInMap("ExternalUserName")]
                [Validation(Required=false)]
                public string ExternalUserName { get; set; }

            }

            /// <summary>
            /// The ID of the snapshot policy.
            /// </summary>
            [NameInMap("SnapshotPolicyId")]
            [Validation(Required=false)]
            public string SnapshotPolicyId { get; set; }

            /// <summary>
            /// The name of the snapshot policy.
            /// </summary>
            [NameInMap("SnapshotPolicyName")]
            [Validation(Required=false)]
            public string SnapshotPolicyName { get; set; }

            /// <summary>
            /// The time when the cloud desktop was first started.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// Indicates whether the cloud desktop supports hibernation.
            /// </summary>
            [NameInMap("SupportHibernation")]
            [Validation(Required=false)]
            public bool? SupportHibernation { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// >  This parameter is in invitational preview and is not publicly available.
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// Details about the tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsTags> Tags { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// Indicates whether disk encryption is enabled.
            /// </summary>
            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// The ID of the Key Management Service (KMS) key that is used when disk encryption is enabled. You can call the [ListKeys](~~28951~~) operation to query the list of KMS keys.
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

            /// <summary>
            /// The zone type. Default value: **AvailabilityZone**. This value indicates Alibaba Cloud zones.
            /// </summary>
            [NameInMap("ZoneType")]
            [Validation(Required=false)]
            public string ZoneType { get; set; }

        }

        /// <summary>
        /// The token that is used for the next query. If this parameter is left empty, all results are returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of cloud desktops.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
