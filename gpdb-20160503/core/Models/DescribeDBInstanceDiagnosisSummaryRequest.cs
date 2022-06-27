// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceDiagnosisSummaryRequest : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RolePreferd")]
        [Validation(Required=false)]
        public string RolePreferd { get; set; }

        [NameInMap("StartStatus")]
        [Validation(Required=false)]
        public string StartStatus { get; set; }

        [NameInMap("SyncMode")]
        [Validation(Required=false)]
        public string SyncMode { get; set; }

    }

}
