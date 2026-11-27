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
            /// <item><description>CALL_FORWARDING: call forwarding</description></item>
            /// <item><description>INCOMING_CALL_BARRED: incoming calls barred</description></item>
            /// <item><description>CALL_REJECTED: call rejected</description></item>
            /// <item><description>ANSWERED: answered</description></item>
            /// <item><description>USER_BUSY: user busy</description></item>
            /// <item><description>POWERED_OFF: powered off</description></item>
            /// <item><description>NO_USER_RESPONSE: no user response</description></item>
            /// <item><description>OPERATOR_BLOCK: blocked by the carrier</description></item>
            /// <item><description>OTHERS: other statuses</description></item>
            /// <item><description>SUSPEND: suspended</description></item>
            /// <item><description>CANCEL: canceled by the caller</description></item>
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
            ///     &quot;content&quot;: &quot;111 Hello, age 222, male. I am the official consultant of ** Automobile. We have launched a new model **; ** is now on the market, starting at ** 10,000 yuan, with * units sold in ** minutes. Would you like to learn more?&quot;,
            ///     &quot;role&quot;: &quot;assistant&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;<Customer interrupts> Hey, who are you?&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;<Customer interrupts> Say that again.&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;Hey, I didn&quot;t catch that.&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;What are you saying?&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;Hello,&quot;,
            ///     &quot;role&quot;: &quot;assistant&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;I am the sales service consultant at the ** Automobile headquarters.&quot;,
            ///     &quot;role&quot;: &quot;assistant&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;We recently launched a new car, **. Would you like to know if you are interested in this model?&quot;,
            ///     &quot;role&quot;: &quot;assistant&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;<Customer interrupts> Hey, then who am I?&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;What are you talking about?&quot;,
            ///     &quot;role&quot;: &quot;user&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;Sorry to bother you, Mr. 111.&quot;,
            ///     &quot;role&quot;: &quot;assistant&quot;
            ///   },
            ///   {
            ///     &quot;content&quot;: &quot;Have a great day! Goodbye!&quot;,
            ///     &quot;role&quot;: &quot;assistant&quot;
            ///   }
            /// ]</para>
            /// </summary>
            [NameInMap("ConversationRecord")]
            [Validation(Required=false)]
            public string ConversationRecord { get; set; }

            /// <summary>
            /// <para>The duration of the call. The value is 0 if the call is not connected. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
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
            /// <para>Sample value</para>
            /// </summary>
            [NameInMap("EncryptionType")]
            [Validation(Required=false)]
            public string EncryptionType { get; set; }

            /// <summary>
            /// <para>The reason for the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Canceled by the caller</para>
            /// </summary>
            [NameInMap("FailedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            /// <summary>
            /// <para>The party that hung up. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: user</description></item>
            /// <item><description><b>1</b>: chatbot</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
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
            /// <para>The external business transaction ID. You can use a unique ID to associate business data.</para>
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
                /// <para>The ID of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9ca2*****************************</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The description of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Evaluate the customer&quot;s interest in the car model and likelihood of purchase</para>
                /// </summary>
                [NameInMap("OutputTagDescription")]
                [Validation(Required=false)]
                public string OutputTagDescription { get; set; }

                /// <summary>
                /// <para>The name of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Customer intent level</para>
                /// </summary>
                [NameInMap("OutputTagName")]
                [Validation(Required=false)]
                public string OutputTagName { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
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
            /// <para>1754617273000</para>
            /// </summary>
            [NameInMap("PickUpTime")]
            [Validation(Required=false)]
            public long? PickUpTime { get; set; }

            /// <summary>
            /// <para>The download URL of the recording file. This field is returned only after the recording file is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://********</para>
            /// </summary>
            [NameInMap("RecordingFileDownloadUrl")]
            [Validation(Required=false)]
            public string RecordingFileDownloadUrl { get; set; }

            /// <summary>
            /// <para>The time when the call ended. The value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <para>The time when the call started. The value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123123123123</para>
            /// </summary>
            [NameInMap("StartCallTime")]
            [Validation(Required=false)]
            public long? StartCallTime { get; set; }

            /// <summary>
            /// <para>The call status code. For more information, see <a href="https://help.aliyun.com/document_detail/112804.html">Call status codes</a> of Voice Messaging.</para>
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
            /// <para>The list of call variables. These are the call variables associated with the call task that you created.</para>
            /// </summary>
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<QueryConversationDetailInfoResponseBodyDataVariables> Variables { get; set; }
            public class QueryConversationDetailInfoResponseBodyDataVariables : TeaModel {
                /// <summary>
                /// <para>The ID of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The key of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The name of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Specifies whether the variable is required. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: yes</para>
                /// </description></item>
                /// <item><description><para>false: no</para>
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
                /// <para>The source of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample value</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The value of the variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Doe</para>
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
        /// <para>Success</para>
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
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
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
