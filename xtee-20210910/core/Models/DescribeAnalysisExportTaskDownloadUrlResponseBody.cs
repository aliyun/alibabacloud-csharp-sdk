// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAnalysisExportTaskDownloadUrlResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeAnalysisExportTaskDownloadUrlResponseBodyResultObject ResultObject { get; set; }
        public class DescribeAnalysisExportTaskDownloadUrlResponseBodyResultObject : TeaModel {
            [NameInMap("downloadFileUrl")]
            [Validation(Required=false)]
            public string DownloadFileUrl { get; set; }

            [NameInMap("executeTime")]
            [Validation(Required=false)]
            public long? ExecuteTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
