// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>The request body for binding an external identity provider.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestBody Body { get; set; }
        public class CreateIdentityProviderRequestBody : TeaModel {
            /// <summary>
            /// <para>The type of the external identity provider. Valid values: DingTalk, Feishu.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("identityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>Specifies whether workspace users are allowed to log on through this external identity provider.</para>
            /// </summary>
            [NameInMap("loginEnabled")]
            [Validation(Required=false)]
            public bool? LoginEnabled { get; set; }

            /// <summary>
            /// <para>The application configuration of the external identity provider. When binding DingTalk, you must provide appKey, appSecret, and corpId. When binding Lark, you must provide appId and appSecret.</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestBodyMetadata Metadata { get; set; }
            public class CreateIdentityProviderRequestBodyMetadata : TeaModel {
                /// <summary>
                /// <para>The App ID of the Lark application. This parameter is required when the binding type is Feishu.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cli_exampleappid01</para>
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The AppKey of the DingTalk application. This parameter is required when the binding type is DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingexampleappkey01</para>
                /// </summary>
                [NameInMap("appKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// <para>Required. The secret of the external identity provider application. This parameter is used only for write operations. The query API does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-app-secret</para>
                /// </summary>
                [NameInMap("appSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                /// <summary>
                /// <para>The CorpId of the DingTalk enterprise. This parameter is required when the binding type is DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingexamplecorpid01</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <para>The data encryption key for event subscription. The value must be the same as the one configured in the external identity provider application. This parameter is used only for write operations. The query API does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-encrypt-key</para>
                /// </summary>
                [NameInMap("encryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                /// <summary>
                /// <para>The verification token for event subscription. The value must be the same as the one configured in the external identity provider application. This parameter is used only for write operations. The query API does not return this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-verification-token</para>
                /// </summary>
                [NameInMap("verificationToken")]
                [Validation(Required=false)]
                public string VerificationToken { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable organization member synchronization. After this feature is enabled, the external identity provider synchronizes organization members as workspace users.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

        }

    }

}
