// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class BeginSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of OK indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BeginSessionResponseBodyData Data { get; set; }
        public class BeginSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The chatbot reply content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello, welcome to STO Express. How can I help you?</para>
            /// </summary>
            [NameInMap("Answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            /// <summary>
            /// <para>The list of control parameters.</para>
            /// </summary>
            [NameInMap("ControlParamsList")]
            [Validation(Required=false)]
            public List<BeginSessionResponseBodyDataControlParamsList> ControlParamsList { get; set; }
            public class BeginSessionResponseBodyDataControlParamsList : TeaModel {
                /// <summary>
                /// <para>The control parameter type. Valid values:</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>HangUp: Hang up.</description></item>
                /// <item><description>Transfer: Transfer.</description></item>
                /// <item><description>GatherDtmf: Gather DTMF.</description></item>
                /// <item><description>Voice: Voice.</description></item>
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
            /// <para>The end time.</para>
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
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1774858849987</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the streaming response has ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StreamEnd")]
            [Validation(Required=false)]
            public bool? StreamEnd { get; set; }

            /// <summary>
            /// <para>The turn ID of the conversation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StreamId")]
            [Validation(Required=false)]
            public string StreamId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. A value of 200 indicates that the HTTP request is successful.</para>
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
        /// <para>The dynamic error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The POP request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14C39896-AE6D-4643-9C9A-E0566B2C2DDD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
