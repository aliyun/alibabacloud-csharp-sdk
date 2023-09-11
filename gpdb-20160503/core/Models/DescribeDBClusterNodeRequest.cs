// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBClusterNodeRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// > You can call the [DescribeDBInstances](~~86911~~) operation to query details about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The node type. Valid values:
        /// 
        /// *   **master**: coordinator node.
        /// *   **segment**: compute node.
        /// 
        /// > If you do not specify this parameter, the information about all nodes is returned.
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

    }

}
