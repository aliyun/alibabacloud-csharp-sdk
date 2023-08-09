// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelineExecutionsResponseBody : TeaModel {
        /// <summary>
        /// Details of the image creation task.
        /// </summary>
        [NameInMap("ImagePipelineExecution")]
        [Validation(Required=false)]
        public DescribeImagePipelineExecutionsResponseBodyImagePipelineExecution ImagePipelineExecution { get; set; }
        public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecution : TeaModel {
            [NameInMap("ImagePipelineExecutionSet")]
            [Validation(Required=false)]
            public List<DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSet> ImagePipelineExecutionSet { get; set; }
            public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSet : TeaModel {
                /// <summary>
                /// The time when the image creation task was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The ID of the image creation task.
                /// </summary>
                [NameInMap("ExecutionId")]
                [Validation(Required=false)]
                public string ExecutionId { get; set; }

                /// <summary>
                /// The ID of the image.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The ID of the image template.
                /// </summary>
                [NameInMap("ImagePipelineId")]
                [Validation(Required=false)]
                public string ImagePipelineId { get; set; }

                /// <summary>
                /// The data returned.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The last modification time of the image creation task.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The status of the image creation task. Valid values:
                /// 
                /// *   BUILDING
                /// *   DISTRIBUTING
                /// *   RELEASING
                /// *   SUCCESS
                /// *   FAILED
                /// *   CANCELLING
                /// *   CANCELLED
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// > This parameter is not publicly available.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTags Tags { get; set; }
                public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTagsTag> Tag { get; set; }
                    public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTagsTag : TeaModel {
                        /// <summary>
                        /// > This parameter is not publicly available.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// > This parameter is not publicly available.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The maximum number of entries per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists. For information about how to use the returned value, see the "Usage notes" section in this topic.
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
        /// The total number of returned image components.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
