// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchSetEdgeInstanceDeviceConfigRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("DeviceConfigs")]
        [Validation(Required=true)]
        public List<BatchSetEdgeInstanceDeviceConfigRequestDeviceConfigs> DeviceConfigs { get; set; }
        public class BatchSetEdgeInstanceDeviceConfigRequestDeviceConfigs : TeaModel {
            [NameInMap("IotId")]
            [Validation(Required=true)]
            public string IotId { get; set; }

            [NameInMap("Content")]
            [Validation(Required=true)]
            public string Content { get; set; }

        }

    }

}
