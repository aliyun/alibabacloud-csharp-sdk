// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoTagScanSummaryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HighSeverity")]
        [Validation(Required=false)]
        public int? HighSeverity { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("LowSeverity")]
        [Validation(Required=false)]
        public int? LowSeverity { get; set; }

        [NameInMap("MediumSeverity")]
        [Validation(Required=false)]
        public int? MediumSeverity { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalSeverity")]
        [Validation(Required=false)]
        public int? TotalSeverity { get; set; }

        [NameInMap("UnknownSeverity")]
        [Validation(Required=false)]
        public int? UnknownSeverity { get; set; }

    }

}
