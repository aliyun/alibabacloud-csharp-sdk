// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeInstanceSpecsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceSpecs")]
        [Validation(Required=false)]
        public List<DescribeInstanceSpecsResponseBodyInstanceSpecs> InstanceSpecs { get; set; }
        public class DescribeInstanceSpecsResponseBodyInstanceSpecs : TeaModel {
            [NameInMap("PackConfig")]
            [Validation(Required=false)]
            public DescribeInstanceSpecsResponseBodyInstanceSpecsPackConfig PackConfig { get; set; }
            public class DescribeInstanceSpecsResponseBodyInstanceSpecsPackConfig : TeaModel {
                [NameInMap("PackBasicThre")]
                [Validation(Required=false)]
                public int? PackBasicThre { get; set; }
                [NameInMap("BindIpCount")]
                [Validation(Required=false)]
                public int? BindIpCount { get; set; }
                [NameInMap("PackAdvThre")]
                [Validation(Required=false)]
                public int? PackAdvThre { get; set; }
                [NameInMap("IpBasicThre")]
                [Validation(Required=false)]
                public int? IpBasicThre { get; set; }
                [NameInMap("IpAdvanceThre")]
                [Validation(Required=false)]
                public int? IpAdvanceThre { get; set; }
                [NameInMap("IpSpec")]
                [Validation(Required=false)]
                public int? IpSpec { get; set; }
            };

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("AvailableDeleteBlackholeCount")]
            [Validation(Required=false)]
            public string AvailableDeleteBlackholeCount { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}
