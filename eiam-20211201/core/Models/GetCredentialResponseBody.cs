// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The credential information.</para>
        /// </summary>
        [NameInMap("Credential")]
        [Validation(Required=false)]
        public GetCredentialResponseBodyCredential Credential { get; set; }
        public class GetCredentialResponseBodyCredential : TeaModel {
            /// <summary>
            /// <para>The creation time, in UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830225000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The content of the credential.</para>
            /// </summary>
            [NameInMap("CredentialContent")]
            [Validation(Required=false)]
            public GetCredentialResponseBodyCredentialCredentialContent CredentialContent { get; set; }
            public class GetCredentialResponseBodyCredentialCredentialContent : TeaModel {
                /// <summary>
                /// <para>The content of the OAuth client credential.</para>
                /// </summary>
                [NameInMap("OAuthClientContent")]
                [Validation(Required=false)]
                public GetCredentialResponseBodyCredentialCredentialContentOAuthClientContent OAuthClientContent { get; set; }
                public class GetCredentialResponseBodyCredentialCredentialContentOAuthClientContent : TeaModel {
                    /// <summary>
                    /// <para>The client_id of the OAuth protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dmvncmxersdxxxxxx</para>
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

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
            /// <para>The scenarios label of the credential. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>llm: Large language model.</description></item>
            /// <item><description>saas: Third-party SaaS service.</description></item>
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
            /// <para>The ID of the subject to which the credential belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apt_werthgfdsasffxxxxx</para>
            /// </summary>
            [NameInMap("CredentialSubjectId")]
            [Validation(Required=false)]
            public string CredentialSubjectId { get; set; }

            /// <summary>
            /// <para>The type of the subject to which the credential belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>authentication_token_provider: Authentication token provider.</description></item>
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
            /// <item><description>api_key: API key credential.</description></item>
            /// <item><description>oauth_client: OAuth client credential.</description></item>
            /// </list>
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
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
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
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The update time, in UNIX timestamp format. Unit: milliseconds.</para>
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
