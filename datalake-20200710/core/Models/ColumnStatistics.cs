// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class ColumnStatistics : TeaModel {
        [NameInMap("ColumnStatisticsDesc")]
        [Validation(Required=false)]
        public ColumnStatisticsDesc ColumnStatisticsDesc { get; set; }

        [NameInMap("ColumnStatisticsObjList")]
        [Validation(Required=false)]
        public List<ColumnStatisticsObj> ColumnStatisticsObjList { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("IsStatsCompliant")]
        [Validation(Required=false)]
        public bool? IsStatsCompliant { get; set; }

    }

}
