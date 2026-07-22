// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallDropTrafficTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The data list on the overview page.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeNatFirewallDropTrafficTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeNatFirewallDropTrafficTrendResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The number of blocked sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DropSession")]
            [Validation(Required=false)]
            public long? DropSession { get; set; }

            /// <summary>
            /// <para>The data timestamp. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1659405600</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>153188</para>
            /// </summary>
            [NameInMap("TotalSession")]
            [Validation(Required=false)]
            public long? TotalSession { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of dropped sessions (peak value) within the corresponding period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62436</para>
        /// </summary>
        [NameInMap("DropSessionMax")]
        [Validation(Required=false)]
        public long? DropSessionMax { get; set; }

        /// <summary>
        /// <para>The period in which the maximum number of dropped sessions occurred. The value is a UNIX timestamp in seconds, which represents the number of seconds that have elapsed since January 1, 1970 (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1525662720</para>
        /// </summary>
        [NameInMap("DropSessionMaxTime")]
        [Validation(Required=false)]
        public string DropSessionMaxTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0F82705-CFC7-5F83-86C8-A063892F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
