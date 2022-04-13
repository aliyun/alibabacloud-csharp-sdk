// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageComponentsResponseBody : TeaModel {
        [NameInMap("ImageComponent")]
        [Validation(Required=false)]
        public DescribeImageComponentsResponseBodyImageComponent ImageComponent { get; set; }
        public class DescribeImageComponentsResponseBodyImageComponent : TeaModel {
            [NameInMap("ImageComponentSet")]
            [Validation(Required=false)]
            public List<DescribeImageComponentsResponseBodyImageComponentImageComponentSet> ImageComponentSet { get; set; }
            public class DescribeImageComponentsResponseBodyImageComponentImageComponentSet : TeaModel {
                public string ComponentType { get; set; }
                public string Content { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public string ImageComponentId { get; set; }
                public string Name { get; set; }
                public string Owner { get; set; }
                public string ResourceGroupId { get; set; }
                public string SystemType { get; set; }
                public DescribeImageComponentsResponseBodyImageComponentImageComponentSetTags Tags { get; set; }
                public class DescribeImageComponentsResponseBodyImageComponentImageComponentSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImageComponentsResponseBodyImageComponentImageComponentSetTagsTag> Tag { get; set; }
                    public class DescribeImageComponentsResponseBodyImageComponentImageComponentSetTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }
            }
        };

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
