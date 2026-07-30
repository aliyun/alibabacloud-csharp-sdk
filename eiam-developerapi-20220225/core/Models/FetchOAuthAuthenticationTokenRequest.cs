// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class FetchOAuthAuthenticationTokenRequest : TeaModel {
        /// <summary>
        /// <para>The credential provider identifier.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_example_identifier</para>
        /// </summary>
        [NameInMap("credentialProviderIdentifier")]
        [Validation(Required=false)]
        public string CredentialProviderIdentifier { get; set; }

        /// <summary>
        /// <para>Custom key-value pairs appended to the OAuth authorization URL to pass additional parameters supported by the OAuth provider.</para>
        /// </summary>
        [NameInMap("customParameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> CustomParameters { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore existing valid tokens and force re-authorization. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("forceAuthentication")]
        [Validation(Required=false)]
        public bool? ForceAuthentication { get; set; }

        /// <summary>
        /// <para>The scope corresponding to the OAuth protocol.</para>
        /// <remarks>
        /// <para>If not specified, the scope of the issued OAuth Access Token defaults to the scope configuration of the corresponding credential provider.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: Multiple scope values are separated by spaces.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example:test_01 example:test_02</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
