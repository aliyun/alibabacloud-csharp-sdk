// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageComponentsResponseBody : TeaModel {
        /// <summary>
        /// Details about the image components.
        /// </summary>
        [NameInMap("ImageComponent")]
        [Validation(Required=false)]
        public DescribeImageComponentsResponseBodyImageComponent ImageComponent { get; set; }
        public class DescribeImageComponentsResponseBodyImageComponent : TeaModel {
            [NameInMap("ImageComponentSet")]
            [Validation(Required=false)]
            public List<DescribeImageComponentsResponseBodyImageComponentImageComponentSet> ImageComponentSet { get; set; }
            public class DescribeImageComponentsResponseBodyImageComponentImageComponentSet : TeaModel {
                /// <summary>
                /// The type of the image component.
                /// </summary>
                [NameInMap("ComponentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                /// <summary>
                /// The content of the image component.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The time when the image component was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the image component.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the image component.
                /// </summary>
                [NameInMap("ImageComponentId")]
                [Validation(Required=false)]
                public string ImageComponentId { get; set; }

                /// <summary>
                /// The name of the image component.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The type of the image component. Valid values:
                /// 
                /// *   SELF: the custom component that you created.
                /// *   ALIYUN: the system component provided by Alibaba Cloud.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The ID of the resource group to which the image component belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The type of the operating system supported by the image component.
                /// </summary>
                [NameInMap("SystemType")]
                [Validation(Required=false)]
                public string SystemType { get; set; }

                /// <summary>
                /// The tags of the image component.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeImageComponentsResponseBodyImageComponentImageComponentSetTags Tags { get; set; }
                public class DescribeImageComponentsResponseBodyImageComponentImageComponentSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImageComponentsResponseBodyImageComponentImageComponentSetTagsTag> Tag { get; set; }
                    public class DescribeImageComponentsResponseBodyImageComponentImageComponentSetTagsTag : TeaModel {
                        /// <summary>
                        /// The key of the tag.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The value of the tag.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. For information about how to use the returned value, see the "Usage notes" section of this topic.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of image components returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
