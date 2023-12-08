// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeJobResourceUsageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeJobResourceUsageResponseBodyData Data { get; set; }
        public class DescribeJobResourceUsageResponseBodyData : TeaModel {
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("JobAcuUsage")]
            [Validation(Required=false)]
            public List<DescribeJobResourceUsageResponseBodyDataJobAcuUsage> JobAcuUsage { get; set; }
            public class DescribeJobResourceUsageResponseBodyDataJobAcuUsage : TeaModel {
                [NameInMap("AcuUsageDetail")]
                [Validation(Required=false)]
                public DescribeJobResourceUsageResponseBodyDataJobAcuUsageAcuUsageDetail AcuUsageDetail { get; set; }
                public class DescribeJobResourceUsageResponseBodyDataJobAcuUsageAcuUsageDetail : TeaModel {
                    [NameInMap("ElasticAcuNumber")]
                    [Validation(Required=false)]
                    public float? ElasticAcuNumber { get; set; }

                    [NameInMap("ReservedAcuNumber")]
                    [Validation(Required=false)]
                    public float? ReservedAcuNumber { get; set; }

                    [NameInMap("TotalAcuNumber")]
                    [Validation(Required=false)]
                    public float? TotalAcuNumber { get; set; }

                }

                [NameInMap("JobEndTime")]
                [Validation(Required=false)]
                public string JobEndTime { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("JobStartTime")]
                [Validation(Required=false)]
                public string JobStartTime { get; set; }

                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

            }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
