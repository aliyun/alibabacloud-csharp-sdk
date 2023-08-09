// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelineExecutionsRequest : TeaModel {
        /// <summary>
        /// The ID of the image creation task.
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
        /// The maximum number of entries per page. Valid values: 1 to 500.
        /// 
        /// Default value: 50.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of `NextToken`.
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
        /// The region ID. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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
        /// The status of the image creation task. You can specify multiple values. Separate the values with commas (,). Example: `BUILDING,DISTRIBUTING`. Valid values:
        /// 
        /// *   BUILDING
        /// *   DISTRIBUTING
        /// *   RELEASING
        /// *   SUCCESS
        /// *   FAILED
        /// *   CANCELLING
        /// *   CANCELLED
        /// 
        /// > If you want to query the image creation tasks in all states, specify all values.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// > This parameter is not publicly available.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeImagePipelineExecutionsRequestTag> Tag { get; set; }
        public class DescribeImagePipelineExecutionsRequestTag : TeaModel {
            /// <summary>
            /// > This parameter is not publicly available.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// > This parameter is not publicly available.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
