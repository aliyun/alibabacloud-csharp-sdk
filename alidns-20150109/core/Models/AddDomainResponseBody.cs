// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDomainResponseBody : TeaModel {
        [NameInMap("DnsServers")]
        [Validation(Required=false)]
        public AddDomainResponseBodyDnsServers DnsServers { get; set; }
        public class AddDomainResponseBodyDnsServers : TeaModel {
            [NameInMap("DnsServer")]
            [Validation(Required=false)]
            public List<string> DnsServer { get; set; }

        }

        /// <summary>
        /// <para>The ID of the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx6615cf240c697f9f7e207xxxxxx</para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The ID of the domain name group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>defaultGroup</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the domain name group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyGroup</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The Punycode for the Chinese domain name. This parameter is returned only for Chinese domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xn--fsq270a.com</para>
        /// </summary>
        [NameInMap("PunyCode")]
        [Validation(Required=false)]
        public string PunyCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx508EF-00FD-xxx9-95A4-1E10BACxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
