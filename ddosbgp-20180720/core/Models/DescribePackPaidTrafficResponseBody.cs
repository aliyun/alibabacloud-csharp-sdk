// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribePackPaidTrafficResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PackPaidTraffics")]
        [Validation(Required=false)]
        public List<DescribePackPaidTrafficResponseBodyPackPaidTraffics> PackPaidTraffics { get; set; }
        public class DescribePackPaidTrafficResponseBodyPackPaidTraffics : TeaModel {
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("BaseBandwidth")]
            [Validation(Required=false)]
            public int? BaseBandwidth { get; set; }

            [NameInMap("ElasticBandwidth")]
            [Validation(Required=false)]
            public int? ElasticBandwidth { get; set; }

            [NameInMap("TotalCapacity")]
            [Validation(Required=false)]
            public float? TotalCapacity { get; set; }

            [NameInMap("MaxAttack")]
            [Validation(Required=false)]
            public float? MaxAttack { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("PaidCapacity")]
            [Validation(Required=false)]
            public float? PaidCapacity { get; set; }

        }

    }

}
