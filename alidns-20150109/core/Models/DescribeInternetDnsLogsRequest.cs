// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeInternetDnsLogsRequest : TeaModel {
        /// <summary>
        /// <para>The account ID displayed on the Recursive Resolution (Public DNS) page after you activate Alibaba Cloud Public DNS.</para>
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
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time of the query (timestamp, unit: milliseconds). &gt;Warning: If the query time span is too large and the amount of resolution logs for the queried domain is excessive, it may lead to a query timeout or inaccurate query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1709196299999</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>Return value language, options: </para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese </description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// <para>Default: en</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Module type </para>
        /// <list type="bullet">
        /// <item><description>AUTHORITY (default): Public Authoritative DNS </description></item>
        /// <item><description>RECURSION: Public Recursive DNS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AUTHORITY</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// <para>Page number, default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size for query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Query parameters </para>
        /// <list type="bullet">
        /// <item><description>sourceIp: Source IP address </description></item>
        /// <item><description>queryNameFuzzy: Domain name (fuzzy value) </description></item>
        /// <item><description>queryType: Record type </description></item>
        /// <item><description>value: Resolution result </description></item>
        /// <item><description>status: Status </description></item>
        /// <item><description>serverIp: Resolution server IP</description></item>
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
        /// <para>The start time of the query (timestamp, unit: milliseconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1709192640000</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

    }

}
