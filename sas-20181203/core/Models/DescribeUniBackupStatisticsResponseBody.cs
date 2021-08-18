// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniBackupStatisticsResponseBody : TeaModel {
        [NameInMap("TotalRestoreTaskCount")]
        [Validation(Required=false)]
        public int? TotalRestoreTaskCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UnprotectedDatabaseCount")]
        [Validation(Required=false)]
        public int? UnprotectedDatabaseCount { get; set; }

        [NameInMap("RestoringTaskCount")]
        [Validation(Required=false)]
        public int? RestoringTaskCount { get; set; }

        [NameInMap("ProtectedDatabaseCount")]
        [Validation(Required=false)]
        public int? ProtectedDatabaseCount { get; set; }

        [NameInMap("TotalRecoverableCount")]
        [Validation(Required=false)]
        public int? TotalRecoverableCount { get; set; }

    }

}
