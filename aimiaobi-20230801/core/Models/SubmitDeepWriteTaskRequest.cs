// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitDeepWriteTaskRequest : TeaModel {
        [NameInMap("AgentOrchestration")]
        [Validation(Required=false)]
        public SubmitDeepWriteTaskRequestAgentOrchestration AgentOrchestration { get; set; }
        public class SubmitDeepWriteTaskRequestAgentOrchestration : TeaModel {
            [NameInMap("DataAnalystAgent")]
            [Validation(Required=false)]
            public SubmitDeepWriteTaskRequestAgentOrchestrationDataAnalystAgent DataAnalystAgent { get; set; }
            public class SubmitDeepWriteTaskRequestAgentOrchestrationDataAnalystAgent : TeaModel {
                [NameInMap("EnableSearch")]
                [Validation(Required=false)]
                public bool? EnableSearch { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("DataCollectorAgent")]
            [Validation(Required=false)]
            public SubmitDeepWriteTaskRequestAgentOrchestrationDataCollectorAgent DataCollectorAgent { get; set; }
            public class SubmitDeepWriteTaskRequestAgentOrchestrationDataCollectorAgent : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("ReporterAgent")]
            [Validation(Required=false)]
            public SubmitDeepWriteTaskRequestAgentOrchestrationReporterAgent ReporterAgent { get; set; }
            public class SubmitDeepWriteTaskRequestAgentOrchestrationReporterAgent : TeaModel {
                [NameInMap("EnableCitation")]
                [Validation(Required=false)]
                public bool? EnableCitation { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<SubmitDeepWriteTaskRequestFiles> Files { get; set; }
        public class SubmitDeepWriteTaskRequestFiles : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>附件的备注</para>
            /// </summary>
            [NameInMap("FileDescription")]
            [Validation(Required=false)]
            public string FileDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://default/aimiaobi-poc/aimiaobi/deep-write-upload/1_1/xxx.txt</para>
            /// </summary>
            [NameInMap("FileKey")]
            [Validation(Required=false)]
            public string FileKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>附件的名称</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        [NameInMap("Instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>llm-1setzb9xb8m11vrc</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
