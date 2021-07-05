// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeLogBackupFilesResponseBody : TeaModel {
        [NameInMap("TotalFileSize")]
        [Validation(Required=false)]
        public long? TotalFileSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeLogBackupFilesResponseBodyItems Items { get; set; }
        public class DescribeLogBackupFilesResponseBodyItems : TeaModel {
            [NameInMap("BinLogFile")]
            [Validation(Required=false)]
            public List<DescribeLogBackupFilesResponseBodyItemsBinLogFile> BinLogFile { get; set; }
            public class DescribeLogBackupFilesResponseBodyItemsBinLogFile : TeaModel {
                public string LogBeginTime { get; set; }
                public string IntranetDownloadLink { get; set; }
                public string LinkExpiredTime { get; set; }
                public string DownloadLink { get; set; }
                public string LogEndTime { get; set; }
                public long? FileSize { get; set; }
            }
        };

    }

}
