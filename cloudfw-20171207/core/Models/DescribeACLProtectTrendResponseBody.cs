// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeACLProtectTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of internal requests that are blocked by the ACL feature.</para>
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
        /// <para>The interval for returning data. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The number of external requests that are blocked by the ACL feature.</para>
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
        /// <para>The total number of requests that are blocked by the ACL feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("TotalProtectCnt")]
        [Validation(Required=false)]
        public long? TotalProtectCnt { get; set; }

        /// <summary>
        /// <para>The statistics on the requests that are blocked by the ACL feature.</para>
        /// </summary>
        [NameInMap("TrendList")]
        [Validation(Required=false)]
        public List<DescribeACLProtectTrendResponseBodyTrendList> TrendList { get; set; }
        public class DescribeACLProtectTrendResponseBodyTrendList : TeaModel {
            /// <summary>
            /// <para>The number of requests that are blocked by ACL on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProtectCnt")]
            [Validation(Required=false)]
            public int? ProtectCnt { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp at midnight (00:00:00) of each day, which indicates the date of the current day. Unit: seconds.</para>
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
