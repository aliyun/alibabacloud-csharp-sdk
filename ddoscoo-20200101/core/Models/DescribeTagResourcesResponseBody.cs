// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// The query token that is returned in this call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array consisting of the details of the tags that are added to the Anti-DDoS Pro instance.
        /// </summary>
        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public DescribeTagResourcesResponseBodyTagResources TagResources { get; set; }
        public class DescribeTagResourcesResponseBodyTagResources : TeaModel {
            [NameInMap("TagResource")]
            [Validation(Required=false)]
            public List<DescribeTagResourcesResponseBodyTagResourcesTagResource> TagResource { get; set; }
            public class DescribeTagResourcesResponseBodyTagResourcesTagResource : TeaModel {
                /// <summary>
                /// The ID of the Anti-DDoS Pro instance.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The type of the resource. The value is fixed as **INSTANCE**, which indicates an Anti-DDoS Pro instance.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The key of the tag that is added to the Anti-DDoS Pro instance.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of the tag that is added to the Anti-DDoS Pro instance.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
