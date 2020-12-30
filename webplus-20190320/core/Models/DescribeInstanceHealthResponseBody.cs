// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeInstanceHealthResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceHealth")]
        [Validation(Required=false)]
        public DescribeInstanceHealthResponseBodyInstanceHealth InstanceHealth { get; set; }
        public class DescribeInstanceHealthResponseBodyInstanceHealth : TeaModel {
            [NameInMap("AppStatus")]
            [Validation(Required=false)]
            public string AppStatus { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("DisconnectedTime")]
            [Validation(Required=false)]
            public long? DisconnectedTime { get; set; }
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public string AgentStatus { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
