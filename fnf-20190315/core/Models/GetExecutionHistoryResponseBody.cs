// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class GetExecutionHistoryResponseBody : TeaModel {
        /// <summary>
        /// The events.
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<GetExecutionHistoryResponseBodyEvents> Events { get; set; }
        public class GetExecutionHistoryResponseBodyEvents : TeaModel {
            /// <summary>
            /// The details about the execution step.
            /// </summary>
            [NameInMap("EventDetail")]
            [Validation(Required=false)]
            public string EventDetail { get; set; }

            /// <summary>
            /// The ID of the execution step.
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            /// <summary>
            /// The ID of the scheduling step.
            /// </summary>
            [NameInMap("ScheduleEventId")]
            [Validation(Required=false)]
            public long? ScheduleEventId { get; set; }

            /// <summary>
            /// The name of the execution step.
            /// </summary>
            [NameInMap("StepName")]
            [Validation(Required=false)]
            public string StepName { get; set; }

            /// <summary>
            /// The time when the event was updated.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// The type of the execution step. Valid values:
            /// 
            /// *   **StepEntered**
            /// *   **StepStarted**
            /// *   **StepSucceeded**
            /// *   **StepFailed**
            /// *   **StepExited**
            /// *   **BranchEntered**
            /// *   **BranchExited**
            /// *   **IterationEntered**
            /// *   **IterationExited**
            /// *   **TaskScheduled**
            /// *   **TaskStarted**
            /// *   **TaskSubmitted**
            /// *   **TaskSubmitFailed**
            /// *   **TaskSucceeded**
            /// *   **TaskFailed**
            /// *   **TaskTimedOut**
            /// *   **ExecutionStarted**
            /// *   **ExecutionStopped**
            /// *   **ExecutionSucceeded**
            /// *   **ExecutionFailed**
            /// *   **ExecutionTimedOut**
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// You do not need to specify this parameter for the first request. The returned value of **ScheduleEventId** is used as the token for the next query. No value is returned for the last query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
