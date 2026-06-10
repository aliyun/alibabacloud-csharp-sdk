// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetTaskByUuidResponseBody : TeaModel {
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
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message</para>
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
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Task information</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public GetTaskByUuidResponseBodyTask Task { get; set; }
        public class GetTaskByUuidResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>Actual execution time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640090211434</para>
            /// </summary>
            [NameInMap("ActualTime")]
            [Validation(Required=false)]
            public long? ActualTime { get; set; }

            /// <summary>
            /// <para>Call ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("CallId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            /// <summary>
            /// <para>Callee number</para>
            /// 
            /// <b>Example:</b>
            /// <para>13777777777</para>
            /// </summary>
            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            /// <summary>
            /// <para>Caller number</para>
            /// 
            /// <b>Example:</b>
            /// <para>057190294</para>
            /// </summary>
            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }

            /// <summary>
            /// <para>List of conversations</para>
            /// </summary>
            [NameInMap("Conversations")]
            [Validation(Required=false)]
            public List<GetTaskByUuidResponseBodyTaskConversations> Conversations { get; set; }
            public class GetTaskByUuidResponseBodyTaskConversations : TeaModel {
                /// <summary>
                /// <para>Action type</para>
                /// <list type="bullet">
                /// <item><description><para>Dialogue: Dialogue</para>
                /// </description></item>
                /// <item><description><para>AbortDialogue: Abort a dialogue</para>
                /// </description></item>
                /// <item><description><para>SilenceTimeout: Silence timeout</para>
                /// </description></item>
                /// <item><description><para>CollectedNumber: Collected number</para>
                /// </description></item>
                /// <item><description><para>EndDialogue: End a dialogue</para>
                /// </description></item>
                /// <item><description><para>Broadcast: Greeting message</para>
                /// </description></item>
                /// <item><description><para>HangUp: Hang up</para>
                /// </description></item>
                /// <item><description><para>Authorize: Authorization</para>
                /// </description></item>
                /// <item><description><para>TransferToAgent: Transfer to an agent</para>
                /// </description></item>
                /// <item><description><para>TransferToIVR: Transfer to an IVR system</para>
                /// </description></item>
                /// <item><description><para>RedirectToPage: Redirect to a page</para>
                /// </description></item>
                /// <item><description><para>CollectNumber: Collect a number</para>
                /// </description></item>
                /// <item><description><para>WaitOnAsyncTask: Wait for an asynchronous task</para>
                /// </description></item>
                /// <item><description><para>Error: Error</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Broadcast</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>Conversation text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>你好，我是**客服</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public string Script { get; set; }

                /// <summary>
                /// <para>Session ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>fd279983-93b9-b13b-9a34-64e5df473225</para>
                /// </summary>
                [NameInMap("SequenceId")]
                [Validation(Required=false)]
                public string SequenceId { get; set; }

                /// <summary>
                /// <para>Who spoke in the conversation. Valid values: Robot or Contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Robot</para>
                /// </summary>
                [NameInMap("Speaker")]
                [Validation(Required=false)]
                public string Speaker { get; set; }

                /// <summary>
                /// <para>Timestamp when the summary was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1579068424883</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            /// <summary>
            /// <para>Reason the task ended</para>
            /// <list type="bullet">
            /// <item><description><para>FINISHED: Task completed normally</para>
            /// </description></item>
            /// <item><description><para>CHATBOT_HANGUP_AFTER_NOANSWER: Bot hung up after no answer</para>
            /// </description></item>
            /// <item><description><para>CHATBOT_HANGUP_AFTER_SILENCE: Bot hung up after silence timeout</para>
            /// </description></item>
            /// <item><description><para>CLIENT_HANGUP_AFTER_NOANSWER: Client hung up after no answer</para>
            /// </description></item>
            /// <item><description><para>CLIENT_HANGUP: Client hung up without reason</para>
            /// </description></item>
            /// <item><description><para>TRANSFER_BY_INTENT: Transferred to agent after intent match</para>
            /// </description></item>
            /// <item><description><para>TRANSFER_AFTER_NOANSWER: Transferred to agent after no answer</para>
            /// </description></item>
            /// <item><description><para>INO_INTERACTION: No interaction from client</para>
            /// </description></item>
            /// <item><description><para>ERROR: System error interrupted the task</para>
            /// </description></item>
            /// <item><description><para>SPECIAL_INTERCEPT_VOICE_ASSISTANT: Intercepted due to voice assistant</para>
            /// </description></item>
            /// <item><description><para>SPECIAL_INTERCEPT_EXTENSION_NUMBER_TRANSFER: Intercepted due to extension number transfer</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>This parameter is a string that returns an enumeration value such as FINISHED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("EndReason")]
            [Validation(Required=false)]
            public string EndReason { get; set; }

            /// <summary>
            /// <para>End time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640090211434</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Job group ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <para>Job ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>Planned execution time (deprecated)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640090211434</para>
            /// </summary>
            [NameInMap("PlannedTime")]
            [Validation(Required=false)]
            public long? PlannedTime { get; set; }

        }

    }

}
