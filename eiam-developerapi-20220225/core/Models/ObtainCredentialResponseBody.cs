// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ObtainCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time of the credential, formatted as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830225000</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The detailed content of the credential. The structure of this object depends on the value of <c>credentialType</c>.</para>
        /// </summary>
        [NameInMap("credentialContent")]
        [Validation(Required=false)]
        public ObtainCredentialResponseBodyCredentialContent CredentialContent { get; set; }
        public class ObtainCredentialResponseBodyCredentialContent : TeaModel {
            /// <summary>
            /// <para>Contains details for an API key credential. Returned only when <c>credentialType</c> is <c>api_key</c>.</para>
            /// </summary>
            [NameInMap("apiKeyContent")]
            [Validation(Required=false)]
            public ObtainCredentialResponseBodyCredentialContentApiKeyContent ApiKeyContent { get; set; }
            public class ObtainCredentialResponseBodyCredentialContentApiKeyContent : TeaModel {
                /// <summary>
                /// <para>The API key value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-nsklncmwizncxxxx</para>
                /// </summary>
                [NameInMap("apiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

            }

            /// <summary>
            /// <para>Contains details for an OAuth client credential. Returned only when <c>credentialType</c> is <c>oauth_client</c>.</para>
            /// </summary>
            [NameInMap("oauthClientContent")]
            [Validation(Required=false)]
            public ObtainCredentialResponseBodyCredentialContentOauthClientContent OauthClientContent { get; set; }
            public class ObtainCredentialResponseBodyCredentialContentOauthClientContent : TeaModel {
                /// <summary>
                /// <para>The <c>client_id</c> for OAuth 2.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dmvncmxersdxxxxxx</para>
                /// </summary>
                [NameInMap("clientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The <c>client_secret</c> for OAuth 2.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nsklnertyt5ddwizncxxxx</para>
                /// </summary>
                [NameInMap("clientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates how the credential was created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>system_init</c>: System-initiated.</para>
        /// </description></item>
        /// <item><description><para><c>user_custom</c>: User-created.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user_custom</para>
        /// </summary>
        [NameInMap("credentialCreationType")]
        [Validation(Required=false)]
        public string CredentialCreationType { get; set; }

        [NameInMap("credentialExternalId")]
        [Validation(Required=false)]
        public string CredentialExternalId { get; set; }

        /// <summary>
        /// <para>The credential ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cred_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("credentialId")]
        [Validation(Required=false)]
        public string CredentialId { get; set; }

        /// <summary>
        /// <para>The credential identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_identifier_test</para>
        /// </summary>
        [NameInMap("credentialIdentifier")]
        [Validation(Required=false)]
        public string CredentialIdentifier { get; set; }

        /// <summary>
        /// <para>The credential name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_name</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        /// <summary>
        /// <para>The usage scenario for the credential. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>llm</c>: For use with a large language model.</para>
        /// </description></item>
        /// <item><description><para><c>saas</c>: For use with a third-party SaaS application.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>llm</para>
        /// </summary>
        [NameInMap("credentialScenarioLabel")]
        [Validation(Required=false)]
        public string CredentialScenarioLabel { get; set; }

        /// <summary>
        /// <para>The sharing scope of the credential, such as whether it is exclusive to a specific account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_exclusive</para>
        /// </summary>
        [NameInMap("credentialSharingScope")]
        [Validation(Required=false)]
        public string CredentialSharingScope { get; set; }

        /// <summary>
        /// <para>The ID of the credential\&quot;s subject.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apt_werthgfdsasffxxxxx</para>
        /// </summary>
        [NameInMap("credentialSubjectId")]
        [Validation(Required=false)]
        public string CredentialSubjectId { get; set; }

        /// <summary>
        /// <para>The credential\&quot;s subject type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>authentication_token_provider</c>: An authentication token provider.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>authentication_token_provider</para>
        /// </summary>
        [NameInMap("credentialSubjectType")]
        [Validation(Required=false)]
        public string CredentialSubjectType { get; set; }

        /// <summary>
        /// <para>The credential type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>api_key</c>: The credential is an API key.</para>
        /// </description></item>
        /// <item><description><para><c>oauth_client</c>: The credential represents an OAuth client.</para>
        /// </description></item>
        /// </list>
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

        /// <summary>
        /// <para>The ID of the account that exclusively owns the credential. This field is present only when <c>credentialSharingScope</c> is <c>user_exclusive</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_xxx</para>
        /// </summary>
        [NameInMap("exclusiveUserId")]
        [Validation(Required=false)]
        public string ExclusiveUserId { get; set; }

        /// <summary>
        /// <para>The EIAM instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The status of the credential. Valid values:</para>
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
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The last update time of the credential, formatted as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830227000</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
