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
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("LimitType")]
                [Validation(Required=false)]
                public string LimitType { get; set; }

                [NameInMap("MaxBandwidthAbs")]
                [Validation(Required=false)]
                public int? MaxBandwidthAbs { get; set; }

                [NameInMap("MaxBandwidthPercent")]
                [Validation(Required=false)]
                public int? MaxBandwidthPercent { get; set; }

                [NameInMap("MinBandwidthAbs")]
                [Validation(Required=false)]
                public int? MinBandwidthAbs { get; set; }

                [NameInMap("MinBandwidthPercent")]
                [Validation(Required=false)]
                public int? MinBandwidthPercent { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PercentSourceType")]
                [Validation(Required=false)]
                public string PercentSourceType { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("QosCarId")]
                [Validation(Required=false)]
                public string QosCarId { get; set; }

                [NameInMap("QosId")]
                [Validation(Required=false)]
                public string QosId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
