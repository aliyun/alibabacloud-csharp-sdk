// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordStatisticsSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.top</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The type of the domain name. This parameter is not case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PUBLIC: authoritative domain name (default)</para>
        /// </description></item>
        /// <item><description><para>CACHE: proxy domain name</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// <para>The end date of the query. The format is <b>YYYY-MM-DD</b>.</para>
        /// <para>The default value is the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-04</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The keyword. The search is performed in the %KeyWord% format and is not case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The page number. The value starts from <b>1</b>. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The maximum value is <b>100</b>, the minimum value is <b>1</b>, and the default value is <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The search mode for the keyword. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>LIKE</b>: fuzzy search (default)</para>
        /// </description></item>
        /// <item><description><para><b>EXACT</b>: exact match</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EXACT</para>
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// <para>The start date of the query. The format is <b>YYYY-MM-DD</b>.</para>
        /// <para>You can query data only from the last 90 days. The value of <c>StartDate</c> must be greater than or equal to the current date minus 90 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-04</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The threshold for the number of DNS requests. This operation returns data for subdomains whose request count is less than or equal to this value.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to 100, subdomains with a request count from 1 to 100 are returned.</para>
        /// </description></item>
        /// <item><description><para>If you leave this parameter empty, all subdomains that have DNS requests are returned.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to 0, subdomains with no DNS requests are returned. If a domain name is added on the current day and has no requests, you can query its data on the next day.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public long? Threshold { get; set; }

    }

}
