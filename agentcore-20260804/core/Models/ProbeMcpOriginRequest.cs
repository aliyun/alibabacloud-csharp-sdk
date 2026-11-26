// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ProbeMcpOriginRequest : TeaModel {
        /// <summary>
        /// <para>The scope of the origin server configuration does not exceed that of the creation API. The control fields for this validation only restrict the validation scope and do not extend the origin server onboarding configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ProbeMcpOriginRequestBody Body { get; set; }
        public class ProbeMcpOriginRequestBody : TeaModel {
            /// <summary>
            /// <para>A single HTTP(S) URL that reuses the addresses of the origin server from the creation API. Embedded credentials, multiple addresses, or protected targets are not accepted.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://mcp.example.com/mcp">https://mcp.example.com/mcp</a></para>
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>Reuses the enabled, directProxy, and httpToMcp origin server authentication fields and validations from the creation API. If enabled is set to true, you must provide a configuration that matches the access type. codePackage or additional headers are not accepted.</para>
            /// </summary>
            [NameInMap("auth")]
            [Validation(Required=false)]
            public ProbeMcpOriginRequestBodyAuth Auth { get; set; }
            public class ProbeMcpOriginRequestBodyAuth : TeaModel {
                /// <summary>
                /// <para>The backend authentication configuration for the direct proxy.</para>
                /// </summary>
                [NameInMap("directProxy")]
                [Validation(Required=false)]
                public ProbeMcpOriginRequestBodyAuthDirectProxy DirectProxy { get; set; }
                public class ProbeMcpOriginRequestBodyAuthDirectProxy : TeaModel {
                    /// <summary>
                    /// <para>The name of the backend authentication header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Authorization</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value of the backend authentication header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-api-key</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether to enable this configuration.</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The list of backend authentication configurations for HTTP to MCP.</para>
                /// </summary>
                [NameInMap("httpToMcp")]
                [Validation(Required=false)]
                public List<ProbeMcpOriginRequestBodyAuthHttpToMcp> HttpToMcp { get; set; }
                public class ProbeMcpOriginRequestBodyAuthHttpToMcp : TeaModel {
                    /// <summary>
                    /// <para>The credential for the backend authentication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-api-key</para>
                    /// </summary>
                    [NameInMap("credential")]
                    [Validation(Required=false)]
                    public string Credential { get; set; }

                    /// <summary>
                    /// <para>The ID of the backend authentication configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>api-key-auth</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the API key parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>X-API-Key</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The location where the API key is passed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>header</para>
                    /// </summary>
                    [NameInMap("position")]
                    [Validation(Required=false)]
                    public string Position { get; set; }

                    /// <summary>
                    /// <para>The type of the backend authentication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>apiKey</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>Used only for HTTP. Reuses the JSON or YAML string semantics from the creation API. This field is required when validating the definition. Remote documents or references are not automatically fetched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;openapi&quot;:&quot;3.0.3&quot;,&quot;info&quot;:{&quot;title&quot;:&quot;Inventory API&quot;,&quot;version&quot;:&quot;1.0.0&quot;},&quot;paths&quot;:{&quot;/inventory&quot;:{&quot;get&quot;:{&quot;operationId&quot;:&quot;listInventory&quot;,&quot;responses&quot;:{&quot;200&quot;:{&quot;description&quot;:&quot;OK&quot;}}}}}}</para>
            /// </summary>
            [NameInMap("swaggerConfig")]
            [Validation(Required=false)]
            public string SwaggerConfig { get; set; }

            /// <summary>
            /// <para>The access type. Valid values: DIRECT_PROXY and HTTP_TO_MCP. CODE_PACKAGE is not supported.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DIRECT_PROXY</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
