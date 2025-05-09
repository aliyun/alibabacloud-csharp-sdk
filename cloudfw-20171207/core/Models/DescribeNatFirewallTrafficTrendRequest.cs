// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallTrafficTrendRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp that is accurate to seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1739330580</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The time interval between the data entries to return. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>60</b>: 1 minute</description></item>
        /// <item><description><b>1800</b>: 30 minutes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-xxxxxx</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The private IP address of the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.100.134.60</para>
        /// </summary>
        [NameInMap("SrcPrivateIP")]
        [Validation(Required=false)]
        public string SrcPrivateIP { get; set; }

        /// <summary>
        /// <para>The public IP address of the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.112.210.136</para>
        /// </summary>
        [NameInMap("SrcPublicIP")]
        [Validation(Required=false)]
        public string SrcPublicIP { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1739326980</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
