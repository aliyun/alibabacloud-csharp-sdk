// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ObtainCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The credential details.</para>
        /// </summary>
        [NameInMap("Credential")]
        [Validation(Required=false)]
        public ObtainCredentialResponseBodyCredential Credential { get; set; }
        public class ObtainCredentialResponseBodyCredential : TeaModel {
            /// <summary>
            /// <para>The time when the credential was created. This value is a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830225000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The credential content.</para>
            /// </summary>
            [NameInMap("CredentialContent")]
            [Validation(Required=false)]
            public ObtainCredentialResponseBodyCredentialCredentialContent CredentialContent { get; set; }
            public class ObtainCredentialResponseBodyCredentialCredentialContent : TeaModel {
                /// <summary>
                /// <para>The details of the API key credential.</para>
                /// </summary>
                [NameInMap("ApiKeyContent")]
                [Validation(Required=false)]
                public ObtainCredentialResponseBodyCredentialCredentialContentApiKeyContent ApiKeyContent { get; set; }
                public class ObtainCredentialResponseBodyCredentialCredentialContentApiKeyContent : TeaModel {
                    /// <summary>
                    /// <para>The API key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nsklncmwizncxxxx</para>
                    /// </summary>
                    [NameInMap("ApiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                }

                /// <summary>
                /// <para>The details of the OAuth 2.0 client credential.</para>
                /// </summary>
                [NameInMap("OAuthClientContent")]
                [Validation(Required=false)]
                public ObtainCredentialResponseBodyCredentialCredentialContentOAuthClientContent OAuthClientContent { get; set; }
                public class ObtainCredentialResponseBodyCredentialCredentialContentOAuthClientContent : TeaModel {
                    /// <summary>
                    /// <para>The client ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dmvncmxersdxxxxxx</para>
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// <para>The client secret.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nsklnertyt5ddwizncxxxx</para>
                    /// </summary>
                    [NameInMap("ClientSecret")]
                    [Validation(Required=false)]
                    public string ClientSecret { get; set; }

                }

            }

            /// <summary>
            /// <para>The credential creation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>system_init</c>: The system created the credential.</para>
            /// </description></item>
            /// <item><description><para><c>user_custom</c>: A user created the credential.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user_custom</para>
            /// </summary>
            [NameInMap("CredentialCreationType")]
            [Validation(Required=false)]
            public string CredentialCreationType { get; set; }

            [NameInMap("CredentialExternalId")]
            [Validation(Required=false)]
            public string CredentialExternalId { get; set; }

            /// <summary>
            /// <para>The credential ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cred_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("CredentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            /// <summary>
            /// <para>The credential identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>credential_identifier_test</para>
            /// </summary>
            [NameInMap("CredentialIdentifier")]
            [Validation(Required=false)]
            public string CredentialIdentifier { get; set; }

            /// <summary>
            /// <para>The credential name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>credential_name</para>
            /// </summary>
            [NameInMap("CredentialName")]
            [Validation(Required=false)]
            public string CredentialName { get; set; }

            /// <summary>
            /// <para>The credential scenario label. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>llm</c>: The credential is used for an LLM.</para>
            /// </description></item>
            /// <item><description><para><c>saas</c>: The credential is used for a SaaS application.</para>
            /// </description></item>
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
            /// <para>The credential subject ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apt_werthgfdsasffxxxxx</para>
            /// </summary>
            [NameInMap("CredentialSubjectId")]
            [Validation(Required=false)]
            public string CredentialSubjectId { get; set; }

            /// <summary>
            /// <para>The credential subject type. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><c>authentication_token_provider</c>: The credential subject is an authentication token provider.</description></item>
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
            /// <item><description><para><c>api_key</c>: An API key.</para>
            /// </description></item>
            /// <item><description><para><c>oauth_client</c>: An OAuth 2.0 client credential.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>api_key</para>
            /// </summary>
            [NameInMap("CredentialType")]
            [Validation(Required=false)]
            public string CredentialType { get; set; }

            /// <summary>
            /// <para>The description.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>enabled</c>: The credential can be used.</para>
            /// </description></item>
            /// <item><description><para><c>disabled</c>: The credential cannot be used.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the credential was last updated. This value is a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830227000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
