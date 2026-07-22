// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetRiskListRequest : TeaModel {
        /// <summary>
        /// <para>The list of IP addresses to query. Separate multiple IP addresses with commas (,). You can query up to 20 IP addresses at a time. This parameter is required in practice. If you do not specify this parameter, the API returns a 400 error.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>IPv4 example: 47.97.XX.XX.</description></item>
        /// <item><description>IPv6 example: 2001:db8:ffff:ffff:ffff:XXXX:ffff.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("IpAddrList")]
        [Validation(Required=false)]
        public List<string> IpAddrList { get; set; }

        /// <summary>
        /// <para>The IP version of the assets protected by Cloud Firewall.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b> (default): IPv4</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: IPv6</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
