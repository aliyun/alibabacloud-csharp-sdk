// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDynamicRoutesResponseBody : TeaModel {
        [NameInMap("DynamicRoutes")]
        [Validation(Required=false)]
        public List<ListDynamicRoutesResponseBodyDynamicRoutes> DynamicRoutes { get; set; }
        public class ListDynamicRoutesResponseBodyDynamicRoutes : TeaModel {
            [NameInMap("ApplicationIds")]
            [Validation(Required=false)]
            public List<string> ApplicationIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Application</para>
            /// </summary>
            [NameInMap("ApplicationType")]
            [Validation(Required=false)]
            public string ApplicationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-21 11:50:03</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dr-a0ca843f53cf****</para>
            /// </summary>
            [NameInMap("DynamicRouteId")]
            [Validation(Required=false)]
            public string DynamicRouteId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>connector</para>
            /// </summary>
            [NameInMap("DynamicRouteType")]
            [Validation(Required=false)]
            public string DynamicRouteType { get; set; }

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
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

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

            [NameInMap("TagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
