// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class RegisterDevicesRequest : TeaModel {
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("UserIdListJson")]
        [Validation(Required=false)]
        public string UserIdListJson { get; set; }

    }

}
