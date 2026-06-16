// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAppAssistantAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether a retry is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dewuApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message, which is used to replace the <c>%s</c> placeholder in the <b>ErrMessage</b> response parameter.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, the value of the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public CreateAppAssistantAgentResponseBodyModule Module { get; set; }
        public class CreateAppAssistantAgentResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The agent ID returned by the platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>duanwei@qianrutest</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The name of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试业务空间</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>The business ID of the associated application instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WD20250703155602000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>The authentication credential.</para>
            /// </summary>
            [NameInMap("Credential")]
            [Validation(Required=false)]
            public CreateAppAssistantAgentResponseBodyModuleCredential Credential { get; set; }
            public class CreateAppAssistantAgentResponseBodyModuleCredential : TeaModel {
                /// <summary>
                /// <para>The extended field.</para>
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extra { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The embedding configuration.</para>
            /// </summary>
            [NameInMap("EmbedConfig")]
            [Validation(Required=false)]
            public CreateAppAssistantAgentResponseBodyModuleEmbedConfig EmbedConfig { get; set; }
            public class CreateAppAssistantAgentResponseBodyModuleEmbedConfig : TeaModel {
                /// <summary>
                /// <para>The extended field.</para>
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extra { get; set; }

                /// <summary>
                /// <para>The raw embedding script.</para>
                /// </summary>
                [NameInMap("RawScript")]
                [Validation(Required=false)]
                public string RawScript { get; set; }

            }

            /// <summary>
            /// <para>The extended parameters.</para>
            /// </summary>
            [NameInMap("ExtraParams")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtraParams { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1740479834</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-28T02:25:41Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The application ID of the agent on the platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WA12313131313</para>
            /// </summary>
            [NameInMap("PlatformAppId")]
            [Validation(Required=false)]
            public string PlatformAppId { get; set; }

            /// <summary>
            /// <para>The platform type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VMWARE</para>
            /// </summary>
            [NameInMap("PlatformType")]
            [Validation(Required=false)]
            public string PlatformType { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231313131</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
