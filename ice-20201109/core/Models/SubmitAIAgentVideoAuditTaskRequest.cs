// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitAIAgentVideoAuditTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*<b><b><b>3b3d94abda22</b></b></b></para>
        /// </summary>
        [NameInMap("AIAgentId")]
        [Validation(Required=false)]
        public string AIAgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("AuditInterval")]
        [Validation(Required=false)]
        public int? AuditInterval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Url&quot;:&quot;<a href="https://yourcallback%22,%22Token%22:%22yourtoken%22%7D">https://yourcallback&quot;,&quot;Token&quot;:&quot;yourtoken&quot;}</a></para>
        /// </summary>
        [NameInMap("CallbackConfig")]
        [Validation(Required=false)]
        public SubmitAIAgentVideoAuditTaskRequestCallbackConfig CallbackConfig { get; set; }
        public class SubmitAIAgentVideoAuditTaskRequestCallbackConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Bearer Token</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://yourcallback">https://yourcallback</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CapturePolicies")]
        [Validation(Required=false)]
        public List<SubmitAIAgentVideoAuditTaskRequestCapturePolicies> CapturePolicies { get; set; }
        public class SubmitAIAgentVideoAuditTaskRequestCapturePolicies : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FrameCount")]
            [Validation(Required=false)]
            public int? FrameCount { get; set; }

            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitAIAgentVideoAuditTaskRequestInput Input { get; set; }
        public class SubmitAIAgentVideoAuditTaskRequestInput : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://my-bucket.cn-shanghai.aliyuncs.com/object-id.mp4">http://my-bucket.cn-shanghai.aliyuncs.com/object-id.mp4</a></para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
