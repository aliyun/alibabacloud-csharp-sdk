// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateRecursionRecordWeightEnableStatusRequest : TeaModel {
        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of a request. The client generates the value of this parameter. The value must be unique for each request and can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21079fa016944979537637959d09bc</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the weight algorithm. Valid values: \<em>\<em>enable\</em>\</em> and \<em>\<em>disable\</em>\</em>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// <para>The DNS resolution line. The default value is <b>default</b>. For more information, see <a href="https://help.aliyun.com/document_detail/29807.html">DNS resolution lines</a>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para><a href="https://help.aliyun.com/document_detail/29807.html">Resolution Line Enumeration</a></para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para><a href="https://www.alibabacloud.com/help/zh/doc-detail/29807.htm">Enumeration of DNS record lines</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("RequestSource")]
        [Validation(Required=false)]
        public string RequestSource { get; set; }

        /// <summary>
        /// <para>The host record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>www</para>
        /// </summary>
        [NameInMap("Rr")]
        [Validation(Required=false)]
        public string Rr { get; set; }

        /// <summary>
        /// <para>The type of the DNS record. The following types are supported: \<em>\<em>A\</em>\</em>, which maps a domain name to an IPv4 address. \<em>\<em>AAAA\</em>\</em>, which maps a domain name to an IPv6 address. \<em>\<em>CNAME\</em>\</em>, an alias record that points a domain name to another domain name. \<em>\<em>MX\</em>\</em>, a mail exchanger record that points a domain name to a mail server address. \<em>\<em>TXT\</em>\</em>, an arbitrary, human-readable text DNS record. \<em>\<em>SRV\</em>\</em>, a service record that identifies a server that provides a specific service, commonly used for directory management in Microsoft systems.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The zone ID for the domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>176432424234</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
