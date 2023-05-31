// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCommonTargetResultListResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the configuration item.
        /// </summary>
        [NameInMap("TargetConfig")]
        [Validation(Required=false)]
        public DescribeCommonTargetResultListResponseBodyTargetConfig TargetConfig { get; set; }
        public class DescribeCommonTargetResultListResponseBodyTargetConfig : TeaModel {
            /// <summary>
            /// The identifier that indicates whether the configuration item is applied to the server. Valid values:
            /// 
            /// *   **add**: applied
            /// *   **del**: not applied
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            /// <summary>
            /// The default identifier.
            /// </summary>
            [NameInMap("TargetDefault")]
            [Validation(Required=false)]
            public string TargetDefault { get; set; }

            /// <summary>
            /// An array that consists of the IDs of the server groups or the UUIDs of the servers.
            /// 
            /// >  If **uuid** is returned for the **TargetType** parameter, **UUIDs** of the servers are returned. If **groupId** is returned for the **TargetType** parameter, IDs of the server groups are returned.
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<string> TargetList { get; set; }

            /// <summary>
            /// The type of the server to which the configuration item is applied. Valid values:
            /// 
            /// *   **uuid**: a server
            /// *   **groupId**: a server group
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

            /// <summary>
            /// The type of the configuration item. Valid values:
            /// 
            /// *   **webshell_timescan**: webshell detection and removal
            /// *   **aliscriptengine**: in-depth detection engine
            /// *   **alidetect**: installation scope of local file detection
            /// *   **alidetect-scan-enable**: detection scope of local file detection
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
