// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipSegmentResponseBody : TeaModel {
        [NameInMap("EipSegments")]
        [Validation(Required=false)]
        public DescribeEipSegmentResponseBodyEipSegments EipSegments { get; set; }
        public class DescribeEipSegmentResponseBodyEipSegments : TeaModel {
            [NameInMap("EipSegment")]
            [Validation(Required=false)]
            public List<DescribeEipSegmentResponseBodyEipSegmentsEipSegment> EipSegment { get; set; }
            public class DescribeEipSegmentResponseBodyEipSegmentsEipSegment : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Descritpion")]
                [Validation(Required=false)]
                public string Descritpion { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("IpCount")]
                [Validation(Required=false)]
                public string IpCount { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Segment")]
                [Validation(Required=false)]
                public string Segment { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
