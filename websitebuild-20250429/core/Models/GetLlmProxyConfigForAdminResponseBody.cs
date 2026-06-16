// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetLlmProxyConfigForAdminResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why access is denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retries are allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Retries are not allowed.</description></item>
        /// <item><description>true: Retries are allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The application name. The application with this name is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic code. This parameter is not in use. Ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message. This parameter is used to replace the <c>%s</c> variable in the <b>ErrMessage</b> parameter.</para>
        /// <remarks>
        /// <para>For example, if the <b>ErrMessage</b> parameter returns <b>The Value of Input Parameter %s is not valid</b> and the <b>DynamicMessage</b> parameter returns <b>DtsJobId</b>, the <b>DtsJobId</b> request parameter is invalid.</para>
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
        /// <para>The returned object.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetLlmProxyConfigForAdminResponseBodyModule Module { get; set; }
        public class GetLlmProxyConfigForAdminResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of allowed models.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.5-plus</para>
            /// </summary>
            [NameInMap("AllowedModels")]
            [Validation(Required=false)]
            public string AllowedModels { get; set; }

            /// <summary>
            /// <para>The business ID of the application instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WD20250703155602000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>The list of blocked models.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.5-plus</para>
            /// </summary>
            [NameInMap("BlockedModels")]
            [Validation(Required=false)]
            public string BlockedModels { get; set; }

            /// <summary>
            /// <para>The specific permissions granted to processes in the container. Only NET_ADMIN and NET_RAW are supported.</para>
            /// <remarks>
            /// <para>NET_RAW is not supported by default. Submit a ticket to apply for this permission.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>adds2</para>
            /// </summary>
            [NameInMap("Capability")]
            [Validation(Required=false)]
            public string Capability { get; set; }

            /// <summary>
            /// <para>The maximum number of requests per day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("DailyLimit")]
            [Validation(Required=false)]
            public int? DailyLimit { get; set; }

            /// <summary>
            /// <para>The maximum number of tokens per day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("DailyTokenLimit")]
            [Validation(Required=false)]
            public long? DailyTokenLimit { get; set; }

            /// <summary>
            /// <para>Specifies whether scheduled delivery of resource snapshots is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The extended configuration in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;deliveryNodeName\&quot;:\&quot;绑定域名及发布\&quot;,\&quot;deliveryNodeStatus\&quot;:\&quot;Finish\&quot;,\&quot;deliveryOperatorRole\&quot;:\&quot;Provider\&quot;}</para>
            /// </summary>
            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

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
            /// <para>The primary key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16257</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The IP blacklist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.41.11.161,10.200.255.60</para>
            /// </summary>
            [NameInMap("IpBlacklist")]
            [Validation(Required=false)]
            public string IpBlacklist { get; set; }

            /// <summary>
            /// <para>The IP whitelist. Separate multiple IP addresses with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.41.11.161,10.200.255.60</para>
            /// </summary>
            [NameInMap("IpWhitelist")]
            [Validation(Required=false)]
            public string IpWhitelist { get; set; }

            /// <summary>
            /// <para>The maximum number of requests per minute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("RpmLimit")]
            [Validation(Required=false)]
            public int? RpmLimit { get; set; }

            /// <summary>
            /// <para>trial,draft,live,refunded,expired,released</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The reason for suspension.</para>
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
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The exception message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is synchronously processed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
