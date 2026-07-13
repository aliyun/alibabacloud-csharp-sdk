// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDomainRecordRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
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
        /// <para>The resolution line. The default value is <b>default</b>.
        /// For more information, see
        /// &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/29807.html">Enumeration of resolution lines</a>.
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/doc-detail/29807.htm">Enumeration of resolution lines</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        /// <summary>
        /// <para>The priority of the MX record. Valid values: <c>[1, 50]</c>.</para>
        /// <para>This parameter is required if the record type is MX.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// <para>The host record.
        /// To resolve the root domain, such as example.com, set the host record to the at sign (@).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@</para>
        /// </summary>
        [NameInMap("RR")]
        [Validation(Required=false)]
        public string RR { get; set; }

        /// <summary>
        /// <para>The ID of the DNS record. To obtain the ID, call the <a href="https://help.aliyun.com/document_detail/2357159.html">DescribeDomainRecords</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99*******</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

        /// <summary>
        /// <para>The time to live (TTL). The default value is 600 seconds (10 minutes).
        /// For more information, see
        /// &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/29806.html">TTL definition</a>.
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/doc-detail/29806.htm">TTL definition</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("TTL")]
        [Validation(Required=false)]
        public long? TTL { get; set; }

        /// <summary>
        /// <para>The type of the DNS record. For more information, see
        /// &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/29805.html">DNS record types</a>.
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/en/doc-detail/29805.htm">DNS record types</a>.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>192.0.2.1</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
