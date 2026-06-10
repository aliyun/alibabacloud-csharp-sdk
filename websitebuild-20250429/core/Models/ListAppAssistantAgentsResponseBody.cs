// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppAssistantAgentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>is retry allowed</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>App Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spring-cloud-b</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>dynamic error message, used to replace the <c>%s</c> placeholder in the <b>ErrMessage</b> error message.  </para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it indicates that the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>Returned error parameters</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>response Data</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public List<ListAppAssistantAgentsResponseBodyModule> Module { get; set; }
        public class ListAppAssistantAgentsResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Agent ID (returned by the platform)</para>
            /// 
            /// <b>Example:</b>
            /// <para>liyang1_v@soulapp</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>Agent Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>演示</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>bizId of the associated application instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>WD20250703155602000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>Credential</para>
            /// </summary>
            [NameInMap("Credential")]
            [Validation(Required=false)]
            public ListAppAssistantAgentsResponseBodyModuleCredential Credential { get; set; }
            public class ListAppAssistantAgentsResponseBodyModuleCredential : TeaModel {
                /// <summary>
                /// <para>API key</para>
                /// 
                /// <b>Example:</b>
                /// <para>akm-xxxxxxx</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <para>API Secret</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-xxxxxx</para>
                /// </summary>
                [NameInMap("ApiSecret")]
                [Validation(Required=false)]
                public string ApiSecret { get; set; }

                /// <summary>
                /// <para>Extension field</para>
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extra { get; set; }

                /// <summary>
                /// <para>Password</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>Username</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>Embed configuration</para>
            /// </summary>
            [NameInMap("EmbedConfig")]
            [Validation(Required=false)]
            public ListAppAssistantAgentsResponseBodyModuleEmbedConfig EmbedConfig { get; set; }
            public class ListAppAssistantAgentsResponseBodyModuleEmbedConfig : TeaModel {
                /// <summary>
                /// <para>Extension fields</para>
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extra { get; set; }

                /// <summary>
                /// <para>Raw embed script</para>
                /// </summary>
                [NameInMap("RawScript")]
                [Validation(Required=false)]
                public string RawScript { get; set; }

            }

            /// <summary>
            /// <para>Extension parameters</para>
            /// </summary>
            [NameInMap("ExtraParams")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtraParams { get; set; }

            /// <summary>
            /// <para>Creation Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1740479834</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>Updated At</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-28T02:25:41Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Agent platform appId</para>
            /// 
            /// <b>Example:</b>
            /// <para>WA12313123131</para>
            /// </summary>
            [NameInMap("PlatformAppId")]
            [Validation(Required=false)]
            public string PlatformAppId { get; set; }

            /// <summary>
            /// <para>Platform Type</para>
            /// 
            /// <b>Example:</b>
            /// <para>VMWARE</para>
            /// </summary>
            [NameInMap("PlatformType")]
            [Validation(Required=false)]
            public string PlatformType { get; set; }

            /// <summary>
            /// <para>Status</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>User ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231311312</para>
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
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>abnormal message</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
