// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDomainRecordRequest : TeaModel {
        /// <summary>
        /// <para>The domain name. Call the <a href="https://www.alibabacloud.com/help/dns/api-alidns-2015-01-09-describedomains?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeDomains</a> operation to query the domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English
        /// The default value is <b>zh</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The DNS resolution line. The default value is <b>default</b>. For more information, see <a href="https://www.alibabacloud.com/help/doc-detail/29807.htm">DNS resolution lines</a>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para><a href="https://help.aliyun.com/document_detail/29807.html">Resolution line enumeration</a></para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para><a href="https://www.alibabacloud.com/help/zh/doc-detail/29807.htm">Resolution Line Enumeration</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        /// <summary>
        /// <para>The priority of the MX record. Valid values: <c>[1,50]</c>.</para>
        /// <para>This parameter is required if the record type is MX. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// <para>The host record.</para>
        /// <para>To resolve example.com, set the host record to &quot;@&quot; instead of leaving it empty.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>www</para>
        /// </summary>
        [NameInMap("RR")]
        [Validation(Required=false)]
        public string RR { get; set; }

        /// <summary>
        /// <para>The time to live (TTL) value of the Domain Name System (DNS) record. Default value: 600. Unit: seconds. For more information, see the following topic:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para><a href="https://help.aliyun.com/document_detail/29806.html">TTL overview</a></para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>The time to live (TTL) of the DNS record. The default value is 600 seconds. For more information, see <a href="https://www.alibabacloud.com/help/doc-detail/29806.htm">TTL</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("TTL")]
        [Validation(Required=false)]
        public long? TTL { get; set; }

        /// <summary>
        /// <para>The type of the DNS record. For more information, see</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para><a href="https://help.aliyun.com/document_detail/29805.html">DNS record type format</a></para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>The type of the DNS record. For more information, see <a href="https://www.alibabacloud.com/help/doc-detail/29805.htm">DNS record types</a>.</para>
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
        /// <para>192.0.2.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The record value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.1</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
