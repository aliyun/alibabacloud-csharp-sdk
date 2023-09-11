// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DownloadSQLLogsRecordsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the download task.
        /// </summary>
        [NameInMap("DownloadId")]
        [Validation(Required=false)]
        public long? DownloadId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
