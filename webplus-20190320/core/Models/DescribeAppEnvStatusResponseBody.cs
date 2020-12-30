// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeAppEnvStatusResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EnvStatus")]
        [Validation(Required=false)]
        public DescribeAppEnvStatusResponseBodyEnvStatus EnvStatus { get; set; }
        public class DescribeAppEnvStatusResponseBodyEnvStatus : TeaModel {
            [NameInMap("ChangeBanner")]
            [Validation(Required=false)]
            public string ChangeBanner { get; set; }
            [NameInMap("LatestChangeId")]
            [Validation(Required=false)]
            public string LatestChangeId { get; set; }
            [NameInMap("EnvStatus")]
            [Validation(Required=false)]
            public string EnvStatus { get; set; }
            [NameInMap("EnvName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }
            [NameInMap("InstanceAgentStatus")]
            [Validation(Required=false)]
            public DescribeAppEnvStatusResponseBodyEnvStatusInstanceAgentStatus InstanceAgentStatus { get; set; }
            public class DescribeAppEnvStatusResponseBodyEnvStatusInstanceAgentStatus : TeaModel {
                [NameInMap("ConnectedInstances")]
                [Validation(Required=false)]
                public int? ConnectedInstances { get; set; }

                [NameInMap("DisconnectedInstances")]
                [Validation(Required=false)]
                public int? DisconnectedInstances { get; set; }

            }
            [NameInMap("LastEnvStatus")]
            [Validation(Required=false)]
            public string LastEnvStatus { get; set; }
            [NameInMap("InstanceAppStatus")]
            [Validation(Required=false)]
            public DescribeAppEnvStatusResponseBodyEnvStatusInstanceAppStatus InstanceAppStatus { get; set; }
            public class DescribeAppEnvStatusResponseBodyEnvStatusInstanceAppStatus : TeaModel {
                [NameInMap("HealthyInstances")]
                [Validation(Required=false)]
                public int? HealthyInstances { get; set; }

                [NameInMap("StoppedInstances")]
                [Validation(Required=false)]
                public int? StoppedInstances { get; set; }

                [NameInMap("UnhealthyInstances")]
                [Validation(Required=false)]
                public int? UnhealthyInstances { get; set; }

                [NameInMap("UnknownInstances")]
                [Validation(Required=false)]
                public int? UnknownInstances { get; set; }

            }
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }
            [NameInMap("AbortingChange")]
            [Validation(Required=false)]
            public bool? AbortingChange { get; set; }
            [NameInMap("ApplyingChange")]
            [Validation(Required=false)]
            public bool? ApplyingChange { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
