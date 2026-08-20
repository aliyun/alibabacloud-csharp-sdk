// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class AddZoneRecordRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. A client generates this value to ensure that it is unique among different requests. The value can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6447728c8578e66aacf062d2df4446dc</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: en</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The source of the DNS resolution request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>default: The default line. This is equivalent to a global line. Configure a default line to ensure that a DNS record is returned even if no smart line is hit.</para>
        /// </description></item>
        /// <item><description><para>Alibaba Cloud line: The DNS resolution request comes from Alibaba Cloud, including Public Cloud, Alibaba Finance Cloud, and Alibaba Gov Cloud.</para>
        /// </description></item>
        /// <item><description><para>Custom line: Customize internal domain name resolution to return a specific IP address for DNS query requests from a specific IP address segment.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Only zones in built-in authoritative acceleration regions support adding DNS resolution request source lines.</para>
        /// </description></item>
        /// <item><description><para>To use the default line, enter &quot;default&quot;. For Alibaba Cloud lines and custom lines, enter the specified line code. Example: aliyun_r_cn-beijing-a</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        /// <summary>
        /// <para>The priority of the MX record. A smaller value indicates a higher priority. Valid values: <b>[1, 99]</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The host record. A host record is the prefix of a domain name. Common host records include www, @, \* (for wildcard DNS), and mail (for mailboxes).</para>
        /// <para>For example, to resolve @.example.com, set the host record to &quot;@&quot;, not an empty string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>www</para>
        /// </summary>
        [NameInMap("Rr")]
        [Validation(Required=false)]
        public string Rr { get; set; }

        /// <summary>
        /// <para>The time to live (TTL). The unit is seconds (s). Valid values are 5, 30, 60, 3600 (1 hour), 43200 (12 hours), and 86400 (1 day). The default value is 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The type of the DNS record. The following types are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>A</b>: Maps a domain name to an IPv4 address in dotted decimal notation.</para>
        /// </description></item>
        /// <item><description><para><b>AAAA</b>: Maps a domain name to an IPv6 address.</para>
        /// </description></item>
        /// <item><description><para><b>CNAME</b>: Maps a domain name to another domain name.</para>
        /// </description></item>
        /// <item><description><para><b>TXT</b>: A text record. The text can be up to 255 characters in length. TXT records are often used for Sender Policy Framework (SPF) records to prevent spam.</para>
        /// </description></item>
        /// <item><description><para><b>MX</b>: Maps a domain name to the domain name of a mail server.</para>
        /// </description></item>
        /// <item><description><para><b>PTR</b>: Maps an IP address to a domain name.</para>
        /// </description></item>
        /// <item><description><para><b>SRV</b>: Specifies the server for a specific service. The format is: Priority Weight Port Target. Separate each value with a space.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Before adding a PTR record, configure a reverse lookup zone. For more information, see <a href="https://help.aliyun.com/document_detail/2592976.html">Reverse DNS lookups and PTR records</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The IP address of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.XX.XX</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The record value. Enter a value based on the DNS record type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114.55.XX.XX</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>The weight. Valid values are integers from 1 to 100. The default value is 1. Set different weights for each address to return addresses based on the weight ratio for DNS queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// <para>The ID of the zone. This is the unique identifier of the zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>df2d03865266bd9842306db586d3****</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
