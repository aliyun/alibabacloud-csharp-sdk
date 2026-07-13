// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddRecursionRecordRequest : TeaModel {
        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. Generate a unique value on your client. The token must be unique for each request. It can contain only ASCII characters and must not exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6447728c8578e66aacf062d2df4446dc</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The priority of the MX record. A smaller value indicates a higher priority. Valid values: 1 to 99.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The DNS resolution line. The default value is <b>default</b>. For more information, see:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para><a href="https://help.aliyun.com/document_detail/29807.html">DNS resolution lines</a></para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para><a href="https://www.alibabacloud.com/help/en/doc-detail/29807.htm">DNS resolution lines</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("RequestSource")]
        [Validation(Required=false)]
        public string RequestSource { get; set; }

        /// <summary>
        /// <para>The host record. The host record is the prefix of a domain name. Common examples include www, @, \* (for wildcard DNS), and mail (for mailboxes).</para>
        /// <para>For example, to resolve @.example.com, set the host record to &quot;@&quot;, not an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>www</para>
        /// </summary>
        [NameInMap("Rr")]
        [Validation(Required=false)]
        public string Rr { get; set; }

        /// <summary>
        /// <para>The time to live (TTL) in seconds. This is the duration for which the record is cached. Supported values: 5, 30, 60, 3600 (1 hour), 43200 (12 hours), and 86400 (24 hours). Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The type of the DNS record. The following record types are supported: A: An IPv4 record that maps a domain name to an IPv4 address. AAAA: An IPv6 record that maps a domain name to an IPv6 address. CNAME: A canonical name record that points a domain name to another domain name. MX: A mail exchanger record that points a domain name to a mail server address. TXT: A text record that contains any human-readable text. SRV: A service record that identifies a server that provides a specific service. This is common in directory management for Microsoft systems. NS: A name server record that delegates a subdomain to another DNS provider for resolution. CAA: A Certification Authority Authorization record that restricts which certification authorities (CAs) can issue certificates for a domain. URL: A URL record that points a domain name to an existing site. SVCB: A service binding record that is used for service discovery. It provides information about supported protocols and service parameters through a DNS record. HTTPS: A record type specific to HTTPS services. An HTTPS record can define secure HTTPS connection protocols and optimal service endpoint addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The client IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The record value. Enter a value that corresponds to the specified record type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>The weight of the record. Valid values are integers from 1 to 100. The default value is 1. Set different weights for each address. DNS queries then return addresses based on the specified weight ratio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// <para>The ID of the zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173671468000011</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
