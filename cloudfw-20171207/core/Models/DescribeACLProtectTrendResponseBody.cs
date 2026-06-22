// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeACLProtectTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of inbound interceptions by Internet access control.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("InProtectCnt")]
        [Validation(Required=false)]
        public long? InProtectCnt { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InterVPCProtectCnt")]
        [Validation(Required=false)]
        [Obsolete]
        public long? InterVPCProtectCnt { get; set; }

        /// <summary>
        /// <para>The interval at which data is returned. Unit: seconds. A result is returned at each interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The number of outbound interceptions by Internet access control.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("OutProtectCnt")]
        [Validation(Required=false)]
        public long? OutProtectCnt { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9063AB86-6FFA-5B2D-A16D-697C966DECA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The cumulative total of AlertCnt across all time points within the query time range. This value indicates the total number of sessions that matched an ACL policy and triggered the monitor (alert) action during the entire time period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalAlertCnt")]
        [Validation(Required=false)]
        public long? TotalAlertCnt { get; set; }

        /// <summary>
        /// <para>The cumulative total of PassCnt across all time points within the query time range. This value indicates the total number of sessions that matched an ACL policy and were allowed during the entire time period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalPassCnt")]
        [Validation(Required=false)]
        public long? TotalPassCnt { get; set; }

        /// <summary>
        /// <para>The total number of Internet access control interceptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("TotalProtectCnt")]
        [Validation(Required=false)]
        public long? TotalProtectCnt { get; set; }

        /// <summary>
        /// <para>The list of Internet access control intercept trend data.</para>
        /// </summary>
        [NameInMap("TrendList")]
        [Validation(Required=false)]
        public List<DescribeACLProtectTrendResponseBodyTrendList> TrendList { get; set; }
        public class DescribeACLProtectTrendResponseBodyTrendList : TeaModel {
            /// <summary>
            /// <para>The total number of sessions that matched an ACL policy and triggered the monitor (alert) action at this point in time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AlertCnt")]
            [Validation(Required=false)]
            public int? AlertCnt { get; set; }

            /// <summary>
            /// <para>The total number of sessions that matched an ACL policy and were allowed at this point in time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PassCnt")]
            [Validation(Required=false)]
            public int? PassCnt { get; set; }

            /// <summary>
            /// <para>The number of Internet access control interceptions on the day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProtectCnt")]
            [Validation(Required=false)]
            public int? ProtectCnt { get; set; }

            /// <summary>
            /// <para>The timestamp of 00:00 on each day. Unit: seconds. Indicates the date.</para>
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
