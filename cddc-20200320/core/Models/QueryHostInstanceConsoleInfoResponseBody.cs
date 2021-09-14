// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class QueryHostInstanceConsoleInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HostInstanceConsoleInfos")]
        [Validation(Required=false)]
        public List<QueryHostInstanceConsoleInfoResponseBodyHostInstanceConsoleInfos> HostInstanceConsoleInfos { get; set; }
        public class QueryHostInstanceConsoleInfoResponseBodyHostInstanceConsoleInfos : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("MaxConnIncreaseRatioValue")]
            [Validation(Required=false)]
            public int? MaxConnIncreaseRatioValue { get; set; }

            [NameInMap("MemSize")]
            [Validation(Required=false)]
            public int? MemSize { get; set; }

            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            [NameInMap("MemoryIncreaseRatioValue")]
            [Validation(Required=false)]
            public int? MemoryIncreaseRatioValue { get; set; }

            [NameInMap("CpuIncreaseRatioValue")]
            [Validation(Required=false)]
            public int? CpuIncreaseRatioValue { get; set; }

            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("LevelName")]
            [Validation(Required=false)]
            public string LevelName { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("DBInstanceDescription")]
            [Validation(Required=false)]
            public string DBInstanceDescription { get; set; }

            [NameInMap("CpuCores")]
            [Validation(Required=false)]
            public int? CpuCores { get; set; }

            [NameInMap("PerfInfo")]
            [Validation(Required=false)]
            public QueryHostInstanceConsoleInfoResponseBodyHostInstanceConsoleInfosPerfInfo PerfInfo { get; set; }
            public class QueryHostInstanceConsoleInfoResponseBodyHostInstanceConsoleInfosPerfInfo : TeaModel {
                [NameInMap("PerfIdbPio")]
                [Validation(Required=false)]
                public float? PerfIdbPio { get; set; }
                [NameInMap("DiskCurr")]
                [Validation(Required=false)]
                public float? DiskCurr { get; set; }
                [NameInMap("MemRatio")]
                [Validation(Required=false)]
                public float? MemRatio { get; set; }
                [NameInMap("CpuRatio")]
                [Validation(Required=false)]
                public float? CpuRatio { get; set; }
            };

        }

    }

}
