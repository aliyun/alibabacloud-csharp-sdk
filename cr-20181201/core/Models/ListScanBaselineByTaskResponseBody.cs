// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListScanBaselineByTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScanBaselines")]
        [Validation(Required=false)]
        public List<ListScanBaselineByTaskResponseBodyScanBaselines> ScanBaselines { get; set; }
        public class ListScanBaselineByTaskResponseBodyScanBaselines : TeaModel {
            [NameInMap("BaselineClassAlias")]
            [Validation(Required=false)]
            public string BaselineClassAlias { get; set; }

            [NameInMap("BaselineDetailAdvice")]
            [Validation(Required=false)]
            public string BaselineDetailAdvice { get; set; }

            [NameInMap("BaselineDetailDescription")]
            [Validation(Required=false)]
            public string BaselineDetailDescription { get; set; }

            [NameInMap("BaselineDetailPrompt")]
            [Validation(Required=false)]
            public string BaselineDetailPrompt { get; set; }

            [NameInMap("BaselineItemCount")]
            [Validation(Required=false)]
            public int? BaselineItemCount { get; set; }

            [NameInMap("BaselineNameAlias")]
            [Validation(Required=false)]
            public string BaselineNameAlias { get; set; }

            [NameInMap("BaselineNameKey")]
            [Validation(Required=false)]
            public string BaselineNameKey { get; set; }

            [NameInMap("BaselineNameLevel")]
            [Validation(Required=false)]
            public string BaselineNameLevel { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            [NameInMap("HighRiskItemCount")]
            [Validation(Required=false)]
            public int? HighRiskItemCount { get; set; }

            [NameInMap("LowRiskItemCount")]
            [Validation(Required=false)]
            public int? LowRiskItemCount { get; set; }

            [NameInMap("MiddleRiskItemCount")]
            [Validation(Required=false)]
            public int? MiddleRiskItemCount { get; set; }

            [NameInMap("ScanTaskId")]
            [Validation(Required=false)]
            public string ScanTaskId { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
