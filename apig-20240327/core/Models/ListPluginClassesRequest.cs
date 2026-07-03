// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPluginClassesRequest : TeaModel {
        /// <summary>
        /// <para>The plug-in alias. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OAuth2 认证</para>
        /// </summary>
        [NameInMap("aliasLike")]
        [Validation(Required=false)]
        public string AliasLike { get; set; }

        /// <summary>
        /// <para>The inbound or outbound direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OutBound: outbound.</description></item>
        /// <item><description>InBound: inbound.</description></item>
        /// <item><description>Both: both directions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InBound</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude built-in plug-ins.</para>
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
        /// <para>Specifies whether the plug-in is installed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("installed")]
        [Validation(Required=false)]
        public bool? Installed { get; set; }

        /// <summary>
        /// <para>The plug-in name. Fuzzy match is supported.</para>
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
        /// <para>The plug-in source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HigressOfficial: Higress official.</description></item>
        /// <item><description>HigressCommunity: Higress community.</description></item>
        /// <item><description>Custom: custom.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HigressOfficial</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The plug-in type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Auth</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
