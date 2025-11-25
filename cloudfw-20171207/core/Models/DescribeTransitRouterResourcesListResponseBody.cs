// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTransitRouterResourcesListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>A61A2516-0A22-5B3F-986B-3D4BF2A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TransitRouterAttachedResources")]
        [Validation(Required=false)]
        public List<DescribeTransitRouterResourcesListResponseBodyTransitRouterAttachedResources> TransitRouterAttachedResources { get; set; }
        public class DescribeTransitRouterResourcesListResponseBodyTransitRouterAttachedResources : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>eas-r-8k1a6jjofkp0cq****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
