// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The ClientToken parameter supports only ASCII characters and cannot exceed 64 characters in length. For more information, see References: <a href="https://www.alibabacloud.com/help/zh/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The credential content.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CredentialContent")]
        [Validation(Required=false)]
        public CreateCredentialRequestCredentialContent CredentialContent { get; set; }
        public class CreateCredentialRequestCredentialContent : TeaModel {
            /// <summary>
            /// <para>The credential content of the API key credential type.</para>
            /// </summary>
            [NameInMap("ApiKeyContent")]
            [Validation(Required=false)]
            public CreateCredentialRequestCredentialContentApiKeyContent ApiKeyContent { get; set; }
            public class CreateCredentialRequestCredentialContentApiKeyContent : TeaModel {
                /// <summary>
                /// <para>The API key content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nsklnertyt5ddwizncxxxx</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

            }

            /// <summary>
            /// <para>The credential content of the OAuth client authentication credential type.</para>
            /// </summary>
            [NameInMap("OAuthClientContent")]
            [Validation(Required=false)]
            public CreateCredentialRequestCredentialContentOAuthClientContent OAuthClientContent { get; set; }
            public class CreateCredentialRequestCredentialContentOAuthClientContent : TeaModel {
                /// <summary>
                /// <para>The client_id of the OAuth protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dmvncmxersdxxxxxx</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The client_secret of the OAuth protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nsklncmwizncxxxx</para>
                /// </summary>
                [NameInMap("ClientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

            }

        }

        [NameInMap("CredentialExternalId")]
        [Validation(Required=false)]
        public string CredentialExternalId { get; set; }

        /// <summary>
        /// <para>The credential identifier.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_identifier_test</para>
        /// </summary>
        [NameInMap("CredentialIdentifier")]
        [Validation(Required=false)]
        public string CredentialIdentifier { get; set; }

        /// <summary>
        /// <para>The credential name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_name</para>
        /// </summary>
        [NameInMap("CredentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        /// <summary>
        /// <para>The Scenarios label of the credential. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>llm: large language model.</description></item>
        /// <item><description>saas: third-party SaaS service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>llm</para>
        /// </summary>
        [NameInMap("CredentialScenarioLabel")]
        [Validation(Required=false)]
        public string CredentialScenarioLabel { get; set; }

        [NameInMap("CredentialSharingScope")]
        [Validation(Required=false)]
        public string CredentialSharingScope { get; set; }

        /// <summary>
        /// <para>The subject ID of the credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apt_werthgfdsasffxxxxx</para>
        /// </summary>
        [NameInMap("CredentialSubjectId")]
        [Validation(Required=false)]
        public string CredentialSubjectId { get; set; }

        /// <summary>
        /// <para>The subject type of the credential. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>authentication_token_provider: authentication token provider.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>authentication_token_provider</para>
        /// </summary>
        [NameInMap("CredentialSubjectType")]
        [Validation(Required=false)]
        public string CredentialSubjectType { get; set; }

        /// <summary>
        /// <para>The credential type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>api_key: API key authentication credential.</description></item>
        /// <item><description>oauth_client: OAuth client authentication credential.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api_key</para>
        /// </summary>
        [NameInMap("CredentialType")]
        [Validation(Required=false)]
        public string CredentialType { get; set; }

        /// <summary>
        /// <para>The credential description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ExclusiveUserId")]
        [Validation(Required=false)]
        public string ExclusiveUserId { get; set; }

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

    }

}
