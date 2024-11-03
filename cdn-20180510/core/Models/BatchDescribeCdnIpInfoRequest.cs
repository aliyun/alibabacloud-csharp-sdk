// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class BatchDescribeCdnIpInfoRequest : TeaModel {
        /// <summary>
        /// <para>The list of IP addresses to query. Separate IP addresses with commas (,). You can specify up to 20 IP addresses at a time.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Example of an IPv4 address: 192.0.2.1</description></item>
        /// <item><description>Example of an IPv6 address: 2001:db8:ffff:ffff:ffff:\<em>\</em>\<em>\</em>:ffff.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111.XXX.XXX.230,47.XXX.XXX.243</para>
        /// </summary>
        [NameInMap("IpAddrList")]
        [Validation(Required=false)]
        public string IpAddrList { get; set; }

        /// <summary>
        /// <para>The language of the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Simplified Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
