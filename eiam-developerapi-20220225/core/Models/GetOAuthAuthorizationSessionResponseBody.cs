// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GetOAuthAuthorizationSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The authentication token ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atntkn_01l6lot7o4e4r77oelp6qtuxxxxx</para>
        /// </summary>
        [NameInMap("authenticationTokenId")]
        [Validation(Required=false)]
        public string AuthenticationTokenId { get; set; }

        /// <summary>
        /// <para>The user authorization URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://login.dingtalk.com/oauth2/auth?client_id=">https://login.dingtalk.com/oauth2/auth?client_id=</a>...</para>
        /// </summary>
        [NameInMap("authorizationUrl")]
        [Validation(Required=false)]
        public string AuthorizationUrl { get; set; }

        /// <summary>
        /// <para>The authentication token consumer ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_ngtkgrrxxxxktg5eao6z4xxxxx</para>
        /// </summary>
        [NameInMap("consumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// <para>The authentication token consumer type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("consumerType")]
        [Validation(Required=false)]
        public string ConsumerType { get; set; }

        /// <summary>
        /// <para>The authentication token creator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_ngtkgrrxxxxktg5eao6z4xxxxx</para>
        /// </summary>
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The authentication token creator type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("creatorType")]
        [Validation(Required=false)]
        public string CreatorType { get; set; }

        /// <summary>
        /// <para>The credential provider business identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_example_identifier</para>
        /// </summary>
        [NameInMap("credentialProviderIdentifier")]
        [Validation(Required=false)]
        public string CredentialProviderIdentifier { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>access_denied</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The user denied the authorization request</para>
        /// </summary>
        [NameInMap("errorDescription")]
        [Validation(Required=false)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// <para>The authentication token expiration time. UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1704153600000</para>
        /// </summary>
        [NameInMap("expirationTime")]
        [Validation(Required=false)]
        public long? ExpirationTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The authorization session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atpoas_01l6losojlojbbv01adsq56xxxxx</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The authorization session status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("sessionStatus")]
        [Validation(Required=false)]
        public string SessionStatus { get; set; }

        /// <summary>
        /// <para>The authorization session URI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:ietf:params:oauth:request_uri:atpoas_01l6ljnvrpc5niakl3gj3amxxxxxx</para>
        /// </summary>
        [NameInMap("sessionUri")]
        [Validation(Required=false)]
        public string SessionUri { get; set; }

    }

}
