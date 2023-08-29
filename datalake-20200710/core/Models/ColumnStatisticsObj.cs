// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class ColumnStatisticsObj : TeaModel {
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        [NameInMap("ColumnStatisticsData")]
        [Validation(Required=false)]
        public ColumnStatisticsObjColumnStatisticsData ColumnStatisticsData { get; set; }
        public class ColumnStatisticsObjColumnStatisticsData : TeaModel {
            [NameInMap("StatisticsData")]
            [Validation(Required=false)]
            public string StatisticsData { get; set; }

            [NameInMap("StatisticsType")]
            [Validation(Required=false)]
            public string StatisticsType { get; set; }

        }

        [NameInMap("ColumnType")]
        [Validation(Required=false)]
        public string ColumnType { get; set; }

    }

}
