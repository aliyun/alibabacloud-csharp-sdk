// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeTagsResponseBody : TeaModel {
        /// <summary>
        /// The number of the returned page. Minimum value: 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Default value: 50. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// A list of tags.
        /// </summary>
        [NameInMap("TagSets")]
        [Validation(Required=false)]
        public DescribeTagsResponseBodyTagSets TagSets { get; set; }
        public class DescribeTagsResponseBodyTagSets : TeaModel {
            [NameInMap("TagSet")]
            [Validation(Required=false)]
            public List<DescribeTagsResponseBodyTagSetsTagSet> TagSet { get; set; }
            public class DescribeTagsResponseBodyTagSetsTagSet : TeaModel {
                /// <summary>
                /// The number of instances to which the tag is added.
                /// </summary>
                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public int? InstanceCount { get; set; }

                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// The number of instances returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
