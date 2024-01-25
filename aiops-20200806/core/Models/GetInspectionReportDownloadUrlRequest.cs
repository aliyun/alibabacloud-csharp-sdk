// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class GetInspectionReportDownloadUrlRequest : TeaModel {
        [NameInMap("DownloadReportListJson")]
        [Validation(Required=false)]
        public string DownloadReportListJson { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

    }

}
