// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeApiGatewayAppSecurityResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ApiGatewayAppSecurity")]
        [Validation(Required=false)]
        public DescribeApiGatewayAppSecurityResponseBodyApiGatewayAppSecurity ApiGatewayAppSecurity { get; set; }
        public class DescribeApiGatewayAppSecurityResponseBodyApiGatewayAppSecurity : TeaModel {
            [NameInMap("GatewayAppKey")]
            [Validation(Required=false)]
            public string GatewayAppKey { get; set; }
            [NameInMap("GatewayAppSecret")]
            [Validation(Required=false)]
            public string GatewayAppSecret { get; set; }
            [NameInMap("GatewayAppId")]
            [Validation(Required=false)]
            public string GatewayAppId { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }
        };

    }

}
