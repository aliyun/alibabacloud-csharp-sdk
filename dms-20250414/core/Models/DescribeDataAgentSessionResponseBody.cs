// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeDataAgentSessionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDataAgentSessionResponseBodyData Data { get; set; }
        public class DescribeDataAgentSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cu0cs*******mf</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            [NameInMap("ChatHistoryLocations")]
            [Validation(Required=false)]
            public List<DescribeDataAgentSessionResponseBodyDataChatHistoryLocations> ChatHistoryLocations { get; set; }
            public class DescribeDataAgentSessionResponseBodyDataChatHistoryLocations : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1731645908000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FavoriteInWorkspace")]
            [Validation(Required=false)]
            public string FavoriteInWorkspace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f-8*******01m</para>
            /// </summary>
            [NameInMap("File")]
            [Validation(Required=false)]
            public string File { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Saved")]
            [Validation(Required=false)]
            public bool? Saved { get; set; }

            [NameInMap("SessionConfig")]
            [Validation(Required=false)]
            public DescribeDataAgentSessionResponseBodyDataSessionConfig SessionConfig { get; set; }
            public class DescribeDataAgentSessionResponseBodyDataSessionConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ca-e*******ckd</para>
                /// </summary>
                [NameInMap("CustomAgentId")]
                [Validation(Required=false)]
                public string CustomAgentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>debug</para>
                /// </summary>
                [NameInMap("CustomAgentStage")]
                [Validation(Required=false)]
                public string CustomAgentStage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("EnableSearch")]
                [Validation(Required=false)]
                public bool? EnableSearch { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CHINESE</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("McpServerIds")]
                [Validation(Required=false)]
                public List<string> McpServerIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ANALYSIS</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>976*********p</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("SessionStatus")]
            [Validation(Required=false)]
            public string SessionStatus { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
