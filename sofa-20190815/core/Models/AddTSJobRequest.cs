// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddTSJobRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        [NameInMap("CountOfActiveZone")]
        [Validation(Required=false)]
        public long? CountOfActiveZone { get; set; }

        [NameInMap("CountOfClient")]
        [Validation(Required=false)]
        public long? CountOfClient { get; set; }

        [NameInMap("Cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        [NameInMap("CustomParams")]
        [Validation(Required=false)]
        public string CustomParams { get; set; }

        [NameInMap("Des")]
        [Validation(Required=false)]
        public string Des { get; set; }

        [NameInMap("EnableForward")]
        [Validation(Required=false)]
        public bool? EnableForward { get; set; }

        [NameInMap("Exclusive")]
        [Validation(Required=false)]
        public bool? Exclusive { get; set; }

        [NameInMap("FailHandleStrategy")]
        [Validation(Required=false)]
        public string FailHandleStrategy { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GrayRatio")]
        [Validation(Required=false)]
        public long? GrayRatio { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("Handlers")]
        [Validation(Required=false)]
        public string Handlers { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InvokeType")]
        [Validation(Required=false)]
        public string InvokeType { get; set; }

        [NameInMap("JobItemId")]
        [Validation(Required=false)]
        public long? JobItemId { get; set; }

        [NameInMap("JobZone")]
        [Validation(Required=false)]
        public string JobZone { get; set; }

        [NameInMap("MaxExecutingChunks")]
        [Validation(Required=false)]
        public long? MaxExecutingChunks { get; set; }

        [NameInMap("MaxExecutingChunksPerClient")]
        [Validation(Required=false)]
        public long? MaxExecutingChunksPerClient { get; set; }

        [NameInMap("MisfireStrategy")]
        [Validation(Required=false)]
        public string MisfireStrategy { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("PermitsPerSecond")]
        [Validation(Required=false)]
        public long? PermitsPerSecond { get; set; }

        [NameInMap("PreAutoTrigger")]
        [Validation(Required=false)]
        public bool? PreAutoTrigger { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        [NameInMap("RouteStrategy")]
        [Validation(Required=false)]
        public string RouteStrategy { get; set; }

        [NameInMap("SecretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        [NameInMap("ShardingCount")]
        [Validation(Required=false)]
        public long? ShardingCount { get; set; }

        [NameInMap("SleepTime")]
        [Validation(Required=false)]
        public long? SleepTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        [NameInMap("TimeoutStrategy")]
        [Validation(Required=false)]
        public string TimeoutStrategy { get; set; }

        [NameInMap("TimeUnit")]
        [Validation(Required=false)]
        public string TimeUnit { get; set; }

        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        [NameInMap("TolerateProcessFailedCount")]
        [Validation(Required=false)]
        public long? TolerateProcessFailedCount { get; set; }

        [NameInMap("TotalZone")]
        [Validation(Required=false)]
        public long? TotalZone { get; set; }

        [NameInMap("TriggerMode")]
        [Validation(Required=false)]
        public string TriggerMode { get; set; }

        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public string Zones { get; set; }

        [NameInMap("ZoneMode")]
        [Validation(Required=false)]
        public string ZoneMode { get; set; }

    }

}
