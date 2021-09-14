// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class AddHostsToBastionResponseBody : TeaModel {
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
        public List<AddHostsToBastionResponseBodyHosts> Hosts { get; set; }
        public class AddHostsToBastionResponseBodyHosts : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("HostPrivateIp")]
            [Validation(Required=false)]
            public string HostPrivateIp { get; set; }

        }

    }

}
