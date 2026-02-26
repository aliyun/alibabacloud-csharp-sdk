// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCredentialRequest : TeaModel {
        /// <summary>
        /// <para>保证请求幂等性。从您的客户端生成一个参数值，确保不同请求间该参数值唯一。ClientToken只支持ASCII字符，且不能超过64个字符。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>凭据的内容。</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CredentialContent")]
        [Validation(Required=false)]
        public CreateCredentialRequestCredentialContent CredentialContent { get; set; }
        public class CreateCredentialRequestCredentialContent : TeaModel {
            /// <summary>
            /// <para>Api Key的内容。</para>
            /// </summary>
            [NameInMap("ApiKeyContent")]
            [Validation(Required=false)]
            public CreateCredentialRequestCredentialContentApiKeyContent ApiKeyContent { get; set; }
            public class CreateCredentialRequestCredentialContentApiKeyContent : TeaModel {
                /// <summary>
                /// <para>API Key 凭证类型的凭据内容。</para>
                /// 
                /// <b>Example:</b>
                /// <para>nsklnertyt5ddwizncxxxx</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

            }

            /// <summary>
            /// <para>OAuth客户端认证凭证类型的凭据内容。</para>
            /// </summary>
            [NameInMap("OAuthClientContent")]
            [Validation(Required=false)]
            public CreateCredentialRequestCredentialContentOAuthClientContent OAuthClientContent { get; set; }
            public class CreateCredentialRequestCredentialContentOAuthClientContent : TeaModel {
                /// <summary>
                /// <para>OAuth协议的client_id。</para>
                /// 
                /// <b>Example:</b>
                /// <para>dmvncmxersdxxxxxx</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>OAuth协议的client_secret。</para>
                /// 
                /// <b>Example:</b>
                /// <para>nsklncmwizncxxxx</para>
                /// </summary>
                [NameInMap("ClientSecret")]
                [Validation(Required=false)]
                public string ClientSecret { get; set; }

            }

        }

        /// <summary>
        /// <para>凭据标识。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_identifier_test</para>
        /// </summary>
        [NameInMap("CredentialIdentifier")]
        [Validation(Required=false)]
        public string CredentialIdentifier { get; set; }

        /// <summary>
        /// <para>凭据名称。</para>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
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
        /// <para>IDaaS EIAM实例的ID。</para>
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
