// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateNacosMcpServerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;REF&quot;,&quot;data&quot;:{&quot;namespaceId&quot;:&quot;public&quot;,&quot;groupName&quot;:&quot;mcp-endpoints&quot;,&quot;serviceName&quot;:&quot;mcp-demo&quot;}}</para>
        /// </summary>
        [NameInMap("EndpointSpecification")]
        [Validation(Required=false)]
        public string EndpointSpecification { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mse-cn-st21ri2****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mcp-demo</para>
        /// </summary>
        [NameInMap("ServerName")]
        [Validation(Required=false)]
        public string ServerName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;description&quot;:&quot;a mcp demo service&quot;,&quot;capabilities&quot;:[],&quot;allVersions&quot;:[{&quot;version&quot;:&quot;1.0.0&quot;,&quot;release_date&quot;:&quot;2025-08-13T01:58:42Z&quot;,&quot;is_latest&quot;:true}],&quot;remoteServerConfig&quot;:{&quot;exportPath&quot;:&quot;/sse&quot;},&quot;enabled&quot;:true,&quot;versionDetail&quot;:{&quot;version&quot;:&quot;1.0.1&quot;},&quot;backendEndpoints&quot;:[{&quot;path&quot;:&quot;/sse&quot;,&quot;address&quot;:&quot;127.0.0.1&quot;,&quot;port&quot;:8080}],&quot;protocol&quot;:&quot;mcp-sse&quot;,&quot;name&quot;:&quot;mcp-demo&quot;,&quot;frontProtocol&quot;:&quot;mcp-sse&quot;}</para>
        /// </summary>
        [NameInMap("ServerSpecification")]
        [Validation(Required=false)]
        public string ServerSpecification { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;tools&quot;:[{&quot;name&quot;:&quot;demo-tool&quot;,&quot;description&quot;:&quot;a demo tool&quot;,&quot;inputSchema&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;name&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;name&quot;}}}}],&quot;toolsMeta&quot;:{&quot;demo-tool&quot;:{&quot;enabled&quot;:true}}}</para>
        /// </summary>
        [NameInMap("ToolSpecification")]
        [Validation(Required=false)]
        public string ToolSpecification { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>allowTools:</para>
        /// <list type="bullet">
        /// <item><description>demo-tool
        /// securityScheme: {}
        /// server:
        /// name: mcp-demo
        /// tools:</description></item>
        /// <item><description>args:<list type="bullet">
        /// <item><description>name: name
        /// description: name
        /// type: string
        /// description: a demo tool
        /// name: demo-tool</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("YamlConfig")]
        [Validation(Required=false)]
        public string YamlConfig { get; set; }

    }

}
