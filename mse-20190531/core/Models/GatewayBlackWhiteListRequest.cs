// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GatewayBlackWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values: zh (Chinese, default) and en (English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>This parameter is not available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("DescSort")]
        [Validation(Required=false)]
        public bool? DescSort { get; set; }

        /// <summary>
        /// <para>parse from filterParams</para>
        /// </summary>
        [NameInMap("FilterParams")]
        [Validation(Required=false)]
        public GatewayBlackWhiteListRequestFilterParams FilterParams { get; set; }
        public class GatewayBlackWhiteListRequestFilterParams : TeaModel {
            /// <summary>
            /// <para>The gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// <para>The unique identifier of the gateway. If both GatewayUniqueId and GatewayId are specified, GatewayId takes precedence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-5017305290e14centbrveca****</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <para>This parameter is not available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("IsWhite")]
            [Validation(Required=false)]
            public bool? IsWhite { get; set; }

            /// <summary>
            /// <para>This parameter is not available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The search content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("SearchContent")]
            [Validation(Required=false)]
            public string SearchContent { get; set; }

            /// <summary>
            /// <para>The query type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ROUTE: searches by route. Set SearchContent to the route name.</para>
            /// </description></item>
            /// <item><description><para>DOMAIN: searches by domain name. Set SearchContent to the domain name.</para>
            /// </description></item>
            /// <item><description><para>IP: searches by specified IP address. Set SearchContent to the IP address.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IP</para>
            /// </summary>
            [NameInMap("SearchType")]
            [Validation(Required=false)]
            public string SearchType { get; set; }

            /// <summary>
            /// <para>This parameter is not available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>This parameter is not available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("OrderItem")]
        [Validation(Required=false)]
        public string OrderItem { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: integers greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
