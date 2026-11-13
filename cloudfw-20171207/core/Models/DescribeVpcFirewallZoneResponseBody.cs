// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallZoneResponseBody : TeaModel {
        /// <summary>
        /// <para>The deployment mode of the VPC firewall service. Valid values: <b>PrimaryStandby</b> (primary/secondary mode) and <b>MultiPrimary</b> (active-active mode).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrimaryStandby</para>
        /// </summary>
        [NameInMap("FirewallServiceMode")]
        [Validation(Required=false)]
        public string FirewallServiceMode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>337A4DBA-8A01-5E9C-99CA-84293E13****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of zones.</para>
        /// </summary>
        [NameInMap("ZoneList")]
        [Validation(Required=false)]
        public List<List<DescribeVpcFirewallZoneResponseBodyZoneList>> ZoneList { get; set; }
        public class DescribeVpcFirewallZoneResponseBodyZoneList : TeaModel {
            /// <summary>
            /// <para>The zone name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou Zone C</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-c</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
