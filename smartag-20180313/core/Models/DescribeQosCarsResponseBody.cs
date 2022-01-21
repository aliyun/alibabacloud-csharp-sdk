// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeQosCarsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("QosCars")]
        [Validation(Required=false)]
        public DescribeQosCarsResponseBodyQosCars QosCars { get; set; }
        public class DescribeQosCarsResponseBodyQosCars : TeaModel {
            [NameInMap("QosCar")]
            [Validation(Required=false)]
            public List<DescribeQosCarsResponseBodyQosCarsQosCar> QosCar { get; set; }
            public class DescribeQosCarsResponseBodyQosCarsQosCar : TeaModel {
                public string Description { get; set; }
                public string LimitType { get; set; }
                public int? MaxBandwidthAbs { get; set; }
                public int? MaxBandwidthPercent { get; set; }
                public int? MinBandwidthAbs { get; set; }
                public int? MinBandwidthPercent { get; set; }
                public string Name { get; set; }
                public string PercentSourceType { get; set; }
                public int? Priority { get; set; }
                public string QosCarId { get; set; }
                public string QosId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
