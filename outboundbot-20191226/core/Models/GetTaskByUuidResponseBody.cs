// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetTaskByUuidResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public GetTaskByUuidResponseBodyTask Task { get; set; }
        public class GetTaskByUuidResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>The actual execution time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640090211434</para>
            /// </summary>
            [NameInMap("ActualTime")]
            [Validation(Required=false)]
            public long? ActualTime { get; set; }

            /// <summary>
            /// <para>The call ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("CallId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            /// <summary>
            /// <para>The called number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13777777777</para>
            /// </summary>
            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            /// <summary>
            /// <para>The calling number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>057190294</para>
            /// </summary>
            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }

            /// <summary>
            /// <para>The list of conversation information.</para>
            /// </summary>
            [NameInMap("Conversations")]
            [Validation(Required=false)]
            public List<GetTaskByUuidResponseBodyTaskConversations> Conversations { get; set; }
            public class GetTaskByUuidResponseBodyTaskConversations : TeaModel {
                /// <summary>
                /// <para>The instruction. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BeginDialogue: starts the conversation.</description></item>
                /// <item><description>Dialogue: indicates a conversation.</description></item>
                /// <item><description>AbortDialogue: aborts the conversation.</description></item>
                /// <item><description>SilenceTimeout: indicates a silence timeout.</description></item>
                /// <item><description>CollectedNumber: indicates a collected number.</description></item>
                /// <item><description>EndDialogue: ends the conversation.</description></item>
                /// <item><description>Broadcast: indicates an opening remark.</description></item>
                /// <item><description>HangUp: hangs up the call.</description></item>
                /// <item><description>Authorize: grants authorization.</description></item>
                /// <item><description>TransferToAgent: transfers the call to an agent.</description></item>
                /// <item><description>TransferToIVR: transfers the call to an IVR.</description></item>
                /// <item><description>RedirectToPage: redirects to a page.</description></item>
                /// <item><description>CollectNumber: collects a number.</description></item>
                /// <item><description>WaitOnAsyncTask: waits for an asynchronous task.</description></item>
                /// <item><description>Error: indicates an error.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Broadcast</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The conversation text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hello, I am **customer service</para>
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public string Script { get; set; }

                /// <summary>
                /// <para>The session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fd279983-93b9-b13b-9a34-64e5df473225</para>
                /// </summary>
                [NameInMap("SequenceId")]
                [Validation(Required=false)]
                public string SequenceId { get; set; }

                /// <summary>
                /// <para>The speaker of the conversation. Valid values: Robot and Contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Robot</para>
                /// </summary>
                [NameInMap("Speaker")]
                [Validation(Required=false)]
                public string Speaker { get; set; }

                /// <summary>
                /// <para>The time when the summary was created. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1579068424883</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The end reason. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FINISHED: normal completion.</description></item>
            /// <item><description>CHATBOT_HANGUP_AFTER_NOANSWER: the robot hangs up after unrecognized input.</description></item>
            /// <item><description>CHATBOT_HANGUP_AFTER_SILENCE: the robot hangs up after a silence timeout.</description></item>
            /// <item><description>CLIENT_HANGUP_AFTER_NOANSWER: the user hangs up after unrecognized input.</description></item>
            /// <item><description>CLIENT_HANGUP: the user hangs up without a reason.</description></item>
            /// <item><description>TRANSFER_BY_INTENT: the call is transferred to a human agent due to intent matching.</description></item>
            /// <item><description>TRANSFER_AFTER_NOANSWER: the call is transferred to a human agent after unrecognized input.</description></item>
            /// <item><description>INO_INTERACTION: no interaction from the user.</description></item>
            /// <item><description>ERROR: the system is interrupted due to an exception.</description></item>
            /// <item><description>SPECIAL_INTERCEPT_VOICE_ASSISTANT: intercepted due to special circumstances - voice assistant.</description></item>
            /// <item><description>SPECIAL_INTERCEPT_EXTENSION_NUMBER_TRANSFER: intercepted due to special circumstances - extension number transfer.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: The data type of this parameter is String. The returned value is an enumerated value such as FINISHED.</notice></para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("EndReason")]
            [Validation(Required=false)]
            public string EndReason { get; set; }

            /// <summary>
            /// <para>The end time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640090211434</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The job group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The planned execution time of the task. The value is a UNIX timestamp in milliseconds.</para>
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
