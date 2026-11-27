// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiCallDetailPageResponseBody : TeaModel {
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAiCallDetailPageResponseBodyData Data { get; set; }
        public class QueryAiCallDetailPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of task details.</para>
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
                /// <para>Default branch</para>
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
                /// <para>The expiration time of the outbound call detail. The value is a timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1785412820000</para>
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
                /// <para>Answered</para>
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
                /// <para>The call time. The value is a timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1748948749000</para>
                /// </summary>
                [NameInMap("CallingTime")]
                [Validation(Required=false)]
                public long? CallingTime { get; set; }

                /// <summary>
                /// <para>The call duration. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ConversationDuration")]
                [Validation(Required=false)]
                public long? ConversationDuration { get; set; }

                /// <summary>
                /// <para>The chat record information. The structure is a JSON array, and the chat records are sorted in chronological order. Details:</para>
                /// <pre><code class="language-json">[
                ///     {
                ///         &quot;content&quot;:&quot;Chat content&quot;,
                ///         &quot;role&quot;:&quot;Role&quot;,//Valid values: user (user), assistant (robot)
                ///     }
                /// ]
                /// </c></pre>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///     {
                ///         &quot;content&quot;: &quot;Hello 111, age 222, gender male. I am the official consultant for ** Motors. We have launched a new model, **. ** is now on the market with a starting price of ** 10,000 yuan. It sold * units in ** minutes. Would you like to learn more?&quot;,
                ///         &quot;role&quot;: &quot;assistant&quot;
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;<Customer interruption> Hey, who are you?&quot;,
                ///         &quot;role&quot;: &quot;user&quot;
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;<Customer interruption> Say that again.&quot;,
                ///         &quot;role&quot;: &quot;user&quot;
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;Hey, I didn&quot;t catch that.&quot;,
                ///         &quot;role&quot;: &quot;user&quot;
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;What are you saying?&quot;,
                ///         &quot;role&quot;: &quot;user&quot;
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;Hello,&quot;,
                ///         &quot;role&quot;: &quot;assistant&quot;
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;I am a sales service consultant at ** Motors headquarters.&quot;,
                ///         &quot;role&quot;: &quot;assistant&quot;
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;We recently launched a new car, **. I would like to know if you are interested in this model.&quot;,
                ///         &quot;role&quot;: &quot;assistant&quot;
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;<Customer interruption> Hey, then who am I?&quot;,
                ///         &quot;role&quot;: &quot;user&quot;
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;What are you talking about?&quot;,
                ///         &quot;role&quot;: &quot;user&quot;
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;Sorry to bother you, Mr. 111.&quot;,
                ///         &quot;role&quot;: &quot;assistant&quot;
                ///     },
                ///     {
                ///         &quot;content&quot;: &quot;Have a great day! Goodbye!&quot;,
                ///         &quot;role&quot;: &quot;assistant&quot;
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
                /// <para>The encryption method. Valid values: 0: No encryption. 1: MD5. 2: SHA256. 3: SM3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EncryptionType")]
                [Validation(Required=false)]
                public long? EncryptionType { get; set; }

                /// <summary>
                /// <para>The reason for the call failure. This field is returned only when the call fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Account suspended</para>
                /// </summary>
                [NameInMap("FailedReason")]
                [Validation(Required=false)]
                public string FailedReason { get; set; }

                /// <summary>
                /// <para>The import time. The value is a timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1748948749000</para>
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
                /// <para>The custom business transaction ID provided by the caller. You can use a unique ID to associate the business.</para>
                /// 
                /// <b>Example:</b>
                /// <para>outId</para>
                /// </summary>
                [NameInMap("OutId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                /// <summary>
                /// <para>The download path of the recording file. This field is returned only after the recording file is generated.</para>
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
                /// <item><description>0: Initialized.</description></item>
                /// <item><description>1: Waiting for call.</description></item>
                /// <item><description>2: Waiting for retry.</description></item>
                /// <item><description>3: Calling.</description></item>
                /// <item><description>4: Call ended.</description></item>
                /// <item><description>5: Call failed.</description></item>
                /// </list>
                /// <para>Only 4 and 5 are final states.</para>
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
                /// <para>Default version</para>
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
        /// <para>The status message.</para>
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
        /// <para>A57441B2-8EB6-5B93-9F37-0A51B8E2C9F5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
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
