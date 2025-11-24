// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeIstioGatewayRoutesResponseBody : TeaModel {
        /// <summary>
        /// <para>The routing rules.</para>
        /// </summary>
        [NameInMap("ManagementRoutes")]
        [Validation(Required=false)]
        public List<DescribeIstioGatewayRoutesResponseBodyManagementRoutes> ManagementRoutes { get; set; }
        public class DescribeIstioGatewayRoutesResponseBodyManagementRoutes : TeaModel {
            /// <summary>
            /// <para>The name of the ASM gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ingressgateway</para>
            /// </summary>
            [NameInMap("ASMGatewayName")]
            [Validation(Required=false)]
            public string ASMGatewayName { get; set; }

            /// <summary>
            /// <para>The description of the routing rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo route</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Destination hosts list.</para>
            /// </summary>
            [NameInMap("DestinationHost")]
            [Validation(Required=false)]
            public List<string> DestinationHost { get; set; }

            /// <summary>
            /// <para>Destination subset list.</para>
            /// </summary>
            [NameInMap("DestinationSubSet")]
            [Validation(Required=false)]
            public List<string> DestinationSubSet { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>istio-demo</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The priority of the routing rule. The value of this parameter is an integer. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The name of the routing rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http-route</para>
            /// </summary>
            [NameInMap("RouteName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

            /// <summary>
            /// <para>The path that is used to match request URLs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/reviews/v1</para>
            /// </summary>
            [NameInMap("RoutePath")]
            [Validation(Required=false)]
            public string RoutePath { get; set; }

            /// <summary>
            /// <para>The status of the routing rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>0</c>: The routing rule is valid.</description></item>
            /// <item><description><c>1</c>: The routing rule is invalid.</description></item>
            /// <item><description><c>2</c>: An error occurs during the creation or update of the routing rule.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31d3a0f0-07ed-4f6e-9004-1804498c****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
