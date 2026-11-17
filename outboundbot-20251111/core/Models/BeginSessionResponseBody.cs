// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class BeginSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The text conversation reply.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Answer&quot;:&quot;Hello, how can I help you?&quot;,&quot;StreamEnd&quot;:true,&quot;SessionId&quot;:&quot;text-11111111-2222-4333-8444-555555555555&quot;,&quot;StreamId&quot;:&quot;0&quot;,&quot;StartTime&quot;:1794560400000,&quot;EndTime&quot;:1794560400123,&quot;ControlParamsList&quot;:[{&quot;Type&quot;:&quot;Voice&quot;}],&quot;Extras&quot;:{&quot;DebugInfo&quot;:&quot;{}&quot;}}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BeginSessionResponseBodyData Data { get; set; }
        public class BeginSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reply content from the robot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello, how can I help you?</para>
            /// </summary>
            [NameInMap("Answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            /// <summary>
            /// <para>The list of robot control instructions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;Type&quot;:&quot;Voice&quot;}]</para>
            /// </summary>
            [NameInMap("ControlParamsList")]
            [Validation(Required=false)]
            public List<BeginSessionResponseBodyDataControlParamsList> ControlParamsList { get; set; }
            public class BeginSessionResponseBodyDataControlParamsList : TeaModel {
                /// <summary>
                /// <para>The type of the control instruction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Voice</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The time when the current reply event is sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1794560400123</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The extended information of the reply.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;DebugInfo&quot;:&quot;{}&quot;}</para>
            /// </summary>
            [NameInMap("Extras")]
            [Validation(Required=false)]
            public BeginSessionResponseBodyDataExtras Extras { get; set; }
            public class BeginSessionResponseBodyDataExtras : TeaModel {
                /// <summary>
                /// <para>The debug information of the conversation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("DebugInfo")]
                [Validation(Required=false)]
                public string DebugInfo { get; set; }

            }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-11111111-2222-4333-8444-555555555555</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The time of the first reply event in the current round.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1794560400000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the response stream for the current round has ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StreamEnd")]
            [Validation(Required=false)]
            public bool? StreamEnd { get; set; }

            /// <summary>
            /// <para>The reply round ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StreamId")]
            [Validation(Required=false)]
            public string StreamId { get; set; }

        }

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
        /// <para>The business message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of error message parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAAAA-BBBB-4CCC-8DDD-EEEEEEEEEEEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
