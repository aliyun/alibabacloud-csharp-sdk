// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The request body for updating the credential.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateCredentialRequestBody Body { get; set; }
        public class UpdateCredentialRequestBody : TeaModel {
            /// <summary>
            /// <para>The new credential content. The value is a JSON string. If credentialType is set to apiKey, only the apiKey field can be included, and the value cannot be empty. At least one of credentialMetadata and description must be specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;apiKey&quot;:&quot;sk-example-value&quot;}</para>
            /// </summary>
            [NameInMap("credentialMetadata")]
            [Validation(Required=false)]
            public string CredentialMetadata { get; set; }

            /// <summary>
            /// <para>The new credential description. The description can be up to 256 characters in length. At least one of description and credentialMetadata must be specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>API Key used for calling model services in the production environment</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>This parameter is required and must be a non-empty array when resourceScope is set to SPECIFIED. Each item contains resourceType and resourceId. resourceName is optional.</para>
            /// </summary>
            [NameInMap("resourceRefs")]
            [Validation(Required=false)]
            public List<UpdateCredentialRequestBodyResourceRefs> ResourceRefs { get; set; }
            public class UpdateCredentialRequestBodyResourceRefs : TeaModel {
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
                /// <para>The resource name. This value is empty if the resource has been deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent</para>
                /// </summary>
                [NameInMap("resourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The resource type, such as agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>ALL indicates all resources. SPECIFIED indicates that the credential applies only to the resources specified in resourceRefs.</para>
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
