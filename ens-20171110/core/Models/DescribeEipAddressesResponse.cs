// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEipAddressesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("EipAddresses")]
        [Validation(Required=true)]
        public DescribeEipAddressesResponseEipAddresses EipAddresses { get; set; }
        public class DescribeEipAddressesResponseEipAddresses : TeaModel {
            [NameInMap("EipAddress")]
            [Validation(Required=true)]
            public List<DescribeEipAddressesResponseEipAddressesEipAddress> EipAddress { get; set; }
            public class DescribeEipAddressesResponseEipAddressesEipAddress : TeaModel {
                public string Eip { get; set; }
                public string InstanceIdInternetIp { get; set; }
            }
        };

    }

}
