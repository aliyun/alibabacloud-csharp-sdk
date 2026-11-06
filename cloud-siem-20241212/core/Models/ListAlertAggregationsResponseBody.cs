// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListAlertAggregationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of alert groups returned based on the specified aggregation method, sorted by alert count in descending order.</para>
        /// </summary>
        [NameInMap("AlertAggregations")]
        [Validation(Required=false)]
        public List<ListAlertAggregationsResponseBodyAlertAggregations> AlertAggregations { get; set; }
        public class ListAlertAggregationsResponseBodyAlertAggregations : TeaModel {
            /// <summary>
            /// <para>The list of account display values involved in the aggregation group, which corresponds one-to-one with the order of AccountIds. If the username is valid and different from the account ID, the format is &quot;Username/Account ID&quot;. Otherwise, only the account ID is returned.</para>
            /// </summary>
            [NameInMap("AccountDisplayValues")]
            [Validation(Required=false)]
            public List<string> AccountDisplayValues { get; set; }

            /// <summary>
            /// <para>The list of IDs of the member accounts for which the report is generated. Note: You only need to specify this parameter when you generate a multi-account report and want to generate a report for a specified range of accounts.</para>
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<string> AccountIds { get; set; }

            /// <summary>
            /// <para>The unique identifier of the aggregation group. It is concatenated by AggregationType, PrimaryValue, and SecondaryValue with colons (:). If there is no secondary aggregation value, the last segment is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vendor_product:alibaba_cloud:sas</para>
            /// </summary>
            [NameInMap("AggregationKey")]
            [Validation(Required=false)]
            public string AggregationKey { get; set; }

            /// <summary>
            /// <para>The aggregation method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5m-avg</para>
            /// </summary>
            [NameInMap("AggregationType")]
            [Validation(Required=false)]
            public string AggregationType { get; set; }

            /// <summary>
            /// <para>The number of consecutive failures. This parameter is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("AlertCount")]
            [Validation(Required=false)]
            public long? AlertCount { get; set; }

            /// <summary>
            /// <para>The collection of MITRE ATT&amp;CK attack techniques associated with the alerts in the aggregation group. Each element is a JSON array string.</para>
            /// </summary>
            [NameInMap("AttackStages")]
            [Validation(Required=false)]
            public List<string> AttackStages { get; set; }

            /// <summary>
            /// <para>The distribution of alert counts by defense action in the aggregation group. Name is the value of the action field, and Value is the corresponding alert count.</para>
            /// </summary>
            [NameInMap("DefenseActionCounts")]
            [Validation(Required=false)]
            public List<ListAlertAggregationsResponseBodyAlertAggregationsDefenseActionCounts> DefenseActionCounts { get; set; }
            public class ListAlertAggregationsResponseBodyAlertAggregationsDefenseActionCounts : TeaModel {
                /// <summary>
                /// <para>The display name of the entity property field that can be added to the whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>accesstoken</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The default right value displayed for the whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test-Qiantu System AI</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

            /// <summary>
            /// <para>The time of the first access. The value is a UNIX timestamp accurate to seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785290308</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>The time when the attack event last occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785293908000</para>
            /// </summary>
            [NameInMap("LatestTime")]
            [Validation(Required=false)]
            public long? LatestTime { get; set; }

            /// <summary>
            /// <para>The display text of the primary aggregation value. For account aggregation, it returns &quot;Username/Account ID&quot;. If there is no valid username, only the account ID is returned. For event summaries, it returns the event name based on Lang. If the name is missing, the event UUID is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test incident</para>
            /// </summary>
            [NameInMap("PrimaryDisplayValue")]
            [Validation(Required=false)]
            public string PrimaryDisplayValue { get; set; }

            /// <summary>
            /// <para>The value corresponding to the primary query condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud</para>
            /// </summary>
            [NameInMap("PrimaryValue")]
            [Validation(Required=false)]
            public string PrimaryValue { get; set; }

            /// <summary>
            /// <para>The value corresponding to the secondary query condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas</para>
            /// </summary>
            [NameInMap("SecondaryValue")]
            [Validation(Required=false)]
            public string SecondaryValue { get; set; }

            /// <summary>
            /// <para>The collection of event source codes.</para>
            /// <remarks>
            /// <para>Example: [\&quot;MRM\&quot;]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("SourceCodes")]
            [Validation(Required=false)]
            public List<string> SourceCodes { get; set; }

            /// <summary>
            /// <para>The distribution of alert counts by alert status in the aggregation group. Name is the alert status value, and Value is the corresponding alert count.</para>
            /// </summary>
            [NameInMap("StatusCounts")]
            [Validation(Required=false)]
            public List<ListAlertAggregationsResponseBodyAlertAggregationsStatusCounts> StatusCounts { get; set; }
            public class ListAlertAggregationsResponseBodyAlertAggregationsStatusCounts : TeaModel {
                /// <summary>
                /// <para>The display name of the entity property field that can be added to the whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://domain.com/">http://domain.com/</a></para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The right value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123.123.123.123</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum number of entries returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
