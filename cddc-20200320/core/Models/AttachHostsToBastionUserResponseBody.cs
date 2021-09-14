// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class AttachHostsToBastionUserResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BastionInstanceId")]
        [Validation(Required=false)]
        public string BastionInstanceId { get; set; }

        [NameInMap("BastionUser")]
        [Validation(Required=false)]
        public string BastionUser { get; set; }

        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public List<AttachHostsToBastionUserResponseBodyHosts> Hosts { get; set; }
        public class AttachHostsToBastionUserResponseBodyHosts : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
