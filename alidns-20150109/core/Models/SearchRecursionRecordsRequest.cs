// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchRecursionRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The sort order. Valid values: asc for ascending and dsc for descending.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The status of the DNS record. Valid values: enable and <b>disable</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4698691</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sorting method. Valid values: rr, type, value, requestSource, weight, ttl, and enableStatus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rr</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The current page number. The value starts from 1. The default value is 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. The maximum value is 100. The default value is 20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The DNS resolution line. The default value is <b>default</b>. For more information, see <a href="https://www.alibabacloud.com/help/en/doc-detail/29807.htm">DNS resolution lines</a>.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para><a href="https://help.aliyun.com/document_detail/29807.html">DNS Line Enumeration</a></para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para><a href="https://www.alibabacloud.com/help/zh/doc-detail/29807.htm">Resolution Line Enumeration</a></para>
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
        /// <para>The time to live (TTL) in the local cache, in seconds. Valid values are 5, 30, 60, 3600 (1 hour), 43200 (12 hours), and 86400 (1 day). The default value is 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The type of the DNS record. The following types are supported:A: Maps a domain name to an IPv4 address.AAAA: Maps a domain name to an IPv6 address.CNAME: An alias record that points a domain name to another domain name.MX: A mail exchanger record that points a domain name to a mail server.TXT: A text record that contains arbitrary human-readable text.SRV: A service record that identifies a server for a specific service. This is common in directory management for Microsoft systems.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The record value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.XX.XX</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>The weight of the DNS record. The value ranges from 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// <para>The zone ID of the DNS record.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>169438909000011</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
