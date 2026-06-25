// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class SendChatMessageRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID. This is a required field. You can obtain the current AgentId from the return value of the CreateAgentSession operation. Agent resources have a lifecycle, so the AgentId you need to pass in each request may change.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_***</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The DMS unit you are currently in. If you choose to analyze a database, this information will be used to correctly connect to your DMS instance through DMS. You can go to the DMS console to check your current DMS unit. If you are a China site user of Alibaba Cloud, you can directly enter cn-hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The data source information. This parameter can be left empty. Only one data source can be passed in through this parameter. We recommend that you use the DataSources parameter instead.</para>
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
            /// <para>The data source type. Valid values: <c>[remote_data_center, database]</c>, which indicate whether the current analysis is for a file or a database respectively.</para>
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
            /// <para>The ID of the database in DMS.</para>
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
        /// <para>The detailed data source information. This parameter can be left empty.</para>
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
            /// <para>The data source type. Valid values: [remote_data_center, database], which indicate whether the current analysis is for a file or a database respectively.</para>
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
            /// <para>The ID of the database in DMS.</para>
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
        /// <para>The content of the message to be sent to the Agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>what can you do?</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The message type. Default value: <c>[primary]</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>In normal cases, when interacting with the Agent, the message type is <c>[primary]</c>.</para>
        /// </description></item>
        /// <item><description><para>When the message is a response to the Agent\&quot;s Human-in-Loop question, the type should be <c>[additional]</c>.</para>
        /// </description></item>
        /// <item><description><para>When the message is intended to trigger a report generation, the type should be <c>[report]</c>.</para>
        /// </description></item>
        /// <item><description><para>When the message is intended to cancel the current session, the type should be <c>[cancel]</c>.</para>
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
        /// <para>This field is required when the message type is <c>additional</c>. Pass in the specific question that the Agent asked the user through Human-in-Loop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请提供计算GMV的口径。</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <para>Pass in the current quoted content, typically used when interacting with the Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;version&quot;:&quot;v0&quot;}</para>
        /// </summary>
        [NameInMap("QuotedMessage")]
        [Validation(Required=false)]
        public string QuotedMessage { get; set; }

        /// <summary>
        /// <para><b>Important</b></para>
        /// <para>When this message is a reply to an Agent message (for example, when the Agent asks for clarification through ASK_HUMAN), reply_to must be set to the exact Checkpoint number carried in that Agent message. If this message is not a specific reply, such as requesting the Agent for further in-depth analysis after analysis is completed, reply_to can be left empty or set to &quot;0&quot;.</para>
        /// <para>This field affects how the Agent decides to process the message. Passing an incorrect value may lead to analysis results that do not meet expectations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReplyTo")]
        [Validation(Required=false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// <para>The special configuration for this session. For the same session, only the configuration passed in the first SendMessage call takes effect.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SessionConfig")]
        [Validation(Required=false)]
        public SendChatMessageRequestSessionConfig SessionConfig { get; set; }
        public class SendChatMessageRequestSessionConfig : TeaModel {
            /// <summary>
            /// <para>Deprecated. The value specified in CreateAgentSession takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("CustomAgentId")]
            [Validation(Required=false)]
            public string CustomAgentId { get; set; }

            /// <summary>
            /// <para>Deprecated. The value specified in CreateAgentSession takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("CustomAgentStage")]
            [Validation(Required=false)]
            public string CustomAgentStage { get; set; }

            /// <summary>
            /// <para>Currently only Chinese and English are supported. The default is Chinese. Only uppercase values are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENGLISH</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The mode:</para>
            /// <list type="bullet">
            /// <item><description><b>ASK_DATA</b>: Ask Data mode</description></item>
            /// <item><description><b>ANALYSIS</b>: Analysis mode</description></item>
            /// <item><description><b>INSIGHT</b>: Insight mode</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ANALYSIS</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>You can enter text of up to 64 characters, which will be used as a watermark in the generated PDF report.</para>
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
        /// <para>The session ID. This is a required field. You can obtain the SessionId by calling CreateAgentSession.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sess_***</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The configuration items that only affect the current task.</para>
        /// </summary>
        [NameInMap("TaskConfig")]
        [Validation(Required=false)]
        public SendChatMessageRequestTaskConfig TaskConfig { get; set; }
        public class SendChatMessageRequestTaskConfig : TeaModel {
            /// <summary>
            /// <para>The report rule configuration. Only when MessageType is REPORT, a report task will be executed based on this configuration.</para>
            /// </summary>
            [NameInMap("ReportConfig")]
            [Validation(Required=false)]
            public SendChatMessageRequestTaskConfigReportConfig ReportConfig { get; set; }
            public class SendChatMessageRequestTaskConfigReportConfig : TeaModel {
                /// <summary>
                /// <para>The prompt that this report should follow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>generate a report</para>
                /// </summary>
                [NameInMap("ReportPrompt")]
                [Validation(Required=false)]
                public string ReportPrompt { get; set; }

                /// <summary>
                /// <para>The report theme. Currently supported values: [default, journal, legacy, neobrutalism].</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("ReportTheme")]
                [Validation(Required=false)]
                public string ReportTheme { get; set; }

                /// <summary>
                /// <para>The service type. Valid values: TextReport and WebReport, which indicate whether this task generates a text report or a web report. Currently, only the WebReport type is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WebReport</para>
                /// </summary>
                [NameInMap("ReportType")]
                [Validation(Required=false)]
                public string ReportType { get; set; }

            }

        }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
