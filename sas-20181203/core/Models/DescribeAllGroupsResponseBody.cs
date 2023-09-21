// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAllGroupsResponseBody : TeaModel {
        /// <summary>
        /// The total number of server groups.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The grouping information about the servers.
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<DescribeAllGroupsResponseBodyGroups> Groups { get; set; }
        public class DescribeAllGroupsResponseBodyGroups : TeaModel {
            /// <summary>
            /// The type of the server group. Valid values:
            /// 
            /// *   **0**: default group
            /// *   **1**: other groups
            /// </summary>
            [NameInMap("GroupFlag")]
            [Validation(Required=false)]
            public int? GroupFlag { get; set; }

            /// <summary>
            /// The ID of the server group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            /// <summary>
            /// The name of the server group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
