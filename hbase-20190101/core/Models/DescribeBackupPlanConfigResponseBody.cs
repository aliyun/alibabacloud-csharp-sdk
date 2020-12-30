// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeBackupPlanConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FullBackupCycle")]
        [Validation(Required=false)]
        public int? FullBackupCycle { get; set; }

        [NameInMap("NextFullBackupDate")]
        [Validation(Required=false)]
        public string NextFullBackupDate { get; set; }

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public DescribeBackupPlanConfigResponseBodyTables Tables { get; set; }
        public class DescribeBackupPlanConfigResponseBodyTables : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<string> Table { get; set; }
        };

        [NameInMap("MinHFileBackupCount")]
        [Validation(Required=false)]
        public int? MinHFileBackupCount { get; set; }

    }

}
