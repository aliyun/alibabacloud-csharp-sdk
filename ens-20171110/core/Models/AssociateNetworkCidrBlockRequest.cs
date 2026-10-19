// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AssociateNetworkCidrBlockRequest : TeaModel {
        /// <summary>
        /// <para>The IP address version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPV4: IPv4 address.</description></item>
        /// <item><description>IPV6: IPv6 address.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPV6</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The ISP of the IPv6 CIDR block. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cmcc</description></item>
        /// <item><description>unicom</description></item>
        /// <item><description>telecom</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("Ipv6Isp")]
        [Validation(Required=false)]
        public string Ipv6Isp { get; set; }

        /// <summary>
        /// <para>The network ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-257gqcdfvx6n****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The secondary IPv4 CIDR block to be added. The CIDR block must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The CIDR block must be within the 10.0.0.0/8, 172.16.0.0/12, or 192.168.0.0/16 range.</description></item>
        /// <item><description>The secondary CIDR block must not overlap with the primary CIDR block or existing secondary CIDR blocks of the network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10.XX.XX.0/24</para>
        /// </summary>
        [NameInMap("SecondaryCidrBlock")]
        [Validation(Required=false)]
        public string SecondaryCidrBlock { get; set; }

    }

}
