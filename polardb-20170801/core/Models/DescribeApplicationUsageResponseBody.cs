// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The Hermes application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-123456</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The usage statistics grouped by UTC date.</para>
        /// </summary>
        [NameInMap("DailyUsage")]
        [Validation(Required=false)]
        public List<DescribeApplicationUsageResponseBodyDailyUsage> DailyUsage { get; set; }
        public class DescribeApplicationUsageResponseBodyDailyUsage : TeaModel {
            /// <summary>
            /// <para>The number of model API calls for the day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>48</para>
            /// </summary>
            [NameInMap("APICalls")]
            [Validation(Required=false)]
            public long? APICalls { get; set; }

            /// <summary>
            /// <para>The number of tokens served from cache hits for the day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1800</para>
            /// </summary>
            [NameInMap("CacheReadTokens")]
            [Validation(Required=false)]
            public long? CacheReadTokens { get; set; }

            /// <summary>
            /// <para>The UTC date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-24</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <para>The number of input tokens for the day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12000</para>
            /// </summary>
            [NameInMap("InputTokens")]
            [Validation(Required=false)]
            public long? InputTokens { get; set; }

            /// <summary>
            /// <para>The number of output tokens for the day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("OutputTokens")]
            [Validation(Required=false)]
            public long? OutputTokens { get; set; }

            /// <summary>
            /// <para>The number of reasoning tokens for the day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("ReasoningTokens")]
            [Validation(Required=false)]
            public long? ReasoningTokens { get; set; }

            /// <summary>
            /// <para>The number of sessions for the day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public long? Sessions { get; set; }

        }

        /// <summary>
        /// <para>The number of days covered by this statistical period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        public int? Days { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The usage statistics grouped by model.</para>
        /// </summary>
        [NameInMap("ModelUsage")]
        [Validation(Required=false)]
        public List<DescribeApplicationUsageResponseBodyModelUsage> ModelUsage { get; set; }
        public class DescribeApplicationUsageResponseBodyModelUsage : TeaModel {
            /// <summary>
            /// <para>The number of API calls for this model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>320</para>
            /// </summary>
            [NameInMap("APICalls")]
            [Validation(Required=false)]
            public long? APICalls { get; set; }

            /// <summary>
            /// <para>The number of tokens served from cache hits for this model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12000</para>
            /// </summary>
            [NameInMap("CacheReadTokens")]
            [Validation(Required=false)]
            public long? CacheReadTokens { get; set; }

            /// <summary>
            /// <para>The number of input tokens consumed by this model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80000</para>
            /// </summary>
            [NameInMap("InputTokens")]
            [Validation(Required=false)]
            public long? InputTokens { get; set; }

            /// <summary>
            /// <para>The model identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-max</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The number of output tokens generated by this model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24000</para>
            /// </summary>
            [NameInMap("OutputTokens")]
            [Validation(Required=false)]
            public long? OutputTokens { get; set; }

            /// <summary>
            /// <para>The model provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bailian</para>
            /// </summary>
            [NameInMap("Provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <para>The number of reasoning tokens generated by this model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4000</para>
            /// </summary>
            [NameInMap("ReasoningTokens")]
            [Validation(Required=false)]
            public long? ReasoningTokens { get; set; }

            /// <summary>
            /// <para>The number of sessions that used this model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public long? Sessions { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F45FFACC-1234-5678-90AB-1234567890AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The current session runtime and storage statistics.</para>
        /// </summary>
        [NameInMap("SessionSummary")]
        [Validation(Required=false)]
        public DescribeApplicationUsageResponseBodySessionSummary SessionSummary { get; set; }
        public class DescribeApplicationUsageResponseBodySessionSummary : TeaModel {
            /// <summary>
            /// <para>The number of currently active sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ActiveSessions")]
            [Validation(Required=false)]
            public long? ActiveSessions { get; set; }

            /// <summary>
            /// <para>The total number of sessions in session storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("StoredSessions")]
            [Validation(Required=false)]
            public long? StoredSessions { get; set; }

        }

        /// <summary>
        /// <para>The aggregated statistics of skill activities.</para>
        /// </summary>
        [NameInMap("SkillUsage")]
        [Validation(Required=false)]
        public DescribeApplicationUsageResponseBodySkillUsage SkillUsage { get; set; }
        public class DescribeApplicationUsageResponseBodySkillUsage : TeaModel {
            /// <summary>
            /// <para>The number of distinct skills that have activity records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("DistinctSkills")]
            [Validation(Required=false)]
            public long? DistinctSkills { get; set; }

            /// <summary>
            /// <para>The total number of skill-related operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("TotalActions")]
            [Validation(Required=false)]
            public long? TotalActions { get; set; }

            /// <summary>
            /// <para>The number of times skills were edited or managed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalEdits")]
            [Validation(Required=false)]
            public long? TotalEdits { get; set; }

            /// <summary>
            /// <para>The number of times skills were loaded or viewed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TotalLoads")]
            [Validation(Required=false)]
            public long? TotalLoads { get; set; }

        }

        /// <summary>
        /// <para>The aggregated usage within the query period.</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public DescribeApplicationUsageResponseBodySummary Summary { get; set; }
        public class DescribeApplicationUsageResponseBodySummary : TeaModel {
            /// <summary>
            /// <para>The number of model API calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>480</para>
            /// </summary>
            [NameInMap("APICalls")]
            [Validation(Required=false)]
            public long? APICalls { get; set; }

            /// <summary>
            /// <para>The number of tokens served from cache hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18000</para>
            /// </summary>
            [NameInMap("CacheReadTokens")]
            [Validation(Required=false)]
            public long? CacheReadTokens { get; set; }

            /// <summary>
            /// <para>The number of input tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120000</para>
            /// </summary>
            [NameInMap("InputTokens")]
            [Validation(Required=false)]
            public long? InputTokens { get; set; }

            /// <summary>
            /// <para>The number of output tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36000</para>
            /// </summary>
            [NameInMap("OutputTokens")]
            [Validation(Required=false)]
            public long? OutputTokens { get; set; }

            /// <summary>
            /// <para>The number of reasoning tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6000</para>
            /// </summary>
            [NameInMap("ReasoningTokens")]
            [Validation(Required=false)]
            public long? ReasoningTokens { get; set; }

            /// <summary>
            /// <para>The number of sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public long? Sessions { get; set; }

        }

    }

}
