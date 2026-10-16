// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The request body for creating a credential.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateCredentialRequestBody Body { get; set; }
        public class CreateCredentialRequestBody : TeaModel {
            /// <summary>
            /// <para>The credential content, which is a JSON string. If credentialType is apiKey, this parameter can only contain the apiKey field, and the value cannot be empty. After the credential is written, only desensitized queries are supported.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;apiKey&quot;:&quot;sk-example-value&quot;}</para>
            /// </summary>
            [NameInMap("credentialMetadata")]
            [Validation(Required=false)]
            public string CredentialMetadata { get; set; }

            /// <summary>
            /// <para>The credential type. Currently, only apiKey is supported.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apiKey</para>
            /// </summary>
            [NameInMap("credentialType")]
            [Validation(Required=false)]
            public string CredentialType { get; set; }

            /// <summary>
            /// <para>The description of the credential. The description can be up to 256 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>API key used to call the model service in the production environment</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the credential. The name must be unique within the workspace, can only contain letters, digits, periods, underscores, and hyphens, and must be 3 to 128 characters in length. Runtime reserved names cannot be used.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model-api-key</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>If resourceScope is SPECIFIED, this parameter must be a non-empty array. Each item must contain resourceType and resourceId. resourceName is optional.</para>
            /// </summary>
            [NameInMap("resourceRefs")]
            [Validation(Required=false)]
            public List<CreateCredentialRequestBodyResourceRefs> ResourceRefs { get; set; }
            public class CreateCredentialRequestBodyResourceRefs : TeaModel {
                /// <summary>
                /// <para>The unique identifier of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-xxxx</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The name of the resource. This parameter is empty if the resource is deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent</para>
                /// </summary>
                [NameInMap("resourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The type of the resource, such as agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The application scope of the credential resource. A value of ALL indicates all resources. A value of SPECIFIED indicates that the credential is applied only to the resources specified by resourceRefs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("resourceScope")]
            [Validation(Required=false)]
            public string ResourceScope { get; set; }

        }

        /// <summary>
        /// <para>Not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Not supported</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
