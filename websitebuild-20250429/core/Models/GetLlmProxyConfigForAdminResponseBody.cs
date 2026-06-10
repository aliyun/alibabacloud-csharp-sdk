// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetLlmProxyConfigForAdminResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed reason for access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retry is allowed. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>false: Retry is not allowed.  </description></item>
        /// <item><description>true: Retry is allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>Application name. Query the application with this name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Dynamic code. This parameter is not used and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>Dynamic error message used to replace the <c>%s</c> placeholder in the <b>ErrMessage</b> error message.  </para>
        /// <remarks>
        /// <para>For example, if <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it indicates that the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>Error parameters returned.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>Returned object.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetLlmProxyConfigForAdminResponseBodyModule Module { get; set; }
        public class GetLlmProxyConfigForAdminResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>List of supported models</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.5-plus</para>
            /// </summary>
            [NameInMap("AllowedModels")]
            [Validation(Required=false)]
            public string AllowedModels { get; set; }

            /// <summary>
            /// <para>Business ID of the application instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>WD20250703155602000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>List of blocked models</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.5-plus</para>
            /// </summary>
            [NameInMap("BlockedModels")]
            [Validation(Required=false)]
            public string BlockedModels { get; set; }

            /// <summary>
            /// <para>Grants specific permissions to processes within the container. Currently, only NET_ADMIN and NET_RAW are supported.  </para>
            /// <remarks>
            /// <para>NET_RAW is not supported by default. You must submit a ticket to request it.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>adds2</para>
            /// </summary>
            [NameInMap("Capability")]
            [Validation(Required=false)]
            public string Capability { get; set; }

            /// <summary>
            /// <para>Daily request quota</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("DailyLimit")]
            [Validation(Required=false)]
            public int? DailyLimit { get; set; }

            /// <summary>
            /// <para>Daily token quota</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("DailyTokenLimit")]
            [Validation(Required=false)]
            public long? DailyTokenLimit { get; set; }

            /// <summary>
            /// <para>Indicates whether scheduled delivery of resource snapshots is enabled.  </para>
            /// <para>Valid values:  </para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.  </description></item>
            /// <item><description>false: Shutdown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Extension configuration (in JSON format)</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;deliveryNodeName\&quot;:\&quot;绑定域名及发布\&quot;,\&quot;deliveryNodeStatus\&quot;:\&quot;Finish\&quot;,\&quot;deliveryOperatorRole\&quot;:\&quot;Provider\&quot;}</para>
            /// </summary>
            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

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
            /// <para>Primary key</para>
            /// 
            /// <b>Example:</b>
            /// <para>16257</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>IP blacklist</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.41.11.161,10.200.255.60</para>
            /// </summary>
            [NameInMap("IpBlacklist")]
            [Validation(Required=false)]
            public string IpBlacklist { get; set; }

            /// <summary>
            /// <para>IP whitelist, with multiple entries separated by commas</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.41.11.161,10.200.255.60</para>
            /// </summary>
            [NameInMap("IpWhitelist")]
            [Validation(Required=false)]
            public string IpWhitelist { get; set; }

            /// <summary>
            /// <para>Requests per minute quota</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("RpmLimit")]
            [Validation(Required=false)]
            public int? RpmLimit { get; set; }

            /// <summary>
            /// <para>trial, draft, live, refunded, expired, released</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Reason for pause.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("SuspendReason")]
            [Validation(Required=false)]
            public string SuspendReason { get; set; }

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
        /// <para>Abnormal message</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is processed synchronously.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
