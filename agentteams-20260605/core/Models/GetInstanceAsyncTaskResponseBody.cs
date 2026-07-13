// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class GetInstanceAsyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<GetInstanceAsyncTaskResponseBodyItems> Items { get; set; }
        public class GetInstanceAsyncTaskResponseBodyItems : TeaModel {
            [NameInMap("CurrentStep")]
            [Validation(Required=false)]
            public string CurrentStep { get; set; }

            [NameInMap("RecoveryMessage")]
            [Validation(Required=false)]
            public GetInstanceAsyncTaskResponseBodyItemsRecoveryMessage RecoveryMessage { get; set; }
            public class GetInstanceAsyncTaskResponseBodyItemsRecoveryMessage : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("OccurredAt")]
                [Validation(Required=false)]
                public string OccurredAt { get; set; }

                [NameInMap("RecoverySuggestion")]
                [Validation(Required=false)]
                public string RecoverySuggestion { get; set; }

                [NameInMap("Retryable")]
                [Validation(Required=false)]
                public bool? Retryable { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("TaskCode")]
            [Validation(Required=false)]
            public string TaskCode { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            [NameInMap("WaitingForUserAction")]
            [Validation(Required=false)]
            public bool? WaitingForUserAction { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
