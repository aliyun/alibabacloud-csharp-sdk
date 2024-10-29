// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessApplicationsForDynamicRouteResponseBody : TeaModel {
        [NameInMap("DynamicRoutes")]
        [Validation(Required=false)]
        public List<ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutes> DynamicRoutes { get; set; }
        public class ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutes : TeaModel {
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutesApplications> Applications { get; set; }
            public class ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutesApplications : TeaModel {
                [NameInMap("Addresses")]
                [Validation(Required=false)]
                public List<string> Addresses { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pa-application-7a9243dd02f4****</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-04-13 13:33:24</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>application_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PortRanges")]
                [Validation(Required=false)]
                public List<ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutesApplicationsPortRanges> PortRanges { get; set; }
                public class ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutesApplicationsPortRanges : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("Begin")]
                    [Validation(Required=false)]
                    public int? Begin { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>81</para>
                    /// </summary>
                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public int? End { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>All</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dr-ca9fddfac7c6****</para>
            /// </summary>
            [NameInMap("DynamicRouteId")]
            [Validation(Required=false)]
            public string DynamicRouteId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BE4FB974-11BC-5453-9BE1-1606A73EACA6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
