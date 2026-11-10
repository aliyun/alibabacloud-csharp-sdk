// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class SendChatMessageRequest : TeaModel {
        /// <summary>
        /// <para><b>[Optimized]</b> This field is now automatically retrieved in the background. You do not need to specify it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_***</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para><b>[Optimized]</b> This field is now automatically retrieved in the background. You do not need to specify it when calling the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The data source information. This parameter can be left empty. You can pass only one data source in this parameter. We recommend that you use the DataSources parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public SendChatMessageRequestDataSource DataSource { get; set; }
        public class SendChatMessageRequestDataSource : TeaModel {
            /// <summary>
            /// <para><b>[Deprecated]</b> This field is deprecated. You do not need to specify it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The data source type. Valid values: <c>[remote_data_center, database]</c>, which indicate that the current analysis is based on a file or a database, respectively.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remote_data_center</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This field is deprecated. You do not need to specify it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The ID of the database in Data Management (DMS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>23******</para>
            /// </summary>
            [NameInMap("DmsDatabaseId")]
            [Validation(Required=false)]
            public string DmsDatabaseId { get; set; }

            /// <summary>
            /// <para>The ID of the instance in DMS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12******</para>
            /// </summary>
            [NameInMap("DmsInstanceId")]
            [Validation(Required=false)]
            public string DmsInstanceId { get; set; }

            /// <summary>
            /// <para>The database engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35****</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This field is deprecated. You do not need to specify it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>localhost</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The permission constraints for querying the current data source. The permission constraint feature is in canary release. This field does not take effect for users outside the canary release scope.</para>
            /// </summary>
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public SendChatMessageRequestDataSourcePermission Permission { get; set; }
            public class SendChatMessageRequestDataSourcePermission : TeaModel {
                /// <summary>
                /// <para>The table-level permission constraints for querying the current data source. Each item in the list represents the permission constraints for a specific table.</para>
                /// </summary>
                [NameInMap("Tables")]
                [Validation(Required=false)]
                public List<SendChatMessageRequestDataSourcePermissionTables> Tables { get; set; }
                public class SendChatMessageRequestDataSourcePermissionTables : TeaModel {
                    /// <summary>
                    /// <para>The list of columns allowed for querying in the current table. If left empty, all columns can be queried. If specified, SQL statements that exceed the allowed scope, such as <c>SELECT *</c>, will be blocked. To ensure optimal analysis results of DataAgent, avoid providing out-of-scope columns in modules such as prompts, knowledge, and instructions. Otherwise, generated SQL statements without permissions will be blocked, which degrades the analysis speed and results of DataAgent.</para>
                    /// </summary>
                    [NameInMap("AllowedColumns")]
                    [Validation(Required=false)]
                    public List<string> AllowedColumns { get; set; }

                    /// <summary>
                    /// <para>The list of columns prohibited from querying in the current table. If left empty, all columns <b>can be queried</b>. If specified, SQL statements that exceed the allowed scope, such as <c>SELECT *</c>, will be blocked.  </para>
                    /// <para>If both the prohibited list and the allowed list are configured, the prohibited list takes higher priority. For example, if Table 1 has columns A, B, C, and D, and columns A and B are configured as non-queryable while columns B and C are configured as queryable, only column C is ultimately queryable.</para>
                    /// <para>To ensure optimal analysis results of DataAgent, avoid providing out-of-scope columns in modules such as prompts, knowledge, and instructions. Otherwise, generated SQL statements without permissions will be blocked, which degrades the analysis speed and results of DataAgent.</para>
                    /// </summary>
                    [NameInMap("DisallowedColumns")]
                    [Validation(Required=false)]
                    public List<string> DisallowedColumns { get; set; }

                    /// <summary>
                    /// <para>The required row filter condition for the current table. If left empty, this field is ignored. If specified, the system checks whether all SQL statements involving this table include the filter column and whether the WHERE clause meets the constraints. SQL statements that do not meet the constraints will be rejected. Ensure the correct format of the validation condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>region = \&quot;east\&quot;</para>
                    /// </summary>
                    [NameInMap("RequiredRowFilter")]
                    [Validation(Required=false)]
                    public string RequiredRowFilter { get; set; }

                    /// <summary>
                    /// <para>The name of the table to which the permission constraint rules apply.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sample_table</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

            }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The list of table names to be analyzed.</para>
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<string> Tables { get; set; }

            /// <summary>
            /// <para>The Uniform Resource Identifier (URI) of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>datalake://abc/def</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        /// <summary>
        /// <para>The detailed data source information. This parameter can be left empty.</para>
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<SendChatMessageRequestDataSources> DataSources { get; set; }
        public class SendChatMessageRequestDataSources : TeaModel {
            /// <summary>
            /// <para><b>[Deprecated]</b> This field is deprecated. You do not need to specify it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The data source type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>remote_data_center: The analysis is performed on a file.</description></item>
            /// <item><description>database: The analysis is performed on a database.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>remote_data_center</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This field is deprecated. You do not need to specify it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mydatabase</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The ID of the database in Data Management (DMS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>123****</para>
            /// </summary>
            [NameInMap("DmsDatabaseId")]
            [Validation(Required=false)]
            public string DmsDatabaseId { get; set; }

            /// <summary>
            /// <para>The ID of the instance in DMS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>248*****</para>
            /// </summary>
            [NameInMap("DmsInstanceId")]
            [Validation(Required=false)]
            public string DmsInstanceId { get; set; }

            /// <summary>
            /// <para>The database engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f-4w*******</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This field is deprecated. You do not need to specify it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>localhost</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The permission constraints for querying the current data source. The permission constraint feature is in canary release. This field does not take effect for users outside the canary release scope.</para>
            /// </summary>
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public SendChatMessageRequestDataSourcesPermission Permission { get; set; }
            public class SendChatMessageRequestDataSourcesPermission : TeaModel {
                /// <summary>
                /// <para>The table-level permission constraints for querying the current data source. Each item in the list represents the permission constraints for a specific table.</para>
                /// </summary>
                [NameInMap("Tables")]
                [Validation(Required=false)]
                public List<SendChatMessageRequestDataSourcesPermissionTables> Tables { get; set; }
                public class SendChatMessageRequestDataSourcesPermissionTables : TeaModel {
                    /// <summary>
                    /// <para>The list of columns that are allowed to be queried in the current table. If this parameter is left empty, all columns can be queried. If this parameter is specified, SQL statements that query columns beyond the allowed scope are blocked. For example, syntax similar to SELECT * is blocked. To ensure the analysis performance of DataAgent, make sure that the prompts, knowledge, and instructions of DataAgent do not include columns beyond the allowed scope. Otherwise, unauthorized SQL statements are generated and blocked, which reduces the analysis speed and effectiveness of DataAgent.</para>
                    /// </summary>
                    [NameInMap("AllowedColumns")]
                    [Validation(Required=false)]
                    public List<string> AllowedColumns { get; set; }

                    /// <summary>
                    /// <para>The list of columns prohibited from querying in the current table. If left empty, all columns <b>can be queried</b>. If specified, SQL statements that exceed the allowed scope, such as <c>SELECT *</c>, will be blocked.  </para>
                    /// <para>If both the prohibited list and the allowed list are configured, the prohibited list takes higher priority. For example, if Table 1 has columns A, B, C, and D, and columns A and B are configured as non-queryable while columns B and C are configured as queryable, only column C is ultimately queryable.</para>
                    /// <para>To ensure optimal analysis results of DataAgent, avoid providing out-of-scope columns in modules such as prompts, knowledge, and instructions. Otherwise, generated SQL statements without permissions will be blocked, which degrades the analysis speed and results of DataAgent.</para>
                    /// </summary>
                    [NameInMap("DisallowedColumns")]
                    [Validation(Required=false)]
                    public List<string> DisallowedColumns { get; set; }

                    /// <summary>
                    /// <para>The required row filter condition for the current table. If left empty, this field is ignored. If specified, the system checks whether all SQL statements involving this table include the filter column and whether the WHERE clause meets the constraints. SQL statements that do not meet the constraints will be rejected. Ensure the correct format of the validation condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>region = \&quot;east\&quot;</para>
                    /// </summary>
                    [NameInMap("RequiredRowFilter")]
                    [Validation(Required=false)]
                    public string RequiredRowFilter { get; set; }

                    /// <summary>
                    /// <para>The name of the table to which the permission constraint rules apply.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sample_table</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

            }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The list of table names to be analyzed.</para>
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<string> Tables { get; set; }

            /// <summary>
            /// <para>The Uniform Resource Identifier (URI) of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>datalake://abc/def</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        /// <summary>
        /// <para>The content of the message sent to the agent in the current request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>what can you do?</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The message type. Default value: <c>[primary]</c>.  </para>
        /// <list type="bullet">
        /// <item><description><para>For regular interactions with the agent, set the message type to <c>[primary]</c>.</para>
        /// </description></item>
        /// <item><description><para>If the message responds to a human-in-the-loop question from the agent, set the type to <c>[additional]</c>.</para>
        /// </description></item>
        /// <item><description><para>If the message triggers report generation, set the type to <c>[report]</c>.</para>
        /// </description></item>
        /// <item><description><para>If the message cancels the current session, set the type to <c>[cancel]</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>primary</para>
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// <para>The parent session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20qrliuoo7p2vlsfg*****</para>
        /// </summary>
        [NameInMap("ParentSessionId")]
        [Validation(Required=false)]
        public string ParentSessionId { get; set; }

        /// <summary>
        /// <para>The specific question asked by the agent to the user through human-in-the-loop. This field is required when the message type is <c>additional</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Provide the calculation criteria for GMV</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <para>The quoted content passed in the current request. This is typically used during interactions with the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;version&quot;:&quot;v0&quot;}</para>
        /// </summary>
        [NameInMap("QuotedMessage")]
        [Validation(Required=false)]
        public string QuotedMessage { get; set; }

        /// <summary>
        /// <para><b>Important</b></para>
        /// <para>If this message replies to an agent message, such as an agent clarifying a question through ASK_HUMAN, you must accurately pass the checkpoint sequence number carried in that agent message to <c>reply_to</c>. If this message is not a targeted reply, such as requesting the agent to perform further in-depth analysis after the initial analysis is complete, you can leave <c>reply_to</c> empty or set it to &quot;0&quot;.  </para>
        /// <para>This field affects how the agent decides to process the message. Passing an incorrect value may lead to suboptimal analysis results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReplyTo")]
        [Validation(Required=false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// <para>The special configurations for the current session. For the same session, only the configurations passed in the first SendMessage request take effect.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SessionConfig")]
        [Validation(Required=false)]
        public SendChatMessageRequestSessionConfig SessionConfig { get; set; }
        public class SendChatMessageRequestSessionConfig : TeaModel {
            /// <summary>
            /// <para>The custom agent ID. A custom agent is an entity used to customize the analysis process. You can create it in the DataAgent console or by calling the CreateCustomAgent operation. A custom agent ID must be a string starting with <c>ca-</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-asfkjhqwe***aesrfqa</para>
            /// </summary>
            [NameInMap("CustomAgentId")]
            [Validation(Required=false)]
            public string CustomAgentId { get; set; }

            /// <summary>
            /// <para>The stage of the custom agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("CustomAgentStage")]
            [Validation(Required=false)]
            public string CustomAgentStage { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable web search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableSearch")]
            [Validation(Required=false)]
            public bool? EnableSearch { get; set; }

            /// <summary>
            /// <para>The list of knowledge base IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dasd***cc211</para>
            /// </summary>
            [NameInMap("KbUuidList")]
            [Validation(Required=false)]
            public List<string> KbUuidList { get; set; }

            /// <summary>
            /// <para>The language. Only uppercase values are supported. Currently, only Chinese and English are supported. Default value: Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENGLISH</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The MCP server IDs in the session configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2q1tu90**********6uttu2nw</para>
            /// </summary>
            [NameInMap("McpServerIds")]
            [Validation(Required=false)]
            public List<string> McpServerIds { get; set; }

            /// <summary>
            /// <para>The mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ASK_DATA</b>: Data query mode.</description></item>
            /// <item><description><b>ANALYSIS</b>: Analysis mode.</description></item>
            /// <item><description><b>INSIGHT</b>: Insight mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ANALYSIS</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The session level data permission settings. If configured multiple times in multi-turn conversations within the same session, the last configuration prevails.</para>
            /// </summary>
            [NameInMap("PermissionConfig")]
            [Validation(Required=false)]
            public SendChatMessageRequestSessionConfigPermissionConfig PermissionConfig { get; set; }
            public class SendChatMessageRequestSessionConfigPermissionConfig : TeaModel {
                /// <summary>
                /// <para>The default behavior for table-level permissions. This parameter controls whether tables not configured in DataSources.[item].Permission can be queried. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>allow: Default value. Works in blacklist mode. By default, all tables can be queried, and the actual permissions are subject to the permissions configured in DMS. Row-level and column-level permissions are enforced only when you configure <b>row-level and column-level</b> permissions in DataSources.[item].Permission.</para>
                /// </description></item>
                /// <item><description><para>deny: Works in whitelist mode. You must manually pass this value. By default, no tables can be queried. A table can be queried only when you configure permissions for it in DataSources.[item].Permission. You can grant full access to a table by not configuring any row-level or column-level restrictions.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>allow</para>
                /// </summary>
                [NameInMap("DefaultAction")]
                [Validation(Required=false)]
                public string DefaultAction { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the plan feature. Valid values: <c>[disable, enable, force]</c>. Default value: <c>enable</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disable</para>
            /// </summary>
            [NameInMap("PlanMode")]
            [Validation(Required=false)]
            public string PlanMode { get; set; }

            /// <summary>
            /// <para>The text used to add a watermark to the generated PDF report. The text can be up to 64 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sample-watermark</para>
            /// </summary>
            [NameInMap("ReportWaterMark")]
            [Validation(Required=false)]
            public string ReportWaterMark { get; set; }

            /// <summary>
            /// <para>Specifies whether to disable user inquiries during the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("SkipAskHuman")]
            [Validation(Required=false)]
            public bool? SkipAskHuman { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip the plan confirmation step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("SkipPlan")]
            [Validation(Required=false)]
            public bool? SkipPlan { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip all SQL confirmations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("SkipSqlConfirm")]
            [Validation(Required=false)]
            public bool? SkipSqlConfirm { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip the web report generation confirmation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("SkipWebReportConfirm")]
            [Validation(Required=false)]
            public bool? SkipWebReportConfirm { get; set; }

            /// <summary>
            /// <para>The list of user-specified skills.</para>
            /// </summary>
            [NameInMap("UserSpecifiedSkillList")]
            [Validation(Required=false)]
            public List<string> UserSpecifiedSkillList { get; set; }

            /// <summary>
            /// <para>The default report theme ID for the current session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("WebReportTheme")]
            [Validation(Required=false)]
            public string WebReportTheme { get; set; }

            /// <summary>
            /// <para>交互模式，可选值 analysis（数据分析，默认）/ chat（聊天）</para>
            /// 
            /// <b>Example:</b>
            /// <para>ANALYSIS</para>
            /// </summary>
            [NameInMap("WorkMode")]
            [Validation(Required=false)]
            public string WorkMode { get; set; }

        }

        /// <summary>
        /// <para>The session ID. This is an optional field used for multi-turn sessions.</para>
        /// <list type="bullet">
        /// <item><description>You can start a session without specifying this field. The response will include the session ID for the current session.</description></item>
        /// <item><description>You can also manually create a session ID by calling the CreateDataAgentSession operation and include the ID when initiating the session.</description></item>
        /// <item><description>If you need multi-turn conversations, such as follow-up questions or confirming execution plans, include the session ID returned by the previous SendChatMessage operation in this request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sess_***</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The configuration items that affect only the current task.</para>
        /// </summary>
        [NameInMap("TaskConfig")]
        [Validation(Required=false)]
        public SendChatMessageRequestTaskConfig TaskConfig { get; set; }
        public class SendChatMessageRequestTaskConfig : TeaModel {
            /// <summary>
            /// <para>The configuration of the report rules. A report task is executed based on this configuration only when MessageType is set to REPORT.</para>
            /// </summary>
            [NameInMap("ReportConfig")]
            [Validation(Required=false)]
            public SendChatMessageRequestTaskConfigReportConfig ReportConfig { get; set; }
            public class SendChatMessageRequestTaskConfigReportConfig : TeaModel {
                /// <summary>
                /// <para>The prompt that must be followed for the current report.</para>
                /// 
                /// <b>Example:</b>
                /// <para>generate a report</para>
                /// </summary>
                [NameInMap("ReportPrompt")]
                [Validation(Required=false)]
                public string ReportPrompt { get; set; }

                /// <summary>
                /// <para>The report theme.
                /// The system themes include default, journal, legacy, and neobrutalism, which are globally available theme IDs. You can call the ListDataAgentTheme operation to obtain the IDs of other available themes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("ReportTheme")]
                [Validation(Required=false)]
                public string ReportTheme { get; set; }

                /// <summary>
                /// <para>The service type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TextReport: A text report is generated for the current task.</description></item>
                /// <item><description>WebReport: A web report is generated for the current task.
                /// Currently, only WebReport is supported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>WebReport</para>
                /// </summary>
                [NameInMap("ReportType")]
                [Validation(Required=false)]
                public string ReportType { get; set; }

            }

        }

        /// <summary>
        /// <para>The Object Storage Service (OSS) bucket of the user. If this parameter is left empty, the analysis process is securely stored in the built-in storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-bucket</para>
        /// </summary>
        [NameInMap("UserOssBucket")]
        [Validation(Required=false)]
        public string UserOssBucket { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1p71ne***baexrt3o</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
