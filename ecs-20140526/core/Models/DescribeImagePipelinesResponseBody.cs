// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelinesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("ImagePipeline")]
        [Validation(Required=false)]
        public DescribeImagePipelinesResponseBodyImagePipeline ImagePipeline { get; set; }
        public class DescribeImagePipelinesResponseBodyImagePipeline : TeaModel {
            [NameInMap("ImagePipelineSet")]
            [Validation(Required=false)]
            public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSet> ImagePipelineSet { get; set; }
            public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSet : TeaModel {
                public string CreationTime { get; set; }
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTags Tags { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTagsTag> Tag { get; set; }
                    public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTagsTag : TeaModel {
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                    }

                }
                public bool? DeleteInstanceOnFailure { get; set; }
                public int? InternetMaxBandwidthOut { get; set; }
                public string InstanceType { get; set; }
                public string ImagePipelineId { get; set; }
                public int? SystemDiskSize { get; set; }
                public string VSwitchId { get; set; }
                public string Description { get; set; }
                public string BaseImage { get; set; }
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetToRegionIds ToRegionIds { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetToRegionIds : TeaModel {
                    [NameInMap("ToRegionId")]
                    [Validation(Required=false)]
                    public List<string> ToRegionId { get; set; }

                }
                public string ResourceGroupId { get; set; }
                public string ImageName { get; set; }
                public string BaseImageType { get; set; }
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAddAccounts AddAccounts { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAddAccounts : TeaModel {
                    [NameInMap("AddAccount")]
                    [Validation(Required=false)]
                    public List<string> AddAccount { get; set; }

                }
                public string Name { get; set; }
                public string BuildContent { get; set; }
            }
        };

    }

}
