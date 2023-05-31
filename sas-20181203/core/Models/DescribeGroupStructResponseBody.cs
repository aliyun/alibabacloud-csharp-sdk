// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupStructResponseBody : TeaModel {
        /// <summary>
        /// The parent node of the group.
        /// </summary>
        [NameInMap("GroupFather")]
        [Validation(Required=false)]
        public int? GroupFather { get; set; }

        /// <summary>
        /// The type of the server group. Valid values:
        /// 
        /// *   **0**: the default group
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
        public long? GroupId { get; set; }

        /// <summary>
        /// The sequence number.
        /// </summary>
        [NameInMap("GroupIndex")]
        [Validation(Required=false)]
        public int? GroupIndex { get; set; }

        /// <summary>
        /// The level of the application group.
        /// </summary>
        [NameInMap("GroupLevel")]
        [Validation(Required=false)]
        public int? GroupLevel { get; set; }

        /// <summary>
        /// The name of the server group.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// An array that consists of child groups.
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// The number of servers in the group.
        /// </summary>
        [NameInMap("MachineNum")]
        [Validation(Required=false)]
        public int? MachineNum { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
