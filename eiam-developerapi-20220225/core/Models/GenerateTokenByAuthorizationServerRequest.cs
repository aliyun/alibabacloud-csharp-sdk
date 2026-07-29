// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GenerateTokenByAuthorizationServerRequest : TeaModel {
        /// <summary>
        /// <para>Federated application credential name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testxxxxx</para>
        /// </summary>
        [NameInMap("application_federated_credential_name")]
        [Validation(Required=false)]
        public string ApplicationFederatedCredentialName { get; set; }

        /// <summary>
        /// <para>Client assertion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJraWQiOiJLRVlLZ0Iyxxxxx</para>
        /// </summary>
        [NameInMap("client_assertion")]
        [Validation(Required=false)]
        public string ClientAssertion { get; set; }

        /// <summary>
        /// <para>Client assertion type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:ietf:params:oauth:client-assertion-type:jwt-bearer</para>
        /// </summary>
        [NameInMap("client_assertion_type")]
        [Validation(Required=false)]
        public string ClientAssertionType { get; set; }

        /// <summary>
        /// <para>Client ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("client_id")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>Client key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CSEHDcHcrUKHw1CuxkJEHPveWRxxxxx</para>
        /// </summary>
        [NameInMap("client_secret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>Client certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testxxxxx</para>
        /// </summary>
        [NameInMap("client_x509")]
        [Validation(Required=false)]
        public string ClientX509 { get; set; }

        /// <summary>
        /// <para>Intermediate certificate list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testxxxxx</para>
        /// </summary>
        [NameInMap("client_x509_chain")]
        [Validation(Required=false)]
        public string ClientX509Chain { get; set; }

        /// <summary>
        /// <para>Authorization code. Required when grant_type is authorization_code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CO541xY59EsKniV2wvWDXZ4jiKxxxxx</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>You can validate the code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("code_verifier")]
        [Validation(Required=false)]
        public string CodeVerifier { get; set; }

        /// <summary>
        /// <para>Device code. Required when grant_type is urn:ietf:params:oauth:grant-type:device_code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DCxxxxxx</para>
        /// </summary>
        [NameInMap("device_code")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        /// <summary>
        /// <para>Grant type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>authorization_code</para>
        /// </summary>
        [NameInMap("grant_type")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// <para>Password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testxxxxx</para>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Redirection URI. Required when grant_type is authorization_code. Must match the redirect_uri used in the authorization code request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/xxxxx">https://example.com/xxxxx</a></para>
        /// </summary>
        [NameInMap("redirect_uri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// <para>Refresh token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RTxxxxx</para>
        /// </summary>
        [NameInMap("refresh_token")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// <para>Scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openid</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>Username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userxxxxx</para>
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
