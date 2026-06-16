// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The credential details.</para>
        /// </summary>
        [NameInMap("Credential")]
        [Validation(Required=false)]
        public GetCredentialResponseBodyCredential Credential { get; set; }
        public class GetCredentialResponseBodyCredential : TeaModel {
            /// <summary>
            /// <para>The creation time of the credential, in Unix timestamp format (milliseconds).</para>
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
                /// <para>The credential content for an OAuth client. This parameter is returned only when <c>CredentialType</c> is <c>oauth_client</c>.</para>
                /// </summary>
                [NameInMap("OAuthClientContent")]
                [Validation(Required=false)]
                public GetCredentialResponseBodyCredentialCredentialContentOAuthClientContent OAuthClientContent { get; set; }
                public class GetCredentialResponseBodyCredentialCredentialContentOAuthClientContent : TeaModel {
                    /// <summary>
                    /// <para>The OAuth client ID.</para>
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
            /// <para>How the credential was created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>system_init</c>: The credential was created by the system.</para>
            /// </description></item>
            /// <item><description><para><c>user_custom</c>: The credential was created by a user.</para>
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
            /// <para>The ID of the credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cred_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("CredentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            /// <summary>
            /// <para>The identifier of the credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>credential_identifier_test</para>
            /// </summary>
            [NameInMap("CredentialIdentifier")]
            [Validation(Required=false)]
            public string CredentialIdentifier { get; set; }

            /// <summary>
            /// <para>The name of the credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>credential_name</para>
            /// </summary>
            [NameInMap("CredentialName")]
            [Validation(Required=false)]
            public string CredentialName { get; set; }

            /// <summary>
            /// <para>The use case of the credential. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>llm</c>: a large language model (LLM).</para>
            /// </description></item>
            /// <item><description><para><c>saas</c>: a third-party Software as a Service (SaaS) application.</para>
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
            /// <para>The ID of the subject that owns the credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apt_werthgfdsasffxxxxx</para>
            /// </summary>
            [NameInMap("CredentialSubjectId")]
            [Validation(Required=false)]
            public string CredentialSubjectId { get; set; }

            /// <summary>
            /// <para>The type of the subject that owns the credential. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><c>authentication_token_provider</c>: The subject is an authentication token provider.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>authentication_token_provider</para>
            /// </summary>
            [NameInMap("CredentialSubjectType")]
            [Validation(Required=false)]
            public string CredentialSubjectType { get; set; }

            /// <summary>
            /// <para>The type of the credential. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>api_key</c>: An API key.</para>
            /// </description></item>
            /// <item><description><para><c>oauth_client</c>: An OAuth client.</para>
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
            /// <para>The user-defined description of the credential.</para>
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
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status of the credential. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>enabled</c>: The credential is active.</para>
            /// </description></item>
            /// <item><description><para><c>disabled</c>: The credential is inactive.</para>
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
            /// <para>The time the credential was last updated, in Unix timestamp format (milliseconds).</para>
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
