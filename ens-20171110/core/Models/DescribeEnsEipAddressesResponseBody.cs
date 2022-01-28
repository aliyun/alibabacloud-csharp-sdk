// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsEipAddressesResponseBody : TeaModel {
        [NameInMap("EipAddresses")]
        [Validation(Required=false)]
        public DescribeEnsEipAddressesResponseBodyEipAddresses EipAddresses { get; set; }
        public class DescribeEnsEipAddressesResponseBodyEipAddresses : TeaModel {
            [NameInMap("EipAddress")]
            [Validation(Required=false)]
            public List<DescribeEnsEipAddressesResponseBodyEipAddressesEipAddress> EipAddress { get; set; }
            public class DescribeEnsEipAddressesResponseBodyEipAddressesEipAddress : TeaModel {
                public string AllocationId { get; set; }
                public string AllocationTime { get; set; }
                public int? Bandwidth { get; set; }
                public string ChargeType { get; set; }
                public string Description { get; set; }
                public string EnsRegionId { get; set; }
                public string InstanceId { get; set; }
                public string InstanceType { get; set; }
                public string InternetChargeType { get; set; }
                public string IpAddress { get; set; }
                public string Isp { get; set; }
                public string Name { get; set; }
                public string Status { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
