// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class CreateUserExclusiveCredentialRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("credentialContent")]
        [Validation(Required=false)]
        public CreateUserExclusiveCredentialRequestCredentialContent CredentialContent { get; set; }
        public class CreateUserExclusiveCredentialRequestCredentialContent : TeaModel {
            [NameInMap("apiKeyContent")]
            [Validation(Required=false)]
            public CreateUserExclusiveCredentialRequestCredentialContentApiKeyContent ApiKeyContent { get; set; }
            public class CreateUserExclusiveCredentialRequestCredentialContentApiKeyContent : TeaModel {
                /// <summary>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_identifier_test</para>
        /// </summary>
        [NameInMap("credentialIdentifier")]
        [Validation(Required=false)]
        public string CredentialIdentifier { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_name</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>llm</para>
        /// </summary>
        [NameInMap("credentialScenarioLabel")]
        [Validation(Required=false)]
        public string CredentialScenarioLabel { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api_key</para>
        /// </summary>
        [NameInMap("credentialType")]
        [Validation(Required=false)]
        public string CredentialType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>credential_description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
