// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAuditFilesResponseBody : TeaModel {
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeAuditFilesResponseBodyItems Items { get; set; }
        public class DescribeAuditFilesResponseBodyItems : TeaModel {
            [NameInMap("LogFile")]
            [Validation(Required=false)]
            public List<DescribeAuditFilesResponseBodyItemsLogFile> LogFile { get; set; }
            public class DescribeAuditFilesResponseBodyItemsLogFile : TeaModel {
                public int? FileID { get; set; }
                public string LogStartTime { get; set; }
                public long? LogSize { get; set; }
                public string LogDownloadURL { get; set; }
                public string LogEndTime { get; set; }
                public string LogStatus { get; set; }
            }
        };

    }

}
