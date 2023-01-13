// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchBindDevicesIntoProjectRequest : TeaModel {
        [NameInMap("Devices")]
        [Validation(Required=true)]
        public List<BatchBindDevicesIntoProjectRequestDevices> Devices { get; set; }
        public class BatchBindDevicesIntoProjectRequestDevices : TeaModel {
            [NameInMap("DeviceName")]
            [Validation(Required=true)]
            public string DeviceName { get; set; }

            [NameInMap("ProductKey")]
            [Validation(Required=true)]
            public string ProductKey { get; set; }

        }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=true)]
        public string ProjectId { get; set; }

    }

}
