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
        /// <para>The client secret. This parameter is required if grant_type is set to client_credentials.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CSEHDcHcrUKHw1CuxkJEHPveWRXBGqVqRsxxxx</para>
        /// </summary>
        [NameInMap("client_secret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>The authorization code. This parameter is required if grant_type is set to authorization_code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The verification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("code_verifier")]
        [Validation(Required=false)]
        public string CodeVerifier { get; set; }

        /// <summary>
        /// <para>The device code. This parameter is required if grant_type is set to authorization_code.urn:ietf:params:oauth:grant-type:device_code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("device_code")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        /// <summary>
        /// <para>The excluded tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ATxxx</para>
        /// </summary>
        [NameInMap("exclusive_tag")]
        [Validation(Required=false)]
        public string ExclusiveTag { get; set; }

        /// <summary>
        /// <para>The authorization type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// </list>
        /// <!---->
        /// 
        /// <list type="bullet">
        /// <item><description>authorization_code</description></item>
        /// <item><description>urn:ietf:params:oauth:grant-type:device_code</description></item>
        /// <item><description>refresh_token</description></item>
        /// <item><description>client_credentials: You must specify the client_id and client_secret parameters.</description></item>
        /// <item><description>password: This option is not supported.</description></item>
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
        /// <para>The username. This parameter is required if grant_type is set to password. The password authentication type is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The redirect URI. This parameter is required if grant_type is set to authorization_code. The value of this parameter must be the same as the redirect URI in the request to obtain the authorization code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("redirect_uri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// <para>The refreshed token. This parameter is required if grant_type is set to refresh_token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ATxxx</para>
        /// </summary>
        [NameInMap("refresh_token")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// <para>The authorization scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>openid</description></item>
        /// <item><description>email</description></item>
        /// <item><description>phone</description></item>
        /// <item><description>profile</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The username. This parameter is required if grant_type is set to password. The password authentication type is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uesrname_001</para>
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
