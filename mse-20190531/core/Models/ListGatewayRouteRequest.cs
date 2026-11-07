// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayRouteRequest : TeaModel {
        /// <summary>
        /// <para>Language type for returned information:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>Sorting. This field is currently unavailable and being deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DescSort")]
        [Validation(Required=false)]
        public bool? DescSort { get; set; }

        /// <summary>
        /// <para>Filter conditions in the format {&quot;key1&quot;:&quot;value1&quot;}</para>
        /// </summary>
        [NameInMap("FilterParams")]
        [Validation(Required=false)]
        public ListGatewayRouteRequestFilterParams FilterParams { get; set; }
        public class ListGatewayRouteRequestFilterParams : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>Default service ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DefaultServiceId")]
            [Validation(Required=false)]
            [Obsolete]
            public long? DefaultServiceId { get; set; }

            /// <summary>
            /// <para>Domain ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>284</para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public long? DomainId { get; set; }

            /// <summary>
            /// <para>Associated domain</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.alites.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Gateway ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// <para>Gateway unique identifier ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-30a0106924c94bca8712ec4e79fc5acc</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <para>Route name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Route path</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>Order (unused)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RouteOrder")]
            [Validation(Required=false)]
            public int? RouteOrder { get; set; }

            /// <summary>
            /// <para>Route status:</para>
            /// <list type="bullet">
            /// <item><description><para>Unpublished: 0</para>
            /// </description></item>
            /// <item><description><para>Publishing: 2</para>
            /// </description></item>
            /// <item><description><para>Published: 3</para>
            /// </description></item>
            /// <item><description><para>Editing (updates not published): 4</para>
            /// </description></item>
            /// <item><description><para>Unpublishing: 5</para>
            /// </description></item>
            /// <item><description><para>Unavailable: 6</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>Sorting property.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreate</para>
        /// </summary>
        [NameInMap("OrderItem")]
        [Validation(Required=false)]
        public string OrderItem { get; set; }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of instances displayed per page (currently not in effect, queries all instances by default).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
