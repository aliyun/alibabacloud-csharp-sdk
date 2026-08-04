// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateDynamicRouteRequest : TeaModel {
        /// <summary>
        /// <para>A collection of private network access application IDs for the dynamic route. You can specify up to 200 IDs. This parameter is required when <b>ApplicationType</b> is set to <b>Application</b>. Specify either this parameter or <b>TagIds</b>, but not both. Do not specify this parameter when <b>ApplicationType</b> is set to <b>All</b>.</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// <para>The application type of the dynamic route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>All</b>: All applications.</para>
        /// </description></item>
        /// <item><description><para><b>Application</b>: Application.</para>
        /// </description></item>
        /// <item><description><para><b>Tag</b>: Tag.</para>
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
        /// <para>The description of the dynamic route. The description must be 1 to 128 characters long and can contain letters, digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一条动态路由</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the dynamic route.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dr-ca9fddfac7c6****</para>
        /// </summary>
        [NameInMap("DynamicRouteId")]
        [Validation(Required=false)]
        public string DynamicRouteId { get; set; }

        /// <summary>
        /// <para>The type of the dynamic route. Valid value: <b>connector</b>: leased line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector</para>
        /// </summary>
        [NameInMap("DynamicRouteType")]
        [Validation(Required=false)]
        public string DynamicRouteType { get; set; }

        /// <summary>
        /// <para>The modification type of the dynamic route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Cover</b> (default): Use the values of <b>RegionIds</b>, <b>ApplicationIds</b>, and <b>TagIds</b> to overwrite the existing regions, private network access application IDs, and private network access tag IDs supported by the SASE POP cluster access points.</para>
        /// </description></item>
        /// <item><description><para><b>Append</b>: Add the values specified in <b>RegionIds</b>, <b>ApplicationIds</b>, and <b>TagIds</b> to the existing regions, private network access application IDs, and private network access tag IDs supported by the SASE POP cluster access points.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>The name of the dynamic route. The name must be 1 to 128 characters long and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>dynamic_route_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The next hop instance ID of the dynamic route. To get valid values, see:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListConnectors~~">ListConnectors</a>: Query connectors in bulk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>connector-8ccb13b6f52c****</para>
        /// </summary>
        [NameInMap("NextHop")]
        [Validation(Required=false)]
        public string NextHop { get; set; }

        /// <summary>
        /// <para>The route priority. A value of 1 indicates the highest priority. Valid values: 1 to 99.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>A list of regions supported by the SASE POP cluster access points.</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// <para>The status of the dynamic route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enabled</b>: Enable the route.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: Disable the route.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>A collection of private network access tag IDs for the dynamic route. You can specify up to 40 IDs. This parameter is required when <b>ApplicationType</b> is set to <b>Tag</b>. Specify either this parameter or <b>ApplicationIds</b>, but not both. Do not specify this parameter when <b>ApplicationType</b> is set to <b>All</b>.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

    }

}
