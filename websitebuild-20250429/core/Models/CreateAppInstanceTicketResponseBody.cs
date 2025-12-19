// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAppInstanceTicketResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>spring-cloud-b</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://check-result-file-sh.oss-cn-shanghai.aliyuncs.com/u6qw3gxzu3b7sbj/u6qw3gxzu3b7sbj.diff.zip?Expires=1740975709&OSSAccessKeyId=LTAI5tKUErVCETM4ev9SELNb&Signature=FP7dDnkrLlOZHmRRORVqbLOtv9c%3D">https://check-result-file-sh.oss-cn-shanghai.aliyuncs.com/u6qw3gxzu3b7sbj/u6qw3gxzu3b7sbj.diff.zip?Expires=1740975709&amp;OSSAccessKeyId=LTAI5tKUErVCETM4ev9SELNb&amp;Signature=FP7dDnkrLlOZHmRRORVqbLOtv9c%3D</a></para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public CreateAppInstanceTicketResponseBodyModule Module { get; set; }
        public class CreateAppInstanceTicketResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1768619049924</para>
            /// </summary>
            [NameInMap("AccessTokenExpiresAt")]
            [Validation(Required=false)]
            public string AccessTokenExpiresAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1768619049924</para>
            /// </summary>
            [NameInMap("AccessTokenIssuedAt")]
            [Validation(Required=false)]
            public string AccessTokenIssuedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>be9750d595b6cd7c93a80b46</para>
            /// </summary>
            [NameInMap("AccessTokenValue")]
            [Validation(Required=false)]
            public string AccessTokenValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12343131221311</para>
            /// </summary>
            [NameInMap("AliyunPk")]
            [Validation(Required=false)]
            public string AliyunPk { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;resourceGroupId\&quot;:\&quot;\&quot;,\&quot;page\&quot;:1,\&quot;size\&quot;:10,\&quot;selected\&quot;:\&quot;[\\\&quot;kvstore\\\&quot;]\&quot;}</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>12343131221311</para>
            /// </summary>
            [NameInMap("ParentPk")]
            [Validation(Required=false)]
            public string ParentPk { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1768619049924</para>
            /// </summary>
            [NameInMap("RefreshTokenExpiresAt")]
            [Validation(Required=false)]
            public string RefreshTokenExpiresAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1768619049924</para>
            /// </summary>
            [NameInMap("RefreshTokenIssuedAt")]
            [Validation(Required=false)]
            public string RefreshTokenIssuedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>be9750d595b6cd7c93a80b46</para>
            /// </summary>
            [NameInMap("RefreshTokenValue")]
            [Validation(Required=false)]
            public string RefreshTokenValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hdm_33be9750d595b6cd7c93a80b46734b22</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

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
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
