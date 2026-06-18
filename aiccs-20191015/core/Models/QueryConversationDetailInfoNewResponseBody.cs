// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryConversationDetailInfoNewResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why access was denied.</para>
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
        public QueryConversationDetailInfoNewResponseBodyData Data { get; set; }
        public class QueryConversationDetailInfoNewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The batch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234******</para>
            /// </summary>
            [NameInMap("BatchId")]
            [Validation(Required=false)]
            public string BatchId { get; set; }

            /// <summary>
            /// <para>The unique ID of the call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123*<b><b><b>^213</b></b></b></para>
            /// </summary>
            [NameInMap("CallId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            /// <summary>
            /// <para>The call result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CALL_FORWARDING: call forwarding.</description></item>
            /// <item><description>INCOMING_CALL_BARRED: incoming call barred.</description></item>
            /// <item><description>CALL_REJECTED: call rejected.</description></item>
            /// <item><description>ANSWERED: the user answered.</description></item>
            /// <item><description>USER_BUSY: the callee is busy.</description></item>
            /// <item><description>POWERED_OFF: the phone is powered off.</description></item>
            /// <item><description>NO_USER_RESPONSE: out of service area.</description></item>
            /// <item><description>OPERATOR_BLOCK: blocked by the carrier.</description></item>
            /// <item><description>OTHERS: other status.</description></item>
            /// <item><description>SUSPEND: the phone is suspended.</description></item>
            /// <item><description>CANCEL: the caller canceled.</description></item>
            /// <item><description>INVALID_NUMBER: invalid number.</description></item>
            /// <item><description>UNAVAILABLE: temporarily unavailable.</description></item>
            /// <item><description>NETWORK_BUSY: network busy.</description></item>
            /// <item><description>NO_ANSWER: no answer.</description></item>
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
            /// <para>130********</para>
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
            /// <para>The chat record information. The structure is a JSON array, and the chat records are sorted in chronological order. The structure is as follows:</para>
            /// <pre><code class="language-json">[
            ///     {
            ///         &quot;content&quot;:&quot;聊天内容&quot;,
            ///         &quot;role&quot;:&quot;角色&quot;,//Valid values: user and assistant (robot).
            ///     }
            /// ]
            /// ```.
            /// </c></pre>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///   {
            ///     &quot;content&quot;: &quot;111您好，年龄222，性别男，我这边是<b>汽车的官方顾问，我们新出了一款车型为</b>；<b>已经上市了，售价</b>万元起，*<em>分钟破</em>台，您看要不了解一下？&quot;,
            ///     &quot;role&quot;: &quot;assistant&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;&lt;客户打断&gt;哎，你是谁？&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;&lt;客户打断&gt;你再说一遍。&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   }]</para>
            /// </summary>
            [NameInMap("ConversationRecord")]
            [Validation(Required=false)]
            public string ConversationRecord { get; set; }

            /// <summary>
            /// <para>The number of conversation turns.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("ConversationTurnCount")]
            [Validation(Required=false)]
            public long? ConversationTurnCount { get; set; }

            /// <summary>
            /// <para>The task detail ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234*******</para>
            /// </summary>
            [NameInMap("DetailId")]
            [Validation(Required=false)]
            public string DetailId { get; set; }

            /// <summary>
            /// <para>The call duration. The value is 0 if the call is not connected. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>28</para>
            /// </summary>
            [NameInMap("EncryptionType")]
            [Validation(Required=false)]
            public long? EncryptionType { get; set; }

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
            /// <para>The hangup direction. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: the user.</description></item>
            /// <item><description><b>1</b>: the robot.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HangupDirection")]
            [Validation(Required=false)]
            public string HangupDirection { get; set; }

            /// <summary>
            /// <para>The import time. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>43</para>
            /// </summary>
            [NameInMap("ImportedTime")]
            [Validation(Required=false)]
            public long? ImportedTime { get; set; }

            /// <summary>
            /// <para>The major intent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A</para>
            /// </summary>
            [NameInMap("MajorIntent")]
            [Validation(Required=false)]
            public string MajorIntent { get; set; }

            /// <summary>
            /// <para>The variable information used at runtime. The information is stored in this field as key-value pairs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;date&quot;: &quot;666&quot;,
            ///   &quot;phoneNumber&quot;: &quot;777&quot;,
            ///   &quot;distance&quot;: &quot;555&quot;,
            ///   &quot;mendian&quot;: &quot;444&quot;,
            ///   &quot;sex&quot;: &quot;男&quot;,
            ///   &quot;name&quot;: &quot;111&quot;,
            ///   &quot;age&quot;: &quot;222&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            /// <summary>
            /// <para>The external business serial number. You can use a unique ID for business association.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123***</para>
            /// </summary>
            [NameInMap("OutId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            /// <summary>
            /// <para>The output tag information.</para>
            /// </summary>
            [NameInMap("OutputTags")]
            [Validation(Required=false)]
            public List<QueryConversationDetailInfoNewResponseBodyDataOutputTags> OutputTags { get; set; }
            public class QueryConversationDetailInfoNewResponseBodyDataOutputTags : TeaModel {
                /// <summary>
                /// <para>The tag ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
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
            /// <para>The time when the call was answered. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12349732441</para>
            /// </summary>
            [NameInMap("PickUpTime")]
            [Validation(Required=false)]
            public long? PickUpTime { get; set; }

            /// <summary>
            /// <para>The download URL of the recording file. This field is available only after a recording file is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>recording.oss.file</para>
            /// </summary>
            [NameInMap("RecordingFileDownloadUrl")]
            [Validation(Required=false)]
            public string RecordingFileDownloadUrl { get; set; }

            /// <summary>
            /// <para>The time when the call ended. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <para>The time when the call started. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1286987391</para>
            /// </summary>
            [NameInMap("StartCallTime")]
            [Validation(Required=false)]
            public long? StartCallTime { get; set; }

            /// <summary>
            /// <para>The agent status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>72</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The call status code. For more information, see <a href="https://help.aliyun.com/document_detail/112804.html">Call status codes</a> in voice messaging.</para>
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
            /// <para>呼叫结束（双呼）</para>
            /// </summary>
            [NameInMap("StatusMsg")]
            [Validation(Required=false)]
            public string StatusMsg { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>138************</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The call variable information.</para>
            /// </summary>
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<QueryConversationDetailInfoNewResponseBodyDataVariables> Variables { get; set; }
            public class QueryConversationDetailInfoNewResponseBodyDataVariables : TeaModel {
                /// <summary>
                /// <para>The variable ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
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
                /// <para>user name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether the variable is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                /// <summary>
                /// <para>The source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>source</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The variable value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mike</para>
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
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: successful.</description></item>
        /// <item><description><b>false</b>: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
