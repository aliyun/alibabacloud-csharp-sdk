// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigUdpReflectRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the UDP reflection attack attack prevention protection policy to add.</para>
        /// <para>This parameter is a string that represents a JSON structure transformed into a character string. The JSON structure contains the following field:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UdpSports</b>: Array type. Required. The UDP reflection source ports to block. Example: <c>[17,19]</c>.</para>
        /// <para>  Block the following source ports that are commonly used in UDP reflection attacks:</para>
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
        /// <item><description>UDP 11211: Memcached reflection attacks</description></item>
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
        /// <para>The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance to manage.</para>
        /// <remarks>
        /// <para>You can invoke <a href="https://help.aliyun.com/document_detail/157459.html">DescribeInstanceIds</a> to query the IDs of all Anti-DDoS Pro or Anti-DDoS Premium instances.</para>
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
        /// <para>The region ID of the Anti-DDoS Pro or Anti-DDoS Premium instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b> (default): the Chinese mainland, which indicates an Anti-DDoS Pro instance.</description></item>
        /// <item><description><b>ap-southeast-1</b>: outside the Chinese mainland, which indicates an Anti-DDoS Premium instance.</description></item>
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
