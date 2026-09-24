// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryConversationDetailInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryConversationDetailInfoResponseBodyData Data { get; set; }
        public class QueryConversationDetailInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique ID of the call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231231231213^11231231231</para>
            /// </summary>
            [NameInMap("CallId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            /// <summary>
            /// <para>The call result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CALL_FORWARDING: Call forwarding.</description></item>
            /// <item><description>INCOMING_CALL_BARRED: Incoming call barred.</description></item>
            /// <item><description>CALL_REJECTED: Call rejected.</description></item>
            /// <item><description>ANSWERED: Answered by user.</description></item>
            /// <item><description>USER_BUSY: Callee busy.</description></item>
            /// <item><description>POWERED_OFF: Powered off.</description></item>
            /// <item><description>NO_USER_RESPONSE: Out of service area.</description></item>
            /// <item><description>OPERATOR_BLOCK: Blocked by carrier.</description></item>
            /// <item><description>OTHERS: Other status.</description></item>
            /// <item><description>SUSPEND: Service suspended.</description></item>
            /// <item><description>CANCEL: Canceled by caller.</description></item>
            /// <item><description>INVALID_NUMBER: Invalid number.</description></item>
            /// <item><description>UNAVAILABLE: Temporarily unavailable.</description></item>
            /// <item><description>NETWORK_BUSY: Network busy.</description></item>
            /// <item><description>NO_ANSWER: No answer.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ANSWERED</para>
            /// </summary>
            [NameInMap("CallResult")]
            [Validation(Required=false)]
            public string CallResult { get; set; }

            /// <summary>
            /// <para>The callee number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>186******</para>
            /// </summary>
            [NameInMap("CalledPhone")]
            [Validation(Required=false)]
            public string CalledPhone { get; set; }

            /// <summary>
            /// <para>The caller number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0571*******</para>
            /// </summary>
            [NameInMap("CallerPhone")]
            [Validation(Required=false)]
            public string CallerPhone { get; set; }

            /// <summary>
            /// <para>The chat record information. The structure is a JSON array, and the chat records are sorted in chronological order. The format is as follows:</para>
            /// <pre><code class="language-json">[
            ///     {
            ///         &quot;content&quot;:&quot;Chat content&quot;,
            ///         &quot;role&quot;:&quot;Role&quot;,//Valid values: user, assistant (robot)
            ///     }
            /// ]
            /// </c></pre>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///   {
            ///     &quot;content&quot;: &quot;111您好，年龄222，性别男，我这边是<b>汽车的官方顾问，我们新出了一款车型为</b>；<b>已经上市了，售价</b>万元起，<b>分钟破*台，您看要不了解一下？&quot;,
            ///     &quot;role&quot;: &quot;assistant&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;&lt;客户打断&gt;哎，你是谁？&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;&lt;客户打断&gt;你再说一遍。&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;哎，我没听清。&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;你在说什么？&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;您好，&quot;,
            ///     &quot;role&quot;: &quot;assistant&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;我是</b>汽车总部销售服务顾问。&quot;,
            ///     &quot;role&quot;: &quot;assistant&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;我们最近推出了一款新车**，想了解一下您是否对这款车型感兴趣？&quot;,
            ///     &quot;role&quot;: &quot;assistant&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;&lt;客户打断&gt;哎，那我是谁？&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;你在说什么呢？&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;抱歉打扰了，111先生。&quot;,
            ///     &quot;role&quot;: &quot;assistant&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;祝您生活愉快！再见！&quot;,
            ///     &quot;role&quot;: &quot;assistant&quot;
            ///   }
            /// ]</para>
            /// </summary>
            [NameInMap("ConversationRecord")]
            [Validation(Required=false)]
            public string ConversationRecord { get; set; }

            /// <summary>
            /// <para>The call duration, in seconds. The value is 0 if the call is not connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("EncryptionType")]
            [Validation(Required=false)]
            public string EncryptionType { get; set; }

            /// <summary>
            /// <para>The failure reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Actively canceled</para>
            /// </summary>
            [NameInMap("FailedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// <para>The hangup direction. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: User.</description></item>
            /// <item><description><b>1</b>: Robot.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("HangupDirection")]
            [Validation(Required=false)]
            public string HangupDirection { get; set; }

            /// <summary>
            /// <para>The major intent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>D</para>
            /// </summary>
            [NameInMap("MajorIntent")]
            [Validation(Required=false)]
            public string MajorIntent { get; set; }

            /// <summary>
            /// <para>The external business serial number. You can use a unique ID for business association.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bb3bc32d-54b8-49c4-80d3-61583417d22e</para>
            /// </summary>
            [NameInMap("OutId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            /// <summary>
            /// <para>The list of output tags.</para>
            /// </summary>
            [NameInMap("OutputTags")]
            [Validation(Required=false)]
            public List<QueryConversationDetailInfoResponseBodyDataOutputTags> OutputTags { get; set; }
            public class QueryConversationDetailInfoResponseBodyDataOutputTags : TeaModel {
                /// <summary>
                /// <para>The tag ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9ca2*****************************</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The tag description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Evaluate the customer\&quot;s interest in the vehicle model and purchase likelihood</para>
                /// </summary>
                [NameInMap("OutputTagDescription")]
                [Validation(Required=false)]
                public string OutputTagDescription { get; set; }

                /// <summary>
                /// <para>The tag name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Customer intent level</para>
                /// </summary>
                [NameInMap("OutputTagName")]
                [Validation(Required=false)]
                public string OutputTagName { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;High (very positive, high conversion probability)&quot;]</para>
                /// </summary>
                [NameInMap("OutputTagValue")]
                [Validation(Required=false)]
                public string OutputTagValue { get; set; }

            }

            /// <summary>
            /// <para>The time when the call was answered. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1754617273000</para>
            /// </summary>
            [NameInMap("PickUpTime")]
            [Validation(Required=false)]
            public long? PickUpTime { get; set; }

            /// <summary>
            /// <para>The download URL of the recording file. This field is available only after a recording file is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://********</para>
            /// </summary>
            [NameInMap("RecordingFileDownloadUrl")]
            [Validation(Required=false)]
            public string RecordingFileDownloadUrl { get; set; }

            /// <summary>
            /// <para>The time when the call ended. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <para>The time when the call started. This value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123123123123</para>
            /// </summary>
            [NameInMap("StartCallTime")]
            [Validation(Required=false)]
            public long? StartCallTime { get; set; }

            /// <summary>
            /// <para>The call status code. For more information, see <a href="https://help.aliyun.com/document_detail/112804.html">Call status codes</a> in Voice Messaging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200005</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// <para>The call status information returned by the carrier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Call ended (dual call)</para>
            /// </summary>
            [NameInMap("StatusMsg")]
            [Validation(Required=false)]
            public string StatusMsg { get; set; }

            /// <summary>
            /// <para>The list of call variables. These are the call variables associated with the call task you created.</para>
            /// </summary>
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<QueryConversationDetailInfoResponseBodyDataVariables> Variables { get; set; }
            public class QueryConversationDetailInfoResponseBodyDataVariables : TeaModel {
                /// <summary>
                /// <para>The variable ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The variable key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether the variable is required. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Required.</para>
                /// </description></item>
                /// <item><description><para>false: Not required.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                /// <summary>
                /// <para>The variable source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample value</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The variable value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2051E18-FF3F-5C08-8D24-6F150D2AF757</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
