// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessApplicationsForDynamicRouteResponseBody : TeaModel {
        /// <summary>
        /// <para>List of dynamic routes.</para>
        /// </summary>
        [NameInMap("DynamicRoutes")]
        [Validation(Required=false)]
        public List<ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutes> DynamicRoutes { get; set; }
        public class ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutes : TeaModel {
            /// <summary>
            /// <para>Collection of private access applications.</para>
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutesApplications> Applications { get; set; }
            public class ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutesApplications : TeaModel {
                /// <summary>
                /// <para>Collection of private access application addresses.</para>
                /// </summary>
                [NameInMap("Addresses")]
                [Validation(Required=false)]
                public List<string> Addresses { get; set; }

                /// <summary>
                /// <para>Private access application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pa-application-7a9243dd02f4****</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// <para>Time when the private access application was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-13 13:33:24</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Private access application description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一条被动态路由引用的内网访问应用</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Private access application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>application_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Collection of private access application port ranges.</para>
                /// </summary>
                [NameInMap("PortRanges")]
                [Validation(Required=false)]
                public List<ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutesApplicationsPortRanges> PortRanges { get; set; }
                public class ListPrivateAccessApplicationsForDynamicRouteResponseBodyDynamicRoutesApplicationsPortRanges : TeaModel {
                    /// <summary>
                    /// <para>Start port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("Begin")]
                    [Validation(Required=false)]
                    public int? Begin { get; set; }

                    /// <summary>
                    /// <para>End port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>81</para>
                    /// </summary>
                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public int? End { get; set; }

                }

                /// <summary>
                /// <para>Protocol used by the private access application. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>All</b>: All protocols.</para>
                /// </description></item>
                /// <item><description><para><b>TCP</b></para>
                /// </description></item>
                /// <item><description><para><b>UDP</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>All</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>Status of the private access application. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Enabled</b>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><b>Disabled</b>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Dynamic route ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dr-ca9fddfac7c6****</para>
            /// </summary>
            [NameInMap("DynamicRouteId")]
            [Validation(Required=false)]
            public string DynamicRouteId { get; set; }

        }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE4FB974-11BC-5453-9BE1-1606A73EACA6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
