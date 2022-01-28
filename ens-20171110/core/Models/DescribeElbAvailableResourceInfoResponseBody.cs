// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeElbAvailableResourceInfoResponseBody : TeaModel {
        [NameInMap("ElbAvailableResourceInfo")]
        [Validation(Required=false)]
        public List<DescribeElbAvailableResourceInfoResponseBodyElbAvailableResourceInfo> ElbAvailableResourceInfo { get; set; }
        public class DescribeElbAvailableResourceInfoResponseBodyElbAvailableResourceInfo : TeaModel {
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            [NameInMap("CanBuyCount")]
            [Validation(Required=false)]
            public string CanBuyCount { get; set; }

            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            [NameInMap("LoadBalancerSpec")]
            [Validation(Required=false)]
            public List<string> LoadBalancerSpec { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
