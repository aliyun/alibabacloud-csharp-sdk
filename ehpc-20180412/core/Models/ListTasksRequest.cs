// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListTasksRequest : TeaModel {
        /// <summary>
        /// Specifies whether to display the response history of the asynchronous API operation. Valid values:
        /// 
        /// *   true: displays the current response and response history of the asynchronous API operation.
        /// *   false: displays only the current response of the asynchronous API operation. If no tasks are running, `[]` is returned.
        /// 
        /// Default value: false
        /// 
        /// >  If you specify the TaskId parameter, the Archived parameter is invalid.
        /// </summary>
        [NameInMap("Archived")]
        [Validation(Required=false)]
        public bool? Archived { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to obtain the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. Valid values: 1 to 999.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 50.
        /// 
        /// Default value: 10
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the task. You can call the following asynchronous API operations to obtain the task ID.
        /// 
        /// *   [CreateCluster](~~87100~~)
        /// *   [StartCluster](~~200345~~)
        /// *   [StopCluster](~~200346~~)
        /// *   [DeleteCluster](~~87110~~)
        /// *   [AddNodes](~~87147~~)
        /// *   [StartNodes](~~87159~~)
        /// *   [ResetNodes](~~87158~~)
        /// *   [StopNodes](~~87160~~)
        /// *   [DeleteNodes](~~87155~~)
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
