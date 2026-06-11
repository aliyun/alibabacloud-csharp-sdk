// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ModifyCustomAgentRequest : TeaModel {
        /// <summary>
        /// <para>The callback configuration.</para>
        /// </summary>
        [NameInMap("CallbackConfig")]
        [Validation(Required=false)]
        public ModifyCustomAgentRequestCallbackConfig CallbackConfig { get; set; }
        public class ModifyCustomAgentRequestCallbackConfig : TeaModel {
            /// <summary>
            /// <para>The arguments for the callback.</para>
            /// </summary>
            [NameInMap("CallbackArgs")]
            [Validation(Required=false)]
            public string CallbackArgs { get; set; }

            /// <summary>
            /// <para>The prompt to use for the callback.</para>
            /// </summary>
            [NameInMap("CallbackPrompt")]
            [Validation(Required=false)]
            public string CallbackPrompt { get; set; }

            /// <summary>
            /// <para>The timestamp of the callback.</para>
            /// </summary>
            [NameInMap("CallbackTime")]
            [Validation(Required=false)]
            public int? CallbackTime { get; set; }

            /// <summary>
            /// <para>The ID of the tool to call.</para>
            /// </summary>
            [NameInMap("ToolId")]
            [Validation(Required=false)]
            public string ToolId { get; set; }

            /// <summary>
            /// <para>The callback type.</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the custom agent.</para>
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
        /// <para>The data scope for the agent, specified in a <b>JSON-formatted string</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>General parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>tableFlag</c>: Set this to <c>true</c> to specify the data scope.</para>
        /// </description></item>
        /// <item><description><para><c>scope</c>: The value must be <c>personal</c>.</para>
        /// </description></item>
        /// <item><description><para><c>personal</c>: The parameters for files or databases.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para><b>For files</b>, use the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>DataSourceType</c>: The value must be <c>remote_data_center</c>.</para>
        /// </description></item>
        /// <item><description><para><c>FileId</c>: The file ID.</para>
        /// </description></item>
        /// <item><description><para><c>Database</c>: The database name returned by the <c>ListDataCenterTable</c> operation. This is typically the file name.</para>
        /// </description></item>
        /// <item><description><para><c>Tables</c>: The table names returned by the <c>ListDataCenterTable</c> operation.</para>
        /// </description></item>
        /// <item><description><para><c>TableIds</c>: The table IDs returned by the <c>ListDataCenterTable</c> operation.</para>
        /// </description></item>
        /// <item><description><para><c>RegionId</c>: The current region.</para>
        /// </description></item>
        /// </list>
        /// <pre><c>{
        ///   &quot;tableFlag&quot;: true,
        ///   &quot;scope&quot;: &quot;personal&quot;,
        ///   &quot;personal&quot;: {
        ///     &quot;DataSourceType&quot;: &quot;remote_data_center&quot;,
        ///     &quot;FileId&quot;: &quot;f-f0jksn001ibmkoo********6v2zn6&quot;,
        ///     &quot;Database&quot;: &quot;diamonds.csv&quot;,
        ///     &quot;Tables&quot;: [
        ///       &quot;diamonds&quot;
        ///     ],
        ///     &quot;TableIds&quot;: [
        ///       &quot;35hfn94pxl********50pi&quot;
        ///     ],
        ///     &quot;RegionId&quot;: &quot;cn-hangzhou&quot;
        ///   }
        /// }
        /// </c></pre>
        /// <para><b>For databases</b>, use the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>DataSourceType</c>: The value must be <c>database</c>.</para>
        /// </description></item>
        /// <item><description><para><c>DmsInstanceId</c>: The ID of the DMS instance, which is returned by the data center API.</para>
        /// </description></item>
        /// <item><description><para><c>DmsDatabaseId</c>: The ID of the DMS database, which is returned by the data center API.</para>
        /// </description></item>
        /// <item><description><para><c>FileId</c>: The instance name. This parameter is deprecated.</para>
        /// </description></item>
        /// <item><description><para><c>DbName</c>: The database name returned by the data center API.</para>
        /// </description></item>
        /// <item><description><para><c>Database</c>: The database name returned by the data center API.</para>
        /// </description></item>
        /// <item><description><para><c>Tables</c>: The table names returned by the data center API.</para>
        /// </description></item>
        /// <item><description><para><c>TableIds</c>: The table IDs returned by the data center API.</para>
        /// </description></item>
        /// <item><description><para><c>Engine</c>: The database engine type. Valid values: <c>mysql</c> and <c>postgresql</c>.</para>
        /// </description></item>
        /// <item><description><para><c>RegionId</c>: The current region.</para>
        /// </description></item>
        /// </list>
        /// <pre><c>{
        ///   &quot;tableFlag&quot;: true,
        ///   &quot;scope&quot;: &quot;personal&quot;,
        ///   &quot;personal&quot;: {
        ///     &quot;DataSourceType&quot;: &quot;database&quot;,
        ///     &quot;DmsInstanceId&quot;: &quot;284***8&quot;,
        ///     &quot;DmsDatabaseId&quot;: &quot;769***45&quot;,
        ///     &quot;FileId&quot;: &quot;pgm-bp15095e*******6t&quot;,
        ///     &quot;DbName&quot;: &quot;pg_catalog&quot;,
        ///     &quot;Database&quot;: &quot;pg_catalog&quot;,
        ///     &quot;Tables&quot;: [
        ///       &quot;pg_aggregate&quot;
        ///     ],
        ///     &quot;TableIds&quot;: [
        ///       &quot;5263****31&quot;
        ///     ],
        ///     &quot;Engine&quot;: &quot;postgresql&quot;,
        ///     &quot;RegionId&quot;: &quot;cn-hangzhou&quot;
        ///   }
        /// }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;tableFlag&quot; : true,
        ///   &quot;scope&quot; : &quot;personal&quot;,
        ///   &quot;personal&quot; : {
        ///     &quot;DataSourceType&quot; : &quot;remote_data_center&quot;,
        ///     &quot;FileId&quot; : &quot;f-5qlrwaw10<b><b><b><b>s3gpw1z&quot;,
        ///     &quot;Database&quot; : &quot;测试表格</b></b></b>.xlsx&quot;,
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
        /// <para>The description of the custom agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent测试描述</para>
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
            /// <para>Specifies whether to prevent the agent from asking for user input during execution.</para>
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
            /// <para>Specifies whether to skip all SQL confirmation steps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SkipSqlConfirm")]
            [Validation(Required=false)]
            public bool? SkipSqlConfirm { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip the confirmation for web report generation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SkipWebReportConfirm")]
            [Validation(Required=false)]
            public bool? SkipWebReportConfirm { get; set; }

        }

        /// <summary>
        /// <para>The system instruction for the custom agent.</para>
        /// <list type="bullet">
        /// <item><description>The maximum length is 10,000 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>分析框架：
        /// 1、需按日、周、月维度监控核心指标（GMV、订单量、UV、转化率），分析趋势变化及同比/环比波动；
        /// 2、划分新老客、渠道、地域进行拆解，识别增长来源与短板；
        /// 3、结合用户行为路径（浏览→加购→支付）开展漏斗分析，定位流失环节；</para>
        /// </summary>
        [NameInMap("Instruction")]
        [Validation(Required=false)]
        public string Instruction { get; set; }

        /// <summary>
        /// <para>A text-based knowledge base for the custom agent.</para>
        /// <list type="bullet">
        /// <item><description>The maximum length is 10,000 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>核心指标定义：
        /// 1、GMV（成交总额）指订单金额总和，含已支付及未支付成功订单；
        /// 2、订单量为每日有效下单笔数；
        /// 3、UV（独立访客）指访问网站或APP的去重用户数；
        /// 4、转化率=支付订单数 / UV，反映流量转化效率；</para>
        /// </summary>
        [NameInMap("Knowledge")]
        [Validation(Required=false)]
        public string Knowledge { get; set; }

        /// <summary>
        /// <para>The configurations for the external knowledge base.</para>
        /// </summary>
        [NameInMap("KnowledgeConfigList")]
        [Validation(Required=false)]
        public List<ModifyCustomAgentRequestKnowledgeConfigList> KnowledgeConfigList { get; set; }
        public class ModifyCustomAgentRequestKnowledgeConfigList : TeaModel {
            /// <summary>
            /// <para>The access type.</para>
            /// <list type="bullet">
            /// <item><description><c>mcp</c>: Connects via the MCP service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mcp</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>The UUID of the knowledge base.</para>
            /// </summary>
            [NameInMap("KbUuid")]
            [Validation(Required=false)]
            public string KbUuid { get; set; }

            /// <summary>
            /// <para>The ID of the MCP server.</para>
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
        /// <para>Agent测试名称</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RelatedSessionId")]
        [Validation(Required=false)]
        public string RelatedSessionId { get; set; }

        /// <summary>
        /// <para>The configuration for the scheduled task.</para>
        /// </summary>
        [NameInMap("ScheduleTaskConfig")]
        [Validation(Required=false)]
        public ModifyCustomAgentRequestScheduleTaskConfig ScheduleTaskConfig { get; set; }
        public class ModifyCustomAgentRequestScheduleTaskConfig : TeaModel {
            /// <summary>
            /// <para>The cron expression for the scheduled task.</para>
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
            /// <para>分析一下这份数据，给出简报</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The ID of a previous session to use as a reference.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4m24*****mg7j2v</para>
            /// </summary>
            [NameInMap("RelatedSessionId")]
            [Validation(Required=false)]
            public string RelatedSessionId { get; set; }

        }

        /// <summary>
        /// <para>The formatting instructions for the text report.</para>
        /// <list type="bullet">
        /// <item><description>The maximum length is 10,000 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>文字报告要求所有数字不使用阿拉伯数字，全部转为中文数字</para>
        /// </summary>
        [NameInMap("TextReportConfig")]
        [Validation(Required=false)]
        public string TextReportConfig { get; set; }

        /// <summary>
        /// <para>The formatting instructions for the web report.</para>
        /// <list type="bullet">
        /// <item><description>The maximum length is 50,000 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>网页报告要求所有数字不使用阿拉伯数字，全部转为中文数字</para>
        /// </summary>
        [NameInMap("WebReportConfig")]
        [Validation(Required=false)]
        public string WebReportConfig { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>56kv1pvl9uvt9**********bb</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
