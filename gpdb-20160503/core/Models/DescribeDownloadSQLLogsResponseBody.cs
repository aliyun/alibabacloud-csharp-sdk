// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDownloadSQLLogsResponseBody : TeaModel {
        /// <summary>
        /// The URL that is used to download the file.
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeDownloadSQLLogsResponseBodyRecords> Records { get; set; }
        public class DescribeDownloadSQLLogsResponseBodyRecords : TeaModel {
            [NameInMap("DownloadId")]
            [Validation(Required=false)]
            public long? DownloadId { get; set; }

            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("ExceptionMsg")]
            [Validation(Required=false)]
            public string ExceptionMsg { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
