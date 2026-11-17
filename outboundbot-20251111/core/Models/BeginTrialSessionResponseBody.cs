// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class BeginTrialSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The business processing status code. OK indicates success. If an exception occurs, the corresponding business error code is returned. Error types and mapping rules follow the current API configuration. No error codes are added or modified in this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The robot reply, round ID, time, and control commands carried by the current SSE event. A single round may contain multiple events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Answer&quot;:&quot;Hello, how can I help you?&quot;,&quot;StreamEnd&quot;:true,&quot;SessionId&quot;:&quot;text-11111111-2222-4333-8444-555555555555&quot;,&quot;StreamId&quot;:&quot;0&quot;,&quot;StartTime&quot;:1794560400000,&quot;EndTime&quot;:1794560400123,&quot;ControlParamsList&quot;:[{&quot;Type&quot;:&quot;Voice&quot;}],&quot;Extras&quot;:{&quot;DebugInfo&quot;:&quot;{}&quot;}}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BeginTrialSessionResponseBodyData Data { get; set; }
        public class BeginTrialSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The robot reply text in the current streaming event. It may be returned across multiple SSE events, or it may be empty in an end event or debug event. Do not equate missing text with session failure. Whether the content is incremental or cumulative is determined by the output conventions of the dialogue engine. The current general callback directly forwards the engine content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello, how can I help you?</para>
            /// </summary>
            [NameInMap("Answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            /// <summary>
            /// <para>The robot control commands attached to this reply. The current POP structure only expands the command Type and does not add other command fields in this document. If no control command is generated, the text service supplements a Voice type command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;Type&quot;:&quot;Voice&quot;}]</para>
            /// </summary>
            [NameInMap("ControlParamsList")]
            [Validation(Required=false)]
            public List<BeginTrialSessionResponseBodyDataControlParamsList> ControlParamsList { get; set; }
            public class BeginTrialSessionResponseBodyDataControlParamsList : TeaModel {
                /// <summary>
                /// <para>The values declared in the control command type include Voice (voice reply), HangUp (hang up), Transfer (transfer), GatherDtmf (collect DTMF tones), and SendSms (send SMS message). SendSms, which was omitted in the original description, is added in this update without changing the backend structure or runtime enumeration constraints.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Voice</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The UNIX timestamp of the current streaming reply callback event, in milliseconds. It is generated based on the current callback time. It may also be returned when StreamEnd=false. Do not directly interpret it as the end time of the entire session or call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1794560400123</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The extended information object attached to the robot reply, which is different from the JSON event array of the request parameter Extras. The current POP expands the DebugInfo field. Whether it is actually returned depends on the engine used and the current round of reply.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;DebugInfo&quot;:&quot;{}&quot;}</para>
            /// </summary>
            [NameInMap("Extras")]
            [Validation(Required=false)]
            public BeginTrialSessionResponseBodyDataExtras Extras { get; set; }
            public class BeginTrialSessionResponseBodyDataExtras : TeaModel {
                /// <summary>
                /// <para>The debug information returned by the dialogue engine, which is a JSON string. It is returned only when the engine provides and obtains debug information, and may be returned with supplementary events after the reply ends. The internal structure is determined by the engine. The example empty object string does not declare any fixed debug fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("DebugInfo")]
                [Validation(Required=false)]
                public string DebugInfo { get; set; }

            }

            /// <summary>
            /// <para>The session ID used to uniquely associate this interaction. For a text session, it is the text- ID returned when the session is started. For web voice, it is the ws- ID. For a real number outbound call test, it is the test- ID. Subsequent calls must use the actual return value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-11111111-2222-4333-8444-555555555555</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp recorded when the streaming reply callback is entered for the first time in the current round, in milliseconds. Subsequent events in the current round use this time. It is not the session creation time or a general update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1794560400000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the streaming output of the current reply round has ended. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The streaming output has ended, and the service has completed the corresponding SSE response.</description></item>
            /// <item><description>false: Subsequent events may still occur in the current round.
            /// This field does not indicate that the entire session or voice call has ended.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StreamEnd")]
            [Validation(Required=false)]
            public bool? StreamEnd { get; set; }

            /// <summary>
            /// <para>The ID of the dialogue round to which this robot reply belongs. A single round of reply may contain multiple streaming events. The text session context starts from 0 and increments during subsequent Dialogue calls. The actual return value from the engine shall prevail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StreamId")]
            [Validation(Required=false)]
            public string StreamId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code recorded in the business response body. A normal return value is 200. To determine whether the business operation is successful, you must also check Code. You cannot determine the success of a call solely based on the presence of this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The business response or error description. This field is usually empty or not returned upon success, and no fixed text is returned. Upon failure, it provides an error description to assist in troubleshooting. Combine this field with Code and Params to understand the cause of the error. The example shows an error message when the trial link visitor token expires (corresponding to the Expired.VisitorToken code) and is for format reference only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VisitorToken: example-visitor-token is expired.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The parameter list used for the localized display of error messages. It is not a scenario variable or business result. A normal successful response is usually an empty array. If an error occurs, parameters corresponding to the error template may be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The ID used to associate and troubleshoot this POP request. The value in the response corresponds to the current request. System request parameters are injected by the gateway, and the caller does not need to fill in system fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAAAA-BBBB-4CCC-8DDD-EEEEEEEEEEEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
