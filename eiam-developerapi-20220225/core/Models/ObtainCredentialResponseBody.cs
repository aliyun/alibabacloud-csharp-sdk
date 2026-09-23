// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ObtainCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time, in UNIX timestamp format. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830225000</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The credential content.</para>
        /// </summary>
        [NameInMap("credentialContent")]
        [Validation(Required=false)]
        public ObtainCredentialResponseBodyCredentialContent CredentialContent { get; set; }
        public class ObtainCredentialResponseBodyCredentialContent : TeaModel {
            /// <summary>
            /// <para>The credential content of the API Key credential type.</para>
            /// </summary>
            [NameInMap("apiKeyContent")]
            [Validation(Required=false)]
            public ObtainCredentialResponseBodyCredentialContentApiKeyContent ApiKeyContent { get; set; }
            public class ObtainCredentialResponseBodyCredentialContentApiKeyContent : TeaModel {
                /// <summary>
                /// <para>The value of the API Key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sk-nsklncmwizncxxxx</para>
                /// </summary>
                [NameInMap("apiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

            }

            /// <summary>
            /// <para>The credential content of the OAuth client authentication credential type.</para>
            /// </summary>
            [NameInMap("oauthClientContent")]
            [Validation(Required=false)]
            public ObtainCredentialResponseBodyCredentialContentOauthClientContent OauthClientContent { get; set; }
            public class ObtainCredentialResponseBodyCredentialContentOauthClientContent : TeaModel {
                /// <summary>
                /// <para>The client_id of the OAuth protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dmvncmxersdxxxxxx</para>
                /// </summary>
                [NameInMap("clientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The client_secret of the OAuth protocol.</para>
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
        /// <para>The creation type of the credential. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system_init: Created by the system.</description></item>
        /// <item><description>user_custom: Created by the user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user_custom</para>
        /// </summary>
        [NameInMap("credentialCreationType")]
        [Validation(Required=false)]
        public string CredentialCreationType { get; set; }

        /// <summary>
        /// <para>The external unique identifier of the credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23528e9957304f57b98112c72788b5xxxxx</para>
        /// </summary>
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
        /// <para>The Scenarios label of the credential. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>llm: Large language model.</description></item>
        /// <item><description>saas: Third-party SaaS service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>llm</para>
        /// </summary>
        [NameInMap("credentialScenarioLabel")]
        [Validation(Required=false)]
        public string CredentialScenarioLabel { get; set; }

        /// <summary>
        /// <para>The credential sharing scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_exclusive</para>
        /// </summary>
        [NameInMap("credentialSharingScope")]
        [Validation(Required=false)]
        public string CredentialSharingScope { get; set; }

        /// <summary>
        /// <para>The subject ID that the credential belongs to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apt_werthgfdsasffxxxxx</para>
        /// </summary>
        [NameInMap("credentialSubjectId")]
        [Validation(Required=false)]
        public string CredentialSubjectId { get; set; }

        /// <summary>
        /// <para>The subject type that the credential belongs to. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>authentication_token_provider: Authentication token provider.</description></item>
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
        /// <item><description>api_key: API Key authentication credential.</description></item>
        /// <item><description>oauth_client: OAuth client authentication credential.</description></item>
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
        /// <para>The exclusive account ID of the credential.</para>
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
        /// <para>The credential status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: Enabled.</description></item>
        /// <item><description>disabled: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The update time, in UNIX timestamp format. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830227000</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
