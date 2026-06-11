// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateDataAgentSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The response structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDataAgentSessionResponseBodyData Data { get; set; }
        public class CreateDataAgentSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cu0cs*******mf</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The agent status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

            /// <summary>
            /// <para>The time when the session was created, in Unix milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1765262307992</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the associated file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f-8*******01m</para>
            /// </summary>
            [NameInMap("File")]
            [Validation(Required=false)]
            public string File { get; set; }

            /// <summary>
            /// <para>Indicates whether the current user has favorited the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Saved")]
            [Validation(Required=false)]
            public bool? Saved { get; set; }

            /// <summary>
            /// <para>The session configuration.</para>
            /// </summary>
            [NameInMap("SessionConfig")]
            [Validation(Required=false)]
            public CreateDataAgentSessionResponseBodyDataSessionConfig SessionConfig { get; set; }
            public class CreateDataAgentSessionResponseBodyDataSessionConfig : TeaModel {
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
                /// <item><description><para><b>debug</b>: Debug stage</para>
                /// </description></item>
                /// <item><description><para><b>prod</b>: Production stage</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>debug</para>
                /// </summary>
                [NameInMap("CustomAgentStage")]
                [Validation(Required=false)]
                public string CustomAgentStage { get; set; }

                /// <summary>
                /// <para>Indicates whether web search is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
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
                /// <item><description><para><b>CHINESE</b>: Chinese</para>
                /// </description></item>
                /// <item><description><para><b>ENGLISH</b>: English</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CHINESE</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>A list of MCP server IDs.</para>
                /// </summary>
                [NameInMap("McpServerIds")]
                [Validation(Required=false)]
                public List<string> McpServerIds { get; set; }

                /// <summary>
                /// <para>The mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>ASK_DATA</b>: Quick Inquiry Mode</para>
                /// </description></item>
                /// <item><description><para><b>ANALYSIS</b>: Analysis Mode</para>
                /// </description></item>
                /// <item><description><para><b>INSIGHT</b>: Insight Mode</para>
                /// </description></item>
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
                /// <para>The name of the user\&quot;s OSS bucket.</para>
                /// <list type="bullet">
                /// <item><description>Analysis files and report artifacts can be uploaded to this OSS bucket.</description></item>
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
            /// <para>The session title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>帮我分析一下这份数据，给出报告。</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

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
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CB***********3F1A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
