// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("Desktops")]
        [Validation(Required=true)]
        public List<DescribeDesktopsResponseDesktops> Desktops { get; set; }
        public class DescribeDesktopsResponseDesktops : TeaModel {
            [NameInMap("DirectoryId")]
            [Validation(Required=true)]
            public string DirectoryId { get; set; }

            [NameInMap("DirectoryType")]
            [Validation(Required=true)]
            public string DirectoryType { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=true)]
            public string CreationTime { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=true)]
            public string DesktopId { get; set; }

            [NameInMap("BundleId")]
            [Validation(Required=true)]
            public string BundleId { get; set; }

            [NameInMap("DesktopStatus")]
            [Validation(Required=true)]
            public string DesktopStatus { get; set; }

            [NameInMap("DesktopName")]
            [Validation(Required=true)]
            public string DesktopName { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=true)]
            public string ImageId { get; set; }

            [NameInMap("DesktopType")]
            [Validation(Required=true)]
            public string DesktopType { get; set; }

            [NameInMap("SystemDiskCategory")]
            [Validation(Required=true)]
            public string SystemDiskCategory { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=true)]
            public int? SystemDiskSize { get; set; }

            [NameInMap("DataDiskCategory")]
            [Validation(Required=true)]
            public string DataDiskCategory { get; set; }

            [NameInMap("DataDiskSize")]
            [Validation(Required=true)]
            public string DataDiskSize { get; set; }

            [NameInMap("PolicyGroupId")]
            [Validation(Required=true)]
            public string PolicyGroupId { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=true)]
            public int? Cpu { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=true)]
            public long? Memory { get; set; }

            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=true)]
            public string NetworkInterfaceId { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=true)]
            public string ExpiredTime { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=true)]
            public string ChargeType { get; set; }

            [NameInMap("GpuCount")]
            [Validation(Required=true)]
            public float? GpuCount { get; set; }

            [NameInMap("GpuSpec")]
            [Validation(Required=true)]
            public string GpuSpec { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=true)]
            public string StartTime { get; set; }

            [NameInMap("ConnectionStatus")]
            [Validation(Required=true)]
            public string ConnectionStatus { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=true)]
            public string OsType { get; set; }

            [NameInMap("Disks")]
            [Validation(Required=true)]
            public List<DescribeDesktopsResponseDesktopsDisks> Disks { get; set; }
            public class DescribeDesktopsResponseDesktopsDisks : TeaModel {
                [NameInMap("DiskId")]
                [Validation(Required=true)]
                public string DiskId { get; set; }

                [NameInMap("DiskSize")]
                [Validation(Required=true)]
                public int? DiskSize { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=true)]
                public string DiskType { get; set; }

            }

            [NameInMap("Tags")]
            [Validation(Required=true)]
            public List<DescribeDesktopsResponseDesktopsTags> Tags { get; set; }
            public class DescribeDesktopsResponseDesktopsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=true)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=true)]
                public string Value { get; set; }

            }

            [NameInMap("Sessions")]
            [Validation(Required=true)]
            public List<DescribeDesktopsResponseDesktopsSessions> Sessions { get; set; }
            public class DescribeDesktopsResponseDesktopsSessions : TeaModel {
                [NameInMap("EndUserId")]
                [Validation(Required=true)]
                public string EndUserId { get; set; }

                [NameInMap("EstablishmentTime")]
                [Validation(Required=true)]
                public string EstablishmentTime { get; set; }

            }

            [NameInMap("EndUserIds")]
            [Validation(Required=true)]
            public List<string> EndUserIds { get; set; }

        }

    }

}
