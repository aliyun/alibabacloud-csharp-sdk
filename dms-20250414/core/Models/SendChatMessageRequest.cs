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
        /// <para>The data source information. This parameter can be left empty. You can specify only one data source for this parameter. We recommend that you use the DataSources parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public SendChatMessageRequestDataSource DataSource { get; set; }
        public class SendChatMessageRequestDataSource : TeaModel {
            /// <summary>
            /// <para><b>[Deprecated]</b> You do not need to specify this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The data source type. Valid values: remote_data_center and database, which indicate that the analysis target is a file or a database, respectively.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remote_data_center</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> You do not need to specify this field.</para>
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
            /// <para>The type of the database.</para>
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
            /// <para><b>[Deprecated]</b> You do not need to specify this field.</para>
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
                    /// <para>The list of fields that are allowed to be queried in the current table. If you do not specify this parameter, all fields can be queried. If you specify this parameter, SQL statements that query fields outside the allowed range, such as the <c>SELECT *</c> syntax, will be blocked. To ensure the analysis performance of DataAgent, make sure that the prompts, knowledge, and instructions modules of DataAgent do not include fields outside the allowed range. Otherwise, unauthorized SQL statements may be generated and blocked, which degrades the analysis speed and performance of DataAgent.</para>
                    /// </summary>
                    [NameInMap("AllowedColumns")]
                    [Validation(Required=false)]
                    public List<string> AllowedColumns { get; set; }

                    /// <summary>
                    /// <para>The list of fields that are prohibited from being queried in the current table. If you do not specify this parameter, all fields <b>can be queried</b>. If you specify this parameter, SQL statements that query fields outside the allowed range, such as the <c>SELECT *</c> syntax, will be blocked.  </para>
                    /// <para>If both the prohibited list and the allowed list are configured, the prohibited list takes precedence. For example, if Table 1 has columns A, B, C, and D, and you configure columns A and B as non-queryable while configuring columns B and C as queryable, only column C is ultimately queryable.</para>
                    /// <para>To ensure the analysis performance of DataAgent, make sure that the prompts, knowledge, and instructions modules of DataAgent do not include fields outside the allowed range. Otherwise, unauthorized SQL statements may be generated and blocked, which degrades the analysis speed and performance of DataAgent.</para>
                    /// </summary>
                    [NameInMap("DisallowedColumns")]
                    [Validation(Required=false)]
                    public List<string> DisallowedColumns { get; set; }

                    /// <summary>
                    /// <para>The row filter condition that must be included for the current table. If you do not specify this parameter, it is ignored. If you specify this parameter, the system checks whether all SQL statements involving this table include the filter field and whether the WHERE condition meets the constraints. SQL statements that do not meet the constraints will be rejected. Pay attention to the format of the validation condition.</para>
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
            /// <para>The data source resource identifier.</para>
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
            /// <para><b>[Deprecated]</b> You do not need to specify this field.</para>
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
            /// <para><b>[Deprecated]</b> You do not need to specify this field.</para>
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
            /// <para>The type of the database.</para>
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
            /// <para><b>[Deprecated]</b> You do not need to specify this field.</para>
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
                    /// <para>The list of columns that are allowed to be queried in the current table. If you do not specify this parameter, all columns can be queried. If you specify this parameter, SQL statements that query columns beyond the allowed scope are blocked. For example, syntax such as SELECT * is blocked. To ensure the analysis performance of DataAgent, make sure that the prompts, knowledge, and instructions of DataAgent do not include columns beyond the allowed scope. Otherwise, unauthorized SQL statements are generated and blocked, which reduces the analysis speed and performance of DataAgent.</para>
                    /// </summary>
                    [NameInMap("AllowedColumns")]
                    [Validation(Required=false)]
                    public List<string> AllowedColumns { get; set; }

                    /// <summary>
                    /// <para>The list of fields that are prohibited from being queried in the current table. If you do not specify this parameter, all fields <b>can be queried</b>. If you specify this parameter, SQL statements that query fields outside the allowed range, such as the <c>SELECT *</c> syntax, will be blocked.  </para>
                    /// <para>If both the prohibited list and the allowed list are configured, the prohibited list takes precedence. For example, if Table 1 has columns A, B, C, and D, and you configure columns A and B as non-queryable while configuring columns B and C as queryable, only column C is ultimately queryable.</para>
                    /// <para>To ensure the analysis performance of DataAgent, make sure that the prompts, knowledge, and instructions modules of DataAgent do not include fields outside the allowed range. Otherwise, unauthorized SQL statements may be generated and blocked, which degrades the analysis speed and performance of DataAgent.</para>
                    /// </summary>
                    [NameInMap("DisallowedColumns")]
                    [Validation(Required=false)]
                    public List<string> DisallowedColumns { get; set; }

                    /// <summary>
                    /// <para>The row filter condition that must be included for the current table. If you do not specify this parameter, it is ignored. If you specify this parameter, the system checks whether all SQL statements involving this table include the filter field and whether the WHERE condition meets the constraints. SQL statements that do not meet the constraints will be rejected. Pay attention to the format of the validation condition.</para>
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
            /// <para>The data source resource identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>datalake://abc/def</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        /// <summary>
        /// <para>The content of the message sent to the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>what can you do?</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The message type. Default value: primary.</para>
        /// <list type="bullet">
        /// <item><description>In normal interactions with the agent, the message type is primary.</description></item>
        /// <item><description>When the message is a response to a human-in-the-loop question from the agent, the type must be additional.</description></item>
        /// <item><description>When the message is intended to trigger report generation, the type must be report.</description></item>
        /// <item><description>When the message is intended to cancel the current session, the type must be cancel.</description></item>
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
        /// <para>Required when the message type is additional. Specifies the specific question asked by the agent to the user through human-in-the-loop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Provide the calculation criteria for GMV</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <para>The current quoted content. This is typically used during interactions with the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;version&quot;:&quot;v0&quot;}</para>
        /// </summary>
        [NameInMap("QuotedMessage")]
        [Validation(Required=false)]
        public string QuotedMessage { get; set; }

        /// <summary>
        /// <para><b>Important</b></para>
        /// <para>When this message is a reply to an agent message (such as the agent asking for clarification through ASK_HUMAN), reply_to must exactly match the Checkpoint sequence number carried by that agent message. If this message is not a targeted reply, such as requesting the agent to perform further in-depth analysis after the initial analysis is complete, you can leave reply_to empty or set it to 0.  </para>
        /// <para>This field affects how the agent decides to process the message. Passing an incorrect value may lead to suboptimal analysis results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReplyTo")]
        [Validation(Required=false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// <para>The special configurations for the current session. For the same session, only the configurations passed during the first SendMessage call take effect.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SessionConfig")]
        [Validation(Required=false)]
        public SendChatMessageRequestSessionConfig SessionConfig { get; set; }
        public class SendChatMessageRequestSessionConfig : TeaModel {
            /// <summary>
            /// <para>The custom agent ID. A custom agent is an entity used to customize the analysis process. You can create it in the DataAgent console or by calling the CreateCustomAgent operation. A custom agent ID must be a string starting with ca-.</para>
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
            /// <para>The language. Only Chinese and English are supported. The default value is Chinese. Only uppercase letters are supported.</para>
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
            /// <para>The data permission settings at the session level. If configured multiple times in multi-turn conversations within the same session, the last configuration prevails.</para>
            /// </summary>
            [NameInMap("PermissionConfig")]
            [Validation(Required=false)]
            public SendChatMessageRequestSessionConfigPermissionConfig PermissionConfig { get; set; }
            public class SendChatMessageRequestSessionConfigPermissionConfig : TeaModel {
                /// <summary>
                /// <para>The default behavior for table-level permissions. This parameter controls whether tables not configured in DataSources.[item].Permission can be queried. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>allow: Works in blacklist mode. This is the default value. By default, all tables can be queried, and the actual permissions are subject to the permissions configured in DMS. Only when you configure <b>row- and column-level</b> permissions in DataSources.[item].Permission will row- and column-level permissions be enforced.</description></item>
                /// <item><description>deny: Works in whitelist mode. You must manually specify this value. By default, no tables can be queried. A table can be queried only when you configure permissions for it in DataSources.[item].Permission. You can grant full access to a table by not configuring any row- or column-level restrictions.</description></item>
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
            /// <para>Specifies whether to enable the plan feature. Valid values: disable, enable, and force. Default value: enable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disable</para>
            /// </summary>
            [NameInMap("PlanMode")]
            [Validation(Required=false)]
            public string PlanMode { get; set; }

            /// <summary>
            /// <para>The text to be added as a watermark to the generated PDF report. The text can be up to 64 characters in length.</para>
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

        }

        /// <summary>
        /// <para>The session ID. This is an optional field used for multi-turn sessions.</para>
        /// <list type="bullet">
        /// <item><description>You can start a session without specifying this field, and the response will include the SessionID for the current session.</description></item>
        /// <item><description>You can also manually create a session ID by calling the CreateDataAgentSession operation and include the ID when initiating the session.</description></item>
        /// <item><description>If you need multi-turn conversations (such as follow-up questions or confirming execution plans), include the SessionID returned by the previous SendChatMessage operation in this API call.</description></item>
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
                /// <para>The prompt that the current report must follow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>generate a report</para>
                /// </summary>
                [NameInMap("ReportPrompt")]
                [Validation(Required=false)]
                public string ReportPrompt { get; set; }

                /// <summary>
                /// <para>The report theme. System themes include default, journal, legacy, and neobrutalism, which are globally available theme IDs. You can call the ListDataAgentTheme operation to obtain other available theme IDs.</para>
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
                /// <item><description>TextReport: The task generates a text report.</description></item>
                /// <item><description>WebReport: The task generates a web report.
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
        /// <para>The Object Storage Service (OSS) bucket of the user. If you do not specify this parameter, the analysis process is securely stored in the built-in storage.</para>
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
