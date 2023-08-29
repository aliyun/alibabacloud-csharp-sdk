// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class ColumnStatisticsDesc : TeaModel {
        [NameInMap("LastAnalyzedTime")]
        [Validation(Required=false)]
        public long? LastAnalyzedTime { get; set; }

        [NameInMap("PartitionName")]
        [Validation(Required=false)]
        public string PartitionName { get; set; }

    }

}
