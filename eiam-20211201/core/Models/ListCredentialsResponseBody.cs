// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCredentialsResponseBody : TeaModel {
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public List<ListCredentialsResponseBodyCredentials> Credentials { get; set; }
        public class ListCredentialsResponseBodyCredentials : TeaModel {
            /// <summary>
            /// <para>云角色创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830225000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>凭据的内容。</para>
            /// </summary>
            [NameInMap("CredentialContent")]
            [Validation(Required=false)]
            public ListCredentialsResponseBodyCredentialsCredentialContent CredentialContent { get; set; }
            public class ListCredentialsResponseBodyCredentialsCredentialContent : TeaModel {
                /// <summary>
                /// <para>OAuth客户端认证凭证类型的凭据内容。</para>
                /// </summary>
                [NameInMap("OAuthClientContent")]
                [Validation(Required=false)]
                public ListCredentialsResponseBodyCredentialsCredentialContentOAuthClientContent OAuthClientContent { get; set; }
                public class ListCredentialsResponseBodyCredentialsCredentialContentOAuthClientContent : TeaModel {
                    /// <summary>
                    /// <para>OAuth协议的client_id</para>
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
            /// <para>凭据的创建类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_custom</para>
            /// </summary>
            [NameInMap("CredentialCreationType")]
            [Validation(Required=false)]
            public string CredentialCreationType { get; set; }

            /// <summary>
            /// <para>凭据ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>cred_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("CredentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            /// <summary>
            /// <para>凭据标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>credential_identifier_test</para>
            /// </summary>
            [NameInMap("CredentialIdentifier")]
            [Validation(Required=false)]
            public string CredentialIdentifier { get; set; }

            /// <summary>
            /// <para>凭据名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>credential_name</para>
            /// </summary>
            [NameInMap("CredentialName")]
            [Validation(Required=false)]
            public string CredentialName { get; set; }

            /// <summary>
            /// <para>凭据的使用场景标签。</para>
            /// 
            /// <b>Example:</b>
            /// <para>llm</para>
            /// </summary>
            [NameInMap("CredentialScenarioLabel")]
            [Validation(Required=false)]
            public string CredentialScenarioLabel { get; set; }

            /// <summary>
            /// <para>凭据所属的主体ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>apt_werthgfdsasffxxxxx</para>
            /// </summary>
            [NameInMap("CredentialSubjectId")]
            [Validation(Required=false)]
            public string CredentialSubjectId { get; set; }

            /// <summary>
            /// <para>凭据所属的主体类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>authentication_token_provider</para>
            /// </summary>
            [NameInMap("CredentialSubjectType")]
            [Validation(Required=false)]
            public string CredentialSubjectType { get; set; }

            /// <summary>
            /// <para>凭据类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>api_key</para>
            /// </summary>
            [NameInMap("CredentialType")]
            [Validation(Required=false)]
            public string CredentialType { get; set; }

            /// <summary>
            /// <para>描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>credential_description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>EIAM实例ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>凭据状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>云角色更新时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830227000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>分页查询时每页行数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>本次调用返回的查询凭证（Token）值，用于下一次翻页查询。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
