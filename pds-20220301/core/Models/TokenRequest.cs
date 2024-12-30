// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class TokenRequest : TeaModel {
        /// <summary>
        /// <para>The JWT assertion that is signed by using the JWT private key. The JWT assertion contains the information about the user to be authorized and the authorization parameters. For more information about the structure of the JWT assertion, see JWTPayload. This parameter is required if grant_type is set to urn:ietf:params:oauth:grant-type:jwt-bearer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ey***asd</para>
        /// </summary>
        [NameInMap("assertion")]
        [Validation(Required=false)]
        public string Assertion { get; set; }

        /// <summary>
        /// <para>The AppId of the application that is created in the Drive and Photo Service console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1Zu***flH</para>
        /// </summary>
        [NameInMap("client_id")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The AppSecret of the application that is created in the Drive and Photo Service console. This parameter is required if the application is of the WebServer type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80D***3i5</para>
        /// </summary>
        [NameInMap("client_secret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>The authorization code in the redirect URI that is specified after the authorization process is complete. This parameter is required if grant_type is set to authorization_code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0045157fa8e24f4f9a0d9e3ff158c1e0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The method that is used to generate an access token. Valid values:</para>
        /// <para>authorization_code: generates an access token by using the authorization code that is returned after the authorization process is complete.</para>
        /// <para>refresh_token: generates an access token by using the refresh token that is returned after the authorization process is complete.</para>
        /// <para>urn:ietf:params:oauth:grant-type:jwt-bearer: generates an access token by using a JWT assertion.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>refresh_token</para>
        /// </summary>
        [NameInMap("grant_type")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// <para>The redirect URI that is specified when you initiate the authorization request. This parameter is required if grant_type is set to authorization_code.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aliyun.com/pds">https://aliyun.com/pds</a></para>
        /// </summary>
        [NameInMap("redirect_uri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// <para>The refresh token that is used to refresh the access token. This parameter is required if grant_type is set to refresh_token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>399623e13353490391266c7d48a13ed1</para>
        /// </summary>
        [NameInMap("refresh_token")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

    }

}
