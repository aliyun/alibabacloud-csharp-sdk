// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTargetResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the server.
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<DescribeTargetResponseBodyTargets> Targets { get; set; }
        public class DescribeTargetResponseBodyTargets : TeaModel {
            /// <summary>
            /// The flag that is added to the server. This parameter can be empty.
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// The UUID of the server or the ID of the server group.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// The type of the object. Valid values:
            /// 
            /// *   **uuid**: a server
            /// *   **groupId**: a server group
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
