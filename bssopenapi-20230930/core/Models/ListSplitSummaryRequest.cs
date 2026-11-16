// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListSplitSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The common filter conditions. Supports filtering by product, commodity, region, billing item, fee type, resource, account, financial unit, resource group, and split item. Different fields are combined by AND. Only one object can be passed for the same field. For more information, see the supplementary description of request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;FilterField&quot;:&quot;SplitItemId&quot;,&quot;Operation&quot;:&quot;IN&quot;,&quot;Values&quot;:[&quot;example-bucket&quot;]}]</para>
        /// </summary>
        [NameInMap("CommonFilters")]
        [Validation(Required=false)]
        public List<ListSplitSummaryRequestCommonFilters> CommonFilters { get; set; }
        public class ListSplitSummaryRequestCommonFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter field. It is required when setting conditions. For supported fields and matching rules, see the supplementary description of request parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SplitItemId</para>
            /// </summary>
            [NameInMap("FilterField")]
            [Validation(Required=false)]
            public string FilterField { get; set; }

            /// <summary>
            /// <para>The matching method. This parameter is case-insensitive and defaults to IN if it is not specified or is empty. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>IN: includes</description></item>
            /// <item><description>NOT: excludes</description></item>
            /// <item><description>PREFIX: literal prefix match
            /// For the supported scope of each field, refer to the supplementary description of the request parameters.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The filter values. It is always an array of strings. Arrays are also used for single values, Boolean values, and account IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;example-bucket&quot;]</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The cost category filter conditions. Different objects in the list and multiple values of the same cost category are matched by OR. The overall cost category filter is combined with the tag filter and CommonFilters by AND.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;CostCategoriesKey&quot;:&quot;business&quot;,&quot;CostCategoriesValues&quot;:[&quot;commerce&quot;]}]</para>
        /// </summary>
        [NameInMap("CostCategoriesFilters")]
        [Validation(Required=false)]
        public List<ListSplitSummaryRequestCostCategoriesFilters> CostCategoriesFilters { get; set; }
        public class ListSplitSummaryRequestCostCategoriesFilters : TeaModel {
            /// <summary>
            /// <para>The cost category name. It cannot be empty or a string of only whitespace characters.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>business</para>
            /// </summary>
            [NameInMap("CostCategoriesKey")]
            [Validation(Required=false)]
            public string CostCategoriesKey { get; set; }

            /// <summary>
            /// <para>The list of cost category values. Matches any given value under the specified cost category. If this parameter is not passed or an empty array is passed, it only requires the existence of the cost category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;commerce&quot;]</para>
            /// </summary>
            [NameInMap("CostCategoriesValues")]
            [Validation(Required=false)]
            public List<string> CostCategoriesValues { get; set; }

        }

        /// <summary>
        /// <para>The query scope for enterprises and accounts. If not passed, the bill scope of the current account is queried. Only one enterprise object can be specified per request. The actual accessible scope is limited by permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;EcId&quot;:&quot;123456&quot;,&quot;AccountIds&quot;:[1234567890123456]}]</para>
        /// </summary>
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<ListSplitSummaryRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class ListSplitSummaryRequestEcIdAccountIds : TeaModel {
            /// <summary>
            /// <para>The list of account IDs to access. If it is empty, all accounts under the current enterprise entity are selected. The actual scope is limited by permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[1234567890123456]</para>
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <para>The enterprise entity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

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
        public ListSplitSummaryRequestPeriod Period { get; set; }
        public class ListSplitSummaryRequestPeriod : TeaModel {
            /// <summary>
            /// <para>The end time. It is inclusive. It is required for <c>DAILY</c> and the format is <c>yyyy-MM-dd</c>. It cannot be earlier than <c>StartTime</c> and must be in the same month as <c>StartTime</c>. It is optional for <c>MONTHLY</c>, but if passed, it must be the same as <c>StartTime</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-07</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The time granularity. This parameter is required for business logic and is case-insensitive. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DAILY: aggregates by day</description></item>
            /// <item><description>MONTHLY: aggregates by month</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("Granularity")]
            [Validation(Required=false)]
            public string Granularity { get; set; }

            /// <summary>
            /// <para>The start time. It is required for business logic and is inclusive. The format is yyyy-MM for MONTHLY and yyyy-MM-dd for DAILY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The resource tag filter conditions. Different objects in the list and multiple values of the same tag key are matched by OR. The overall tag filter is combined with the cost category filter and CommonFilters by AND.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;TagKey&quot;:&quot;env&quot;,&quot;TagValues&quot;:[&quot;prod&quot;]}]</para>
        /// </summary>
        [NameInMap("TagFilters")]
        [Validation(Required=false)]
        public List<ListSplitSummaryRequestTagFilters> TagFilters { get; set; }
        public class ListSplitSummaryRequestTagFilters : TeaModel {
            /// <summary>
            /// <para>The tag key. It cannot be empty or a string of only whitespace characters.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The list of tag values. Matches any given value under the specified tag key. If this parameter is not passed or an empty array is passed, it only requires the existence of the tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;prod&quot;]</para>
            /// </summary>
            [NameInMap("TagValues")]
            [Validation(Required=false)]
            public List<string> TagValues { get; set; }

        }

    }

}
