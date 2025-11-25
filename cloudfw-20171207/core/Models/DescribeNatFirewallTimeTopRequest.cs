// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallTimeTopRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ngw-uf62zzi7000bca7zn****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>total_max_bps</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.100.134.XXX</para>
        /// </summary>
        [NameInMap("SrcPrivateIP")]
        [Validation(Required=false)]
        public string SrcPrivateIP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>47.93.47.XXX</para>
        /// </summary>
        [NameInMap("SrcPublicIP")]
        [Validation(Required=false)]
        public string SrcPublicIP { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1749693960</para>
        /// </summary>
        [NameInMap("TrafficTime")]
        [Validation(Required=false)]
        public string TrafficTime { get; set; }

    }

}
