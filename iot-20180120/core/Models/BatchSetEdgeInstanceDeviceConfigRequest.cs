// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchSetEdgeInstanceDeviceConfigRequest : TeaModel {
        [NameInMap("DeviceConfigs")]
        [Validation(Required=false)]
        public List<BatchSetEdgeInstanceDeviceConfigRequestDeviceConfigs> DeviceConfigs { get; set; }
        public class BatchSetEdgeInstanceDeviceConfigRequestDeviceConfigs : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

        }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

    }

}
