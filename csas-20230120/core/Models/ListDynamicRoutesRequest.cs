// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDynamicRoutesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pa-application-e12860ef6c48****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("DynamicRouteIds")]
        [Validation(Required=false)]
        public List<string> DynamicRouteIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dynamic_route_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>connector-8ccb13b6f52c****</para>
        /// </summary>
        [NameInMap("NextHop")]
        [Validation(Required=false)]
        public string NextHop { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tag-d3f64e8bdd4a****</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

    }

}
