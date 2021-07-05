// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeOssDownloadsResponseBody : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MigrateTaskId")]
        [Validation(Required=false)]
        public string MigrateTaskId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeOssDownloadsResponseBodyItems Items { get; set; }
        public class DescribeOssDownloadsResponseBodyItems : TeaModel {
            [NameInMap("OssDownload")]
            [Validation(Required=false)]
            public List<DescribeOssDownloadsResponseBodyItemsOssDownload> OssDownload { get; set; }
            public class DescribeOssDownloadsResponseBodyItemsOssDownload : TeaModel {
                public string EndTime { get; set; }
                public string Status { get; set; }
                public string Description { get; set; }
                public string CreateTime { get; set; }
                public string BackupMode { get; set; }
                public string IsAvailable { get; set; }
                public string FileName { get; set; }
                public string FileSize { get; set; }
            }
        };

    }

}
