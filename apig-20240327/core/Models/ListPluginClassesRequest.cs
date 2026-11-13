// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPluginClassesRequest : TeaModel {
        /// <summary>
        /// <para>The plugin alias for fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OAuth2 authentication</para>
        /// </summary>
        [NameInMap("aliasLike")]
        [Validation(Required=false)]
        public string AliasLike { get; set; }

        /// <summary>
        /// <para>The traffic direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OutBound: Outbound.</description></item>
        /// <item><description>InBound: Inbound.</description></item>
        /// <item><description>Both: Both.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InBound</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude built-in plugins.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("excludeBuiltinAiProxy")]
        [Validation(Required=false)]
        public bool? ExcludeBuiltinAiProxy { get; set; }

        /// <summary>
        /// <para>The gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-d1j8tjum1hkhxxxxxxxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The gateway type filter. Currently, <b>AI</b> and <b>API</b> gateway types are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>Specifies whether the plugin is installed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("installed")]
        [Validation(Required=false)]
        public bool? Installed { get; set; }

        /// <summary>
        /// <para>The plugin name for fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oauth</para>
        /// </summary>
        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
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
        /// <para>The plugin source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Higress official: HigressOfficial.</description></item>
        /// <item><description>Higress community: HigressCommunity.</description></item>
        /// <item><description>Custom: Custom.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HigressOfficial</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The plugin type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Auth</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
