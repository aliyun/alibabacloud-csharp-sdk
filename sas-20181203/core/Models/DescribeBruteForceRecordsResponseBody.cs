// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBruteForceRecordsResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the IP addresses.
        /// </summary>
        [NameInMap("MachineList")]
        [Validation(Required=false)]
        public List<DescribeBruteForceRecordsResponseBodyMachineList> MachineList { get; set; }
        public class DescribeBruteForceRecordsResponseBodyMachineList : TeaModel {
            /// <summary>
            /// The timestamp when the block action on the IP address becomes invalid.
            /// </summary>
            [NameInMap("BlockExpireDate")]
            [Validation(Required=false)]
            public long? BlockExpireDate { get; set; }

            /// <summary>
            /// The blocked IP address.
            /// </summary>
            [NameInMap("BlockIp")]
            [Validation(Required=false)]
            public string BlockIp { get; set; }

            /// <summary>
            /// The error code returned when the defense rule fails to block the IP address.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The ID of the primary key in the table of records on the blocked IP address.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The port that is attacked.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The name of the defense rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The type of the defense rule. Valid values:
            /// 
            /// *   **userRule**: custom rule
            /// *   **blinkRule**: system rule
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The status of the defense rule. Valid values:
            /// 
            /// *   **0**: invalid
            /// *   **1**: enabled
            /// *   **2**: failed
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The UUID of the server on which access from the IP address is blocked.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeBruteForceRecordsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeBruteForceRecordsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **20**.
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
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
