// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20171120.Models
{
    public class DescribePackListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PackList")]
        [Validation(Required=true)]
        public List<DescribePackListResponsePackList> PackList { get; set; }
        public class DescribePackListResponsePackList : TeaModel {
            [NameInMap("AvailableDeleteBlackholeCount")]
            [Validation(Required=true)]
            public int? AvailableDeleteBlackholeCount { get; set; }

            [NameInMap("Region")]
            [Validation(Required=true)]
            public string Region { get; set; }

            [NameInMap("PackId")]
            [Validation(Required=true)]
            public string PackId { get; set; }

            [NameInMap("PackConfig")]
            [Validation(Required=true)]
            public DescribePackListResponsePackListPackConfig PackConfig { get; set; }
            public class DescribePackListResponsePackListPackConfig : TeaModel {
                [NameInMap("PackAdvThre")]
                [Validation(Required=true)]
                public int? PackAdvThre { get; set; }
                [NameInMap("IpAdvanceThre")]
                [Validation(Required=true)]
                public int? IpAdvanceThre { get; set; }
                [NameInMap("IpBasicThre")]
                [Validation(Required=true)]
                public int? IpBasicThre { get; set; }
                [NameInMap("PackBasicThre")]
                [Validation(Required=true)]
                public int? PackBasicThre { get; set; }
                [NameInMap("IpSpec")]
                [Validation(Required=true)]
                public int? IpSpec { get; set; }
            };

        }

    }

}
