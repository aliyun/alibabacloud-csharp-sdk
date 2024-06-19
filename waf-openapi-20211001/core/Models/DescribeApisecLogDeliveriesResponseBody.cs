// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecLogDeliveriesResponseBody : TeaModel {
        [NameInMap("DeliveryConfigs")]
        [Validation(Required=false)]
        public List<DescribeApisecLogDeliveriesResponseBodyDeliveryConfigs> DeliveryConfigs { get; set; }
        public class DescribeApisecLogDeliveriesResponseBodyDeliveryConfigs : TeaModel {
            [NameInMap("AssertKey")]
            [Validation(Required=false)]
            public string AssertKey { get; set; }

            [NameInMap("LogRegionId")]
            [Validation(Required=false)]
            public string LogRegionId { get; set; }

            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
