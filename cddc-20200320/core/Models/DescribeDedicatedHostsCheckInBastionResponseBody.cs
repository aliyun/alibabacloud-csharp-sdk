// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedHostsCheckInBastionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BastionInstanceId")]
        [Validation(Required=false)]
        public string BastionInstanceId { get; set; }

        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<DescribeDedicatedHostsCheckInBastionResponseBodyHosts> Hosts { get; set; }
        public class DescribeDedicatedHostsCheckInBastionResponseBodyHosts : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("DedicatedHostName")]
            [Validation(Required=false)]
            public string DedicatedHostName { get; set; }

            [NameInMap("AllocationStatus")]
            [Validation(Required=false)]
            public bool? AllocationStatus { get; set; }

            [NameInMap("InBastion")]
            [Validation(Required=false)]
            public bool? InBastion { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

    }

}
