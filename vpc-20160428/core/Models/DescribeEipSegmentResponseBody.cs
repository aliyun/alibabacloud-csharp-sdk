// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipSegmentResponseBody : TeaModel {
        /// <summary>
        /// The details of the contiguous EIP group.
        /// </summary>
        [NameInMap("EipSegments")]
        [Validation(Required=false)]
        public DescribeEipSegmentResponseBodyEipSegments EipSegments { get; set; }
        public class DescribeEipSegmentResponseBodyEipSegments : TeaModel {
            [NameInMap("EipSegment")]
            [Validation(Required=false)]
            public List<DescribeEipSegmentResponseBodyEipSegmentsEipSegment> EipSegment { get; set; }
            public class DescribeEipSegmentResponseBodyEipSegmentsEipSegment : TeaModel {
                /// <summary>
                /// The time when the contiguous EIP group was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the contiguous EIP group.
                /// </summary>
                [NameInMap("Descritpion")]
                [Validation(Required=false)]
                public string Descritpion { get; set; }

                /// <summary>
                /// The ID of the contiguous EIP group.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The number of EIPs in the contiguous EIP group.
                /// </summary>
                [NameInMap("IpCount")]
                [Validation(Required=false)]
                public string IpCount { get; set; }

                /// <summary>
                /// The name of the contiguous EIP group.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the region to which the contiguous EIP group belongs.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The CIDR block and mask of the contiguous EIP group.
                /// </summary>
                [NameInMap("Segment")]
                [Validation(Required=false)]
                public string Segment { get; set; }

                /// <summary>
                /// The status of the contiguous EIP group. Valid values:
                /// 
                /// *   **Allocating**
                /// *   **Allocated**
                /// *   **Releasing**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The zone of the contiguous EIP group.
                /// </summary>
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
