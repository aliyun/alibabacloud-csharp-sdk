// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelinesResponseBody : TeaModel {
        /// <summary>
        /// Details about the image templates.
        /// </summary>
        [NameInMap("ImagePipeline")]
        [Validation(Required=false)]
        public DescribeImagePipelinesResponseBodyImagePipeline ImagePipeline { get; set; }
        public class DescribeImagePipelinesResponseBodyImagePipeline : TeaModel {
            [NameInMap("ImagePipelineSet")]
            [Validation(Required=false)]
            public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSet> ImagePipelineSet { get; set; }
            public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSet : TeaModel {
                /// <summary>
                /// The IDs of Alibaba Cloud accounts to which to share the image that will be created based on the image template.
                /// </summary>
                [NameInMap("AddAccounts")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAddAccounts AddAccounts { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAddAccounts : TeaModel {
                    [NameInMap("AddAccount")]
                    [Validation(Required=false)]
                    public List<string> AddAccount { get; set; }

                }

                /// <summary>
                /// The source image.
                /// 
                /// *   When `BaseImageType` is set to IMAGE, the value of this parameter is the ID of a custom image.
                /// *   When `BaseImageType` is set to IMAGE_FAMILY, the value of this parameter is the name of an image family.
                /// </summary>
                [NameInMap("BaseImage")]
                [Validation(Required=false)]
                public string BaseImage { get; set; }

                /// <summary>
                /// The type of the source image. Valid values:
                /// 
                /// *   IMAGE: custom image
                /// *   IMAGE_FAMILY: image family
                /// </summary>
                [NameInMap("BaseImageType")]
                [Validation(Required=false)]
                public string BaseImageType { get; set; }

                /// <summary>
                /// The content of the image template.
                /// </summary>
                [NameInMap("BuildContent")]
                [Validation(Required=false)]
                public string BuildContent { get; set; }

                /// <summary>
                /// The time when the image template was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// Indicates whether to release the intermediate instance when the image fails to be created.
                /// </summary>
                [NameInMap("DeleteInstanceOnFailure")]
                [Validation(Required=false)]
                public bool? DeleteInstanceOnFailure { get; set; }

                /// <summary>
                /// The description of the image template.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name prefix of the image to be created based on the image template.
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// The ID of the image template.
                /// </summary>
                [NameInMap("ImagePipelineId")]
                [Validation(Required=false)]
                public string ImagePipelineId { get; set; }

                /// <summary>
                /// The instance type.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The size of the outbound public bandwidth for the intermediate instance. Unit: Mbit/s.
                /// </summary>
                [NameInMap("InternetMaxBandwidthOut")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthOut { get; set; }

                /// <summary>
                /// The name of the image template.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The system disk size of the intermediate instance. Unit: GiB
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

                /// <summary>
                /// The tags of the image template.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTags Tags { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTagsTag> Tag { get; set; }
                    public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTagsTag : TeaModel {
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

                /// <summary>
                /// The IDs of regions to which to distribute the image that will be created based on the image template.
                /// </summary>
                [NameInMap("ToRegionIds")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetToRegionIds ToRegionIds { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetToRegionIds : TeaModel {
                    [NameInMap("ToRegionId")]
                    [Validation(Required=false)]
                    public List<string> ToRegionId { get; set; }

                }

                /// <summary>
                /// The ID of the vSwitch in the virtual private cloud (VPC).
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

        }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. For information about how to use the return value, see the "Usage notes" section of this topic.
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
        /// The total number of image templates returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
