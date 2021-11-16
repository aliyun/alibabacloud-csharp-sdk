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
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("DeployedReplica")]
            [Validation(Required=false)]
            public long? DeployedReplica { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("NodeAmount")]
            [Validation(Required=false)]
            public long? NodeAmount { get; set; }
            [NameInMap("OutputES")]
            [Validation(Required=false)]
            public string OutputES { get; set; }
            [NameInMap("OutputESUserName")]
            [Validation(Required=false)]
            public string OutputESUserName { get; set; }
            [NameInMap("OutputEsDescription")]
            [Validation(Required=false)]
            public string OutputEsDescription { get; set; }
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }
            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("Replica")]
            [Validation(Required=false)]
            public long? Replica { get; set; }
            [NameInMap("ResourceSpec")]
            [Validation(Required=false)]
            public string ResourceSpec { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("VsArea")]
            [Validation(Required=false)]
            public string VsArea { get; set; }
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }
        };

    }

}
