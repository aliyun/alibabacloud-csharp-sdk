// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GetIqsUsageResult : TeaModel {
        /// <summary>
        /// <para>The daily call volume records.</para>
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<GetIqsUsageResultRecords> Records { get; set; }
        public class GetIqsUsageResultRecords : TeaModel {
            /// <summary>
            /// <para>The API name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UnifiedSearch</para>
            /// </summary>
            [NameInMap("api")]
            [Validation(Required=false)]
            public string Api { get; set; }

            /// <summary>
            /// <para>The queries per second (QPS) for tiered billing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("billingQps")]
            [Validation(Required=false)]
            public int? BillingQps { get; set; }

            /// <summary>
            /// <para>The metering date in the YYYYMMDD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20250716</para>
            /// </summary>
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <para>The search engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Generic</para>
            /// </summary>
            [NameInMap("engineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The number of failed calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("failedCalls")]
            [Validation(Required=false)]
            public int? FailedCalls { get; set; }

            /// <summary>
            /// <para>The matched metering tier. Valid values: 1001, 1002, 1003, and 1004.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("ladderType")]
            [Validation(Required=false)]
            public string LadderType { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>138608930******0</para>
            /// </summary>
            [NameInMap("mainAccountId")]
            [Validation(Required=false)]
            public string MainAccountId { get; set; }

            /// <summary>
            /// <para>The sub-account that initiates the call (RAM user or API key identifier).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2193843763***9272</para>
            /// </summary>
            [NameInMap("subAccountId")]
            [Validation(Required=false)]
            public string SubAccountId { get; set; }

            /// <summary>
            /// <para>The number of successful calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("successCalls")]
            [Validation(Required=false)]
            public int? SuccessCalls { get; set; }

            /// <summary>
            /// <para>The total number of calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("totalBillStatCalls")]
            [Validation(Required=false)]
            public int? TotalBillStatCalls { get; set; }

            /// <summary>
            /// <para>The total number of calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("totalCalls")]
            [Validation(Required=false)]
            public int? TotalCalls { get; set; }

            /// <summary>
            /// <para>The value-added package usage for calling enhanced APIs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("valueAddedAdvanced")]
            [Validation(Required=false)]
            public int? ValueAddedAdvanced { get; set; }

            /// <summary>
            /// <para>The number of value-added package calls used for the summarization feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("valueAddedSummary")]
            [Validation(Required=false)]
            public int? ValueAddedSummary { get; set; }

        }

    }

}
