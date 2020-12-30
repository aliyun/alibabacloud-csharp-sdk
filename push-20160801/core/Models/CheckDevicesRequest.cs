// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class CheckDevicesRequest : TeaModel {
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        [NameInMap("DeviceIds")]
        [Validation(Required=false)]
        public string DeviceIds { get; set; }

    }

}
