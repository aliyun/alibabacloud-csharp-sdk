// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewayInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("GatewayInfos")]
        [Validation(Required=false)]
        public DescribeGatewayInfoResponseBodyGatewayInfos GatewayInfos { get; set; }
        public class DescribeGatewayInfoResponseBodyGatewayInfos : TeaModel {
            [NameInMap("GatewayInfo")]
            [Validation(Required=false)]
            public List<DescribeGatewayInfoResponseBodyGatewayInfosGatewayInfo> GatewayInfo { get; set; }
            public class DescribeGatewayInfoResponseBodyGatewayInfosGatewayInfo : TeaModel {
                [NameInMap("Info")]
                [Validation(Required=false)]
                public string Info { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

            }

        }

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
