// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAgentlessRiskUuidResponseBody : TeaModel {
        /// <summary>
        /// The information about the hosts.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListAgentlessRiskUuidResponseBodyList> List { get; set; }
        public class ListAgentlessRiskUuidResponseBodyList : TeaModel {
            /// <summary>
            /// The number of baseline risks.
            /// </summary>
            [NameInMap("BaselineCount")]
            [Validation(Required=false)]
            public int? BaselineCount { get; set; }

            /// <summary>
            /// The instance ID of the asset.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The instance name of the asset.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the server.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The number of malicious samples.
            /// </summary>
            [NameInMap("MaliciousCount")]
            [Validation(Required=false)]
            public int? MaliciousCount { get; set; }

            /// <summary>
            /// The timestamp of the detection. Unit: milliseconds.
            /// </summary>
            [NameInMap("ScanTime")]
            [Validation(Required=false)]
            public long? ScanTime { get; set; }

            /// <summary>
            /// The ID of the asset that is detected.
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// The name of the asset that is detected.
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// The number of detected vulnerabilities.
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListAgentlessRiskUuidResponseBodyPageInfo PageInfo { get; set; }
        public class ListAgentlessRiskUuidResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
