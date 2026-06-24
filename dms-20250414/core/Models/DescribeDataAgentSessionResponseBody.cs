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

            /// <summary>
            /// <para>The list of artifacts produced by the session. Currently, only reports are included.</para>
            /// </summary>
            [NameInMap("Artifacts")]
            [Validation(Required=false)]
            public List<DescribeDataAgentSessionResponseBodyDataArtifacts> Artifacts { get; set; }
            public class DescribeDataAgentSessionResponseBodyDataArtifacts : TeaModel {
                /// <summary>
                /// <para>The brief description of the artifact. This value may be empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a simple report</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the backend completed the artifact task. This is a UNIX timestamp accurate to the second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1778743587</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The globally unique artifact ID. If the report is produced by calling SendChatMessage with MessageType set to REPORT, the artifact ID is the same as the MessageId returned by the SendChatMessage operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bab******33e1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The artifact name. This is typically a string concatenated by the system. It is aligned with the name field in the ListFileUpload operation. You can use this field to query the download URL of the artifact file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>report_****_2026****</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The time when the backend received the artifact request. This is a UNIX timestamp accurate to the second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1778743587</para>
                /// </summary>
                [NameInMap("ReceiveTime")]
                [Validation(Required=false)]
                public string ReceiveTime { get; set; }

                /// <summary>
                /// <para>The time when the backend actually started running the artifact task. This is a UNIX timestamp accurate to the second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1778743587</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The artifact status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>PENDING: The backend has received the task but has not started it.</para>
                /// </description></item>
                /// <item><description><para>RUNNING: The backend has started the task but has not completed it.</para>
                /// </description></item>
                /// <item><description><para>SUCCESS: The task succeeded. You can query the file information by calling the ListFileUpload operation.</para>
                /// </description></item>
                /// <item><description><para>FAILED: The task failed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PENDING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The artifact type. Valid values: TextReport and WebReport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WebReport</para>
                /// </summary>
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
            /// <para>The time when the session was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731645908000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The list of data sources used in the current session.</para>
            /// </summary>
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<DescribeDataAgentSessionResponseBodyDataDataSources> DataSources { get; set; }
            public class DescribeDataAgentSessionResponseBodyDataDataSources : TeaModel {
                /// <summary>
                /// <para>The data source category. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>CHAT</b>: specified through the CreateDataAgentSession or SendChatMessage operation during a conversation.</para>
                /// </description></item>
                /// <item><description><para><b>CUSTOM_AGENT</b>: from the preset analysis data scope in a custom agent.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CHAT</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The data source details.</para>
                /// <para>When Category is CHAT or CUSTOM_AGENT, the structure of Detail is aligned with the structure of a single element in the DataSources parameter of the SendChatMessage operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the session is saved to favorites in the workspace by the current user.</para>
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

            /// <summary>
            /// <para>The recall results from the knowledge base and memory for this session.</para>
            /// </summary>
            [NameInMap("RecallResults")]
            [Validation(Required=false)]
            public List<DescribeDataAgentSessionResponseBodyDataRecallResults> RecallResults { get; set; }
            public class DescribeDataAgentSessionResponseBodyDataRecallResults : TeaModel {
                /// <summary>
                /// <para>The content of the recalled knowledge chunk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sky is blue</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The similarity score of this data entry. The scoring algorithm is related to the algorithm (l2/ip/cosine) specified when the index was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.65</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <para>The type of recalled knowledge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>memory</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the session is saved to favorites by the current user.</para>
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
                /// <item><description><b>debug</b>: the debugging stage.</description></item>
                /// <item><description><b>prod</b>: the production stage.</description></item>
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

                /// <summary>
                /// <para>The encryption key for storing artifacts in OSS (including built-in and user-specified OSS). This is typically specified in CreateDataAgentSession.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ay***1Te</para>
                /// </summary>
                [NameInMap("EncryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                /// <summary>
                /// <para>The encryption type for storing artifacts in OSS (including built-in and user-specified OSS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public string EncryptType { get; set; }

                /// <summary>
                /// <para>The list of knowledge base IDs for this session.</para>
                /// </summary>
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
                /// <item><description><b>ASK_DATA</b>: the data query mode.</description></item>
                /// <item><description><b>ANALYSIS</b>: the analysis mode.</description></item>
                /// <item><description><b>INSIGHT</b>: the insight mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ANALYSIS</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The report page width.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300mm</para>
                /// </summary>
                [NameInMap("ReportPageWidth")]
                [Validation(Required=false)]
                public long? ReportPageWidth { get; set; }

                /// <summary>
                /// <para>The report watermark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("ReportWaterMark")]
                [Validation(Required=false)]
                public string ReportWaterMark { get; set; }

                /// <summary>
                /// <para>The name of the user OSS bucket. Analysis process files and report artifacts can be uploaded to the user-specified OSS bucket.</para>
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
        /// <item><description><b>true</b>: The operation was successful.</description></item>
        /// <item><description><b>false</b>: The operation failed.</description></item>
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
