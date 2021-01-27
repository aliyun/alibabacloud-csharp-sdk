// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentStatusesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NodeStatusList")]
        [Validation(Required=false)]
        public DescribeMonitoringAgentStatusesResponseBodyNodeStatusList NodeStatusList { get; set; }
        public class DescribeMonitoringAgentStatusesResponseBodyNodeStatusList : TeaModel {
            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public List<DescribeMonitoringAgentStatusesResponseBodyNodeStatusListNodeStatus> NodeStatus { get; set; }
            public class DescribeMonitoringAgentStatusesResponseBodyNodeStatusListNodeStatus : TeaModel {
                public string Status { get; set; }
                public bool? AutoInstall { get; set; }
                public string InstanceId { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
