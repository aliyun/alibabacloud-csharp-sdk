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
            /// <para>The list of account display values associated with the aggregation group, in one-to-one correspondence with AccountIds. When the username is valid and differs from the account ID, the format is &quot;username/account ID&quot;. Otherwise, only the account ID is returned.</para>
            /// </summary>
            [NameInMap("AccountDisplayValues")]
            [Validation(Required=false)]
            public List<string> AccountDisplayValues { get; set; }

            /// <summary>
            /// <para>The list of member accounts IDs for which the report is generated. You need to specify this parameter only when you generate a multi-account report and want to limit the report to specific member accounts.</para>
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<string> AccountIds { get; set; }

            /// <summary>
            /// <para>The unique identifier of the aggregation group, which is a concatenation of AggregationType, PrimaryValue, and SecondaryValue joined by colons (:). The last segment is empty if no secondary aggregation value exists.</para>
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
            /// <para>The collection of MITRE ATT&amp;CK attack techniques associated with alerts in the aggregation group. Each element is a JSON array string.</para>
            /// </summary>
            [NameInMap("AttackStages")]
            [Validation(Required=false)]
            public List<string> AttackStages { get; set; }

            /// <summary>
            /// <para>The quantity distribution by defense action within the aggregation group. Name is the action field value, and Value is the corresponding alert count.</para>
            /// </summary>
            [NameInMap("DefenseActionCounts")]
            [Validation(Required=false)]
            public List<ListAlertAggregationsResponseBodyAlertAggregationsDefenseActionCounts> DefenseActionCounts { get; set; }
            public class ListAlertAggregationsResponseBodyAlertAggregationsDefenseActionCounts : TeaModel {
                /// <summary>
                /// <para>The display name of the entity attribute field that can be added to the whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>accesstoken</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The default right-hand value displayed for the whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test-FutureSystemAI</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

            /// <summary>
            /// <para>The time of the first access, represented as a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785290308</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>The most recent time when the attack event occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785293908000</para>
            /// </summary>
            [NameInMap("LatestTime")]
            [Validation(Required=false)]
            public long? LatestTime { get; set; }

            /// <summary>
            /// <para>The display text of the primary aggregation value. For account aggregation, the format is &quot;username/account ID&quot;. If no valid username exists, only the account ID is returned. For event summaries, the event name is returned based on the Lang parameter. If the name is missing, the event UUID is returned.</para>
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
            /// <para>Example: [\\\&quot;MRM\\\&quot;]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("SourceCodes")]
            [Validation(Required=false)]
            public List<string> SourceCodes { get; set; }

            /// <summary>
            /// <para>The quantity distribution by alert status within the aggregation group. Name is the alert status value, and Value is the corresponding alert count.</para>
            /// </summary>
            [NameInMap("StatusCounts")]
            [Validation(Required=false)]
            public List<ListAlertAggregationsResponseBodyAlertAggregationsStatusCounts> StatusCounts { get; set; }
            public class ListAlertAggregationsResponseBodyAlertAggregationsStatusCounts : TeaModel {
                /// <summary>
                /// <para>The display name of the entity attribute field that can be added to the whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://domain.com/">http://domain.com/</a></para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The right-hand value.</para>
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
        /// <para>The page number.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
