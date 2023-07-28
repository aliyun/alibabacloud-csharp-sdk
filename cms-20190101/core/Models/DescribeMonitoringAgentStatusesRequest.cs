// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentStatusesRequest : TeaModel {
        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("HostAvailabilityTaskId")]
        [Validation(Required=false)]
        public string HostAvailabilityTaskId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeMonitoringAgentStatuses**.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
