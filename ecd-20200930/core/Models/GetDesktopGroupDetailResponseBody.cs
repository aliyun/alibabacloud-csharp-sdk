// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class GetDesktopGroupDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public List<GetDesktopGroupDetailResponseBodyDesktops> Desktops { get; set; }
        public class GetDesktopGroupDetailResponseBodyDesktops : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("PolicyGroupName")]
            [Validation(Required=false)]
            public string PolicyGroupName { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("MaxDesktopsCount")]
            [Validation(Required=false)]
            public int? MaxDesktopsCount { get; set; }

            [NameInMap("AllowAutoSetup")]
            [Validation(Required=false)]
            public int? AllowAutoSetup { get; set; }

            [NameInMap("ResType")]
            [Validation(Required=false)]
            public int? ResType { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            [NameInMap("OwnBundleId")]
            [Validation(Required=false)]
            public string OwnBundleId { get; set; }

            [NameInMap("GpuCount")]
            [Validation(Required=false)]
            public float? GpuCount { get; set; }

            [NameInMap("AllowBufferCount")]
            [Validation(Required=false)]
            public int? AllowBufferCount { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            [NameInMap("OwnBundleName")]
            [Validation(Required=false)]
            public string OwnBundleName { get; set; }

            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            [NameInMap("DesktopGroupName")]
            [Validation(Required=false)]
            public string DesktopGroupName { get; set; }

            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("KeepDuration")]
            [Validation(Required=false)]
            public long? KeepDuration { get; set; }

            [NameInMap("MinDesktopsCount")]
            [Validation(Required=false)]
            public int? MinDesktopsCount { get; set; }

            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public string DataDiskSize { get; set; }

            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("Comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

        }

    }

}
