// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class BatchGetResourceConfigurationsRequest : TeaModel {
        /// <summary>
        /// <para>The list of resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<BatchGetResourceConfigurationsRequestResources> Resources { get; set; }
        public class BatchGetResourceConfigurationsRequestResources : TeaModel {
            /// <summary>
            /// <para>The region ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bp1kyg72m****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// <para>For a list of resource types supported by Resource Center, see <a href="https://help.aliyun.com/document_detail/477798.html">Alibaba Cloud services and resource types that are supported by Resource Center</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::VPC::RouteTable</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
