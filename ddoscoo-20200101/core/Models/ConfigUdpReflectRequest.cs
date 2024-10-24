// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigUdpReflectRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the filtering policy for UDP reflection attacks.</para>
        /// <para>The value is a string that consists of a JSON struct. The JSON struct contains the following field:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UdpSports</b>: the source ports of the UDP traffic that you want to block. This field is required and must be of the ARRAY type. Example: <c>[17,19]</c>.</para>
        /// <para>We recommend that you block the following source ports of UDP traffic:</para>
        /// <list type="bullet">
        /// <item><description>UDP 17: QOTD reflection attacks</description></item>
        /// <item><description>UDP 19: CharGEN reflection attacks</description></item>
        /// <item><description>UDP 69: TFTP reflection attacks</description></item>
        /// <item><description>UDP 111: Portmap reflection attacks</description></item>
        /// <item><description>UDP 123: NTP reflection attacks</description></item>
        /// <item><description>UDP 137: NetBIOS reflection attacks</description></item>
        /// <item><description>UDP 161: SNMPv2 reflection attacks</description></item>
        /// <item><description>UDP 389: CLDAP reflection attacks</description></item>
        /// <item><description>UDP 1194: OpenVPN reflection attacks</description></item>
        /// <item><description>UDP 1900: SSDP reflection attacks</description></item>
        /// <item><description>UDP 3389: RDP reflection attacks</description></item>
        /// <item><description>UDP 11211: memcached reflection attacks</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;UdpSports\&quot;:[17,19]}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/157459.html">DescribeInstanceIds</a> operation to query the IDs of all instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-i7m25564****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the Anti-DDoS Proxy instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: indicates an Anti-DDoS Proxy (Chinese Mainland) instance. This is the default value.</description></item>
        /// <item><description><b>ap-southeast-1</b>: indicates an Anti-DDoS Proxy (Outside Chinese Mainland) instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
