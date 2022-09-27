// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelineExecutionsResponseBody : TeaModel {
        [NameInMap("ImagePipelineExecution")]
        [Validation(Required=false)]
        public DescribeImagePipelineExecutionsResponseBodyImagePipelineExecution ImagePipelineExecution { get; set; }
        public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecution : TeaModel {
            [NameInMap("ImagePipelineExecutionSet")]
            [Validation(Required=false)]
            public List<DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSet> ImagePipelineExecutionSet { get; set; }
            public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSet : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("ExecutionId")]
                [Validation(Required=false)]
                public string ExecutionId { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("ImagePipelineId")]
                [Validation(Required=false)]
                public string ImagePipelineId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTags Tags { get; set; }
                public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTagsTag> Tag { get; set; }
                    public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTagsTag : TeaModel {
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
