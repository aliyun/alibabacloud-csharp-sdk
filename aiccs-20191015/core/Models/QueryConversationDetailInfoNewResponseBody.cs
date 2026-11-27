// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryConversationDetailInfoNewResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reasons for access denial.</para>
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
            /// <para>The branch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("BranchId")]
            [Validation(Required=false)]
            public long? BranchId { get; set; }

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
            /// <item><description>CALL_FORWARDING: call forwarding</description></item>
            /// <item><description>INCOMING_CALL_BARRED: incoming call barred</description></item>
            /// <item><description>CALL_REJECTED: call rejected</description></item>
            /// <item><description>ANSWERED: answered</description></item>
            /// <item><description>USER_BUSY: callee busy</description></item>
            /// <item><description>POWERED_OFF: powered off</description></item>
            /// <item><description>NO_USER_RESPONSE: out of service area</description></item>
            /// <item><description>OPERATOR_BLOCK: blocked by carrier</description></item>
            /// <item><description>OTHERS: other statuses</description></item>
            /// <item><description>SUSPEND: suspended</description></item>
            /// <item><description>CANCEL: canceled by caller</description></item>
            /// <item><description>INVALID_NUMBER: invalid number</description></item>
            /// <item><description>UNAVAILABLE: temporarily unavailable</description></item>
            /// <item><description>NETWORK_BUSY: network busy</description></item>
            /// <item><description>NO_ANSWER: no answer</description></item>
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
            /// <para>130********</para>
            /// </summary>
            [NameInMap("CalledPhone")]
            [Validation(Required=false)]
            public string CalledPhone { get; set; }

            /// <summary>
            /// <para>The calling number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0571*******</para>
            /// </summary>
            [NameInMap("CallerPhone")]
            [Validation(Required=false)]
            public string CallerPhone { get; set; }

            /// <summary>
            /// <para>The chat record information. The structure is a JSON array. The chat records are sorted in chronological order. Details:</para>
            /// <pre><code class="language-json">[
            ///     {
            ///         &quot;content&quot;:&quot;Chat content&quot;,
            ///         &quot;role&quot;:&quot;Role&quot;,//Valid values: user (user), assistant (chatbot)
            ///     }
            /// ]
            /// </c></pre>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///   {
            ///     &quot;content&quot;: &quot;Hello 111, age 222, male. I am the official consultant for ** Motors. We have launched a new model, **; it is now on the market with a starting price of ** ten thousand yuan, and * units were sold in ** minutes. Would you like to know more?&quot;,
            ///     &quot;role&quot;: &quot;assistant&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;<Customer interruption> Hey, who are you?&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;<Customer interruption> Say that again.&quot;,
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
            /// <para>The encryption method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: no encryption</description></item>
            /// <item><description>1: MD5</description></item>
            /// <item><description>2: SHA256</description></item>
            /// <item><description>3: SM3</description></item>
            /// </list>
            /// 
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
            /// <para>Manually canceled</para>
            /// </summary>
            [NameInMap("FailedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// <para>The list of frozen skill snapshots at the start of the call.</para>
            /// </summary>
            [NameInMap("FrozenSkills")]
            [Validation(Required=false)]
            public List<QueryConversationDetailInfoNewResponseBodyDataFrozenSkills> FrozenSkills { get; set; }
            public class QueryConversationDetailInfoNewResponseBodyDataFrozenSkills : TeaModel {
                /// <summary>
                /// <para>The load mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PRELOAD / ON_DEMAND</para>
                /// </summary>
                [NameInMap("LoadMode")]
                [Validation(Required=false)]
                public string LoadMode { get; set; }

                /// <summary>
                /// <para>The skill business ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111111</para>
                /// </summary>
                [NameInMap("SkillId")]
                [Validation(Required=false)]
                public string SkillId { get; set; }

                /// <summary>
                /// <para>The skill name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Name</para>
                /// </summary>
                [NameInMap("SkillName")]
                [Validation(Required=false)]
                public string SkillName { get; set; }

                /// <summary>
                /// <para>The frozen skill version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>V3-Test</para>
                /// </summary>
                [NameInMap("SkillVersion")]
                [Validation(Required=false)]
                public string SkillVersion { get; set; }

                /// <summary>
                /// <para>The version policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PINNED / FOLLOW_CURRENT</para>
                /// </summary>
                [NameInMap("VersionPolicy")]
                [Validation(Required=false)]
                public string VersionPolicy { get; set; }

            }

            /// <summary>
            /// <para>The hang-up direction. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: user</description></item>
            /// <item><description><b>1</b>: chatbot</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HangupDirection")]
            [Validation(Required=false)]
            public string HangupDirection { get; set; }

            /// <summary>
            /// <para>The import time. The value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>43</para>
            /// </summary>
            [NameInMap("ImportedTime")]
            [Validation(Required=false)]
            public long? ImportedTime { get; set; }

            /// <summary>
            /// <para>The primary intent.</para>
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
            ///   &quot;sex&quot;: &quot;Male&quot;,
            ///   &quot;name&quot;: &quot;111&quot;,
            ///   &quot;age&quot;: &quot;222&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            /// <summary>
            /// <para>The business transaction ID passed from external systems. You can use a unique ID to associate business data.</para>
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
                /// <para>Evaluate the customer&quot;s interest in the vehicle model and purchase likelihood</para>
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
                /// <para>[&quot;High (very positive, high probability of conversion)&quot;]</para>
                /// </summary>
                [NameInMap("OutputTagValue")]
                [Validation(Required=false)]
                public string OutputTagValue { get; set; }

            }

            /// <summary>
            /// <para>The time when the call was answered. The value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12349732441</para>
            /// </summary>
            [NameInMap("PickUpTime")]
            [Validation(Required=false)]
            public long? PickUpTime { get; set; }

            /// <summary>
            /// <para>The download URL of the recording file. This field is returned only after the recording file is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>recording.oss.file</para>
            /// </summary>
            [NameInMap("RecordingFileDownloadUrl")]
            [Validation(Required=false)]
            public string RecordingFileDownloadUrl { get; set; }

            /// <summary>
            /// <para>The time when the call ended. The value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <para>The time when the call started. The value is a timestamp in milliseconds.</para>
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
            /// <para>The call status code. For more information, see <a href="https://help.aliyun.com/document_detail/112804.html">Call status codes</a> in Voice Messaging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200005</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// <para>The call status message returned by the carrier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Call ended (two-way call)</para>
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
                /// <para>Specifies whether the variable is required.</para>
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
        /// <para>Specifies whether the operation was called successfully. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: success</description></item>
        /// <item><description><b>false</b>: failure</description></item>
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
