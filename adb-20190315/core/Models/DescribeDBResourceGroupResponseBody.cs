// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The queried resource group.
        /// </summary>
        [NameInMap("GroupsInfo")]
        [Validation(Required=false)]
        public List<DescribeDBResourceGroupResponseBodyGroupsInfo> GroupsInfo { get; set; }
        public class DescribeDBResourceGroupResponseBodyGroupsInfo : TeaModel {
            /// <summary>
            /// The time when the resource group was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The name of the resource group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The query execution mode. Valid values:
            /// 
            /// *   **interactive**
            /// *   **batch** (default)
            /// 
            /// > For more information, see [Query execution modes](~~189502~~).
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// The database accounts that are associated with the resource group.
            /// </summary>
            [NameInMap("GroupUsers")]
            [Validation(Required=false)]
            public string GroupUsers { get; set; }

            /// <summary>
            /// The number of nodes. Each node provides 16 cores and 64 GB memory.
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            /// <summary>
            /// The time when the resource group was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
