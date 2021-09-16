// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeOssDownloadsForSQLServerResponseBody : TeaModel {
        [NameInMap("MigrateIaskId")]
        [Validation(Required=false)]
        public string MigrateIaskId { get; set; }

        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeOssDownloadsForSQLServerResponseBodyItems Items { get; set; }
        public class DescribeOssDownloadsForSQLServerResponseBodyItems : TeaModel {
            [NameInMap("OssDownload")]
            [Validation(Required=false)]
            public List<DescribeOssDownloadsForSQLServerResponseBodyItemsOssDownload> OssDownload { get; set; }
            public class DescribeOssDownloadsForSQLServerResponseBodyItemsOssDownload : TeaModel {
                public string Status { get; set; }
                public string CreateTime { get; set; }
                public string IsAvail { get; set; }
                public string FileName { get; set; }
                public string BakType { get; set; }
                public string Desc { get; set; }
                public string FileSize { get; set; }
            }
        };

    }

}
