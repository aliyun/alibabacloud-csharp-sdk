// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAddrAttributeInfoRequest : TeaModel {
        /// <summary>
        /// <para>The addresses.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1.1.1.1&quot;]</para>
        /// </summary>
        [NameInMap("Addrs")]
        [Validation(Required=false)]
        public string Addrs { get; set; }

        /// <summary>
        /// <para>The language of the values for specific response parameters. Default value: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The type of addresses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPV4: IPv4 address</description></item>
        /// <item><description>IPv6: IPv6 address</description></item>
        /// <item><description>DOMAIN: domain name</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
