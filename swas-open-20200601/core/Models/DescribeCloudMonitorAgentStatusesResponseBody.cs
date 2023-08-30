// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeCloudMonitorAgentStatusesResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the Cloud Monitor agent was automatically installed on the simple application server. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("InstanceStatusList")]
        [Validation(Required=false)]
        public List<DescribeCloudMonitorAgentStatusesResponseBodyInstanceStatusList> InstanceStatusList { get; set; }
        public class DescribeCloudMonitorAgentStatusesResponseBodyInstanceStatusList : TeaModel {
            [NameInMap("AutoInstall")]
            [Validation(Required=false)]
            public bool? AutoInstall { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
