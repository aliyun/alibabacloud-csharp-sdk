// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DescribeAppMonitorMetricRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("DeployOrderId")]
        [Validation(Required=false)]
        public string DeployOrderId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public long? EnvId { get; set; }

        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        [NameInMap("PodName")]
        [Validation(Required=false)]
        public string PodName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
