// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLLogFilesResponseBody : TeaModel {
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

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSQLLogFilesResponseBodyItems Items { get; set; }
        public class DescribeSQLLogFilesResponseBodyItems : TeaModel {
            [NameInMap("LogFile")]
            [Validation(Required=false)]
            public List<DescribeSQLLogFilesResponseBodyItemsLogFile> LogFile { get; set; }
            public class DescribeSQLLogFilesResponseBodyItemsLogFile : TeaModel {
                public string FileID { get; set; }
                public string LogStatus { get; set; }
                public string LogDownloadURL { get; set; }
                public string LogSize { get; set; }
                public string LogStartTime { get; set; }
                public string LogEndTime { get; set; }
            }
        };

    }

}
