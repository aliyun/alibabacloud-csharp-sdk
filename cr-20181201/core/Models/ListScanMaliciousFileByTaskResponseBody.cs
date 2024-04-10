// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListScanMaliciousFileByTaskResponseBody : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScanMaliciousFiles")]
        [Validation(Required=false)]
        public List<ListScanMaliciousFileByTaskResponseBodyScanMaliciousFiles> ScanMaliciousFiles { get; set; }
        public class ListScanMaliciousFileByTaskResponseBodyScanMaliciousFiles : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("MaliciousMd5")]
            [Validation(Required=false)]
            public string MaliciousMd5 { get; set; }

            [NameInMap("MaliciousName")]
            [Validation(Required=false)]
            public string MaliciousName { get; set; }

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
