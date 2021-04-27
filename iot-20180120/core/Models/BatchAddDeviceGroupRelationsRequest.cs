/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchAddDeviceGroupRelationsRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("Device")]
        [Validation(Required=false)]
        public List<BatchAddDeviceGroupRelationsRequestDevice> Device { get; set; }
        public class BatchAddDeviceGroupRelationsRequestDevice : TeaModel {
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

        }

    }

}
