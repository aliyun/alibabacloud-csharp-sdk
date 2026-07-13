// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAddrAttributeInfoRequest : TeaModel {
        /// <summary>
        /// <para>The list of addresses.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       &quot;1.1.XX.XX&quot;
        /// ]</para>
        /// </summary>
        [NameInMap("Addrs")]
        [Validation(Required=false)]
        public string Addrs { get; set; }

        /// <summary>
        /// <para>The language of some returned parameters. Default value: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The address type:</para>
        /// <list type="bullet">
        /// <item><description><para>IPV4: IPv4 address</para>
        /// </description></item>
        /// <item><description><para>IPV6: IPv6 address</para>
        /// </description></item>
        /// <item><description><para>DOMAIN: domain name</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPV4</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
