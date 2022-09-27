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
                [NameInMap("ComponentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ImageComponentId")]
                [Validation(Required=false)]
                public string ImageComponentId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SystemType")]
                [Validation(Required=false)]
                public string SystemType { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

        }

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
