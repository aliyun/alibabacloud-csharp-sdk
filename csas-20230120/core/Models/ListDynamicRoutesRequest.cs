// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDynamicRoutesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the private access application for the dynamic route. You cannot filter by both the private access application ID and the private access tag ID. You can obtain the ID from the following sources:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="~~ListPrivateAccessApplications~~">ListPrivateAccessApplications</a>: Queries multiple private access applications.</para>
        /// </description></item>
        /// <item><description><para><a href="~~CreatePrivateAccessApplication~~">CreatePrivateAccessApplication</a>: Creates a private access application.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pa-application-e12860ef6c48****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The number of the page to return for a paged query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The IDs of the dynamic routes. You can specify up to 100 dynamic route IDs.</para>
        /// </summary>
        [NameInMap("DynamicRouteIds")]
        [Validation(Required=false)]
        public List<string> DynamicRouteIds { get; set; }

        /// <summary>
        /// <para>The name of the dynamic route. The name must be 1 to 128 characters in length and can contain Chinese characters, letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>dynamic_route_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the next hop instance for the dynamic route. You can obtain the ID from the following source:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListConnectors~~">ListConnectors</a>: Queries multiple connectors.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>connector-8ccb13b6f52c****</para>
        /// </summary>
        [NameInMap("NextHop")]
        [Validation(Required=false)]
        public string NextHop { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. Valid values: 1 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The ID of the private access tag for the dynamic route. You cannot filter by both the private access tag ID and the private access application ID. You can obtain the ID from the following sources:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="~~ListPrivateAccessTags~~">ListPrivateAccessTags</a>: Queries multiple private access tags.</para>
        /// </description></item>
        /// <item><description><para><a href="~~CreatePrivateAccessTag~~">CreatePrivateAccessTag</a>: Creates a private access tag.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tag-d3f64e8bdd4a****</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

    }

}
