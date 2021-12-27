// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventExportInfoResponseBody : TeaModel {
        [NameInMap("ExportStatus")]
        [Validation(Required=false)]
        public string ExportStatus { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        [NameInMap("Link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        [NameInMap("Properties")]
        [Validation(Required=false)]
        public string Properties { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
