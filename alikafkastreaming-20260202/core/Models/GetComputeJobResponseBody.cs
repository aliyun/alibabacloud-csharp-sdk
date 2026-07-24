// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaStreaming20260202.Models
{
    public class GetComputeJobResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetComputeJobResponseBodyData Data { get; set; }
        public class GetComputeJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CuLimit")]
            [Validation(Required=false)]
            public double? CuLimit { get; set; }

            [NameInMap("CuReserved")]
            [Validation(Required=false)]
            public double? CuReserved { get; set; }

            [NameInMap("CuUsed")]
            [Validation(Required=false)]
            public double? CuUsed { get; set; }

            [NameInMap("DebugMode")]
            [Validation(Required=false)]
            public int? DebugMode { get; set; }

            [NameInMap("DeployedSql")]
            [Validation(Required=false)]
            public string DeployedSql { get; set; }

            [NameInMap("DraftSql")]
            [Validation(Required=false)]
            public string DraftSql { get; set; }

            [NameInMap("HistoryInfos")]
            [Validation(Required=false)]
            public string HistoryInfos { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("JobConfig")]
            [Validation(Required=false)]
            public string JobConfig { get; set; }

            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UpgradeMode")]
            [Validation(Required=false)]
            public string UpgradeMode { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
