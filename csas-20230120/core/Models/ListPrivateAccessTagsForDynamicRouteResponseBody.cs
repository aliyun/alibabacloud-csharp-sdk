// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessTagsForDynamicRouteResponseBody : TeaModel {
        [NameInMap("DynamicRoutes")]
        [Validation(Required=false)]
        public List<ListPrivateAccessTagsForDynamicRouteResponseBodyDynamicRoutes> DynamicRoutes { get; set; }
        public class ListPrivateAccessTagsForDynamicRouteResponseBodyDynamicRoutes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dr-ca9fddfac7c6****</para>
            /// </summary>
            [NameInMap("DynamicRouteId")]
            [Validation(Required=false)]
            public string DynamicRouteId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPrivateAccessTagsForDynamicRouteResponseBodyDynamicRoutesTags> Tags { get; set; }
            public class ListPrivateAccessTagsForDynamicRouteResponseBodyDynamicRoutesTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-10-23 14:02:56</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tag_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tag-d3f64e8bdd4a****</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("TagType")]
                [Validation(Required=false)]
                public string TagType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B608C6AE-623D-55C4-9454-601B88AE937E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
