// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class UpdateZoneRecordRequest : TeaModel {
        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. The client generates the value, which must be unique among different requests. The token can contain a maximum of 64 ASCII characters.</para>
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
        /// <para>The DNS resolution line. The default value is default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        /// <summary>
        /// <para>The priority of the MX record. You can set different priorities for mail servers. Valid values: 1 to 99. A smaller value indicates a higher priority.</para>
        /// <remarks>
        /// <para>This parameter is required if the record type is MX.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the DNS record. To obtain the ID, call the DescribeZoneRecords operation to query a list of DNS records.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172223****</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>The host record. This is the prefix of a domain name. Common examples include www, @, \* (for wildcard DNS), and mail (for mailboxes).</para>
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
        /// <para>The time to live (TTL) in seconds (s). Valid values: 5, 30, 60, 3600 (1 hour), 43200 (12 hours), and 86400 (1 day).</para>
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
        /// <item><description><para><b>SRV</b>: A service record that specifies the server for a specific service. The format is: Priority Weight Port Target. Each part must be separated by a space.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Before adding a PTR record, configure a reverse lookup zone. For more information, see <a href="https://help.aliyun.com/document_detail/2592976.html">Reverse DNS lookup and PTR records</a></para>
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
        /// <para>The record value. Enter a value that corresponds to the record type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.16.XX.XX</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>The weight of the record. Valid values are integers from 1 to 100. The default value is 1. You can set different weights for records to return IP addresses in proportion to their weights.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
