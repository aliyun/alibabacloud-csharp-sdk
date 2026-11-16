// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListConsumeSummaryShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The common filter conditions. Valid conditions for different fields take effect simultaneously. For supported fields and operations, see &quot;Common filtering&quot; in the supplementary description of request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;FilterField&quot;:&quot;ProductCode&quot;,&quot;Operation&quot;:&quot;IN&quot;,&quot;Values&quot;:[&quot;ecs&quot;]}]</para>
        /// </summary>
        [NameInMap("CommonFilters")]
        [Validation(Required=false)]
        public string CommonFiltersShrink { get; set; }

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
        public string EcIdAccountIdsShrink { get; set; }

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
        public string PeriodShrink { get; set; }

    }

}
