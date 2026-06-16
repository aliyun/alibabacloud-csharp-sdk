// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class RefreshAppInstanceTicketResponseBody : TeaModel {
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
        /// <para>Indicates whether retry is allowed.</para>
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
        /// <para>mar</para>
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
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error parameters returned.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The application module.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public RefreshAppInstanceTicketResponseBodyModule Module { get; set; }
        public class RefreshAppInstanceTicketResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The time when the access token expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-18T22:30:00+08:00</para>
            /// </summary>
            [NameInMap("AccessTokenExpiresAt")]
            [Validation(Required=false)]
            public string AccessTokenExpiresAt { get; set; }

            /// <summary>
            /// <para>The time when the access token was issued.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-18T22:30:00+08:00</para>
            /// </summary>
            [NameInMap("AccessTokenIssuedAt")]
            [Validation(Required=false)]
            public string AccessTokenIssuedAt { get; set; }

            /// <summary>
            /// <para>The access token value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2108341e17661121129745384e79f9</para>
            /// </summary>
            [NameInMap("AccessTokenValue")]
            [Validation(Required=false)]
            public string AccessTokenValue { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1907880872137014</para>
            /// </summary>
            [NameInMap("AliyunPk")]
            [Validation(Required=false)]
            public string AliyunPk { get; set; }

            /// <summary>
            /// <para>The extended properties.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <para>The authorization code type.</para>
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
            /// <para>26842</para>
            /// </summary>
            [NameInMap("Bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1907880872137014</para>
            /// </summary>
            [NameInMap("ParentPk")]
            [Validation(Required=false)]
            public string ParentPk { get; set; }

            /// <summary>
            /// <para>The time when the refresh token expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-18T22:30:00+08:00</para>
            /// </summary>
            [NameInMap("RefreshTokenExpiresAt")]
            [Validation(Required=false)]
            public string RefreshTokenExpiresAt { get; set; }

            /// <summary>
            /// <para>The time when the refresh token was issued.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-18T22:30:00+08:00</para>
            /// </summary>
            [NameInMap("RefreshTokenIssuedAt")]
            [Validation(Required=false)]
            public string RefreshTokenIssuedAt { get; set; }

            /// <summary>
            /// <para>The refresh token value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2108341e17661121129745384e79f9</para>
            /// </summary>
            [NameInMap("RefreshTokenValue")]
            [Validation(Required=false)]
            public string RefreshTokenValue { get; set; }

            /// <summary>
            /// <para>The external unique identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>357504C7F21FCAE502756332ECE8B533</para>
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
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
