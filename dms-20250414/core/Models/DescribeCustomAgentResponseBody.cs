// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeCustomAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCustomAgentResponseBodyData Data { get; set; }
        public class DescribeCustomAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The custom agent type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Default: system-built-in custom agent</description></item>
            /// <item><description>Common: common custom agent</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Common</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud main account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16738266********</para>
            /// </summary>
            [NameInMap("AliyunParentUid")]
            [Validation(Required=false)]
            public string AliyunParentUid { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20372822********</para>
            /// </summary>
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            /// <summary>
            /// <para>The callback feature configuration.</para>
            /// </summary>
            [NameInMap("CallbackConfig")]
            [Validation(Required=false)]
            public DescribeCustomAgentResponseBodyDataCallbackConfig CallbackConfig { get; set; }
            public class DescribeCustomAgentResponseBodyDataCallbackConfig : TeaModel {
                /// <summary>
                /// <para>The parameters to invoke callback tool calling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;ID&quot;:&quot;test&quot;}</para>
                /// </summary>
                [NameInMap("CallbackArgs")]
                [Validation(Required=false)]
                public string CallbackArgs { get; set; }

                /// <summary>
                /// <para>The prompt for generating parameters to invoke callback tool calling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>send web report to <a href="mailto:123456@163.com">123456@163.com</a></para>
                /// </summary>
                [NameInMap("CallbackPrompt")]
                [Validation(Required=false)]
                public string CallbackPrompt { get; set; }

                /// <summary>
                /// <para>The timing to invoke callback tool calling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallbackTime")]
                [Validation(Required=false)]
                public int? CallbackTime { get; set; }

                /// <summary>
                /// <para>The callback tool identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mcp serverId (6te...g7a)</para>
                /// </summary>
                [NameInMap("ToolId")]
                [Validation(Required=false)]
                public string ToolId { get; set; }

                /// <summary>
                /// <para>The callback tool type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mcp</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The name of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HaoY*****</para>
            /// </summary>
            [NameInMap("CreatorUserName")]
            [Validation(Required=false)]
            public string CreatorUserName { get; set; }

            /// <summary>
            /// <para>The custom agent ID.</para>
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
            /// <para>The specified data scope in JSON string format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;tableFlag&quot; : true,
            ///   &quot;scope&quot; : &quot;personal&quot;,
            ///   &quot;personal&quot; : {
            ///     &quot;DataSourceType&quot; : &quot;remote_data_center&quot;,
            ///     &quot;FileId&quot; : &quot;f-5qlrwaw10<b><b><b><b>s3gpw1z&quot;,
            ///     &quot;Database&quot; : &quot;test-table</b></b></b>.xlsx&quot;,
            ///     &quot;Tables&quot; : [ &quot;Sheet1&quot; ],
            ///     &quot;TableIds&quot; : [ &quot;</b>****&quot; ],
            ///     &quot;RegionId&quot; : &quot;cn-hangzhou&quot;
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("DataJson")]
            [Validation(Required=false)]
            public string DataJson { get; set; }

            /// <summary>
            /// <para>Specifies whether the agent is displayed by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DefaultAgent")]
            [Validation(Required=false)]
            public int? DefaultAgent { get; set; }

            /// <summary>
            /// <para>The custom agent description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description for the test agent</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The current DMS unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DmsUnit")]
            [Validation(Required=false)]
            public string DmsUnit { get; set; }

            /// <summary>
            /// <para>The execution configuration.</para>
            /// </summary>
            [NameInMap("ExecutionConfig")]
            [Validation(Required=false)]
            public DescribeCustomAgentResponseBodyDataExecutionConfig ExecutionConfig { get; set; }
            public class DescribeCustomAgentResponseBodyDataExecutionConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to prohibit appending data sources in a session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ForbiddenAppendDataSource")]
                [Validation(Required=false)]
                public bool? ForbiddenAppendDataSource { get; set; }

                /// <summary>
                /// <para>Specifies whether to disable user inquiries during the process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
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
                /// <para>Specifies whether to skip the confirmation for drawing a web report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SkipWebReportConfirm")]
                [Validation(Required=false)]
                public bool? SkipWebReportConfirm { get; set; }

            }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-11T14:04:32.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-11T14:04:32.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The instructions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Analytical framework:</para>
            /// <para>Monitor core metrics (GMV, order volume, UV, and conversion rate) on a daily, weekly, and monthly basis to analyze trends and identify year-over-year and month-over-month fluctuations.
            /// Segment by new vs. returning customers, channels, and regions to identify growth drivers and areas of weakness.
            /// Conduct funnel analysis based on user behavior paths (browse → add to cart → purchase) to pinpoint stages where user drop-off occurs.</para>
            /// </summary>
            [NameInMap("Instruction")]
            [Validation(Required=false)]
            public string Instruction { get; set; }

            /// <summary>
            /// <para>Specifies whether a periodic task is configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsScheduleTask")]
            [Validation(Required=false)]
            public bool? IsScheduleTask { get; set; }

            /// <summary>
            /// <para>The knowledge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Core metric definitions:</para>
            /// <para>GMV (Gross Merchandise Volume) refers to the total sum of order amounts, including both paid and unpaid orders.
            /// Order volume refers to the number of valid orders placed per day.
            /// UV (Unique Visitors) refers to the deduplicated number of users who visit the website or app.
            /// Conversion rate = paid orders / UV, reflecting the efficiency of traffic conversion.</para>
            /// </summary>
            [NameInMap("Knowledge")]
            [Validation(Required=false)]
            public string Knowledge { get; set; }

            /// <summary>
            /// <para>The external knowledge bases.</para>
            /// </summary>
            [NameInMap("KnowledgeConfigList")]
            [Validation(Required=false)]
            public List<DescribeCustomAgentResponseBodyDataKnowledgeConfigList> KnowledgeConfigList { get; set; }
            public class DescribeCustomAgentResponseBodyDataKnowledgeConfigList : TeaModel {
                /// <summary>
                /// <para>The access type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>mcp: MCP access</description></item>
                /// <item><description>dms_kb: DMS knowledge base access</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>mcp</para>
                /// </summary>
                [NameInMap("AccessType")]
                [Validation(Required=false)]
                public string AccessType { get; set; }

                /// <summary>
                /// <para>The knowledge base ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kb-HZ-6anhdzx7hddf9*******obx</para>
                /// </summary>
                [NameInMap("KbUuid")]
                [Validation(Required=false)]
                public string KbUuid { get; set; }

                /// <summary>
                /// <para>The MCP server ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nhdpt9adf6ac**********ca</para>
                /// </summary>
                [NameInMap("McpServerId")]
                [Validation(Required=false)]
                public string McpServerId { get; set; }

            }

            /// <summary>
            /// <para>The knowledge semantic configuration list.</para>
            /// </summary>
            [NameInMap("KnowledgeSemanticConfigList")]
            [Validation(Required=false)]
            public List<DescribeCustomAgentResponseBodyDataKnowledgeSemanticConfigList> KnowledgeSemanticConfigList { get; set; }
            public class DescribeCustomAgentResponseBodyDataKnowledgeSemanticConfigList : TeaModel {
                /// <summary>
                /// <para>The DMS database ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>71991648</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public string DbId { get; set; }

                /// <summary>
                /// <para>The DMS instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2190779</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The knowledge UUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7ca8f50d78234******e87</para>
                /// </summary>
                [NameInMap("KnowledgeUuid")]
                [Validation(Required=false)]
                public string KnowledgeUuid { get; set; }

                /// <summary>
                /// <para>The knowledge semantic type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>sql_template: SQL template</description></item>
                /// <item><description>ossie_model: Ossie semantic view</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sql_template</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20372822********</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The name of the modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HaoY*****</para>
            /// </summary>
            [NameInMap("ModifierUserName")]
            [Validation(Required=false)]
            public string ModifierUserName { get; set; }

            /// <summary>
            /// <para>The custom agent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test agent name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The next run time of the periodic task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1767715200</para>
            /// </summary>
            [NameInMap("NextRuntime")]
            [Validation(Required=false)]
            public long? NextRuntime { get; set; }

            /// <summary>
            /// <para>The offline time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-11T14:04:32.000+00:00</para>
            /// </summary>
            [NameInMap("OfflineTime")]
            [Validation(Required=false)]
            public string OfflineTime { get; set; }

            /// <summary>
            /// <para>The list of recommended questions. You can configure up to 10 recommended questions.</para>
            /// </summary>
            [NameInMap("RecommendQuestionList")]
            [Validation(Required=false)]
            public List<string> RecommendQuestionList { get; set; }

            /// <summary>
            /// <para>The region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The referenced historical session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5xyz...</para>
            /// </summary>
            [NameInMap("RelatedSessionId")]
            [Validation(Required=false)]
            public string RelatedSessionId { get; set; }

            /// <summary>
            /// <para>The release time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-11T14:04:32.000+00:00</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public string ReleaseTime { get; set; }

            /// <summary>
            /// <para>The periodic task configuration.</para>
            /// </summary>
            [NameInMap("ScheduleTaskConfig")]
            [Validation(Required=false)]
            public DescribeCustomAgentResponseBodyDataScheduleTaskConfig ScheduleTaskConfig { get; set; }
            public class DescribeCustomAgentResponseBodyDataScheduleTaskConfig : TeaModel {
                /// <summary>
                /// <para>The cron expression for time-based periodic scheduling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 0 ? * 1-7</para>
                /// </summary>
                [NameInMap("CronExpression")]
                [Validation(Required=false)]
                public string CronExpression { get; set; }

                /// <summary>
                /// <para>The question for the periodic task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Analyze the data and provide the report</para>
                /// </summary>
                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

                /// <summary>
                /// <para>The referenced historical session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4m24*****mg7j2v</para>
                /// </summary>
                [NameInMap("RelatedSessionId")]
                [Validation(Required=false)]
                public string RelatedSessionId { get; set; }

            }

            /// <summary>
            /// <para>The custom agent status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RELEASED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The text report format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The text report requires that all numbers be written in Chinese numerals rather than Arabic numerals.</para>
            /// </summary>
            [NameInMap("TextReportConfig")]
            [Validation(Required=false)]
            public string TextReportConfig { get; set; }

            /// <summary>
            /// <para>The list of user-specified skills.</para>
            /// </summary>
            [NameInMap("UserSpecifiedSkillList")]
            [Validation(Required=false)]
            public List<string> UserSpecifiedSkillList { get; set; }

            /// <summary>
            /// <para>The web report format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The web report requires that all numbers be written in Chinese numerals rather than Arabic numerals.</para>
            /// </summary>
            [NameInMap("WebReportConfig")]
            [Validation(Required=false)]
            public string WebReportConfig { get; set; }

            /// <summary>
            /// <para>The web report theme. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>default: default</description></item>
            /// <item><description>journal: journal</description></item>
            /// <item><description>legacy: classic</description></item>
            /// <item><description>neobrutalism: stylized</description></item>
            /// <item><description>infographic: infographic</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
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

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.                                 </description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
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
