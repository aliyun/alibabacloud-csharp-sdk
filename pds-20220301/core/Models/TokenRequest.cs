// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class TokenRequest : TeaModel {
        /// <summary>
        /// The JWT assertion that is signed by using the JWT private key. The JWT assertion contains the information about the user to be authorized and the authorization parameters. For more information about the structure of the JWT assertion, see JWTPayload. This parameter is required if grant_type is set to urn:ietf:params:oauth:grant-type:jwt-bearer.
        /// </summary>
        [NameInMap("assertion")]
        [Validation(Required=false)]
        public string Assertion { get; set; }

        /// <summary>
        /// The AppId of the application that is created in the Drive and Photo Service console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("client_id")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// The AppSecret of the application that is created in the Drive and Photo Service console. This parameter is required if the application is of the WebServer type.
        /// </summary>
        [NameInMap("client_secret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The authorization code in the redirect URI that is specified after the authorization process is complete. This parameter is required if grant_type is set to authorization_code.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The method that is used to generate an access token. Valid values:
        /// 
        /// authorization_code: generates an access token by using the authorization code that is returned after the authorization process is complete.
        /// 
        /// refresh_token: generates an access token by using the refresh token that is returned after the authorization process is complete.
        /// 
        /// urn:ietf:params:oauth:grant-type:jwt-bearer: generates an access token by using a JWT assertion.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("grant_type")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// The redirect URI that is specified when you initiate the authorization request. This parameter is required if grant_type is set to authorization_code.
        /// </summary>
        [NameInMap("redirect_uri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// The refresh token that is used to refresh the access token. This parameter is required if grant_type is set to refresh_token.
        /// </summary>
        [NameInMap("refresh_token")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

    }

}
