// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmSummaryResponseBody : TeaModel {
        /// <summary>
        /// The total number of instances within the current account.
        /// </summary>
        [NameInMap("InstanceTotalCount")]
        [Validation(Required=false)]
        public int? InstanceTotalCount { get; set; }

        /// <summary>
        /// The total number of configured health check tasks.
        /// </summary>
        [NameInMap("MonitorTaskTotalCount")]
        [Validation(Required=false)]
        public int? MonitorTaskTotalCount { get; set; }

        /// <summary>
        /// The quota on the number of health check tasks.
        /// </summary>
        [NameInMap("MonitorTaskTotalQuota")]
        [Validation(Required=false)]
        public int? MonitorTaskTotalQuota { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
