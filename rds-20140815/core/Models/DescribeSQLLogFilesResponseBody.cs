// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLLogFilesResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSQLLogFilesResponseBodyItems Items { get; set; }
        public class DescribeSQLLogFilesResponseBodyItems : TeaModel {
            [NameInMap("LogFile")]
            [Validation(Required=false)]
            public List<DescribeSQLLogFilesResponseBodyItemsLogFile> LogFile { get; set; }
            public class DescribeSQLLogFilesResponseBodyItemsLogFile : TeaModel {
                [NameInMap("FileID")]
                [Validation(Required=false)]
                public string FileID { get; set; }

                [NameInMap("LogDownloadURL")]
                [Validation(Required=false)]
                public string LogDownloadURL { get; set; }

                [NameInMap("LogEndTime")]
                [Validation(Required=false)]
                public string LogEndTime { get; set; }

                [NameInMap("LogSize")]
                [Validation(Required=false)]
                public string LogSize { get; set; }

                [NameInMap("LogStartTime")]
                [Validation(Required=false)]
                public string LogStartTime { get; set; }

                [NameInMap("LogStatus")]
                [Validation(Required=false)]
                public string LogStatus { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
