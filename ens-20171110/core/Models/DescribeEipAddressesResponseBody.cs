// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEipAddressesResponseBody : TeaModel {
        /// <summary>
        /// Details of the EIPs.
        /// </summary>
        [NameInMap("EipAddresses")]
        [Validation(Required=false)]
        public DescribeEipAddressesResponseBodyEipAddresses EipAddresses { get; set; }
        public class DescribeEipAddressesResponseBodyEipAddresses : TeaModel {
            [NameInMap("EipAddress")]
            [Validation(Required=false)]
            public List<DescribeEipAddressesResponseBodyEipAddressesEipAddress> EipAddress { get; set; }
            public class DescribeEipAddressesResponseBodyEipAddressesEipAddress : TeaModel {
                /// <summary>
                /// The information about an EIP.
                /// </summary>
                [NameInMap("Eip")]
                [Validation(Required=false)]
                public string Eip { get; set; }

                /// <summary>
                /// The public IP address of the ENS instance.
                /// </summary>
                [NameInMap("InstanceIdInternetIp")]
                [Validation(Required=false)]
                public string InstanceIdInternetIp { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
