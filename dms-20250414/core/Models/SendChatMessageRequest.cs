// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class SendChatMessageRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID. This parameter is required. You can obtain the current agent ID from the response of the CreateAgentSession operation. Agent resources have a lifecycle, so the agent ID that you specify in each request may change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_***</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The Data Management unit you are currently in. If you choose to analyze a database, this information is used to correctly connect to your Data Management instance. You can go to the Data Management console to view your current Data Management unit. If you are a user of the Alibaba Cloud China Website, set this parameter to ap-southeast-1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The data source information. This parameter is optional. You can pass only one data source in this parameter. Use the DataSources parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public SendChatMessageRequestDataSource DataSource { get; set; }
        public class SendChatMessageRequestDataSource : TeaModel {
            /// <summary>
            /// <para>Deprecated. You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The data source type. Valid values: <c>[remote_data_center, database]</c>, indicating that the analysis is performed on a file or a database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remote_data_center</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <para>Deprecated. You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The ID of the database in Data Management.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23******</para>
            /// </summary>
            [NameInMap("DmsDatabaseId")]
            [Validation(Required=false)]
            public string DmsDatabaseId { get; set; }

            /// <summary>
            /// <para>The ID of the instance in Data Management.</para>
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
            /// <para>Deprecated. You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>localhost</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

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
            /// <para>The list of table names to analyze.</para>
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<string> Tables { get; set; }

        }

        /// <summary>
        /// <para>The detailed data source information. This parameter is optional.</para>
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<SendChatMessageRequestDataSources> DataSources { get; set; }
        public class SendChatMessageRequestDataSources : TeaModel {
            /// <summary>
            /// <para>Deprecated. You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The data source type. Valid values: remote_data_center and database, indicating that the analysis is performed on a file or a database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remote_data_center</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <para>Deprecated. You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mydatabase</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The ID of the database in Data Management.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123****</para>
            /// </summary>
            [NameInMap("DmsDatabaseId")]
            [Validation(Required=false)]
            public string DmsDatabaseId { get; set; }

            /// <summary>
            /// <para>The ID of the instance in Data Management.</para>
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
            /// <para>Deprecated. You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>localhost</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

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
            /// <para>The list of table names to analyze.</para>
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<string> Tables { get; set; }

        }

        /// <summary>
        /// <para>The message content to send to the agent.</para>
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
        /// <item><description><para>In normal cases, set the message type to <c>[primary]</c> when interacting with the agent.</para>
        /// </description></item>
        /// <item><description><para>When the message is a response to a human-in-the-loop question from the agent, set the type to <c>[additional]</c>.</para>
        /// </description></item>
        /// <item><description><para>When the message is intended to trigger report generation, set the type to <c>[report]</c>.</para>
        /// </description></item>
        /// <item><description><para>When the message is intended to cancel the current session, set the type to <c>[cancel]</c>.</para>
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
        /// <para>The specific question that the agent asks the user through human-in-the-loop. This parameter is required when the message type is <c>additional</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请提供计算GMV的口径。</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <para>The quoted content. This parameter is typically used when interacting with the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;version&quot;:&quot;v0&quot;}</para>
        /// </summary>
        [NameInMap("QuotedMessage")]
        [Validation(Required=false)]
        public string QuotedMessage { get; set; }

        /// <summary>
        /// <para><b>Important</b></para>
        /// <para>When this message is a reply to an agent message (for example, the agent asks a clarifying question through ASK_HUMAN), set reply_to to the exact Checkpoint sequence number carried in that agent message. If this message is not a targeted reply, such as requesting the agent to perform further in-depth analysis after analysis is complete, you can leave reply_to empty or set it to &quot;0&quot;.  </para>
        /// <para>This field affects how the agent decides to process the message. Passing an incorrect value may cause the analysis results to be less effective than expected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReplyTo")]
        [Validation(Required=false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// <para>The special configuration for this session. Only the configuration passed in the first SendMessage call within the same session takes effect.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SessionConfig")]
        [Validation(Required=false)]
        public SendChatMessageRequestSessionConfig SessionConfig { get; set; }
        public class SendChatMessageRequestSessionConfig : TeaModel {
            /// <summary>
            /// <para>Deprecated. Use the input parameters of CreateAgentSession instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("CustomAgentId")]
            [Validation(Required=false)]
            public string CustomAgentId { get; set; }

            /// <summary>
            /// <para>Deprecated. Use the input parameters of CreateAgentSession instead.</para>
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
            public string EnableSearch { get; set; }

            /// <summary>
            /// <para>The list of knowledge base IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dasd***cc211</para>
            /// </summary>
            [NameInMap("KbUuidList")]
            [Validation(Required=false)]
            public string KbUuidList { get; set; }

            /// <summary>
            /// <para>Only Chinese and English are supported. The default value is Chinese. Only uppercase values are supported.</para>
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
            public string McpServerIds { get; set; }

            /// <summary>
            /// <para>The mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ASK_DATA</b>: data query mode.</description></item>
            /// <item><description><b>ANALYSIS</b>: analysis mode.</description></item>
            /// <item><description><b>INSIGHT</b>: insight mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ANALYSIS</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the plan. Valid values: disable, enable, and force. Default value: enable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disable</para>
            /// </summary>
            [NameInMap("PlanMode")]
            [Validation(Required=false)]
            public string PlanMode { get; set; }

            /// <summary>
            /// <para>The text of up to 64 characters that is used as a watermark in the generated PDF report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例水印</para>
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

        }

        /// <summary>
        /// <para>The session ID. This parameter is required. You can call the CreateAgentSession operation to obtain the session ID.</para>
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
            /// <para>The report rule configuration. Only when MessageType is REPORT, a report task is executed based on this configuration.</para>
            /// </summary>
            [NameInMap("ReportConfig")]
            [Validation(Required=false)]
            public SendChatMessageRequestTaskConfigReportConfig ReportConfig { get; set; }
            public class SendChatMessageRequestTaskConfigReportConfig : TeaModel {
                /// <summary>
                /// <para>The prompt that the report must follow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>generate a report</para>
                /// </summary>
                [NameInMap("ReportPrompt")]
                [Validation(Required=false)]
                public string ReportPrompt { get; set; }

                /// <summary>
                /// <para>The report theme. Valid values: default, journal, legacy, and neobrutalism.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("ReportTheme")]
                [Validation(Required=false)]
                public string ReportTheme { get; set; }

                /// <summary>
                /// <para>The service type. Valid values: TextReport and WebReport, indicating that the task generates a text report or a web report. Only WebReport is supported.</para>
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
        /// <para>The OSS bucket of the user. If this parameter is not specified, the analysis process is securely stored in built-in storage.</para>
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
