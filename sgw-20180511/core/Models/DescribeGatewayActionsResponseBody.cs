// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewayActionsResponseBody : TeaModel {
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public DescribeGatewayActionsResponseBodyActions Actions { get; set; }
        public class DescribeGatewayActionsResponseBodyActions : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public List<DescribeGatewayActionsResponseBodyActionsAction> Action { get; set; }
            public class DescribeGatewayActionsResponseBodyActionsAction : TeaModel {
                [NameInMap("AdLdap")]
                [Validation(Required=false)]
                public string AdLdap { get; set; }

                [NameInMap("Cache")]
                [Validation(Required=false)]
                public string Cache { get; set; }

                [NameInMap("Disk")]
                [Validation(Required=false)]
                public string Disk { get; set; }

                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("Monitor")]
                [Validation(Required=false)]
                public string Monitor { get; set; }

                [NameInMap("Self")]
                [Validation(Required=false)]
                public string Self { get; set; }

                [NameInMap("SmbUser")]
                [Validation(Required=false)]
                public string SmbUser { get; set; }

                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
