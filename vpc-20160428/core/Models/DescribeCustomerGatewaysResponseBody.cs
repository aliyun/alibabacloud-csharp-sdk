// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeCustomerGatewaysResponseBody : TeaModel {
        [NameInMap("CustomerGateways")]
        [Validation(Required=false)]
        public DescribeCustomerGatewaysResponseBodyCustomerGateways CustomerGateways { get; set; }
        public class DescribeCustomerGatewaysResponseBodyCustomerGateways : TeaModel {
            [NameInMap("CustomerGateway")]
            [Validation(Required=false)]
            public List<DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGateway> CustomerGateway { get; set; }
            public class DescribeCustomerGatewaysResponseBodyCustomerGatewaysCustomerGateway : TeaModel {
                [NameInMap("Asn")]
                [Validation(Required=false)]
                public long? Asn { get; set; }

                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("CustomerGatewayId")]
                [Validation(Required=false)]
                public string CustomerGatewayId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

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
        public int? TotalCount { get; set; }

    }

}
