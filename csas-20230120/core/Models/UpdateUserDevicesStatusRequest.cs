// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateUserDevicesStatusRequest : TeaModel {
        [NameInMap("DeviceAction")]
        [Validation(Required=false)]
        public string DeviceAction { get; set; }

        [NameInMap("DeviceTags")]
        [Validation(Required=false)]
        public List<string> DeviceTags { get; set; }

    }

}
