// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ObtainCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>云角色创建时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830225000</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>凭据的内容。</para>
        /// </summary>
        [NameInMap("credentialContent")]
        [Validation(Required=false)]
        public ObtainCredentialResponseBodyCredentialContent CredentialContent { get; set; }
        public class ObtainCredentialResponseBodyCredentialContent : TeaModel {
            [NameInMap("apiKeyContent")]
            [Validation(Required=false)]
            public ObtainCredentialResponseBodyCredentialContentApiKeyContent ApiKeyContent { get; set; }
            public class ObtainCredentialResponseBodyCredentialContentApiKeyContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>nsklncmwizncxxxx</para>
                /// </summary>
                [NameInMap("apiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

            }

            /// <summary>
            /// <para>OAuth客户端认证凭证类型的凭据内容。</para>
            /// </summary>
            [NameInMap("oauthClientContent")]
            [Validation(Required=false)]
            public ObtainCredentialResponseBodyCredentialContentOauthClientContent OauthClientContent { get; set; }
            public class ObtainCredentialResponseBodyCredentialContentOauthClientContent : TeaModel {
                /// <summary>
                /// <para>OAuth协议的client_id</para>
                /// 
                /// <b>Example:</b>
                /// <para>dmvncmxersdxxxxxx</para>
                /// </summary>
                [NameInMap("clientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>nsklnertyt5ddwizncxxxx</para>
                /// </summary>
                [NameInMap("clientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

            }

        }

        /// <summary>
        /// <para>凭据的创建类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_custom</para>
        /// </summary>
        [NameInMap("credentialCreationType")]
        [Validation(Required=false)]
        public string CredentialCreationType { get; set; }

        /// <summary>
        /// <para>凭据ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>cred_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("credentialId")]
        [Validation(Required=false)]
        public string CredentialId { get; set; }

        /// <summary>
        /// <para>凭据标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_identifier_test</para>
        /// </summary>
        [NameInMap("credentialIdentifier")]
        [Validation(Required=false)]
        public string CredentialIdentifier { get; set; }

        /// <summary>
        /// <para>凭据名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_name</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        /// <summary>
        /// <para>凭据的使用场景标签。</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm</para>
        /// </summary>
        [NameInMap("credentialScenarioLabel")]
        [Validation(Required=false)]
        public string CredentialScenarioLabel { get; set; }

        /// <summary>
        /// <para>凭据所属的主体ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>apt_werthgfdsasffxxxxx</para>
        /// </summary>
        [NameInMap("credentialSubjectId")]
        [Validation(Required=false)]
        public string CredentialSubjectId { get; set; }

        /// <summary>
        /// <para>凭据所属的主体类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>authentication_token_provider</para>
        /// </summary>
        [NameInMap("credentialSubjectType")]
        [Validation(Required=false)]
        public string CredentialSubjectType { get; set; }

        /// <summary>
        /// <para>凭据类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>api_key</para>
        /// </summary>
        [NameInMap("credentialType")]
        [Validation(Required=false)]
        public string CredentialType { get; set; }

        /// <summary>
        /// <para>描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>EIAM实例ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>凭据状态</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>云角色更新时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649830227000</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
