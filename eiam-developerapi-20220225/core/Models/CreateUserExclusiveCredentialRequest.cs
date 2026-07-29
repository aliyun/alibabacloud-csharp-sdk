// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class CreateUserExclusiveCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The credential content.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("credentialContent")]
        [Validation(Required=false)]
        public CreateUserExclusiveCredentialRequestCredentialContent CredentialContent { get; set; }
        public class CreateUserExclusiveCredentialRequestCredentialContent : TeaModel {
            /// <summary>
            /// <para>The credential content for the API Key credential type.</para>
            /// </summary>
            [NameInMap("apiKeyContent")]
            [Validation(Required=false)]
            public CreateUserExclusiveCredentialRequestCredentialContentApiKeyContent ApiKeyContent { get; set; }
            public class CreateUserExclusiveCredentialRequestCredentialContentApiKeyContent : TeaModel {
                /// <summary>
                /// <para>The value of the API Key.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-nsklncmwizncxxxx</para>
                /// </summary>
                [NameInMap("apiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

            }

        }

        [NameInMap("credentialExternalId")]
        [Validation(Required=false)]
        public string CredentialExternalId { get; set; }

        /// <summary>
        /// <para>The credential identifier.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_identifier_test</para>
        /// </summary>
        [NameInMap("credentialIdentifier")]
        [Validation(Required=false)]
        public string CredentialIdentifier { get; set; }

        /// <summary>
        /// <para>The credential name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_name</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        /// <summary>
        /// <para>The scenarios label of the credential. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>llm: large language model.</description></item>
        /// <item><description>saas: third-party SaaS service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>llm</para>
        /// </summary>
        [NameInMap("credentialScenarioLabel")]
        [Validation(Required=false)]
        public string CredentialScenarioLabel { get; set; }

        /// <summary>
        /// <para>The credential type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>api_key: API Key authentication credential.</description></item>
        /// <item><description>oauth_client: OAuth client authentication credential.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api_key</para>
        /// </summary>
        [NameInMap("credentialType")]
        [Validation(Required=false)]
        public string CredentialType { get; set; }

        /// <summary>
        /// <para>The credential description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("returnCiphertext")]
        [Validation(Required=false)]
        public bool? ReturnCiphertext { get; set; }

    }

}
