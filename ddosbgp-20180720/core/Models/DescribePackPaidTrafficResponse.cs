// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribePackPaidTrafficResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PackPaidTraffics")]
        [Validation(Required=true)]
        public List<DescribePackPaidTrafficResponsePackPaidTraffics> PackPaidTraffics { get; set; }
        public class DescribePackPaidTrafficResponsePackPaidTraffics : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=true)]
            public long? StartTime { get; set; }

            [NameInMap("BaseBandwidth")]
            [Validation(Required=true)]
            public int? BaseBandwidth { get; set; }

            [NameInMap("ElasticBandwidth")]
            [Validation(Required=true)]
            public int? ElasticBandwidth { get; set; }

            [NameInMap("PaidCapacity")]
            [Validation(Required=true)]
            public float? PaidCapacity { get; set; }

            [NameInMap("TotalCapacity")]
            [Validation(Required=true)]
            public float? TotalCapacity { get; set; }

            [NameInMap("MaxAttack")]
            [Validation(Required=true)]
            public float? MaxAttack { get; set; }

        }

    }

}
