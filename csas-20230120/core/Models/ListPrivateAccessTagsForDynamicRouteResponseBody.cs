// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessTagsForDynamicRouteResponseBody : TeaModel {
        /// <summary>
        /// <para>The dynamic route list.</para>
        /// </summary>
        [NameInMap("DynamicRoutes")]
        [Validation(Required=false)]
        public List<ListPrivateAccessTagsForDynamicRouteResponseBodyDynamicRoutes> DynamicRoutes { get; set; }
        public class ListPrivateAccessTagsForDynamicRouteResponseBodyDynamicRoutes : TeaModel {
            /// <summary>
            /// <para>The dynamic route ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dr-ca9fddfac7c6****</para>
            /// </summary>
            [NameInMap("DynamicRouteId")]
            [Validation(Required=false)]
            public string DynamicRouteId { get; set; }

            /// <summary>
            /// <para>A collection of private network access tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPrivateAccessTagsForDynamicRouteResponseBodyDynamicRoutesTags> Tags { get; set; }
            public class ListPrivateAccessTagsForDynamicRouteResponseBodyDynamicRoutesTags : TeaModel {
                /// <summary>
                /// <para>The private network access tag creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-23 14:02:56</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The private network access tag description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一条被动态路由引用的内网访问标签</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The private network access tag name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The private network access tag ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-d3f64e8bdd4a****</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <para>The private network access tag type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Default</b>: Default.</para>
                /// </description></item>
                /// <item><description><para><b>Custom</b>: Custom.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("TagType")]
                [Validation(Required=false)]
                public string TagType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B608C6AE-623D-55C4-9454-601B88AE937E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
