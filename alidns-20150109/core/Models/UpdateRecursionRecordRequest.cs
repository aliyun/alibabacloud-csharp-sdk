// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateRecursionRecordRequest : TeaModel {
        /// <summary>
        /// <para>A client token that ensures the idempotence of a request. Generate a unique value for this parameter on your client. The value can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21079fa016944979537637959d09bc</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The priority of the MX record. A smaller value indicates a higher priority. The value can be an integer from 1 to 99.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the DNS record.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9*******</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

        /// <summary>
        /// <para>The resolution line. The default value is <b>default</b>. For more information, see:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para><a href="https://help.aliyun.com/document_detail/29807.html">Lines</a></para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para><a href="https://www.alibabacloud.com/help/en/doc-detail/29807.htm">Lines</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>WebSDK</para>
        /// </summary>
        [NameInMap("RequestSource")]
        [Validation(Required=false)]
        public string RequestSource { get; set; }

        /// <summary>
        /// <para>The host record. This is the prefix of a domain name. Common prefixes are www, @, \* for wildcard DNS, and mail for mailboxes.</para>
        /// <para>For example, to resolve @.example.com, set the host record to &quot;@&quot;. Do not leave it empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Rr")]
        [Validation(Required=false)]
        public string Rr { get; set; }

        /// <summary>
        /// <para>The Time to Live (TTL) in seconds. Only the following values are supported: 5, 30, 60, 3600 (1 hour), 43200 (12 hours), and 86400 (24 hours). The default value is 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The type of the DNS record. The following types are supported: A: An IPv4 record that maps a domain name to an IPv4 address. AAAA: An IPv6 record that maps a domain name to an IPv6 address. CNAME: An alias record that points a domain name to another domain name. MX: A mail exchanger record that points a domain name to a mail server address. TXT: A text record that contains arbitrary human-readable text. SRV: A service record that identifies a server for a specific service. This is common in directory management for Microsoft systems.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The record value. Enter a value that corresponds to the DNS record type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.XX.XX</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>The weight. An integer from 1 to 100, inclusive. The default value is 1. You can set different weights for each address. DNS queries return addresses in proportion to their weights.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
