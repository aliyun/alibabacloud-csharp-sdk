// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWarningExportInfoResponseBody : TeaModel {
        [NameInMap("CurrentCount")]
        [Validation(Required=false)]
        public int? CurrentCount { get; set; }

        [NameInMap("ExportStatus")]
        [Validation(Required=false)]
        public string ExportStatus { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Queries the progress of a export task for a baseline check result.
        /// </summary>
        [NameInMap("Link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// DescribeWarningExportInfo
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
