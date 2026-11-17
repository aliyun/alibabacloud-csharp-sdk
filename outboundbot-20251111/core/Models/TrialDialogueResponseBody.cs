// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class TrialDialogueResponseBody : TeaModel {
        /// <summary>
        /// <para>The business processing status code. OK indicates success. When an exception occurs, the corresponding business error code is returned. The error types and mapping rules follow the current API configuration, and no error codes are added or modified in this update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The robot reply, turn ID, time, and control commands carried by the current SSE event. A single turn may have multiple events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Answer&quot;:&quot;Sure, let me introduce the handling process to you.&quot;,&quot;StreamEnd&quot;:true,&quot;SessionId&quot;:&quot;text-11111111-2222-4333-8444-555555555555&quot;,&quot;StreamId&quot;:&quot;1&quot;,&quot;StartTime&quot;:1794560400000,&quot;EndTime&quot;:1794560400123,&quot;ControlParamsList&quot;:[{&quot;Type&quot;:&quot;Voice&quot;}],&quot;Extras&quot;:{&quot;DebugInfo&quot;:&quot;{}&quot;}}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TrialDialogueResponseBodyData Data { get; set; }
        public class TrialDialogueResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The robot reply text in the current streaming event. It may be returned across multiple SSE events, or it may be empty in the end event or debug event. Do not equate missing text with session failure. Whether the content is incremental or cumulative is determined by the output convention of the dialogue engine. The current general callback directly forwards the engine content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sure, let me introduce the handling process to you</para>
            /// </summary>
            [NameInMap("Answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            /// <summary>
            /// <para>The robot control commands attached to this reply. The current POP structure only expands the command Type and does not add other command fields in this document. When no control commands are generated, the text service supplements a Voice type command.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;Type&quot;:&quot;Voice&quot;}]</para>
            /// </summary>
            [NameInMap("ControlParamsList")]
            [Validation(Required=false)]
            public List<TrialDialogueResponseBodyDataControlParamsList> ControlParamsList { get; set; }
            public class TrialDialogueResponseBodyDataControlParamsList : TeaModel {
                /// <summary>
                /// <para>The values declared in the control command type include Voice (voice reply), HangUp (hang up), Transfer (transfer), GatherDtmf (collect key presses), and SendSms (send SMS). This update supplements SendSms, which was omitted in the original description, without changing the backend structure or runtime enumeration constraints.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Voice</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The UNIX timestamp of the current streaming reply callback event, in milliseconds. It is generated based on the current callback time. It may also be returned when StreamEnd=false, and should not be directly interpreted as the end time of the entire conversation or call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1794560400123</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The extended information object attached to the robot reply, which is different from the JSON event array of the request parameter Extras. The current POP expands the DebugInfo field. Whether it is actually returned depends on the engine used and the current turn of reply.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;DebugInfo&quot;:&quot;{}&quot;}</para>
            /// </summary>
            [NameInMap("Extras")]
            [Validation(Required=false)]
            public TrialDialogueResponseBodyDataExtras Extras { get; set; }
            public class TrialDialogueResponseBodyDataExtras : TeaModel {
                /// <summary>
                /// <para>The debug information returned by the dialogue engine as a JSON string. It is returned only when the engine provides the debug information, and may be returned with supplementary events after the reply ends. The internal structure is determined by the engine. The example empty object string does not declare any fixed debug fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("DebugInfo")]
                [Validation(Required=false)]
                public string DebugInfo { get; set; }

            }

            /// <summary>
            /// <para>The session ID used to uniquely associate this interaction. For a text conversation, it is the text- identifier returned when the conversation is started. For web voice, it is the ws- identifier. For real number outbound call tests, it is the test- identifier. Subsequent calls must use the actual return value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-11111111-2222-4333-8444-555555555555</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp recorded when the streaming reply callback is entered for the first time in this turn, in milliseconds. Subsequent events in this turn use this time. It is not the session creation time, nor is it an update time in the general sense.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1794560400000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the streaming output for the current reply turn has ended. A value of true indicates that the streaming output has ended and the service has completed the corresponding SSE response. A value of false indicates that there may still be subsequent events in this turn. This field does not indicate that the entire conversation or voice call has ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StreamEnd")]
            [Validation(Required=false)]
            public bool? StreamEnd { get; set; }

            /// <summary>
            /// <para>The ID of the conversation turn to which this robot reply belongs. The same turn of reply can contain multiple streaming events. The text conversation context starts from 0 and increments during subsequent Dialogue calls. The actual return value of the engine shall prevail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StreamId")]
            [Validation(Required=false)]
            public string StreamId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code recorded in the business response body. A normal return is 200. To determine whether the business is successful, you should also check Code. You cannot determine that the call is successful solely based on the presence of this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The business response or error description. It is usually empty or not returned upon success, and you cannot require a fixed text to be returned upon success. Upon failure, it is an error description used to assist troubleshooting, and should be combined with Code and Params to understand the cause of the error. The example is an error message when the experience link visitor token expires (corresponding to Code Expired.VisitorToken), and is for format reference only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VisitorToken: example-visitor-token is expired.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of parameters used for the localized display of error messages, which are not scenario variables or business results. A normal successful response is usually an empty array. When an error occurs, parameters corresponding to the error template may be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The ID used to associate and troubleshoot this POP request. The value in the response corresponds to this request. System request parameters are injected by the gateway, and the caller does not need to fill in system fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAAAA-BBBB-4CCC-8DDD-EEEEEEEEEEEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
