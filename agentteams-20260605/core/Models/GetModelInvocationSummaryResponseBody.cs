// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetModelInvocationSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetModelInvocationSummaryResponseBodyData Data { get; set; }
        public class GetModelInvocationSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The call frequency. Unit: calls per minute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("CallFrequency")]
            [Validation(Required=false)]
            public double? CallFrequency { get; set; }

            /// <summary>
            /// <para>The provider call distribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("ProviderDistribution")]
            [Validation(Required=false)]
            public List<GetModelInvocationSummaryResponseBodyDataProviderDistribution> ProviderDistribution { get; set; }
            public class GetModelInvocationSummaryResponseBodyDataProviderDistribution : TeaModel {
                /// <summary>
                /// <para>The number of calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>455</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.65</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public double? Percentage { get; set; }

                /// <summary>
                /// <para>The provider name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-provider</para>
                /// </summary>
                [NameInMap("ProviderName")]
                [Validation(Required=false)]
                public string ProviderName { get; set; }

            }

            /// <summary>
            /// <para>The number of calls made today.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TodayCallCount")]
            [Validation(Required=false)]
            public int? TodayCallCount { get; set; }

            /// <summary>
            /// <para>The change rate of calls made today.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.15</para>
            /// </summary>
            [NameInMap("TodayChangeRate")]
            [Validation(Required=false)]
            public double? TodayChangeRate { get; set; }

            /// <summary>
            /// <para>The number of calls made this week.</para>
            /// 
            /// <b>Example:</b>
            /// <para>700</para>
            /// </summary>
            [NameInMap("WeekCallCount")]
            [Validation(Required=false)]
            public int? WeekCallCount { get; set; }

            /// <summary>
            /// <para>The change rate of calls made this week.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.05</para>
            /// </summary>
            [NameInMap("WeekChangeRate")]
            [Validation(Required=false)]
            public double? WeekChangeRate { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
