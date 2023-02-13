// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelineExecutionsRequest : TeaModel {
        /// <summary>
        /// The ID of the image build task.
        /// </summary>
        [NameInMap("ExecutionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// The ID of the image template.
        /// </summary>
        [NameInMap("ImagePipelineId")]
        [Validation(Required=false)]
        public string ImagePipelineId { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page. Valid values: 1 to 500.
        /// 
        /// Default value: 50.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The query token. Set the value to the `NextToken` value that was returned when you last called the DescribeImagePipelineExecutions operation. Leave this parameter empty when you call this operation for the first time.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the image build task. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The status of the image build task. You can specify multiple values at the same time. Separate the values with commas (,). Example format: `BUILDING,DISTRIBUTING`. Valid values: 
        /// 
        /// - BUILDING: The image is being built.
        /// - DISTRIBUTING: The image is being distributed.
        /// - RELEASING: The image is being recycled.
        /// - SUCCESS: The image is built.
        /// - FAILED: The image fails to be built.
        /// - CANCELLING: The image build task is being canceled.
        /// - CANCELLED: The image build task is canceled.
        /// 
        /// >  You cannot query the image build tasks in all status by leaving this parameter empty.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// > This parameter is deprecated.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeImagePipelineExecutionsRequestTag> Tag { get; set; }
        public class DescribeImagePipelineExecutionsRequestTag : TeaModel {
            /// <summary>
            /// > This parameter is deprecated.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// > This parameter is deprecated.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
