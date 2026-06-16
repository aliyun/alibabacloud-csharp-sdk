// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCredentialsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of credentials.</para>
        /// </summary>
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public List<ListCredentialsResponseBodyCredentials> Credentials { get; set; }
        public class ListCredentialsResponseBodyCredentials : TeaModel {
            /// <summary>
            /// <para>The time the credential was created, provided as a Unix timestamp in milliseconds.</para>
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
            public ListCredentialsResponseBodyCredentialsCredentialContent CredentialContent { get; set; }
            public class ListCredentialsResponseBodyCredentialsCredentialContent : TeaModel {
                /// <summary>
                /// <para>The content of an OAuth client credential.</para>
                /// </summary>
                [NameInMap("OAuthClientContent")]
                [Validation(Required=false)]
                public ListCredentialsResponseBodyCredentialsCredentialContentOAuthClientContent OAuthClientContent { get; set; }
                public class ListCredentialsResponseBodyCredentialsCredentialContentOAuthClientContent : TeaModel {
                    /// <summary>
                    /// <para>The client ID of the OAuth client.</para>
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
            /// <item><description><para><c>system_init</c>: Created by the system.</para>
            /// </description></item>
            /// <item><description><para><c>user_custom</c>: Created by a user.</para>
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
            /// <para>The use case label for the credential. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>llm</c>: A large language model.</para>
            /// </description></item>
            /// <item><description><para><c>saas</c>: A third-party SaaS service.</para>
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
            /// <para>The ID of the credential\&quot;s subject.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apt_werthgfdsasffxxxxx</para>
            /// </summary>
            [NameInMap("CredentialSubjectId")]
            [Validation(Required=false)]
            public string CredentialSubjectId { get; set; }

            /// <summary>
            /// <para>The type of the credential\&quot;s subject. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><c>authentication_token_provider</c>: An authentication token provider.</description></item>
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
            /// <para>The description of the credential.</para>
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
            /// <para>The ID of the EIAM instance.</para>
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
            /// <item><description><para><c>enabled</c>: The credential is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>disabled</c>: The credential is disabled.</para>
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
            /// <para>The time the credential was last updated, provided as a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830227000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. If this parameter is not returned, it indicates all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
