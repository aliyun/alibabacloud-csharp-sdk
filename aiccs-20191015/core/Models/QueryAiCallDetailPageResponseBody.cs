// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiCallDetailPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason for access denial.</para>
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
        /// <para>The returned result data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAiCallDetailPageResponseBodyData Data { get; set; }
        public class QueryAiCallDetailPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of task detail data.</para>
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
                /// <para>The branch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49</para>
                /// </summary>
                [NameInMap("BranchId")]
                [Validation(Required=false)]
                public long? BranchId { get; set; }

                /// <summary>
                /// <para>The branch name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default branch.</para>
                /// </summary>
                [NameInMap("BranchName")]
                [Validation(Required=false)]
                public string BranchName { get; set; }

                /// <summary>
                /// <para>The version ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("BranchVersionId")]
                [Validation(Required=false)]
                public long? BranchVersionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>29</para>
                /// </summary>
                [NameInMap("CallExpireTime")]
                [Validation(Required=false)]
                public long? CallExpireTime { get; set; }

                /// <summary>
                /// <para>The call ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123<em><b><b>456^123</b></b></em>456</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>The call result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Answered.</para>
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
                /// <para>The calling time. This is a timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1748948749000</para>
                /// </summary>
                [NameInMap("CallingTime")]
                [Validation(Required=false)]
                public long? CallingTime { get; set; }

                /// <summary>
                /// <para>The conversation duration. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ConversationDuration")]
                [Validation(Required=false)]
                public long? ConversationDuration { get; set; }

                /// <summary>
                /// <para>The chat record information. The structure is a JSON array, sorted in chronological order. The format is as follows:</para>
                /// <pre><code class="language-json">[
                ///     {
                ///         &quot;content&quot;:&quot;Chat content&quot;,
                ///         &quot;role&quot;:&quot;Role&quot;,//Valid values: user, assistant (bot)
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
                /// <para>The number of conversation turns.</para>
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
                /// <para>The encryption type. Valid values: 0: no encryption. 1: MD5. 2: SHA256. 3: SM3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EncryptionType")]
                [Validation(Required=false)]
                public long? EncryptionType { get; set; }

                /// <summary>
                /// <para>The reason for call failure. This field is present only when the call fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Account suspended.</para>
                /// </summary>
                [NameInMap("FailedReason")]
                [Validation(Required=false)]
                public string FailedReason { get; set; }

                /// <summary>
                /// <para>The import time. This is a timestamp in milliseconds.</para>
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
                /// <para>The variable information used at runtime, stored in key-value format in this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;date&quot;: &quot;666&quot;,
                ///   &quot;phoneNumber&quot;: &quot;777&quot;,
                ///   &quot;distance&quot;: &quot;555&quot;,
                ///   &quot;mendian&quot;: &quot;444&quot;,
                ///   &quot;sex&quot;: &quot;male&quot;,
                ///   &quot;name&quot;: &quot;111&quot;,
                ///   &quot;age&quot;: &quot;222&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

                /// <summary>
                /// <para>The business serial number reserved for external input. A unique ID can be used for business association.</para>
                /// 
                /// <b>Example:</b>
                /// <para>outId</para>
                /// </summary>
                [NameInMap("OutId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                /// <summary>
                /// <para>The download path of the recording file. This field is present only after the recording file is generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://*******</para>
                /// </summary>
                [NameInMap("RecordingFilePath")]
                [Validation(Required=false)]
                public string RecordingFilePath { get; set; }

                /// <summary>
                /// <para>The task detail status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: initialized.</description></item>
                /// <item><description>1: waiting to call.</description></item>
                /// <item><description>2: waiting to retry.</description></item>
                /// <item><description>3: calling.</description></item>
                /// <item><description>4: call ended.</description></item>
                /// <item><description>5: call failed.</description></item>
                /// </list>
                /// <para>Only 4 and 5 are desired states.</para>
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
                /// <para>The version name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default version.</para>
                /// </summary>
                [NameInMap("VersionName")]
                [Validation(Required=false)]
                public string VersionName { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("VersionNo")]
                [Validation(Required=false)]
                public long? VersionNo { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
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
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
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
        /// <para>Indicates whether the operation was successful. Valid values:</para>
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
