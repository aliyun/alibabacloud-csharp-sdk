// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20171120.Models
{
    public class DescribePackResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PackInfo")]
        [Validation(Required=true)]
        public DescribePackResponsePackInfo PackInfo { get; set; }
        public class DescribePackResponsePackInfo : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=true)]
            public string Region { get; set; }
            [NameInMap("AvailableDeleteBlackholeCount")]
            [Validation(Required=true)]
            public int? AvailableDeleteBlackholeCount { get; set; }
            [NameInMap("IpList")]
            [Validation(Required=true)]
            public List<DescribePackResponsePackInfoIpList> IpList { get; set; }
            public class DescribePackResponsePackInfoIpList : TeaModel {
                public string Ip { get; set; }
            }
            [NameInMap("PackConfig")]
            [Validation(Required=true)]
            public DescribePackResponsePackInfoPackConfig PackConfig { get; set; }
            public class DescribePackResponsePackInfoPackConfig : TeaModel {
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

            }
        };

    }

}
