// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class SetDeviceSettingShrinkRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public string DeviceInfoShrink { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public object Value { get; set; }

    }

}
