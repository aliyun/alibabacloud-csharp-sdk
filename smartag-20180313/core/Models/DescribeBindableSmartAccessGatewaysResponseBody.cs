// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeBindableSmartAccessGatewaysResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmartAccessGateways")]
        [Validation(Required=false)]
        public DescribeBindableSmartAccessGatewaysResponseBodySmartAccessGateways SmartAccessGateways { get; set; }
        public class DescribeBindableSmartAccessGatewaysResponseBodySmartAccessGateways : TeaModel {
            [NameInMap("SmartAccessGateway")]
            [Validation(Required=false)]
            public List<DescribeBindableSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGateway> SmartAccessGateway { get; set; }
            public class DescribeBindableSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGateway : TeaModel {
                public string Name { get; set; }
                public string SmartAGId { get; set; }
                public long? SmartAGUid { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
