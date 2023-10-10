// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodesRequest : TeaModel {
        /// <summary>
        /// The IDs of the nodes that you want to query. Separate multiple node IDs with commas (,).
        /// </summary>
        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// The node pool ID.
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The node state that you want to use to filter nodes. Valid values:
        /// 
        /// *   `all`: query nodes in the following four states.
        /// *   `running`: query nodes in the running state.
        /// *   `removing`: query nodes that are being removed.
        /// *   `initial`: query nodes that are being initialized.
        /// *   `failed`: query nodes that fail to be created.
        /// 
        /// Default value: `all`.
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
