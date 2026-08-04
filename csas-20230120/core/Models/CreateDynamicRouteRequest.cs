// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateDynamicRouteRequest : TeaModel {
        /// <summary>
        /// <para>A collection of internal network access application IDs for the dynamic route. You can enter a maximum of 200 internal network access application IDs. Required when ApplicationType is <b>Application</b>. Choose one of <b>ApplicationIds</b> or <b>TagIds</b>. Do not enter when <b>ApplicationType</b> is <b>All</b>.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>The dynamic route description. It is 1 to 128 characters long. It supports Chinese characters, uppercase and lowercase letters, numbers, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一条动态路由</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The dynamic route type. Valid values: <b>connector</b>: Leased line.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector</para>
        /// </summary>
        [NameInMap("DynamicRouteType")]
        [Validation(Required=false)]
        public string DynamicRouteType { get; set; }

        /// <summary>
        /// <para>The dynamic route name. It is 1 to 128 characters long. It supports Chinese characters, uppercase and lowercase letters, numbers, periods (.), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dynamic_route_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The next hop instance ID of the dynamic route. Source:</para>
        /// <list type="bullet">
        /// <item><description>For more information, see <a href="">ListConnectors</a>: Query Connectors in batches.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector-8ccb13b6f52c****</para>
        /// </summary>
        [NameInMap("NextHop")]
        [Validation(Required=false)]
        public string NextHop { get; set; }

        /// <summary>
        /// <para>The dynamic route priority. 1 indicates the highest priority. Valid values: 1-99.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>A list of regions supported by SASE POP cluster access points.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// <para>The dynamic route status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enabled</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>A collection of internal network access tag IDs for the dynamic route. You can enter a maximum of 40 internal network access tag IDs. Required when ApplicationType is <b>Tag</b>. Choose one of <b>ApplicationIds</b> or <b>TagIds</b>. Do not enter when <b>ApplicationType</b> is <b>All</b>.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

    }

}
