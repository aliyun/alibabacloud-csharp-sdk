// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDynamicRoutesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of dynamic routes.</para>
        /// </summary>
        [NameInMap("DynamicRoutes")]
        [Validation(Required=false)]
        public List<ListDynamicRoutesResponseBodyDynamicRoutes> DynamicRoutes { get; set; }
        public class ListDynamicRoutesResponseBodyDynamicRoutes : TeaModel {
            /// <summary>
            /// <para>The IDs of the private access applications for the dynamic route. This field has a value when the application type is <b>Application</b>.</para>
            /// </summary>
            [NameInMap("ApplicationIds")]
            [Validation(Required=false)]
            public List<string> ApplicationIds { get; set; }

            /// <summary>
            /// <para>The application type of the dynamic route. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>All</b>: All applications.</para>
            /// </description></item>
            /// <item><description><para><b>Application</b>: A specific application.</para>
            /// </description></item>
            /// <item><description><para><b>Tag</b>: A specific tag.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Application</para>
            /// </summary>
            [NameInMap("ApplicationType")]
            [Validation(Required=false)]
            public string ApplicationType { get; set; }

            /// <summary>
            /// <para>The time when the dynamic route was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-21 11:50:03</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the dynamic route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一条动态路由</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the dynamic route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dr-a0ca843f53cf****</para>
            /// </summary>
            [NameInMap("DynamicRouteId")]
            [Validation(Required=false)]
            public string DynamicRouteId { get; set; }

            /// <summary>
            /// <para>The type of the dynamic route. Valid value: <b>connector</b>, which indicates a private leased line.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connector</para>
            /// </summary>
            [NameInMap("DynamicRouteType")]
            [Validation(Required=false)]
            public string DynamicRouteType { get; set; }

            /// <summary>
            /// <para>The name of the dynamic route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dynamic_route_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the next hop instance for the dynamic route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connector-8ccb13b6f52c****</para>
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            /// <summary>
            /// <para>The priority of the dynamic route. A value of 1 indicates the highest priority. The priority is consistent with the order in the list query results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The list of regions where the SASE POP cluster endpoint is supported.</para>
            /// </summary>
            [NameInMap("RegionIds")]
            [Validation(Required=false)]
            public List<string> RegionIds { get; set; }

            /// <summary>
            /// <para>The status of the dynamic route. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enabled</b>: The dynamic route is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b>: The dynamic route is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The IDs of the private access tags for the dynamic route. This field has a value when the application type is <b>Tag</b>.</para>
            /// </summary>
            [NameInMap("TagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of dynamic routes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
