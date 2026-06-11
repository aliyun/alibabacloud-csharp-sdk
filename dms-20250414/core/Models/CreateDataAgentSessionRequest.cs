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
            /// <para>The custom agent stage. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>debug</b>: Test stage.</para>
            /// </description></item>
            /// <item><description><para><b>prod</b>: Production stage.</para>
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
            /// <para>Specifies whether to enable web search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
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
            /// <item><description><para><b>ASK_DATA</b>: Quick inquiry mode.</para>
            /// </description></item>
            /// <item><description><para><b>ANALYSIS</b>: Analysis mode.</para>
            /// </description></item>
            /// <item><description><para><b>INSIGHT</b>: Insight mode.</para>
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
            /// <para>The OSS bucket name.</para>
            /// <list type="bullet">
            /// <item><description>This bucket stores intermediate files and report artifacts from the analysis.</description></item>
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
        /// <para>The session title. Supports Chinese and English. Maximum length: 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>帮我分析一下这份数据，给出报告。</para>
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
