// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class BatchQueryVisionDeviceInfoRequest : TeaModel {
        [NameInMap("DeviceNameList")]
        [Validation(Required=false)]
        public List<string> DeviceNameList { get; set; }

        [NameInMap("IotIdList")]
        [Validation(Required=false)]
        public List<string> IotIdList { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
