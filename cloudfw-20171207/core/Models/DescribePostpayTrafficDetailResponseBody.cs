// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayTrafficDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TrafficList")]
        [Validation(Required=false)]
        public List<DescribePostpayTrafficDetailResponseBodyTrafficList> TrafficList { get; set; }
        public class DescribePostpayTrafficDetailResponseBodyTrafficList : TeaModel {
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("TotalBytes")]
            [Validation(Required=false)]
            public long? TotalBytes { get; set; }

            [NameInMap("TrafficDay")]
            [Validation(Required=false)]
            public string TrafficDay { get; set; }

            [NameInMap("TrafficType")]
            [Validation(Required=false)]
            public string TrafficType { get; set; }

        }

    }

}
