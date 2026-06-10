// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeGroupExecutingInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>API status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Execution information</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExecutingInfo")]
        [Validation(Required=false)]
        public DescribeGroupExecutingInfoResponseBodyExecutingInfo ExecutingInfo { get; set; }
        public class DescribeGroupExecutingInfoResponseBodyExecutingInfo : TeaModel {
            /// <summary>
            /// <para>Average talk time</para>
            /// 
            /// <b>Example:</b>
            /// <para>258</para>
            /// </summary>
            [NameInMap("AvgTalkTime")]
            [Validation(Required=false)]
            public int? AvgTalkTime { get; set; }

            /// <summary>
            /// <para>Number of failed calls</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CallFailedNum")]
            [Validation(Required=false)]
            public int? CallFailedNum { get; set; }

            /// <summary>
            /// <para>Number of outbound calls</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CallNum")]
            [Validation(Required=false)]
            public int? CallNum { get; set; }

            /// <summary>
            /// <para>Deprecated</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("CreatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>Call duration distribution</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;max&quot;:&quot;40&quot;,&quot;1&quot;:&quot;1&quot;,&quot;total&quot;:&quot;40&quot;,&quot;min&quot;:&quot;40&quot;}</para>
            /// </summary>
            [NameInMap("DurationDistribution")]
            [Validation(Required=false)]
            public string DurationDistribution { get; set; }

            /// <summary>
            /// <para>End time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640087774563</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Number of completed executions</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("FinishedNum")]
            [Validation(Required=false)]
            public int? FinishedNum { get; set; }

            /// <summary>
            /// <para>Number of calls hung up by customers</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("HangUpByClientNum")]
            [Validation(Required=false)]
            public int? HangUpByClientNum { get; set; }

            /// <summary>
            /// <para>Execution progress</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("JobsProgress")]
            [Validation(Required=false)]
            public DescribeGroupExecutingInfoResponseBodyExecutingInfoJobsProgress JobsProgress { get; set; }
            public class DescribeGroupExecutingInfoResponseBodyExecutingInfoJobsProgress : TeaModel {
                /// <summary>
                /// <para>Number of canceled tasks</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("CancelledNum")]
                [Validation(Required=false)]
                public int? CancelledNum { get; set; }

                /// <summary>
                /// <para>Number of executing jobs</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ExecutingNum")]
                [Validation(Required=false)]
                public int? ExecutingNum { get; set; }

                /// <summary>
                /// <para>Number of failed tasks</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("FailedNum")]
                [Validation(Required=false)]
                public int? FailedNum { get; set; }

                /// <summary>
                /// <para>Number of paused tasks</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("PausedNum")]
                [Validation(Required=false)]
                public int? PausedNum { get; set; }

                /// <summary>
                /// <para>Number of tasks being scheduled</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("SchedulingNum")]
                [Validation(Required=false)]
                public int? SchedulingNum { get; set; }

                /// <summary>
                /// <para>Total number of completed tasks</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalCompletedNum")]
                [Validation(Required=false)]
                public int? TotalCompletedNum { get; set; }

                /// <summary>
                /// <para>Total number of jobs</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalJobs")]
                [Validation(Required=false)]
                public int? TotalJobs { get; set; }

                /// <summary>
                /// <para>Number of unanswered calls</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalNotAnsweredNum")]
                [Validation(Required=false)]
                public int? TotalNotAnsweredNum { get; set; }

            }

            /// <summary>
            /// <para>Number of calls with no interaction</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NoInteractionNum")]
            [Validation(Required=false)]
            public int? NoInteractionNum { get; set; }

            /// <summary>
            /// <para>Start time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640087774563</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>Distribution of conversation rounds</para>
            /// <list type="bullet">
            /// <item><description><para>total: total number of conversation rounds involved</para>
            /// </description></item>
            /// <item><description><para>number: specific round number</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;total&quot;:&quot;5&quot;,&quot;5&quot;:&quot;1&quot;} means 5 conversation rounds were involved, and 1 call had 5 user turns.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;total&quot;:&quot;5&quot;,&quot;5&quot;:&quot;4&quot;}</para>
            /// </summary>
            [NameInMap("TalkTurnsDistribution")]
            [Validation(Required=false)]
            public string TalkTurnsDistribution { get; set; }

            /// <summary>
            /// <para>Intent recognition</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TransferByIntentNum")]
            [Validation(Required=false)]
            public int? TransferByIntentNum { get; set; }

            /// <summary>
            /// <para>No answer</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TransferByNoAnswer")]
            [Validation(Required=false)]
            public int? TransferByNoAnswer { get; set; }

        }

        /// <summary>
        /// <para>Task group ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>b24d321a-2a74-4dd1-a0ba-4ab09cef6652</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>c46001bc-3ead-4bfd-9a69-4b5b66a4a3f4</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>API message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
