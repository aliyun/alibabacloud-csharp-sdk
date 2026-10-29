// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>The request content for binding an external identity provider.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateIdentityProviderRequestBody Body { get; set; }
        public class CreateIdentityProviderRequestBody : TeaModel {
            /// <summary>
            /// <para>The type of the external identity provider. Valid values: DingTalk and Feishu.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("identityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow workspace users to log on through the external identity provider.</para>
            /// </summary>
            [NameInMap("loginEnabled")]
            [Validation(Required=false)]
            public bool? LoginEnabled { get; set; }

            /// <summary>
            /// <para>The application configuration of the external identity provider. When you bind DingTalk, you must provide appKey, appSecret, and corpId. When you bind Lark, you must provide appId and appSecret.</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestBodyMetadata Metadata { get; set; }
            public class CreateIdentityProviderRequestBodyMetadata : TeaModel {
                /// <summary>
                /// <para>The app ID of the Lark application. This parameter is required when the binding type is Feishu.</para>
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
                /// <para>Required. The secret of the external identity provider application. This parameter is used only for writing and is not returned by query API operations.</para>
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
                /// <para>The data encryption key for event subscription. The value must be the same as the one configured in the external identity provider application. This parameter is used only for writing and is not returned by query API operations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-encrypt-key</para>
                /// </summary>
                [NameInMap("encryptKey")]
                [Validation(Required=false)]
                public string EncryptKey { get; set; }

                /// <summary>
                /// <para>The verification token for event subscription. The value must be the same as the one configured in the external identity provider application. This parameter is used only for writing and is not returned by query API operations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-verification-token</para>
                /// </summary>
                [NameInMap("verificationToken")]
                [Validation(Required=false)]
                public string VerificationToken { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable organization member synchronization. If enabled, the external identity provider synchronizes organization members as workspace users.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

            /// <summary>
            /// <para>Controls the first synchronization when DingTalk or Lark is bound. If omitted or set to null, the default value is true. If set to false, only the configuration is saved, and synchronization is explicitly triggered later. CustomSSO does not use the vendor pull link.</para>
            /// </summary>
            [NameInMap("syncOnBind")]
            [Validation(Required=false)]
            public bool? SyncOnBind { get; set; }

            /// <summary>
            /// <para>Retains the department-based synchronization scope definition. If omitted during creation, the default value is AllAuthorized. The first vendor synchronization is determined by syncOnBind. If omitted or set to null during an update, the original value is retained. Updating and saving the scope does not automatically perform full synchronization.</para>
            /// </summary>
            [NameInMap("syncScope")]
            [Validation(Required=false)]
            public CreateIdentityProviderRequestBodySyncScope SyncScope { get; set; }
            public class CreateIdentityProviderRequestBodySyncScope : TeaModel {
                /// <summary>
                /// <para>When the mode is SelectedDepartments, the list must contain at least one non-empty department ID, which should be obtained from ListIdentityProviderDepartments. When the mode is AllAuthorized, pass an empty array or omit this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;10001&quot;]</para>
                /// </summary>
                [NameInMap("departmentIds")]
                [Validation(Required=false)]
                public List<string> DepartmentIds { get; set; }

                /// <summary>
                /// <para>AllAuthorized: the full authorization scope, which is limited by the application address book authorization. SelectedDepartments: the selected departments and all their sub-departments. When explicitly submitting syncScope, you must provide a valid mode, which is verified by the backend.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SelectedDepartments</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

        }

    }

}
