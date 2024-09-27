// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainStatisticsSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the <b>YYYY-MM-DD</b> format.</para>
        /// <para>The default value is the day when you perform the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-04</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The keyword for searches in %KeyWord% mode. The value is not case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1 to 100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The search mode of the keyword. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LIKE</b>: fuzzy match (default).</description></item>
        /// <item><description><b>EXACT</b>: exact match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LIKE</para>
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the <b>YYYY-MM-DD</b> format.</para>
        /// <para>You can only query DNS records of the last 90 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-04</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The threshold of query volume that can be obtained. You can also obtain data about a domain name with the query volume less than or equal to the threshold. For example, if you set this parameter to 100, you can query domain names with less than 100 queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public long? Threshold { get; set; }

    }

}
