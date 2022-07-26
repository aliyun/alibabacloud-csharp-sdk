// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AssignPrivateIpAddressesResponseBody : TeaModel {
        [NameInMap("AssignedPrivateIpAddressesSet")]
        [Validation(Required=false)]
        public AssignPrivateIpAddressesResponseBodyAssignedPrivateIpAddressesSet AssignedPrivateIpAddressesSet { get; set; }
        public class AssignPrivateIpAddressesResponseBodyAssignedPrivateIpAddressesSet : TeaModel {
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }
            [NameInMap("PrivateIpSet")]
            [Validation(Required=false)]
            public List<string> PrivateIpSet { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
