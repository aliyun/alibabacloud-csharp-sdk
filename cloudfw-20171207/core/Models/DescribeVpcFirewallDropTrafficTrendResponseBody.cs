// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallDropTrafficTrendResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallDropTrafficTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeVpcFirewallDropTrafficTrendResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("AclDrop")]
            [Validation(Required=false)]
            public long? AclDrop { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-08-25 12:00:00</para>
            /// </summary>
            [NameInMap("DataTime")]
            [Validation(Required=false)]
            public string DataTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DropSession")]
            [Validation(Required=false)]
            public long? DropSession { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("IpsDrop")]
            [Validation(Required=false)]
            public long? IpsDrop { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1659405600</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>153188</para>
            /// </summary>
            [NameInMap("TotalSession")]
            [Validation(Required=false)]
            public long? TotalSession { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DropSessionMax")]
        [Validation(Required=false)]
        public long? DropSessionMax { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C87C1797-02E6-5EEB-A943-4416207D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
