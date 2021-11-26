// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeApmResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeApmResponseBodyResult Result { get; set; }
        public class DescribeApmResponseBodyResult : TeaModel {
            [NameInMap("apmServerDomain")]
            [Validation(Required=false)]
            public string ApmServerDomain { get; set; }
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("deployedReplica")]
            [Validation(Required=false)]
            public long? DeployedReplica { get; set; }
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("nodeAmount")]
            [Validation(Required=false)]
            public long? NodeAmount { get; set; }
            [NameInMap("outputES")]
            [Validation(Required=false)]
            public string OutputES { get; set; }
            [NameInMap("outputESUserName")]
            [Validation(Required=false)]
            public string OutputESUserName { get; set; }
            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }
            [NameInMap("resourceSpec")]
            [Validation(Required=false)]
            public string ResourceSpec { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("vsArea")]
            [Validation(Required=false)]
            public string VsArea { get; set; }
            [NameInMap("vswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }
        };

    }

}
