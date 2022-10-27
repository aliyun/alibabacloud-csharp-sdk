// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSQLPlansResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SQLPlans")]
        [Validation(Required=false)]
        public List<DescribeSQLPlansResponseBodySQLPlans> SQLPlans { get; set; }
        public class DescribeSQLPlansResponseBodySQLPlans : TeaModel {
            [NameInMap("AvgExecutionMS")]
            [Validation(Required=false)]
            public float? AvgExecutionMS { get; set; }

            [NameInMap("AvgExecutionTimeMS")]
            [Validation(Required=false)]
            public long? AvgExecutionTimeMS { get; set; }

            [NameInMap("FirstLoadTime")]
            [Validation(Required=false)]
            public long? FirstLoadTime { get; set; }

            [NameInMap("FirstLoadTimeUTCString")]
            [Validation(Required=false)]
            public string FirstLoadTimeUTCString { get; set; }

            [NameInMap("HitCount")]
            [Validation(Required=false)]
            public int? HitCount { get; set; }

            [NameInMap("MergedVersion")]
            [Validation(Required=false)]
            public int? MergedVersion { get; set; }

            [NameInMap("NodeIp")]
            [Validation(Required=false)]
            public string NodeIp { get; set; }

            [NameInMap("OutlineData")]
            [Validation(Required=false)]
            public string OutlineData { get; set; }

            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public long? OutlineId { get; set; }

            [NameInMap("OutlineTime")]
            [Validation(Required=false)]
            public long? OutlineTime { get; set; }

            [NameInMap("OutlineTimeUTCString")]
            [Validation(Required=false)]
            public string OutlineTimeUTCString { get; set; }

            [NameInMap("PlanFull")]
            [Validation(Required=false)]
            public string PlanFull { get; set; }

            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public int? PlanId { get; set; }

            [NameInMap("PlanInfo")]
            [Validation(Required=false)]
            public string PlanInfo { get; set; }

            [NameInMap("PlanUnionHash")]
            [Validation(Required=false)]
            public string PlanUnionHash { get; set; }

            [NameInMap("QuerySQL")]
            [Validation(Required=false)]
            public string QuerySQL { get; set; }

        }

    }

}
