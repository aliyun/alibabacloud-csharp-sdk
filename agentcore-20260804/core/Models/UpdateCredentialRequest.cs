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
            /// <para>The credential content, submitted as a JSON string. For the apiKey type, it contains only a non-empty apiKey. For the mcpHeader type, it contains a non-empty headers array, where each item includes a name and a value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;apiKey&quot;:&quot;sk-example-value&quot;}</para>
            /// </summary>
            [NameInMap("credentialMetadata")]
            [Validation(Required=false)]
            public string CredentialMetadata { get; set; }

            /// <summary>
            /// <para>The new credential description. The description can be up to 256 characters in length. If omitted, the original description is retained. It can be updated independently of the credential content or application scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>API key used to call the model service in the production environment</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of applicable resources for the MCP header credential. If submitted, resourceScope must also be submitted. An empty array [] is allowed when the scope is SPECIFIED. Omit this field when the scope is ALL.</para>
            /// </summary>
            [NameInMap("resourceRefs")]
            [Validation(Required=false)]
            public List<UpdateCredentialRequestBodyResourceRefs> ResourceRefs { get; set; }
            public class UpdateCredentialRequestBodyResourceRefs : TeaModel {
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
                /// <para>The resource name. This field is empty if the resource has been deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-mcp-service</para>
                /// </summary>
                [NameInMap("resourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The resource type. Currently, the value is mcpServer, which indicates an MCP service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mcpServer</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The application scope of the MCP header credential. This field is supported only for the mcpHeader type. ALL indicates all MCP services, and SPECIFIED indicates the MCP services specified in resourceRefs. Do not submit this field for the apiKey type.</para>
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
