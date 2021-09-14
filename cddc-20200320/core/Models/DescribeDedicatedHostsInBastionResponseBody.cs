// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedHostsInBastionResponseBody : TeaModel {
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
        public List<DescribeDedicatedHostsInBastionResponseBodyHosts> Hosts { get; set; }
        public class DescribeDedicatedHostsInBastionResponseBodyHosts : TeaModel {
            [NameInMap("HostDescription")]
            [Validation(Required=false)]
            public string HostDescription { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("BastionHostId")]
            [Validation(Required=false)]
            public string BastionHostId { get; set; }

            [NameInMap("OsName")]
            [Validation(Required=false)]
            public string OsName { get; set; }

            [NameInMap("HostAccountCount")]
            [Validation(Required=false)]
            public string HostAccountCount { get; set; }

            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

            [NameInMap("HostPrivateIp")]
            [Validation(Required=false)]
            public string HostPrivateIp { get; set; }

            [NameInMap("AccountCreating")]
            [Validation(Required=false)]
            public bool? AccountCreating { get; set; }

            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

        }

    }

}
