// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoTagScanSummaryResponseBody : TeaModel {
        /// <summary>
        /// The number of medium-severity vulnerabilities.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The number of low-severity vulnerabilities.
        /// </summary>
        [NameInMap("HighSeverity")]
        [Validation(Required=false)]
        public int? HighSeverity { get; set; }

        /// <summary>
        /// The number of high-severity vulnerabilities.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("LowSeverity")]
        [Validation(Required=false)]
        public int? LowSeverity { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   `true`: The request is successful.
        /// *   `false`: The request fails.
        /// </summary>
        [NameInMap("MediumSeverity")]
        [Validation(Required=false)]
        public int? MediumSeverity { get; set; }

        /// <summary>
        /// The total number of vulnerabilities detected on images.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("TotalSeverity")]
        [Validation(Required=false)]
        public int? TotalSeverity { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("UnknownSeverity")]
        [Validation(Required=false)]
        public int? UnknownSeverity { get; set; }

    }

}
