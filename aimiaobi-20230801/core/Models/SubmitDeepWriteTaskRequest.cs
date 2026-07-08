// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitDeepWriteTaskRequest : TeaModel {
        /// <summary>
        /// <para>The agent orchestration options.</para>
        /// </summary>
        [NameInMap("AgentOrchestration")]
        [Validation(Required=false)]
        public SubmitDeepWriteTaskRequestAgentOrchestration AgentOrchestration { get; set; }
        public class SubmitDeepWriteTaskRequestAgentOrchestration : TeaModel {
            /// <summary>
            /// <para>The data analysis agent.</para>
            /// </summary>
            [NameInMap("DataAnalystAgent")]
            [Validation(Required=false)]
            public SubmitDeepWriteTaskRequestAgentOrchestrationDataAnalystAgent DataAnalystAgent { get; set; }
            public class SubmitDeepWriteTaskRequestAgentOrchestrationDataAnalystAgent : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable retrieval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableSearch")]
                [Validation(Required=false)]
                public bool? EnableSearch { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataAnalystAgent</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The data collection agent.</para>
            /// </summary>
            [NameInMap("DataCollectorAgent")]
            [Validation(Required=false)]
            public SubmitDeepWriteTaskRequestAgentOrchestrationDataCollectorAgent DataCollectorAgent { get; set; }
            public class SubmitDeepWriteTaskRequestAgentOrchestrationDataCollectorAgent : TeaModel {
                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataCollectorAgent</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The reporter agent.</para>
            /// </summary>
            [NameInMap("ReporterAgent")]
            [Validation(Required=false)]
            public SubmitDeepWriteTaskRequestAgentOrchestrationReporterAgent ReporterAgent { get; set; }
            public class SubmitDeepWriteTaskRequestAgentOrchestrationReporterAgent : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable citations.</para>
                /// </summary>
                [NameInMap("EnableCitation")]
                [Validation(Required=false)]
                public bool? EnableCitation { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ReporterAgent</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>A list of attachments.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<SubmitDeepWriteTaskRequestFiles> Files { get; set; }
        public class SubmitDeepWriteTaskRequestFiles : TeaModel {
            /// <summary>
            /// <para>A description of the attachment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>附件的说明</para>
            /// </summary>
            [NameInMap("FileDescription")]
            [Validation(Required=false)]
            public string FileDescription { get; set; }

            /// <summary>
            /// <para>The Object Storage Service (OSS) address of the attachment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://default/aimiaobi-poc/aimiaobi/deep-write-upload/1_1/xxx.txt</para>
            /// </summary>
            [NameInMap("FileKey")]
            [Validation(Required=false)]
            public string FileKey { get; set; }

            /// <summary>
            /// <para>The name of the attachment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>附件的名称</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

        /// <summary>
        /// <para>The user\&quot;s question.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>北京2025年新能源汽车发展趋势</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The instructions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请根据北京新能源汽车在汽车品牌、新车发布、能源等方面进行分析</para>
        /// </summary>
        [NameInMap("Instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/2782167.html">The workspace ID.</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-1setzb9xb8m11vrc</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
