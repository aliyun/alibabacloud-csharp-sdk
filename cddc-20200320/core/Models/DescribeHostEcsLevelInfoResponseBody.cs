// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeHostEcsLevelInfoResponseBody : TeaModel {
        [NameInMap("HostEcsLevelInfos")]
        [Validation(Required=false)]
        public List<DescribeHostEcsLevelInfoResponseBodyHostEcsLevelInfos> HostEcsLevelInfos { get; set; }
        public class DescribeHostEcsLevelInfoResponseBodyHostEcsLevelInfos : TeaModel {
            [NameInMap("CddcHostType")]
            [Validation(Required=false)]
            public string CddcHostType { get; set; }

            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeHostEcsLevelInfoResponseBodyHostEcsLevelInfosItems> Items { get; set; }
            public class DescribeHostEcsLevelInfoResponseBodyHostEcsLevelInfosItems : TeaModel {
                [NameInMap("CloudStorageBandwidth")]
                [Validation(Required=false)]
                public float? CloudStorageBandwidth { get; set; }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("CpuFrequency")]
                [Validation(Required=false)]
                public string CpuFrequency { get; set; }

                [NameInMap("CpuVersion")]
                [Validation(Required=false)]
                public string CpuVersion { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EcsClass")]
                [Validation(Required=false)]
                public string EcsClass { get; set; }

                [NameInMap("EcsClassCode")]
                [Validation(Required=false)]
                public string EcsClassCode { get; set; }

                [NameInMap("IsCloudDisk")]
                [Validation(Required=false)]
                public int? IsCloudDisk { get; set; }

                [NameInMap("LocalStorage")]
                [Validation(Required=false)]
                public string LocalStorage { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                [NameInMap("NetBandWidth")]
                [Validation(Required=false)]
                public float? NetBandWidth { get; set; }

                [NameInMap("NetPackage")]
                [Validation(Required=false)]
                public int? NetPackage { get; set; }

                [NameInMap("RdsClassCode")]
                [Validation(Required=false)]
                public string RdsClassCode { get; set; }

                [NameInMap("StorageIops")]
                [Validation(Required=false)]
                public int? StorageIops { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
