// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallTrafficTrendRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. This value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1739330580</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity for the query. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>60</b>: 1 minute.</para>
        /// </description></item>
        /// <item><description><para><b>1800</b>: 30 minutes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>The ID of the NAT Gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-xxxxxx</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The private source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.100.134.60</para>
        /// </summary>
        [NameInMap("SrcPrivateIP")]
        [Validation(Required=false)]
        public string SrcPrivateIP { get; set; }

        /// <summary>
        /// <para>The source IP address on the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.112.210.136</para>
        /// </summary>
        [NameInMap("SrcPublicIP")]
        [Validation(Required=false)]
        public string SrcPublicIP { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. This value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1739326980</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
