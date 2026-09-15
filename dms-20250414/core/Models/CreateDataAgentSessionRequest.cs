// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateDataAgentSessionRequest : TeaModel {
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
        /// <para>The file ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f-8*******01m</para>
        /// </summary>
        [NameInMap("File")]
        [Validation(Required=false)]
        public string File { get; set; }

        /// <summary>
        /// <para>The session configuration.</para>
        /// </summary>
        [NameInMap("SessionConfig")]
        [Validation(Required=false)]
        public CreateDataAgentSessionRequestSessionConfig SessionConfig { get; set; }
        public class CreateDataAgentSessionRequestSessionConfig : TeaModel {
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
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableSearch")]
            [Validation(Required=false)]
            public bool? EnableSearch { get; set; }

            /// <summary>
            /// <para>The encryption key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("EncryptKey")]
            [Validation(Required=false)]
            public string EncryptKey { get; set; }

            /// <summary>
            /// <para>The encryption type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("EncryptType")]
            [Validation(Required=false)]
            public string EncryptType { get; set; }

            /// <summary>
            /// <para>The list of knowledge base IDs.</para>
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
            /// <para>The list of MCP header configurations.</para>
            /// </summary>
            [NameInMap("McpHeaders")]
            [Validation(Required=false)]
            public List<CreateDataAgentSessionRequestSessionConfigMcpHeaders> McpHeaders { get; set; }
            public class CreateDataAgentSessionRequestSessionConfigMcpHeaders : TeaModel {
                /// <summary>
                /// <para>The MCP header configuration.</para>
                /// </summary>
                [NameInMap("McpHeader")]
                [Validation(Required=false)]
                public List<CreateDataAgentSessionRequestSessionConfigMcpHeadersMcpHeader> McpHeader { get; set; }
                public class CreateDataAgentSessionRequestSessionConfigMcpHeadersMcpHeader : TeaModel {
                    /// <summary>
                    /// <para>The key to add to the header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UserId</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value to add to the header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>421****571</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the MCP server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1fl4r*****1qi</para>
                /// </summary>
                [NameInMap("McpServerId")]
                [Validation(Required=false)]
                public string McpServerId { get; set; }

            }

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
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReportPageWidth")]
            [Validation(Required=false)]
            public long? ReportPageWidth { get; set; }

            /// <summary>
            /// <para>The report watermark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ReportWaterMark")]
            [Validation(Required=false)]
            public string ReportWaterMark { get; set; }

            /// <summary>
            /// <para>The name of the user OSS bucket. Analysis process files and report artifacts can be uploaded to the specified OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-oss-bucket</para>
            /// </summary>
            [NameInMap("UserOssBucket")]
            [Validation(Required=false)]
            public string UserOssBucket { get; set; }

        }

        /// <summary>
        /// <para>The title. Chinese and English characters are supported. Maximum length: 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Help me analyze this data and generate a report</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
