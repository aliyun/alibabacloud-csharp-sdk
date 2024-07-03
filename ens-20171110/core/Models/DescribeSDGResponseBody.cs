// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSDGResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SDGs")]
        [Validation(Required=false)]
        public List<DescribeSDGResponseBodySDGs> SDGs { get; set; }
        public class DescribeSDGResponseBodySDGs : TeaModel {
            [NameInMap("AvaliableRegionIds")]
            [Validation(Required=false)]
            public List<DescribeSDGResponseBodySDGsAvaliableRegionIds> AvaliableRegionIds { get; set; }
            public class DescribeSDGResponseBodySDGsAvaliableRegionIds : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("CreationInstanceId")]
            [Validation(Required=false)]
            public string CreationInstanceId { get; set; }

            [NameInMap("CreationRegionId")]
            [Validation(Required=false)]
            public string CreationRegionId { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ParentSDGId")]
            [Validation(Required=false)]
            public string ParentSDGId { get; set; }

            [NameInMap("PreloadInfos")]
            [Validation(Required=false)]
            public List<DescribeSDGResponseBodySDGsPreloadInfos> PreloadInfos { get; set; }
            public class DescribeSDGResponseBodySDGsPreloadInfos : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("RedundantNum")]
                [Validation(Required=false)]
                public int? RedundantNum { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            [NameInMap("SDGId")]
            [Validation(Required=false)]
            public string SDGId { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
