// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipSegmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the contiguous EIP group.</para>
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
                /// <para>The time when the contiguous EIP group was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-03-06T12:30:07Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the contiguous EIP group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyEipSegment</para>
                /// </summary>
                [NameInMap("Descritpion")]
                [Validation(Required=false)]
                public string Descritpion { get; set; }

                /// <summary>
                /// <para>The ID of the contiguous EIP group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eipsg-2zett8ba055tbsxme****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The number of EIPs in the contiguous EIP group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("IpCount")]
                [Validation(Required=false)]
                public string IpCount { get; set; }

                /// <summary>
                /// <para>The name of the contiguous EIP group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyEipSegment</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the region to which the contiguous EIP group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The CIDR block and mask of the contiguous EIP group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>161.xx.xx.32/28</para>
                /// </summary>
                [NameInMap("Segment")]
                [Validation(Required=false)]
                public string Segment { get; set; }

                /// <summary>
                /// <para>The status of the contiguous EIP group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Allocating</b></description></item>
                /// <item><description><b>Allocated</b></description></item>
                /// <item><description><b>Releasing</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Allocated</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The zone of the contiguous EIP group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-a</para>
                /// </summary>
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7A6301A-64BA-41EC-8284-8F4838C15D1F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
