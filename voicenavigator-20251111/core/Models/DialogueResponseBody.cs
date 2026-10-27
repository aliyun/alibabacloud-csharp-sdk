// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class DialogueResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of <c>OK</c> indicates that the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business-specific data returned by the operation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DialogueResponseBodyData Data { get; set; }
        public class DialogueResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The bot\&quot;s reply.</para>
            /// 
            /// <b>Example:</b>
            /// <para>不好意思，我没听</para>
            /// </summary>
            [NameInMap("Answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            /// <summary>
            /// <para>A list of control parameters.</para>
            /// </summary>
            [NameInMap("ControlParamsList")]
            [Validation(Required=false)]
            public List<DialogueResponseBodyDataControlParamsList> ControlParamsList { get; set; }
            public class DialogueResponseBodyDataControlParamsList : TeaModel {
                /// <summary>
                /// <para>The type of the control parameter.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para><c>HangUp</c>: Hang up.</para>
                /// </description></item>
                /// <item><description><para><c>Transfer</c>: Transfer.</para>
                /// </description></item>
                /// <item><description><para><c>GatherDtmf</c>: Gather DTMF.</para>
                /// </description></item>
                /// <item><description><para><c>Voice</c>: Voice.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Voice</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The Unix timestamp for when the operation ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1752283603978</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>07d72ea0-6e38-48d4-8371-14deaaba996f</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The Unix timestamp for when the operation started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1774858849987</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>A flag that indicates whether the stream has ended. A value of <c>true</c> signifies the end of the stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StreamEnd")]
            [Validation(Required=false)]
            public bool? StreamEnd { get; set; }

            /// <summary>
            /// <para>The stream ID for the conversational turn.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StreamId")]
            [Validation(Required=false)]
            public string StreamId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. A value of <c>200</c> indicates a successful response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The HTTP response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The parameters associated with an error.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DB8BA95-4513-54B9-9C67-A28909CFB4AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
