// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeACLProtectTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of inbound sessions blocked by access control policies for internet traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("InProtectCnt")]
        [Validation(Required=false)]
        public long? InProtectCnt { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InterVPCProtectCnt")]
        [Validation(Required=false)]
        public long? InterVPCProtectCnt { get; set; }

        /// <summary>
        /// <para>The interval between data points. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The number of outbound sessions blocked by access control policies for internet traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("OutProtectCnt")]
        [Validation(Required=false)]
        public long? OutProtectCnt { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9063AB86-6FFA-5B2D-A16D-697C966DECA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of sessions that trigger the alert action in access control policies in the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalAlertCnt")]
        [Validation(Required=false)]
        public long? TotalAlertCnt { get; set; }

        /// <summary>
        /// <para>The total number of sessions that are allowed by access control policies in the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalPassCnt")]
        [Validation(Required=false)]
        public long? TotalPassCnt { get; set; }

        /// <summary>
        /// <para>The total number of sessions blocked by access control policies for internet traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("TotalProtectCnt")]
        [Validation(Required=false)]
        public long? TotalProtectCnt { get; set; }

        /// <summary>
        /// <para>The trend of sessions blocked by access control policies for internet traffic.</para>
        /// </summary>
        [NameInMap("TrendList")]
        [Validation(Required=false)]
        public List<DescribeACLProtectTrendResponseBodyTrendList> TrendList { get; set; }
        public class DescribeACLProtectTrendResponseBodyTrendList : TeaModel {
            /// <summary>
            /// <para>The total number of sessions that trigger the alert action in access control policies at the specified point in time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AlertCnt")]
            [Validation(Required=false)]
            public int? AlertCnt { get; set; }

            /// <summary>
            /// <para>The total number of sessions that are allowed by access control policies at the specified point in time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PassCnt")]
            [Validation(Required=false)]
            public int? PassCnt { get; set; }

            /// <summary>
            /// <para>The number of sessions blocked by access control policies for internet traffic on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProtectCnt")]
            [Validation(Required=false)]
            public int? ProtectCnt { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates the start of the query time range. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1697299200</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

    }

}
