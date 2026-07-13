// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainResolveStatisticsSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The sort direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DESC: descending</para>
        /// </description></item>
        /// <item><description><para>ASC: ascending</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The end date. The format is yyyy-MM-dd. For example, 2023-03-13.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-01</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The keyword. This parameter is used with SearchMode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language. Valid values: zh, en, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The page number. The value starts from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. The maximum value is 1000. The minimum value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search mode of the keyword. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>LIKE: fuzzy search (default)</para>
        /// </description></item>
        /// <item><description><para>EXACT: exact match</para>
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
        /// <para>The start date. The format is yyyy-MM-dd. For example, 2023-03-01.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-01</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The threshold for the number of DNS queries. This parameter filters domain names by query volume.</para>
        /// <para>If you do not specify this parameter, the operation returns domain names with more than zero queries.</para>
        /// <para>If you specify a value less than 0, the operation returns all domain names.</para>
        /// <para>If you specify 0, the operation returns domain names with zero queries.</para>
        /// <para>If you specify a value greater than 0, the operation returns domain names with a query volume up to this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public long? Threshold { get; set; }

    }

}
