// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
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
        /// The IDs of node groups.
        /// </summary>
        [NameInMap("NodeGroupIds")]
        [Validation(Required=false)]
        public List<string> NodeGroupIds { get; set; }

        /// <summary>
        /// An array that consists of information about the ID of the node.
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// The names of the nodes.
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// The status of the node.
        /// </summary>
        [NameInMap("NodeStates")]
        [Validation(Required=false)]
        public List<string> NodeStates { get; set; }

        /// <summary>
        /// The private IP address.
        /// </summary>
        [NameInMap("PrivateIps")]
        [Validation(Required=false)]
        public List<string> PrivateIps { get; set; }

        /// <summary>
        /// The public IP address.
        /// </summary>
        [NameInMap("PublicIps")]
        [Validation(Required=false)]
        public List<string> PublicIps { get; set; }

        /// <summary>
        /// The ID of the region in which you want to create the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The list of tags to be bound.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
