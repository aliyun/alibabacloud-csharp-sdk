// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniBackupDatabaseResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeUniBackupDatabaseResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeUniBackupDatabaseResponseBodyPageInfo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
        };

        [NameInMap("DatabaseList")]
        [Validation(Required=false)]
        public List<DescribeUniBackupDatabaseResponseBodyDatabaseList> DatabaseList { get; set; }
        public class DescribeUniBackupDatabaseResponseBodyDatabaseList : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("DatabaseType")]
            [Validation(Required=false)]
            public string DatabaseType { get; set; }

            [NameInMap("DatabaseVersion")]
            [Validation(Required=false)]
            public string DatabaseVersion { get; set; }

            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceUuid")]
            [Validation(Required=false)]
            public string InstanceUuid { get; set; }

            [NameInMap("CreatedByProduct")]
            [Validation(Required=false)]
            public string CreatedByProduct { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }

        }

    }

}
