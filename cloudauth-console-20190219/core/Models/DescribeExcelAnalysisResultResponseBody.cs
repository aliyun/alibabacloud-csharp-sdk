// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_console20190219.Models
{
    public class DescribeExcelAnalysisResultResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ExcelResult")]
        [Validation(Required=false)]
        public DescribeExcelAnalysisResultResponseBodyExcelResult ExcelResult { get; set; }
        public class DescribeExcelAnalysisResultResponseBodyExcelResult : TeaModel {
            [NameInMap("InsertCount")]
            [Validation(Required=false)]
            public int? InsertCount { get; set; }
            [NameInMap("UpdateCount")]
            [Validation(Required=false)]
            public int? UpdateCount { get; set; }
            [NameInMap("ErrorCount")]
            [Validation(Required=false)]
            public int? ErrorCount { get; set; }
            [NameInMap("ErrorLine")]
            [Validation(Required=false)]
            public List<string> ErrorLine { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
