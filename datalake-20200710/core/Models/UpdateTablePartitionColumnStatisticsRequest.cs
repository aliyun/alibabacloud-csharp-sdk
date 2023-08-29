// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class UpdateTablePartitionColumnStatisticsRequest : TeaModel {
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("ColumnStatisticsList")]
        [Validation(Required=false)]
        public List<ColumnStatistics> ColumnStatisticsList { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("IsStatsCompliant")]
        [Validation(Required=false)]
        public bool? IsStatsCompliant { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("ValidWriteIdList")]
        [Validation(Required=false)]
        public string ValidWriteIdList { get; set; }

        [NameInMap("WriteId")]
        [Validation(Required=false)]
        public string WriteId { get; set; }

    }

}
