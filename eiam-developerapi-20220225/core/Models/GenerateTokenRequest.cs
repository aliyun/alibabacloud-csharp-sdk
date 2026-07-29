// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GenerateTokenRequest : TeaModel {
        /// <summary>
        /// <para>The client ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("client_id")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The client secret. This parameter is required when \<c>grant_type\\</c> is \<c>client_credentials\\</c> and the \<c>client_secret_post\\</c> method is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CSEHDcHcrUKHw1CuxkJEHPveWRXBGqVqRsxxxx</para>
        /// </summary>
        [NameInMap("client_secret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>The authorization code. This parameter is required when \<c>grant_type\\</c> is \<c>authorization_code\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The code verifier. This is used in the authorization code grant type when PKCE is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("code_verifier")]
        [Validation(Required=false)]
        public string CodeVerifier { get; set; }

        /// <summary>
        /// <para>The device code. This parameter is required when \<c>grant_type\\</c> is \<c>urn:ietf:params:oauth:grant-type:device_code\\</c> (device flow).</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("device_code")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        /// <summary>
        /// <para>The excluded tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ATxxx</para>
        /// </summary>
        [NameInMap("exclusive_tag")]
        [Validation(Required=false)]
        public string ExclusiveTag { get; set; }

        /// <summary>
        /// <para>The authorization grant type. The following types are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>\<c>client_credentials\\</c>: Client credentials grant. Requires \<c>client_id\\</c> and \<c>client_secret\\</c>.</para>
        /// </description></item>
        /// <item><description><para>\<c>refresh_token\\</c>: Refresh token grant.</para>
        /// </description></item>
        /// <item><description><para>\<c>authorization_code\\</c>: Authorization code grant.</para>
        /// </description></item>
        /// <item><description><para>\<c>urn:ietf:params:oauth:grant-type:device_code\\</c>: Device flow.</para>
        /// </description></item>
        /// <item><description><para>\<c>password\\</c>: Password grant.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client_credentials</para>
        /// </summary>
        [NameInMap("grant_type")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// <para>The username. This parameter is required for password mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The redirection URI. This parameter is required for the authorization code grant type. It must match the redirection URI in the request to get the authorization code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("redirect_uri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// <para>The refresh token. This parameter is required when \<c>grant_type\\</c> is \<c>refresh_token\\</c> (refresh token grant).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ATxxx</para>
        /// </summary>
        [NameInMap("refresh_token")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// <para>The scope. This parameter is optional. Multiple values are supported. Separate multiple values with spaces.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>openid</para>
        /// </description></item>
        /// <item><description><para>email</para>
        /// </description></item>
        /// <item><description><para>phone</para>
        /// </description></item>
        /// <item><description><para>profile</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The username. This parameter is required for the password grant type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uesrname_001</para>
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
