// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageSensitiveFileListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageSensitiveFileListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageSensitiveFileListResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("LastRowKey")]
            [Validation(Required=false)]
            public string LastRowKey { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SensitiveFileList")]
        [Validation(Required=false)]
        public List<DescribeImageSensitiveFileListResponseBodySensitiveFileList> SensitiveFileList { get; set; }
        public class DescribeImageSensitiveFileListResponseBodySensitiveFileList : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            [NameInMap("SensitiveFileKey")]
            [Validation(Required=false)]
            public string SensitiveFileKey { get; set; }

            [NameInMap("SensitiveFileName")]
            [Validation(Required=false)]
            public string SensitiveFileName { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
