// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateCredentialRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request. You can generate a parameter value on your client to ensure that the value is unique across different requests. The ClientToken parameter supports only ASCII characters and can be up to 64 characters in length. For more information, see References: <a href="https://www.alibabacloud.com/help/zh/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The credential content.</para>
        /// </summary>
        [NameInMap("CredentialContent")]
        [Validation(Required=false)]
        public UpdateCredentialRequestCredentialContent CredentialContent { get; set; }
        public class UpdateCredentialRequestCredentialContent : TeaModel {
            /// <summary>
            /// <para>The credential content for the API key credential type.</para>
            /// </summary>
            [NameInMap("ApiKeyContent")]
            [Validation(Required=false)]
            public UpdateCredentialRequestCredentialContentApiKeyContent ApiKeyContent { get; set; }
            public class UpdateCredentialRequestCredentialContentApiKeyContent : TeaModel {
                /// <summary>
                /// <para>The API key content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nsklnertyt5ddwizncxxxx</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

            }

            /// <summary>
            /// <para>The credential content for the OAuth client credential type.</para>
            /// </summary>
            [NameInMap("OAuthClientContent")]
            [Validation(Required=false)]
            public UpdateCredentialRequestCredentialContentOAuthClientContent OAuthClientContent { get; set; }
            public class UpdateCredentialRequestCredentialContentOAuthClientContent : TeaModel {
                /// <summary>
                /// <para>The client_id of the OAuth protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dmvncmxersdxxxxxx</para>
                /// </summary>
                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                /// <summary>
                /// <para>The client_secret of the OAuth protocol.</para>
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
        /// <para>The credential ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cred_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("CredentialId")]
        [Validation(Required=false)]
        public string CredentialId { get; set; }

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
        /// <para>The instance ID.</para>
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
