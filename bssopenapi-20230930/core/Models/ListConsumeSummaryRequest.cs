// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListConsumeSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The common filter conditions. Valid conditions for different fields take effect simultaneously. For supported fields and operations, see &quot;Common filtering&quot; in the supplementary description of request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;FilterField&quot;:&quot;ProductCode&quot;,&quot;Operation&quot;:&quot;IN&quot;,&quot;Values&quot;:[&quot;ecs&quot;]}]</para>
        /// </summary>
        [NameInMap("CommonFilters")]
        [Validation(Required=false)]
        public List<ListConsumeSummaryRequestCommonFilters> CommonFilters { get; set; }
        public class ListConsumeSummaryRequestCommonFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter field. For supported fields and operations, see &quot;Common filtering&quot; in the supplementary description of request parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ProductCode</para>
            /// </summary>
            [NameInMap("FilterField")]
            [Validation(Required=false)]
            public string FilterField { get; set; }

            /// <summary>
            /// <para>The operator. Default value: <c>IN</c>. <c>IN</c> indicates inclusion or exact match, <c>NOT</c> indicates exclusion, and <c>PREFIX</c> indicates prefix match. For the specific support scope, see &quot;Common filtering&quot; in the supplementary description of request parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The filter values always use a string array, including single values, Boolean values, and account IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;ecs&quot;]</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The aggregation dimension.</para>
        /// <para><c>BILLING_ITEM</c>: aggregates by billing item. This is the default value.</para>
        /// <para><c>RESOURCE</c>: aggregates by resource.</para>
        /// <para><c>PRODUCT</c>: aggregates by product.</para>
        /// <para><c>ACCOUNT</c>: aggregates by account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BILLING_ITEM</para>
        /// </summary>
        [NameInMap("DimensionType")]
        [Validation(Required=false)]
        public string DimensionType { get; set; }

        /// <summary>
        /// <para>The query scope for enterprises and accounts. If this parameter is not specified, the default billing scope of the current calling account is used. Only one enterprise object can be specified per request, and the actual scope is limited by permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;EcId&quot;:&quot;123456&quot;,&quot;AccountIds&quot;:[1234567890123456]}]</para>
        /// </summary>
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<ListConsumeSummaryRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class ListConsumeSummaryRequestEcIdAccountIds : TeaModel {
            /// <summary>
            /// <para>The list of account IDs to query. This parameter is required when an enterprise object is passed. If the entire EcIdAccountIds parameter is omitted, the data of the current calling account is queried by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[1234567890123456]</para>
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <para>The ID of the enterprise entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records expected to be returned for a single query. Specify a positive integer. Keep this value unchanged during pagination. The actual number of returned records may be less than this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token for the next page. Do not specify this parameter for the first request. For subsequent requests, pass the value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-next-token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The query time range, which specifies the time granularity, start time, and end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Granularity&quot;:&quot;DAILY&quot;,&quot;StartTime&quot;:&quot;2026-10-01&quot;,&quot;EndTime&quot;:&quot;2026-10-07&quot;}</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public ListConsumeSummaryRequestPeriod Period { get; set; }
        public class ListConsumeSummaryRequestPeriod : TeaModel {
            /// <summary>
            /// <para>For monthly queries, only one month is supported at a time. The value must be the same as the start month, and the format is <c>yyyy-MM</c>.</para>
            /// <para>For daily queries, this parameter is required. The format is <c>yyyy-MM-dd</c>. The end date cannot be earlier than the start date, and the start and end dates must be in the same month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-07</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para><c>MONTHLY</c>: aggregates by month. <c>DAILY</c>: aggregates by day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("Granularity")]
            [Validation(Required=false)]
            public string Granularity { get; set; }

            /// <summary>
            /// <para>For monthly queries, the format is <c>yyyy-MM</c>.</para>
            /// <para>For daily queries, the format is <c>yyyy-MM-dd</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-01</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

    }

}
