// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPluginsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the mounted resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-cuip2pum1hksng6oni3g</para>
        /// </summary>
        [NameInMap("attachResourceId")]
        [Validation(Required=false)]
        public string AttachResourceId { get; set; }

        /// <summary>
        /// <para>The type of mount point supported by the policy.</para>
        /// <list type="bullet">
        /// <item><description>HttpApi: HttpApi.</description></item>
        /// <item><description>Operation: Operation of HttpApi.</description></item>
        /// <item><description>GatewayRoute: Gateway route.</description></item>
        /// <item><description>GatewayService: Gateway service.</description></item>
        /// <item><description>GatewayServicePort: Gateway service port.</description></item>
        /// <item><description>Domain: Gateway domain name.</description></item>
        /// <item><description>Gateway: Gateway.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HttpApi</para>
        /// </summary>
        [NameInMap("attachResourceType")]
        [Validation(Required=false)]
        public string AttachResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the gateway instance used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-csrhgn6m1hkt65qbxxgg</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The gateway type used to filter results. Valid values: <b>AI</b> and <b>API</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>Specifies whether the response includes built-in AI plug-ins installed by the system. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("includeBuiltinAiGateway")]
        [Validation(Required=false)]
        public bool? IncludeBuiltinAiGateway { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the plug-in type used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pls-dn82a9djd8z****</para>
        /// </summary>
        [NameInMap("pluginClassId")]
        [Validation(Required=false)]
        public string PluginClassId { get; set; }

        /// <summary>
        /// <para>The name of the plug-in type used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-auth</para>
        /// </summary>
        [NameInMap("pluginClassName")]
        [Validation(Required=false)]
        public string PluginClassName { get; set; }

        /// <summary>
        /// <para>Specifies whether the response includes the plug-in mounting information corresponding to attachResourceId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("withAttachmentInfo")]
        [Validation(Required=false)]
        public bool? WithAttachmentInfo { get; set; }

    }

}
