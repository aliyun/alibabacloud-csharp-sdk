// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateCustomAgentRequest : TeaModel {
        [NameInMap("CallbackConfig")]
        [Validation(Required=false)]
        public CreateCustomAgentRequestCallbackConfig CallbackConfig { get; set; }
        public class CreateCustomAgentRequestCallbackConfig : TeaModel {
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
        /// <para>The current DMS unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The specified data scope, in <b>JSON character string format</b>.</para>
        /// <list type="bullet">
        /// <item><description>Common parameter description<list type="bullet">
        /// <item><description>tableFlag: true specifies the data scope.</description></item>
        /// <item><description>scope: personal is a fixed value.</description></item>
        /// <item><description>personal: the parameters for file and database types.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para><b>File type</b>: Pass parameters in the following format:</para>
        /// <list type="bullet">
        /// <item><description>DataSourceType: remote_data_center is a fixed value.</description></item>
        /// <item><description>FileId: The file ID.</description></item>
        /// <item><description>Database: The database name returned by the ListDataCenterTable operation, which is usually the file name.</description></item>
        /// <item><description>Tables: The table names returned by the ListDataCenterTable operation.</description></item>
        /// <item><description>TableIds: The table IDs returned by the ListDataCenterTable operation.</description></item>
        /// <item><description>RegionId: The current region.</description></item>
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
        /// <para><b>Database type</b>: Pass parameters as follows:</para>
        /// <list type="bullet">
        /// <item><description>DataSourceType: database is a fixed value.</description></item>
        /// <item><description>DmsInstanceId: The DMS instance ID returned by the Data Center API.</description></item>
        /// <item><description>DmsDatabaseId: The DMS database ID returned by the Data Center API.</description></item>
        /// <item><description>FileId: The instance name. <b>[Deprecated]</b></description></item>
        /// <item><description>DbName: The database name returned by the Data Center API.</description></item>
        /// <item><description>Database: The database name returned by the Data Center API.</description></item>
        /// <item><description>Tables: The table names returned by the Data Center API.</description></item>
        /// <item><description>TableIds: The table IDs returned by the Data Center API.</description></item>
        /// <item><description>Engine: The engine type, such as mysql or postgresql.</description></item>
        /// <item><description>RegionId: The current region.</description></item>
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
        ///     &quot;Database&quot; : &quot;TestTable</b></b></b>.xlsx&quot;,
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
        /// <para>Agent test description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The execution configuration.</para>
        /// </summary>
        [NameInMap("ExecutionConfig")]
        [Validation(Required=false)]
        public CreateCustomAgentRequestExecutionConfig ExecutionConfig { get; set; }
        public class CreateCustomAgentRequestExecutionConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to prohibit appending data sources during a session.</para>
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
            /// <para>Specifies whether to skip the web report generation confirmation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SkipWebReportConfirm")]
            [Validation(Required=false)]
            public bool? SkipWebReportConfirm { get; set; }

        }

        /// <summary>
        /// <para>The instructions.</para>
        /// <list type="bullet">
        /// <item><description>Input limit: A maximum of 10,000 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Core metric definitions:</para>
        /// <ol>
        /// <item><description>GMV (Gross Merchandise Volume) refers to the total order amount, including both paid and unpaid orders.</description></item>
        /// <item><description>Order volume refers to the number of valid orders placed per day.</description></item>
        /// <item><description>UV (Unique Visitors) refers to the number of deduplicated users who visit the website or app.</description></item>
        /// <item><description>Conversion rate = Number of paid orders / UV, which reflects the traffic conversion efficiency</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("Instruction")]
        [Validation(Required=false)]
        public string Instruction { get; set; }

        /// <summary>
        /// <para>The knowledge.</para>
        /// <list type="bullet">
        /// <item><description>Input limit: A maximum of 10,000 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Core metric definitions:</para>
        /// <ol>
        /// <item><description>GMV (Gross Merchandise Volume) refers to the total order amount, including both paid and unpaid orders.</description></item>
        /// <item><description>Order volume refers to the number of valid orders placed per day.</description></item>
        /// <item><description>UV (Unique Visitors) refers to the number of deduplicated users who visit the website or app.</description></item>
        /// <item><description>Conversion rate = Number of paid orders / UV, which reflects the traffic conversion efficiency</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("Knowledge")]
        [Validation(Required=false)]
        public string Knowledge { get; set; }

        /// <summary>
        /// <para>The external knowledge bases.</para>
        /// </summary>
        [NameInMap("KnowledgeConfigList")]
        [Validation(Required=false)]
        public List<CreateCustomAgentRequestKnowledgeConfigList> KnowledgeConfigList { get; set; }
        public class CreateCustomAgentRequestKnowledgeConfigList : TeaModel {
            /// <summary>
            /// <para>The access type. If you do not specify this parameter, the default value is mcp. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>mcp: Access through MCP. The McpServerId parameter is required.</description></item>
            /// <item><description>dms_kb: Access through a DMS knowledge base. The KbUuid parameter is required.</description></item>
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
            /// <para>The ID of the MCP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nhdpt9adf6ac**********ca</para>
            /// </summary>
            [NameInMap("McpServerId")]
            [Validation(Required=false)]
            public string McpServerId { get; set; }

        }

        [NameInMap("KnowledgeSemanticConfigList")]
        [Validation(Required=false)]
        public List<CreateCustomAgentRequestKnowledgeSemanticConfigList> KnowledgeSemanticConfigList { get; set; }
        public class CreateCustomAgentRequestKnowledgeSemanticConfigList : TeaModel {
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public string DbId { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("KnowledgeUuid")]
            [Validation(Required=false)]
            public string KnowledgeUuid { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The name of the custom agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent test name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the referenced historical session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99crainsjnveo*******vynid</para>
        /// </summary>
        [NameInMap("RelatedSessionId")]
        [Validation(Required=false)]
        public string RelatedSessionId { get; set; }

        /// <summary>
        /// <para>The scheduled task configuration.</para>
        /// </summary>
        [NameInMap("ScheduleTaskConfig")]
        [Validation(Required=false)]
        public CreateCustomAgentRequestScheduleTaskConfig ScheduleTaskConfig { get; set; }
        public class CreateCustomAgentRequestScheduleTaskConfig : TeaModel {
            /// <summary>
            /// <para>The cron expression for periodic scheduling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 0 ? * 1-7</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>The query for the periodic task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Analyze this data and provide a brief report</para>
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
        /// <para>All numbers in the text report must be written in Chinese characters instead of Arabic numerals</para>
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
        /// <para>All numbers in the web report must be written in Chinese characters instead of Arabic numerals</para>
        /// </summary>
        [NameInMap("WebReportConfig")]
        [Validation(Required=false)]
        public string WebReportConfig { get; set; }

        /// <summary>
        /// <para>The web report theme.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
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

}
