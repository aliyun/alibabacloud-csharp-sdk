// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetTaskStatsSummaryResponseBody : TeaModel {
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
        public GetTaskStatsSummaryResponseBodyData Data { get; set; }
        public class GetTaskStatsSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The average task duration. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000.5</para>
            /// </summary>
            [NameInMap("AverageTaskDuration")]
            [Validation(Required=false)]
            public double? AverageTaskDuration { get; set; }

            /// <summary>
            /// <para>The task status distribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[...]</para>
            /// </summary>
            [NameInMap("StatusDistribution")]
            [Validation(Required=false)]
            public List<GetTaskStatsSummaryResponseBodyDataStatusDistribution> StatusDistribution { get; set; }
            public class GetTaskStatsSummaryResponseBodyDataStatusDistribution : TeaModel {
                /// <summary>
                /// <para>The number of tasks in this status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>800</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The total token consumption of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500000</para>
            /// </summary>
            [NameInMap("TaskTokenConsumption")]
            [Validation(Required=false)]
            public long? TaskTokenConsumption { get; set; }

            /// <summary>
            /// <para>The total number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("TotalTasks")]
            [Validation(Required=false)]
            public int? TotalTasks { get; set; }

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
