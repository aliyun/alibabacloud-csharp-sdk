// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBinlogFilesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("TotalFileSize")]
        [Validation(Required=false)]
        public long? TotalFileSize { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBinlogFilesResponseBodyItems Items { get; set; }
        public class DescribeBinlogFilesResponseBodyItems : TeaModel {
            [NameInMap("BinLogFile")]
            [Validation(Required=false)]
            public List<DescribeBinlogFilesResponseBodyItemsBinLogFile> BinLogFile { get; set; }
            public class DescribeBinlogFilesResponseBodyItemsBinLogFile : TeaModel {
                public long? FileSize { get; set; }
                public string LogBeginTime { get; set; }
                public string LogEndTime { get; set; }
                public string DownloadLink { get; set; }
                public string IntranetDownloadLink { get; set; }
                public string LinkExpiredTime { get; set; }
                public string Checksum { get; set; }
                public string HostInstanceID { get; set; }
                public string LogFileName { get; set; }
            }
        };

    }

}
