// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryConversationDetailInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
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
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryConversationDetailInfoResponseBodyData Data { get; set; }
        public class QueryConversationDetailInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique call ID.</para>
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
            /// <item><description><para><c>CALL_FORWARDING</c>: Call forwarding.</para>
            /// </description></item>
            /// <item><description><para><c>INCOMING_CALL_BARRED</c>: Incoming call barred.</para>
            /// </description></item>
            /// <item><description><para><c>CALL_REJECTED</c>: Call rejected.</para>
            /// </description></item>
            /// <item><description><para><c>ANSWERED</c>: Answered by user.</para>
            /// </description></item>
            /// <item><description><para><c>USER_BUSY</c>: Called party busy.</para>
            /// </description></item>
            /// <item><description><para><c>POWERED_OFF</c>: Powered off.</para>
            /// </description></item>
            /// <item><description><para><c>NO_USER_RESPONSE</c>: Out of service area.</para>
            /// </description></item>
            /// <item><description><para><c>OPERATOR_BLOCK</c>: Blocked by carrier.</para>
            /// </description></item>
            /// <item><description><para><c>OTHERS</c>: Other.</para>
            /// </description></item>
            /// <item><description><para><c>SUSPEND</c>: Suspended.</para>
            /// </description></item>
            /// <item><description><para><c>CANCEL</c>: Canceled by caller.</para>
            /// </description></item>
            /// <item><description><para><c>INVALID_NUMBER</c>: Invalid number.</para>
            /// </description></item>
            /// <item><description><para><c>UNAVAILABLE</c>: Temporarily unavailable.</para>
            /// </description></item>
            /// <item><description><para><c>NETWORK_BUSY</c>: Network busy.</para>
            /// </description></item>
            /// <item><description><para><c>NO_ANSWER</c>: No answer.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ANSWERED</para>
            /// </summary>
            [NameInMap("CallResult")]
            [Validation(Required=false)]
            public string CallResult { get; set; }

            /// <summary>
            /// <para>The called number.</para>
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
            /// <para>The conversation record. The structure is a JSON array in which entries are sorted by time. Example:</para>
            /// <pre><code class="language-json">[
            ///     {
            ///         &quot;content&quot;:&quot;Conversation content&quot;,
            ///         &quot;role&quot;:&quot;Role&quot;, // Valid values: user, assistant
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
            /// <para>The duration of the call, in seconds. If the call was not connected, the value is 0.</para>
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
            /// <para>主动取消</para>
            /// </summary>
            [NameInMap("FailedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// <para>The party that hung up. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: user.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: assistant.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>用户</para>
            /// </summary>
            [NameInMap("HangupDirection")]
            [Validation(Required=false)]
            public string HangupDirection { get; set; }

            /// <summary>
            /// <para>The primary intent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>D</para>
            /// </summary>
            [NameInMap("MajorIntent")]
            [Validation(Required=false)]
            public string MajorIntent { get; set; }

            /// <summary>
            /// <para>The business-specific ID that is passed in. You can use this unique ID to associate the call with your business.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bb3bc32d-54b8-49c4-80d3-61583417d22e</para>
            /// </summary>
            [NameInMap("OutId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            /// <summary>
            /// <para>A list of output tags.</para>
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
                /// <para>评估客户对车型的兴趣和购买可能性</para>
                /// </summary>
                [NameInMap("OutputTagDescription")]
                [Validation(Required=false)]
                public string OutputTagDescription { get; set; }

                /// <summary>
                /// <para>The tag name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>客户意向度</para>
                /// </summary>
                [NameInMap("OutputTagName")]
                [Validation(Required=false)]
                public string OutputTagName { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;高（非常积极，大概率转化）&quot;]</para>
                /// </summary>
                [NameInMap("OutputTagValue")]
                [Validation(Required=false)]
                public string OutputTagValue { get; set; }

            }

            /// <summary>
            /// <para>The timestamp when the call was answered, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1754617273000</para>
            /// </summary>
            [NameInMap("PickUpTime")]
            [Validation(Required=false)]
            public long? PickUpTime { get; set; }

            /// <summary>
            /// <para>The download URL for the recording file. This parameter is returned only after the recording file is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://********</para>
            /// </summary>
            [NameInMap("RecordingFileDownloadUrl")]
            [Validation(Required=false)]
            public string RecordingFileDownloadUrl { get; set; }

            /// <summary>
            /// <para>The timestamp when the call ended, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the call was initiated, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123123123123</para>
            /// </summary>
            [NameInMap("StartCallTime")]
            [Validation(Required=false)]
            public long? StartCallTime { get; set; }

            /// <summary>
            /// <para>The call status code. For more information, see <a href="https://help.aliyun.com/document_detail/112804.html">Call status codes</a> for the voice service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200005</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// <para>The status message returned by the carrier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>呼叫结束（双呼）</para>
            /// </summary>
            [NameInMap("StatusMsg")]
            [Validation(Required=false)]
            public string StatusMsg { get; set; }

            /// <summary>
            /// <para>A list of variables associated with the call task.</para>
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
                /// <para>姓名</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether the variable is required. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: The variable is required.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: The variable is optional.</para>
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
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The variable value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The status code message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
