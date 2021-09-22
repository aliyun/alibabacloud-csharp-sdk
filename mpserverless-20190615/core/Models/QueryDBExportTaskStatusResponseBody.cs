// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class QueryDBExportTaskStatusResponseBody : TeaModel {
        [NameInMap("ExportedCount")]
        [Validation(Required=false)]
        public string ExportedCount { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        [NameInMap("DetailMessage")]
        [Validation(Required=false)]
        public string DetailMessage { get; set; }

    }

}
