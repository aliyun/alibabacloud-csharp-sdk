// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipGatewayInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("EipInfos")]
        [Validation(Required=false)]
        public DescribeEipGatewayInfoResponseBodyEipInfos EipInfos { get; set; }
        public class DescribeEipGatewayInfoResponseBodyEipInfos : TeaModel {
            [NameInMap("EipInfo")]
            [Validation(Required=false)]
            public List<DescribeEipGatewayInfoResponseBodyEipInfosEipInfo> EipInfo { get; set; }
            public class DescribeEipGatewayInfoResponseBodyEipInfosEipInfo : TeaModel {
                public string Ip { get; set; }
                public string IpGw { get; set; }
                public string IpMask { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
