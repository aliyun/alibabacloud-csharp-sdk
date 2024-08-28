// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListGatewayResponseBody : TeaModel {
        [NameInMap("Gateways")]
        [Validation(Required=false)]
        public List<ListGatewayResponseBodyGateways> Gateways { get; set; }
        public class ListGatewayResponseBodyGateways : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            [NameInMap("GatewayName")]
            [Validation(Required=false)]
            public string GatewayName { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("InternetDomain")]
            [Validation(Required=false)]
            public string InternetDomain { get; set; }

            [NameInMap("InternetEnabled")]
            [Validation(Required=false)]
            public bool? InternetEnabled { get; set; }

            [NameInMap("IntranetDomain")]
            [Validation(Required=false)]
            public string IntranetDomain { get; set; }

            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public int? Replicas { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
