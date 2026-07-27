// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ModifyCustomAgentRequest : TeaModel {
        [NameInMap("CallbackConfig")]
        [Validation(Required=false)]
        public ModifyCustomAgentRequestCallbackConfig CallbackConfig { get; set; }
        public class ModifyCustomAgentRequestCallbackConfig : TeaModel {
            [NameInMap("CallbackArgs")]
            [Validation(Required=false)]
            public string CallbackArgs { get; set; }

            [NameInMap("CallbackPrompt")]
            [Validation(Required=false)]
            public string CallbackPrompt { get; set; }

            [NameInMap("CallbackTime")]
            [Validation(Required=false)]
            public int? CallbackTime { get; set; }

            [NameInMap("ToolId")]
            [Validation(Required=false)]
            public string ToolId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The custom agent ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-4y3ca4khkcu**********ysf</para>
        /// </summary>
        [NameInMap("CustomAgentId")]
        [Validation(Required=false)]
        public string CustomAgentId { get; set; }

        /// <summary>
        /// <para>The current DMS unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The specified data scope, in <b>JSON string format</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{</para>
        /// </summary>
        [NameInMap("DataJson")]
        [Validation(Required=false)]
        public string DataJson { get; set; }

        /// <summary>
        /// <para>The description of the custom agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgentTestDescription.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The execution configuration.</para>
        /// </summary>
        [NameInMap("ExecutionConfig")]
        [Validation(Required=false)]
        public ModifyCustomAgentRequestExecutionConfig ExecutionConfig { get; set; }
        public class ModifyCustomAgentRequestExecutionConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to disable user inquiries during the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SkipAskHuman")]
            [Validation(Required=false)]
            public bool? SkipAskHuman { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip the plan confirmation step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SkipPlan")]
            [Validation(Required=false)]
            public bool? SkipPlan { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip all SQL confirmations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SkipSqlConfirm")]
            [Validation(Required=false)]
            public bool? SkipSqlConfirm { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip the web report rendering confirmation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SkipWebReportConfirm")]
            [Validation(Required=false)]
            public bool? SkipWebReportConfirm { get; set; }

        }

        /// <summary>
        /// <para>The instruction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Analysis framework:</para>
        /// </summary>
        [NameInMap("Instruction")]
        [Validation(Required=false)]
        public string Instruction { get; set; }

        /// <summary>
        /// <para>The knowledge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Core metric definitions:</para>
        /// </summary>
        [NameInMap("Knowledge")]
        [Validation(Required=false)]
        public string Knowledge { get; set; }

        /// <summary>
        /// <para>The external knowledge bases.</para>
        /// </summary>
        [NameInMap("KnowledgeConfigList")]
        [Validation(Required=false)]
        public List<ModifyCustomAgentRequestKnowledgeConfigList> KnowledgeConfigList { get; set; }
        public class ModifyCustomAgentRequestKnowledgeConfigList : TeaModel {
            /// <summary>
            /// <para>The access type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            [NameInMap("KbUuid")]
            [Validation(Required=false)]
            public string KbUuid { get; set; }

            /// <summary>
            /// <para>The ID of the MCP Server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nhdpt9adf6ac**********ca</para>
            /// </summary>
            [NameInMap("McpServerId")]
            [Validation(Required=false)]
            public string McpServerId { get; set; }

        }

        /// <summary>
        /// <para>The name of the custom agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgentTestName.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RelatedSessionId")]
        [Validation(Required=false)]
        public string RelatedSessionId { get; set; }

        /// <summary>
        /// <para>The scheduled task configuration.</para>
        /// </summary>
        [NameInMap("ScheduleTaskConfig")]
        [Validation(Required=false)]
        public ModifyCustomAgentRequestScheduleTaskConfig ScheduleTaskConfig { get; set; }
        public class ModifyCustomAgentRequestScheduleTaskConfig : TeaModel {
            /// <summary>
            /// <para>The cron expression for time-based scheduling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 0,1 ? * 1-7</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>The query for the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Analyze this data and provide a brief report.</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The ID of the referenced historical session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4m24*****mg7j2v</para>
            /// </summary>
            [NameInMap("RelatedSessionId")]
            [Validation(Required=false)]
            public string RelatedSessionId { get; set; }

        }

        /// <summary>
        /// <para>The text report format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The text report requires all numbers to be written in Chinese characters instead of Arabic numerals.</para>
        /// </summary>
        [NameInMap("TextReportConfig")]
        [Validation(Required=false)]
        public string TextReportConfig { get; set; }

        /// <summary>
        /// <para>The web report format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The web report requires all numbers to be written in Chinese characters instead of Arabic numerals.</para>
        /// </summary>
        [NameInMap("WebReportConfig")]
        [Validation(Required=false)]
        public string WebReportConfig { get; set; }

        [NameInMap("WebReportTheme")]
        [Validation(Required=false)]
        public string WebReportTheme { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>56kv1pvl9uvt9**********bb</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
