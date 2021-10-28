// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewaysForCmsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Gateways")]
        [Validation(Required=false)]
        public DescribeGatewaysForCmsResponseBodyGateways Gateways { get; set; }
        public class DescribeGatewaysForCmsResponseBodyGateways : TeaModel {
            [NameInMap("Gateway")]
            [Validation(Required=false)]
            public List<DescribeGatewaysForCmsResponseBodyGatewaysGateway> Gateway { get; set; }
            public class DescribeGatewaysForCmsResponseBodyGatewaysGateway : TeaModel {
                public string Description { get; set; }
                public string GatewayId { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
