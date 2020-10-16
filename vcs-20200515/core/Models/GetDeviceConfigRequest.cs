// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetDeviceConfigRequest : TeaModel {
        [NameInMap("DeviceSn")]
        [Validation(Required=true)]
        public string DeviceSn { get; set; }

        [NameInMap("DeviceTimeStamp")]
        [Validation(Required=true)]
        public string DeviceTimeStamp { get; set; }

    }

}
