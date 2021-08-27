// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelineExecutionsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("ImagePipelineExecution")]
        [Validation(Required=false)]
        public DescribeImagePipelineExecutionsResponseBodyImagePipelineExecution ImagePipelineExecution { get; set; }
        public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecution : TeaModel {
            [NameInMap("ImagePipelineExecutionSet")]
            [Validation(Required=false)]
            public List<DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSet> ImagePipelineExecutionSet { get; set; }
            public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSet : TeaModel {
                public string CreationTime { get; set; }
                public string ImagePipelineId { get; set; }
                public string Status { get; set; }
                public string ModifiedTime { get; set; }
                public string ResourceGroupId { get; set; }
                public string Message { get; set; }
                public string ImageId { get; set; }
                public string ExecutionId { get; set; }
                public DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTags Tags { get; set; }
                public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTagsTag> Tag { get; set; }
                    public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTagsTag : TeaModel {
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                    }

                }
            }
        };

    }

}
