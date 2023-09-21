// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulListPageResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeVulListPageResponseBodyData> Data { get; set; }
        public class DescribeVulListPageResponseBodyData : TeaModel {
            /// <summary>
            /// The common vulnerabilities and exposures (CVE) ID of the vulnerability.
            /// </summary>
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            /// <summary>
            /// The extended field for Server Guard.
            /// </summary>
            [NameInMap("ExtAegis")]
            [Validation(Required=false)]
            public string ExtAegis { get; set; }

            /// <summary>
            /// The primary key ID of the database.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// Indicates whether the vulnerability was detected based on version comparison. Valid values:
            /// 
            /// *   1: The vulnerability was detected based on version comparison.
            /// *   0: The vulnerability was not detected based on version comparison.
            /// </summary>
            [NameInMap("IsAegis")]
            [Validation(Required=false)]
            public int? IsAegis { get; set; }

            /// <summary>
            /// Indicates whether the vulnerability was detected based on proof of concept (POC) verification. Valid values:
            /// 
            /// *   1: The vulnerability was detected based on POC verification.
            /// *   0: The vulnerability was not detected based on POC verification.
            /// </summary>
            [NameInMap("IsSas")]
            [Validation(Required=false)]
            public int? IsSas { get; set; }

            /// <summary>
            /// The ID of the vulnerability.
            /// </summary>
            [NameInMap("OtherId")]
            [Validation(Required=false)]
            public string OtherId { get; set; }

            /// <summary>
            /// The time when the vulnerability was disclosed.
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// The name of the vulnerability.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
