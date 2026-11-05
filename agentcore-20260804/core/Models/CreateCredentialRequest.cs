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
            /// <para>The credential content, submitted as a JSON string. For the apiKey type, it contains only a non-empty apiKey. For the mcpHeader type, it contains a non-empty headers array, where each item includes a name and a value.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;apiKey&quot;:&quot;sk-example-value&quot;}</para>
            /// </summary>
            [NameInMap("credentialMetadata")]
            [Validation(Required=false)]
            public string CredentialMetadata { get; set; }

            /// <summary>
            /// <para>The credential type. Valid values: apiKey (API key) and mcpHeader (MCP request header).</para>
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
            /// <para>The name of the credential. The name must be unique within the workspace, contain only letters, digits, periods, underscores, and hyphens, and be 3 to 99 characters in length. Runtime reserved names cannot be used.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model-api-key</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of applicable resources for an mcpHeader credential. This parameter must be non-empty when resourceScope is set to SPECIFIED, and must be omitted when resourceScope is set to ALL.</para>
            /// </summary>
            [NameInMap("resourceRefs")]
            [Validation(Required=false)]
            public List<CreateCredentialRequestBodyResourceRefs> ResourceRefs { get; set; }
            public class CreateCredentialRequestBodyResourceRefs : TeaModel {
                /// <summary>
                /// <para>The ID of the applicable MCP service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mcp-example</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The name of the resource. This parameter is empty if the resource is deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-mcp-service</para>
                /// </summary>
                [NameInMap("resourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The type of the resource. Set the value to mcpServer, which indicates an MCP service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mcpServer</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The application scope of an mcpHeader credential. This parameter is supported only for the mcpHeader type. ALL indicates all MCP services, and SPECIFIED indicates the MCP services specified in resourceRefs. Do not submit this field for the apiKey type.</para>
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
