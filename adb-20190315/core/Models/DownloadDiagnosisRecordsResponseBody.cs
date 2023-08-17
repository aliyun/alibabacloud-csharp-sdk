// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DownloadDiagnosisRecordsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the download task.
        /// </summary>
        [NameInMap("DownloadId")]
        [Validation(Required=false)]
        public int? DownloadId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
