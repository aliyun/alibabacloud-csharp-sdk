// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitAIAgentVideoAuditTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AI agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*<b><b><b>3b3d94abda22</b></b></b></para>
        /// </summary>
        [NameInMap("AIAgentId")]
        [Validation(Required=false)]
        public string AIAgentId { get; set; }

        /// <summary>
        /// <para>The interval, in milliseconds, at which to submit captured frames to the AI agent. Valid values: 0 to 5000. Default value: 3000. If it is set to 0, all captured frames are sent to the model in a single batch request. Otherwise, frames are sent sequentially with the specified interval between each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("AuditInterval")]
        [Validation(Required=false)]
        public int? AuditInterval { get; set; }

        /// <summary>
        /// <para>Callback configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Url&quot;:&quot;<a href="https://yourcallback%22,%22Token%22:%22yourtoken%22%7D">https://yourcallback&quot;,&quot;Token&quot;:&quot;yourtoken&quot;}</a></para>
        /// </summary>
        [NameInMap("CallbackConfig")]
        [Validation(Required=false)]
        public SubmitAIAgentVideoAuditTaskRequestCallbackConfig CallbackConfig { get; set; }
        public class SubmitAIAgentVideoAuditTaskRequestCallbackConfig : TeaModel {
            /// <summary>
            /// <para>The authentication token for callback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bearer Token</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The URL for receiving callback notifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://yourcallback">https://yourcallback</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>An array of frame-capturing policies. Each policy defines a set of frames to be analyzed and will generate a separate result from the model.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CapturePolicies")]
        [Validation(Required=false)]
        public List<SubmitAIAgentVideoAuditTaskRequestCapturePolicies> CapturePolicies { get; set; }
        public class SubmitAIAgentVideoAuditTaskRequestCapturePolicies : TeaModel {
            /// <summary>
            /// <para>The duration over which to capture the specified number of frames. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The number of frames to capture.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FrameCount")]
            [Validation(Required=false)]
            public int? FrameCount { get; set; }

            /// <summary>
            /// <para>The text prompt to send to the MLLM along with the captured frames.</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>The timestamp in the video at which to start capturing frames. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The details of the input file.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitAIAgentVideoAuditTaskRequestInput Input { get; set; }
        public class SubmitAIAgentVideoAuditTaskRequestInput : TeaModel {
            /// <summary>
            /// <para>The OSS URL of the input file. Format:</para>
            /// <para>http(s)://{BucketName}.{Endpoint}/{ObjectName}</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://my-bucket.cn-shanghai.aliyuncs.com/object-id.mp4">http://my-bucket.cn-shanghai.aliyuncs.com/object-id.mp4</a></para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the input file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS: an OSS object.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The user-defined data.</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
