// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeFirewallDropTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data list.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeFirewallDropTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeFirewallDropTrendResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The number of sessions blocked by the Internet firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InternetDropSession")]
            [Validation(Required=false)]
            public long? InternetDropSession { get; set; }

            /// <summary>
            /// <para>The number of sessions blocked by the NAT firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("NatDropSession")]
            [Validation(Required=false)]
            public long? NatDropSession { get; set; }

            /// <summary>
            /// <para>The time when the traffic occurred. The value is a UNIX timestamp in seconds.</para>
            /// <para>If the data at this point in time has not been processed, the values of other fields are -1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758474000</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <para>The total number of sessions blocked by the firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("TotalDropSession")]
            [Validation(Required=false)]
            public long? TotalDropSession { get; set; }

            /// <summary>
            /// <para>The number of sessions blocked by the VPC firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("VpcDropSession")]
            [Validation(Required=false)]
            public long? VpcDropSession { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of total blocked sessions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("MaxDropSession")]
        [Validation(Required=false)]
        public long? MaxDropSession { get; set; }

        /// <summary>
        /// <para>The time when the maximum number of total blocked sessions occurred. The value is a UNIX timestamp in seconds, such as 1672502400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656837360</para>
        /// </summary>
        [NameInMap("MaxDropTime")]
        [Validation(Required=false)]
        public long? MaxDropTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75E60025-43C5-5635-B7B7-272C5246****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
