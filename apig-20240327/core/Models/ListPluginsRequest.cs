// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPluginsRequest : TeaModel {
        /// <summary>
        /// <para>The resource attachment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-cuip2pum1hksng6oni3g</para>
        /// </summary>
        [NameInMap("attachResourceId")]
        [Validation(Required=false)]
        public string AttachResourceId { get; set; }

        /// <summary>
        /// <para>The resource attachment type.</para>
        /// <list type="bullet">
        /// <item><description>HttpApi: HttpApi.</description></item>
        /// <item><description>Operation: Operation of HttpApi.</description></item>
        /// <item><description>GatewayRoute: Gateway route.</description></item>
        /// <item><description>GatewayService: Gateway service.</description></item>
        /// <item><description>GatewayServicePort: Gateway service port.</description></item>
        /// <item><description>Domain: Gateway domain.</description></item>
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
        /// <para>The gateway instance ID for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-csrhgn6m1hkt65qbxxgg</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values: <b>AI</b> and <b>API</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>Specifies whether to include built-in AI plug-ins in the returned results. Default: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("includeBuiltinAiGateway")]
        [Validation(Required=false)]
        public bool? IncludeBuiltinAiGateway { get; set; }

        /// <summary>
        /// <para>The page number to return. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The plug-in type ID for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pls-dn82a9djd8z****</para>
        /// </summary>
        [NameInMap("pluginClassId")]
        [Validation(Required=false)]
        public string PluginClassId { get; set; }

        /// <summary>
        /// <para>The plug-in type name for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-auth</para>
        /// </summary>
        [NameInMap("pluginClassName")]
        [Validation(Required=false)]
        public string PluginClassName { get; set; }

        /// <summary>
        /// <para>Specifies whether the returned results should include plug-in attachment information corresponding to the attachResourceId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("withAttachmentInfo")]
        [Validation(Required=false)]
        public bool? WithAttachmentInfo { get; set; }

    }

}
