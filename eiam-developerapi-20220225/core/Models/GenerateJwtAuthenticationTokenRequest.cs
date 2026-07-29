// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GenerateJwtAuthenticationTokenRequest : TeaModel {
        /// <summary>
        /// <para>The \<c>aud\\</c> field of the JWT.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("audiences")]
        [Validation(Required=false)]
        public List<string> Audiences { get; set; }

        /// <summary>
        /// <para>Credential provider identity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_example_identifier</para>
        /// </summary>
        [NameInMap("credentialProviderIdentifier")]
        [Validation(Required=false)]
        public string CredentialProviderIdentifier { get; set; }

        /// <summary>
        /// <para>Custom claims.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>Key-value pairs. Keys must be strings.</para>
        /// </summary>
        [NameInMap("customClaims")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomClaims { get; set; }

        /// <summary>
        /// <para>The validity period of the JWT, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public int? Expiration { get; set; }

        /// <summary>
        /// <para>Whether the generated JWT needs to include a &quot;derived short token&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("includeDerivedShortToken")]
        [Validation(Required=false)]
        public bool? IncludeDerivedShortToken { get; set; }

        /// <summary>
        /// <para>The \<c>iss\\</c> field of the JWT.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://test.issuer.com">https://test.issuer.com</a></para>
        /// </summary>
        [NameInMap("issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <para>The \<c>sub\\</c> field of the JWT.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_jwt_subject</para>
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

    }

}
