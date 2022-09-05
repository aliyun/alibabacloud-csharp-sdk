// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopGroupsResponseBody : TeaModel {
        [NameInMap("DesktopGroups")]
        [Validation(Required=false)]
        public List<DescribeDesktopGroupsResponseBodyDesktopGroups> DesktopGroups { get; set; }
        public class DescribeDesktopGroupsResponseBodyDesktopGroups : TeaModel {
            [NameInMap("BindAmount")]
            [Validation(Required=false)]
            public long? BindAmount { get; set; }

            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            [NameInMap("ConnectDuration")]
            [Validation(Required=false)]
            public long? ConnectDuration { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            [NameInMap("DesktopGroupName")]
            [Validation(Required=false)]
            public string DesktopGroupName { get; set; }

            [NameInMap("EndUserCount")]
            [Validation(Required=false)]
            public int? EndUserCount { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            [NameInMap("IdleDisconnectDuration")]
            [Validation(Required=false)]
            public long? IdleDisconnectDuration { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("KeepDuration")]
            [Validation(Required=false)]
            public long? KeepDuration { get; set; }

            [NameInMap("LoadPolicy")]
            [Validation(Required=false)]
            public long? LoadPolicy { get; set; }

            [NameInMap("MaxDesktopsCount")]
            [Validation(Required=false)]
            public int? MaxDesktopsCount { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            [NameInMap("MinDesktopsCount")]
            [Validation(Required=false)]
            public int? MinDesktopsCount { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            [NameInMap("OwnBundleId")]
            [Validation(Required=false)]
            public string OwnBundleId { get; set; }

            [NameInMap("OwnBundleName")]
            [Validation(Required=false)]
            public string OwnBundleName { get; set; }

            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public long? OwnType { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            [NameInMap("RatioThreshold")]
            [Validation(Required=false)]
            public float? RatioThreshold { get; set; }

            [NameInMap("ResetType")]
            [Validation(Required=false)]
            public long? ResetType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("StopDuration")]
            [Validation(Required=false)]
            public long? StopDuration { get; set; }

            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
