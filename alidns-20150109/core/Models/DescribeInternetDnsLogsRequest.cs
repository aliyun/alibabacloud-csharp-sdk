// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeInternetDnsLogsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Public DNS configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51**4</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This is a UNIX timestamp in milliseconds.</para>
        /// <remarks>
        /// <para>Warning: If you specify a wide time range, many logs may be returned. This can cause a query timeout or inaccurate results.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1741526400000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The module type.</para>
        /// <list type="bullet">
        /// <item><description><para>AUTHORITY (default): public authoritative DNS</para>
        /// </description></item>
        /// <item><description><para>RECURSION: public recursive DNS</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AUTHORITY</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PreciseSort")]
        [Validation(Required=false)]
        public bool? PreciseSort { get; set; }

        /// <summary>
        /// <para>The query parameters.</para>
        /// <list type="bullet">
        /// <item><description><para>sourceIp: the source IP address</para>
        /// </description></item>
        /// <item><description><para>queryNameFuzzy: the domain name (fuzzy match)</para>
        /// </description></item>
        /// <item><description><para>queryType: the record type</para>
        /// </description></item>
        /// <item><description><para>value: the resolution result</para>
        /// </description></item>
        /// <item><description><para>status: the status</para>
        /// </description></item>
        /// <item><description><para>serverIp: the IP address of the resolution server</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sourceIp&quot;:&quot;59.82.XX.XX&quot;,&quot;queryType&quot;:&quot;A&quot;}</para>
        /// </summary>
        [NameInMap("QueryCondition")]
        [Validation(Required=false)]
        public string QueryCondition { get; set; }

        [NameInMap("RecursionProtocolType")]
        [Validation(Required=false)]
        public string RecursionProtocolType { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. This is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1738848000000</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

    }

}
