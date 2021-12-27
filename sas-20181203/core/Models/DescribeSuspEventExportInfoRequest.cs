// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventExportInfoRequest : TeaModel {
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public int? ExportId { get; set; }

        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
