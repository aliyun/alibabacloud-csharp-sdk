// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListNodeGroupsRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The number of maximum number of records to obtain at a time. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Marks the current position where reading starts. If you set this value to null, you can start from the beginning.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The IDs of node groups. Valid values of the number of array elements N: 1 to 100.
        /// </summary>
        [NameInMap("NodeGroupIds")]
        [Validation(Required=false)]
        public List<string> NodeGroupIds { get; set; }

        /// <summary>
        /// The list of node group names. Valid values of the number of array elements N: 1 to 100.
        /// </summary>
        [NameInMap("NodeGroupNames")]
        [Validation(Required=false)]
        public List<string> NodeGroupNames { get; set; }

        /// <summary>
        /// The status of the node group. Valid values of the number of array elements N: 1 to 100.
        /// </summary>
        [NameInMap("NodeGroupStates")]
        [Validation(Required=false)]
        public List<string> NodeGroupStates { get; set; }

        /// <summary>
        /// The list of node group types. Valid values of the number of array elements N: 1 to 100.
        /// </summary>
        [NameInMap("NodeGroupTypes")]
        [Validation(Required=false)]
        public List<string> NodeGroupTypes { get; set; }

        /// <summary>
        /// The ID of the region in which you want to create the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
