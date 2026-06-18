// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiCallDetailPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The reason why the access request was denied.</para>
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
        public QueryAiCallDetailPageResponseBodyData Data { get; set; }
        public class QueryAiCallDetailPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of task details.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryAiCallDetailPageResponseBodyDataList> List { get; set; }
            public class QueryAiCallDetailPageResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The batch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1183**************</para>
                /// </summary>
                [NameInMap("BatchId")]
                [Validation(Required=false)]
                public string BatchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>49</para>
                /// </summary>
                [NameInMap("BranchId")]
                [Validation(Required=false)]
                public long? BranchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("BranchName")]
                [Validation(Required=false)]
                public string BranchName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("BranchVersionId")]
                [Validation(Required=false)]
                public long? BranchVersionId { get; set; }

                /// <summary>
                /// <para>The call result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>用户接通</para>
                /// </summary>
                [NameInMap("CallResult")]
                [Validation(Required=false)]
                public string CallResult { get; set; }

                /// <summary>
                /// <para>The called number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0537101****</para>
                /// </summary>
                [NameInMap("CalledNumber")]
                [Validation(Required=false)]
                public string CalledNumber { get; set; }

                /// <summary>
                /// <para>The call time, formatted as a timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1748948749000</para>
                /// </summary>
                [NameInMap("CallingTime")]
                [Validation(Required=false)]
                public long? CallingTime { get; set; }

                /// <summary>
                /// <para>The conversation duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ConversationDuration")]
                [Validation(Required=false)]
                public long? ConversationDuration { get; set; }

                /// <summary>
                /// <para>The conversation record, formatted as a chronologically sorted JSON array. Each object has the following structure:</para>
                /// <pre><code class="language-json">[
                ///     {
                ///         &quot;content&quot;:&quot;The content of the message.&quot;,
                ///         &quot;role&quot;:&quot;The role of the speaker.&quot;, // Valid values: user, assistant
                ///     }
                /// ]
                /// </c></pre>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///     {
                ///         &quot;content&quot;: &quot;111您好，年龄222，性别男，我这边是<b>汽车的官方顾问，我们新出了一款车型为</b>；<b>已经上市了，售价</b>万元起，<b>分钟破*台，您看要不了解一下？&quot;,
                ///         &quot;role&quot;: &quot;assistant&quot;
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;&lt;客户打断&gt;哎，你是谁？&quot;,
                ///         &quot;role&quot;: &quot;user&quot;,
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;&lt;客户打断&gt;你再说一遍。&quot;,
                ///         &quot;role&quot;: &quot;user&quot;,
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;哎，我没听清。&quot;,
                ///         &quot;role&quot;: &quot;user&quot;,
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;你在说什么？&quot;,
                ///         &quot;role&quot;: &quot;user&quot;,
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;您好，&quot;,
                ///         &quot;role&quot;: &quot;assistant&quot;,
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;我是</b>汽车总部销售服务顾问。&quot;,
                ///         &quot;role&quot;: &quot;assistant&quot;,
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;我们最近推出了一款新车**，想了解一下您是否对这款车型感兴趣？&quot;,
                ///         &quot;role&quot;: &quot;assistant&quot;,
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;&lt;客户打断&gt;哎，那我是谁？&quot;,
                ///         &quot;role&quot;: &quot;user&quot;,
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;你在说什么呢？&quot;,
                ///         &quot;role&quot;: &quot;user&quot;,
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;抱歉打扰了，111先生。&quot;,
                ///         &quot;role&quot;: &quot;assistant&quot;,
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;祝您生活愉快！再见！&quot;,
                ///         &quot;role&quot;: &quot;assistant&quot;,
                ///     }
                /// ]</para>
                /// </summary>
                [NameInMap("ConversationRecord")]
                [Validation(Required=false)]
                public string ConversationRecord { get; set; }

                /// <summary>
                /// <para>The conversation turn count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ConversationTurnCount")]
                [Validation(Required=false)]
                public long? ConversationTurnCount { get; set; }

                /// <summary>
                /// <para>The task detail ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9662*************</para>
                /// </summary>
                [NameInMap("DetailId")]
                [Validation(Required=false)]
                public string DetailId { get; set; }

                /// <summary>
                /// <para>The encryption type. Valid values are: 0 (no encryption), 1 (MD5), 2 (SHA256), and 3 (SM3).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EncryptionType")]
                [Validation(Required=false)]
                public long? EncryptionType { get; set; }

                /// <summary>
                /// <para>The failure reason. Provided only if the call fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>账户停机</para>
                /// </summary>
                [NameInMap("FailedReason")]
                [Validation(Required=false)]
                public string FailedReason { get; set; }

                /// <summary>
                /// <para>The import time, formatted as a timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1748948749000</para>
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
                /// <para>A JSON object of key-value pairs for runtime variables.</para>
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
                /// <b>Example:</b>
                /// <para>outId</para>
                /// </summary>
                [NameInMap("OutId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                /// <summary>
                /// <para>The recording file path. Provided only after the recording file is generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://*******</para>
                /// </summary>
                [NameInMap("RecordingFilePath")]
                [Validation(Required=false)]
                public string RecordingFilePath { get; set; }

                /// <summary>
                /// <para>The task detail status.</para>
                /// <list type="bullet">
                /// <item><description><para>0: Initializing</para>
                /// </description></item>
                /// <item><description><para>1: Waiting to call</para>
                /// </description></item>
                /// <item><description><para>2: Waiting to retry</para>
                /// </description></item>
                /// <item><description><para>3: Calling</para>
                /// </description></item>
                /// <item><description><para>4: Call ended</para>
                /// </description></item>
                /// <item><description><para>5: Call failed</para>
                /// </description></item>
                /// </list>
                /// <para>Only statuses 4 and 5 are terminal states.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1187**************</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("VersionName")]
                [Validation(Required=false)]
                public string VersionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>55</para>
                /// </summary>
                [NameInMap("VersionNo")]
                [Validation(Required=false)]
                public long? VersionNo { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>A description of the status code.</para>
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
        /// <para>A57441B2-8EB6-5B93-9F37-0A51B8E2C9F5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values are:</para>
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
