// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListSplitSummaryShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The common filter conditions. Supports filtering by product, commodity, region, billing item, fee type, resource, account, financial unit, resource group, and split item. Different fields are combined by AND. Only one object can be passed for the same field. For more information, see the supplementary description of request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;FilterField&quot;:&quot;SplitItemId&quot;,&quot;Operation&quot;:&quot;IN&quot;,&quot;Values&quot;:[&quot;example-bucket&quot;]}]</para>
        /// </summary>
        [NameInMap("CommonFilters")]
        [Validation(Required=false)]
        public string CommonFiltersShrink { get; set; }

        /// <summary>
        /// <para>The cost category filter conditions. Different objects in the list and multiple values of the same cost category are matched by OR. The overall cost category filter is combined with the tag filter and CommonFilters by AND.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;CostCategoriesKey&quot;:&quot;business&quot;,&quot;CostCategoriesValues&quot;:[&quot;commerce&quot;]}]</para>
        /// </summary>
        [NameInMap("CostCategoriesFilters")]
        [Validation(Required=false)]
        public string CostCategoriesFiltersShrink { get; set; }

        /// <summary>
        /// <para>The query scope for enterprises and accounts. If not passed, the bill scope of the current account is queried. Only one enterprise object can be specified per request. The actual accessible scope is limited by permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;EcId&quot;:&quot;123456&quot;,&quot;AccountIds&quot;:[1234567890123456]}]</para>
        /// </summary>
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public string EcIdAccountIdsShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of records expected to be returned per page. It is used in conjunction with <c>NextToken</c>. Pass a positive integer. We recommend that you explicitly set this parameter and keep it unchanged during pagination. The actual number of returned records may be less than this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page of query results. Do not pass this parameter for the first query. For subsequent queries, pass the <c>NextToken</c> returned in the previous response as is. The query ends when the token is empty or no longer returned. Do not construct or parse the token yourself. Keep <c>Period</c>, account scope, all filter conditions, and <c>MaxResults</c> consistent during pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opaque-token-example</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The query time range. It is required for business logic and includes Granularity, StartTime, and EndTime. Only one billing month can be queried per request. If passed, it overrides the legacy flat time parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Granularity&quot;:&quot;DAILY&quot;,&quot;StartTime&quot;:&quot;2026-09-01&quot;,&quot;EndTime&quot;:&quot;2026-09-07&quot;}</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string PeriodShrink { get; set; }

        /// <summary>
        /// <para>The resource tag filter conditions. Different objects in the list and multiple values of the same tag key are matched by OR. The overall tag filter is combined with the cost category filter and CommonFilters by AND.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;TagKey&quot;:&quot;env&quot;,&quot;TagValues&quot;:[&quot;prod&quot;]}]</para>
        /// </summary>
        [NameInMap("TagFilters")]
        [Validation(Required=false)]
        public string TagFiltersShrink { get; set; }

    }

}
