// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GenerateOauthTokenRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The audience identifier of the resource server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com">https://example.com</a></para>
        /// </summary>
        [NameInMap("Audience")]
        [Validation(Required=false)]
        public string Audience { get; set; }

        /// <summary>
        /// <para>The grant type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client_credentials</para>
        /// </summary>
        [NameInMap("GrantType")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The requested token type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:ietf:params:oauth:token-type:access_token</para>
        /// </summary>
        [NameInMap("RequestedTokenType")]
        [Validation(Required=false)]
        public string RequestedTokenType { get; set; }

        /// <summary>
        /// <para>The permission scope.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ScopeValues")]
        [Validation(Required=false)]
        public List<string> ScopeValues { get; set; }

        /// <summary>
        /// <para>The subject token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>subject001</para>
        /// </summary>
        [NameInMap("SubjectToken")]
        [Validation(Required=false)]
        public string SubjectToken { get; set; }

        /// <summary>
        /// <para>The subject token type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:ietf:params:oauth:token-type:access_token</para>
        /// </summary>
        [NameInMap("SubjectTokenType")]
        [Validation(Required=false)]
        public string SubjectTokenType { get; set; }

    }

}
