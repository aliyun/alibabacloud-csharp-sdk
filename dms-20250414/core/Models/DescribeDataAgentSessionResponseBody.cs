// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeDataAgentSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDataAgentSessionResponseBodyData Data { get; set; }
        public class DescribeDataAgentSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cu0cs*******mf</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The current agent status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            [NameInMap("Artifacts")]
            [Validation(Required=false)]
            public List<DescribeDataAgentSessionResponseBodyDataArtifacts> Artifacts { get; set; }
            public class DescribeDataAgentSessionResponseBodyDataArtifacts : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ReceiveTime")]
                [Validation(Required=false)]
                public string ReceiveTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The chat replay history.</para>
            /// </summary>
            [NameInMap("ChatHistoryLocations")]
            [Validation(Required=false)]
            public List<DescribeDataAgentSessionResponseBodyDataChatHistoryLocations> ChatHistoryLocations { get; set; }
            public class DescribeDataAgentSessionResponseBodyDataChatHistoryLocations : TeaModel {
                /// <summary>
                /// <para>The key of the chat replay history.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKey1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The OSS download URL of the chat replay history.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The session creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731645908000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<DescribeDataAgentSessionResponseBodyDataDataSources> DataSources { get; set; }
            public class DescribeDataAgentSessionResponseBodyDataDataSources : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the session is saved as a favorite in the workspace by the current logged-in user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FavoriteInWorkspace")]
            [Validation(Required=false)]
            public string FavoriteInWorkspace { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f-8*******01m</para>
            /// </summary>
            [NameInMap("File")]
            [Validation(Required=false)]
            public string File { get; set; }

            [NameInMap("RecallResults")]
            [Validation(Required=false)]
            public List<DescribeDataAgentSessionResponseBodyDataRecallResults> RecallResults { get; set; }
            public class DescribeDataAgentSessionResponseBodyDataRecallResults : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the session is saved as a favorite by the current logged-in user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Saved")]
            [Validation(Required=false)]
            public bool? Saved { get; set; }

            /// <summary>
            /// <para>The session configuration item.</para>
            /// </summary>
            [NameInMap("SessionConfig")]
            [Validation(Required=false)]
            public DescribeDataAgentSessionResponseBodyDataSessionConfig SessionConfig { get; set; }
            public class DescribeDataAgentSessionResponseBodyDataSessionConfig : TeaModel {
                /// <summary>
                /// <para>The custom agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ca-e*******ckd</para>
                /// </summary>
                [NameInMap("CustomAgentId")]
                [Validation(Required=false)]
                public string CustomAgentId { get; set; }

                /// <summary>
                /// <para>The stage of the custom agent. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>debug</b>: Debug stage.</description></item>
                /// <item><description><b>prod</b>: Production stage.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>debug</para>
                /// </summary>
                [NameInMap("CustomAgentStage")]
                [Validation(Required=false)]
                public string CustomAgentStage { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable web search.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("EnableSearch")]
                [Validation(Required=false)]
                public bool? EnableSearch { get; set; }

                [NameInMap("EncryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public string EncryptType { get; set; }

                [NameInMap("KbUuidList")]
                [Validation(Required=false)]
                public List<string> KbUuidList { get; set; }

                /// <summary>
                /// <para>The language. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CHINESE</b>: Chinese.</description></item>
                /// <item><description><b>ENGLISH</b>: English.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CHINESE</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>The list of MCP server IDs in the session configuration.</para>
                /// </summary>
                [NameInMap("McpServerIds")]
                [Validation(Required=false)]
                public List<string> McpServerIds { get; set; }

                /// <summary>
                /// <para>The mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ASK_DATA</b>: Ask data mode.</description></item>
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

                [NameInMap("ReportPageWidth")]
                [Validation(Required=false)]
                public long? ReportPageWidth { get; set; }

                [NameInMap("ReportWaterMark")]
                [Validation(Required=false)]
                public string ReportWaterMark { get; set; }

                /// <summary>
                /// <para>The name of the user OSS bucket.</para>
                /// <list type="bullet">
                /// <item><description>Analysis process files and report artifacts can be uploaded to the user-specified OSS bucket.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>user-oss-bucket</para>
                /// </summary>
                [NameInMap("UserOssBucket")]
                [Validation(Required=false)]
                public string UserOssBucket { get; set; }

            }

            /// <summary>
            /// <para>The agent session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>976*********p</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The session status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("SessionStatus")]
            [Validation(Required=false)]
            public string SessionStatus { get; set; }

            /// <summary>
            /// <para>The title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>分析一下这份文件，给出报告。</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The ID of the session owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2096******</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

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
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>18****-*****-*******7A3122F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
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
