// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class GetExecutionHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The events.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<GetExecutionHistoryResponseBodyEvents> Events { get; set; }
        public class GetExecutionHistoryResponseBodyEvents : TeaModel {
            /// <summary>
            /// <para>The details about the execution step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("EventDetail")]
            [Validation(Required=false)]
            public string EventDetail { get; set; }

            /// <summary>
            /// <para>The ID of the execution step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            /// <summary>
            /// <para>The ID of the scheduling step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScheduleEventId")]
            [Validation(Required=false)]
            public long? ScheduleEventId { get; set; }

            /// <summary>
            /// <para>The name of the execution step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>passStep</para>
            /// </summary>
            [NameInMap("StepName")]
            [Validation(Required=false)]
            public string StepName { get; set; }

            /// <summary>
            /// <para>The time when the event was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-01T01:01:01.001Z</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The type of the execution step. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>StepEntered</b></description></item>
            /// <item><description><b>StepStarted</b></description></item>
            /// <item><description><b>StepSucceeded</b></description></item>
            /// <item><description><b>StepFailed</b></description></item>
            /// <item><description><b>StepExited</b></description></item>
            /// <item><description><b>BranchEntered</b></description></item>
            /// <item><description><b>BranchExited</b></description></item>
            /// <item><description><b>IterationEntered</b></description></item>
            /// <item><description><b>IterationExited</b></description></item>
            /// <item><description><b>TaskScheduled</b></description></item>
            /// <item><description><b>TaskStarted</b></description></item>
            /// <item><description><b>TaskSubmitted</b></description></item>
            /// <item><description><b>TaskSubmitFailed</b></description></item>
            /// <item><description><b>TaskSucceeded</b></description></item>
            /// <item><description><b>TaskFailed</b></description></item>
            /// <item><description><b>TaskTimedOut</b></description></item>
            /// <item><description><b>ExecutionStarted</b></description></item>
            /// <item><description><b>ExecutionStopped</b></description></item>
            /// <item><description><b>ExecutionSucceeded</b></description></item>
            /// <item><description><b>ExecutionFailed</b></description></item>
            /// <item><description><b>ExecutionTimedOut</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TaskSucceeded</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>You do not need to specify this parameter for the first request. The returned value of <b>ScheduleEventId</b> is used as the token for the next query. No value is returned for the last query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRequestId</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
