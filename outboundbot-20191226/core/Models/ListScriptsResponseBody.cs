// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListScriptsResponseBody : TeaModel {
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
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
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The paginated list of scripts.</para>
        /// </summary>
        [NameInMap("Scripts")]
        [Validation(Required=false)]
        public ListScriptsResponseBodyScripts Scripts { get; set; }
        public class ListScriptsResponseBodyScripts : TeaModel {
            /// <summary>
            /// <para>The list of scripts.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListScriptsResponseBodyScriptsList> List { get; set; }
            public class ListScriptsResponseBodyScriptsList : TeaModel {
                /// <summary>
                /// <para>The agent access key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14791f5f226b4878b3d9b676a0291234</para>
                /// </summary>
                [NameInMap("AgentKey")]
                [Validation(Required=false)]
                public string AgentKey { get; set; }

                /// <summary>
                /// <para>Indicates whether the agent is an LLM agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AgentLlm")]
                [Validation(Required=false)]
                public bool? AgentLlm { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578965079000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The debug status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DRAFTED</para>
                /// </summary>
                [NameInMap("DebugStatus")]
                [Validation(Required=false)]
                public string DebugStatus { get; set; }

                /// <summary>
                /// <para>Indicates whether emotion detection is enabled. This parameter is always false for LLM-based scripts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EmotionEnable")]
                [Validation(Required=false)]
                public bool? EmotionEnable { get; set; }

                /// <summary>
                /// <para>The industry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>金融</para>
                /// </summary>
                [NameInMap("Industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                /// <summary>
                /// <para>Indicates whether the debug version of the script is a draft.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDebugDrafted")]
                [Validation(Required=false)]
                public bool? IsDebugDrafted { get; set; }

                /// <summary>
                /// <para>Indicates whether the script is a draft.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDrafted")]
                [Validation(Required=false)]
                public bool? IsDrafted { get; set; }

                /// <summary>
                /// <para>Indicates whether the script is for a preset scene.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsPreset")]
                [Validation(Required=false)]
                public bool? IsPreset { get; set; }

                /// <summary>
                /// <para>Indicates whether long wait is enabled. This parameter is always false for LLM-based scripts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("LongWaitEnable")]
                [Validation(Required=false)]
                public bool? LongWaitEnable { get; set; }

                /// <summary>
                /// <para>Indicates whether mini playback is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("MiniPlaybackEnable")]
                [Validation(Required=false)]
                public bool? MiniPlaybackEnable { get; set; }

                /// <summary>
                /// <para>Indicates whether graceful barge-in is enabled. This parameter is always false for LLM-based scripts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("NewBargeInEnable")]
                [Validation(Required=false)]
                public bool? NewBargeInEnable { get; set; }

                /// <summary>
                /// <para>The NLU access type, which is set to Managed for LLM scenarios and is empty for small model scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>空或者Managed</para>
                /// </summary>
                [NameInMap("NluAccessType")]
                [Validation(Required=false)]
                public string NluAccessType { get; set; }

                /// <summary>
                /// <para>The NLU engine, which is set to Prompts for LLM scenarios and is empty for small model scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>空或者Prompts</para>
                /// </summary>
                [NameInMap("NluEngine")]
                [Validation(Required=false)]
                public string NluEngine { get; set; }

                /// <summary>
                /// <para>The Function Compute configuration for function calling mode.</para>
                /// </summary>
                [NameInMap("NluProfile")]
                [Validation(Required=false)]
                public ListScriptsResponseBodyScriptsListNluProfile NluProfile { get; set; }
                public class ListScriptsResponseBodyScriptsListNluProfile : TeaModel {
                    /// <summary>
                    /// <para>The function name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sanfang_test</para>
                    /// </summary>
                    [NameInMap("FcFunction")]
                    [Validation(Required=false)]
                    public string FcFunction { get; set; }

                    /// <summary>
                    /// <para>The URL of the function trigger.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://sanfang_test-xxxxxx.cn-shanghai-vpc.fcapp.run">http://sanfang_test-xxxxxx.cn-shanghai-vpc.fcapp.run</a></para>
                    /// </summary>
                    [NameInMap("FcHttpTriggerUrl")]
                    [Validation(Required=false)]
                    public string FcHttpTriggerUrl { get; set; }

                    /// <summary>
                    /// <para>The function region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shanghai</para>
                    /// </summary>
                    [NameInMap("FcRegion")]
                    [Validation(Required=false)]
                    public string FcRegion { get; set; }

                }

                /// <summary>
                /// <para>The rejection reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>话术用语不合规</para>
                /// </summary>
                [NameInMap("RejectReason")]
                [Validation(Required=false)]
                public string RejectReason { get; set; }

                /// <summary>
                /// <para>The scene.</para>
                /// 
                /// <b>Example:</b>
                /// <para>电销</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The script description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>电话销售话术</para>
                /// </summary>
                [NameInMap("ScriptDescription")]
                [Validation(Required=false)]
                public string ScriptDescription { get; set; }

                /// <summary>
                /// <para>The script ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8d6a6e41-8093-49af-a9d1-0281878758ac</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>The script name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>电话销售话术</para>
                /// </summary>
                [NameInMap("ScriptName")]
                [Validation(Required=false)]
                public string ScriptName { get; set; }

                /// <summary>
                /// <para>The script status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DRAFTED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578965079000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1160195</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public long? AgentId { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of scripts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
