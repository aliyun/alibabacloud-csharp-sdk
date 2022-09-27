// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelinesResponseBody : TeaModel {
        [NameInMap("ImagePipeline")]
        [Validation(Required=false)]
        public DescribeImagePipelinesResponseBodyImagePipeline ImagePipeline { get; set; }
        public class DescribeImagePipelinesResponseBodyImagePipeline : TeaModel {
            [NameInMap("ImagePipelineSet")]
            [Validation(Required=false)]
            public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSet> ImagePipelineSet { get; set; }
            public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSet : TeaModel {
                [NameInMap("AddAccounts")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAddAccounts AddAccounts { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAddAccounts : TeaModel {
                    [NameInMap("AddAccount")]
                    [Validation(Required=false)]
                    public List<string> AddAccount { get; set; }

                }

                [NameInMap("BaseImage")]
                [Validation(Required=false)]
                public string BaseImage { get; set; }

                [NameInMap("BaseImageType")]
                [Validation(Required=false)]
                public string BaseImageType { get; set; }

                [NameInMap("BuildContent")]
                [Validation(Required=false)]
                public string BuildContent { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DeleteInstanceOnFailure")]
                [Validation(Required=false)]
                public bool? DeleteInstanceOnFailure { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                [NameInMap("ImagePipelineId")]
                [Validation(Required=false)]
                public string ImagePipelineId { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("InternetMaxBandwidthOut")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthOut { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTags Tags { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTagsTag> Tag { get; set; }
                    public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("ToRegionIds")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetToRegionIds ToRegionIds { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetToRegionIds : TeaModel {
                    [NameInMap("ToRegionId")]
                    [Validation(Required=false)]
                    public List<string> ToRegionId { get; set; }

                }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

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
