// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeIpAddressesResponseBody : TeaModel {
        [NameInMap("IpAddresses")]
        [Validation(Required=false)]
        public List<DescribeIpAddressesResponseBodyIpAddresses> IpAddresses { get; set; }
        public class DescribeIpAddressesResponseBodyIpAddresses : TeaModel {
            [NameInMap("CreateByWuying")]
            [Validation(Required=false)]
            public bool? CreateByWuying { get; set; }

            [NameInMap("EipAddress")]
            [Validation(Required=false)]
            public string EipAddress { get; set; }

            [NameInMap("EipId")]
            [Validation(Required=false)]
            public string EipId { get; set; }

            [NameInMap("EipStatus")]
            [Validation(Required=false)]
            public string EipStatus { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
