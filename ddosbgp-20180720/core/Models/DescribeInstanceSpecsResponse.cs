// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeInstanceSpecsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InstanceSpecs")]
        [Validation(Required=true)]
        public List<DescribeInstanceSpecsResponseInstanceSpecs> InstanceSpecs { get; set; }
        public class DescribeInstanceSpecsResponseInstanceSpecs : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=true)]
            public string Region { get; set; }

            [NameInMap("AvailableDeleteBlackholeCount")]
            [Validation(Required=true)]
            public string AvailableDeleteBlackholeCount { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("PackConfig")]
            [Validation(Required=true)]
            public DescribeInstanceSpecsResponseInstanceSpecsPackConfig PackConfig { get; set; }
            public class DescribeInstanceSpecsResponseInstanceSpecsPackConfig : TeaModel {
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
                [NameInMap("BindIpCount")]
                [Validation(Required=true)]
                public int? BindIpCount { get; set; }
            };

        }

    }

}
