// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAppInstanceTicketResponseBody : TeaModel {
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
        /// <para>Whether to allow retry</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>App name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spring-cloud-b</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>Dynamic error message, used to replace the <c>%s</c> in the <b>ErrMessage</b> error message.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b>, and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it means that the input request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERRROR</para>
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
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public CreateAppInstanceTicketResponseBodyModule Module { get; set; }
        public class CreateAppInstanceTicketResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Access token expiration time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1768619049924</para>
            /// </summary>
            [NameInMap("AccessTokenExpiresAt")]
            [Validation(Required=false)]
            public string AccessTokenExpiresAt { get; set; }

            /// <summary>
            /// <para>Access token issuance time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1768619049924</para>
            /// </summary>
            [NameInMap("AccessTokenIssuedAt")]
            [Validation(Required=false)]
            public string AccessTokenIssuedAt { get; set; }

            /// <summary>
            /// <para>Access token value</para>
            /// 
            /// <b>Example:</b>
            /// <para>be9750d595b6cd7c93a80b46</para>
            /// </summary>
            [NameInMap("AccessTokenValue")]
            [Validation(Required=false)]
            public string AccessTokenValue { get; set; }

            /// <summary>
            /// <para>User ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>12343131221311</para>
            /// </summary>
            [NameInMap("AliyunPk")]
            [Validation(Required=false)]
            public string AliyunPk { get; set; }

            /// <summary>
            /// <para>Extended attributes</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;resourceGroupId\&quot;:\&quot;\&quot;,\&quot;page\&quot;:1,\&quot;size\&quot;:10,\&quot;selected\&quot;:\&quot;[\\\&quot;kvstore\\\&quot;]\&quot;}</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <para>Authorization grant type</para>
            /// 
            /// <b>Example:</b>
            /// <para>authorization_code</para>
            /// </summary>
            [NameInMap("AuthorizationGrantType")]
            [Validation(Required=false)]
            public string AuthorizationGrantType { get; set; }

            /// <summary>
            /// <para>bid</para>
            /// 
            /// <b>Example:</b>
            /// <para>123131</para>
            /// </summary>
            [NameInMap("Bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            /// <summary>
            /// <para>User ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>12343131221311</para>
            /// </summary>
            [NameInMap("ParentPk")]
            [Validation(Required=false)]
            public string ParentPk { get; set; }

            /// <summary>
            /// <para>Refresh token expiration time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1768619049924</para>
            /// </summary>
            [NameInMap("RefreshTokenExpiresAt")]
            [Validation(Required=false)]
            public string RefreshTokenExpiresAt { get; set; }

            /// <summary>
            /// <para>Refresh token issuance time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1768619049924</para>
            /// </summary>
            [NameInMap("RefreshTokenIssuedAt")]
            [Validation(Required=false)]
            public string RefreshTokenIssuedAt { get; set; }

            /// <summary>
            /// <para>Refresh token value</para>
            /// 
            /// <b>Example:</b>
            /// <para>be9750d595b6cd7c93a80b46</para>
            /// </summary>
            [NameInMap("RefreshTokenValue")]
            [Validation(Required=false)]
            public string RefreshTokenValue { get; set; }

            /// <summary>
            /// <para>Unique identifier externally</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdm_33be9750d595b6cd7c93a80b46734b22</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>ID of the request</para>
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
        /// <para>Exception message</para>
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
