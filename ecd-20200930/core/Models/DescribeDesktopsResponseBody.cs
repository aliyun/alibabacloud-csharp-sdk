// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopsResponseBody : TeaModel {
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopsResponseBodyDesktops> Desktops { get; set; }
        public class DescribeDesktopsResponseBodyDesktops : TeaModel {
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            [NameInMap("BundleName")]
            [Validation(Required=false)]
            public string BundleName { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsDisks> Disks { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsDisks : TeaModel {
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public int? DiskSize { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

            }

            [NameInMap("DowngradeQuota")]
            [Validation(Required=false)]
            public long? DowngradeQuota { get; set; }

            [NameInMap("DowngradedTimes")]
            [Validation(Required=false)]
            public long? DowngradedTimes { get; set; }

            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("FotaUpdate")]
            [Validation(Required=false)]
            public DescribeDesktopsResponseBodyDesktopsFotaUpdate FotaUpdate { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsFotaUpdate : TeaModel {
                [NameInMap("CurrentAppVersion")]
                [Validation(Required=false)]
                public string CurrentAppVersion { get; set; }
                [NameInMap("NewAppVersion")]
                [Validation(Required=false)]
                public string NewAppVersion { get; set; }
                [NameInMap("ReleaseNote")]
                [Validation(Required=false)]
                public string ReleaseNote { get; set; }
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }
            };

            [NameInMap("GpuCategory")]
            [Validation(Required=false)]
            public long? GpuCategory { get; set; }

            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

            [NameInMap("GpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ManagementFlag")]
            [Validation(Required=false)]
            public string ManagementFlag { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            [NameInMap("OfficeSiteVpcType")]
            [Validation(Required=false)]
            public string OfficeSiteVpcType { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsSessions> Sessions { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsSessions : TeaModel {
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                [NameInMap("EstablishmentTime")]
                [Validation(Required=false)]
                public string EstablishmentTime { get; set; }

                [NameInMap("ExternalUserName")]
                [Validation(Required=false)]
                public string ExternalUserName { get; set; }

            }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDesktopsResponseBodyDesktopsTags> Tags { get; set; }
            public class DescribeDesktopsResponseBodyDesktopsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

            [NameInMap("ZoneType")]
            [Validation(Required=false)]
            public string ZoneType { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
