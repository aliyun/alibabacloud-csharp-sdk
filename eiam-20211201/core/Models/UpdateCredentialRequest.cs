// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateCredentialRequest : TeaModel {
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
        /// </summary>
        [NameInMap("CredentialContent")]
        [Validation(Required=false)]
        public UpdateCredentialRequestCredentialContent CredentialContent { get; set; }
        public class UpdateCredentialRequestCredentialContent : TeaModel {
            /// <summary>
            /// <para>Api Key的内容。</para>
            /// </summary>
            [NameInMap("ApiKeyContent")]
            [Validation(Required=false)]
            public UpdateCredentialRequestCredentialContentApiKeyContent ApiKeyContent { get; set; }
            public class UpdateCredentialRequestCredentialContentApiKeyContent : TeaModel {
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
            public UpdateCredentialRequestCredentialContentOAuthClientContent OAuthClientContent { get; set; }
            public class UpdateCredentialRequestCredentialContentOAuthClientContent : TeaModel {
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
        /// <para>凭据ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cred_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("CredentialId")]
        [Validation(Required=false)]
        public string CredentialId { get; set; }

        /// <summary>
        /// <para>凭据名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_name</para>
        /// </summary>
        [NameInMap("CredentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

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
