// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateDeviceShadowRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("ShadowMessage")]
        [Validation(Required=false)]
        public string ShadowMessage { get; set; }

        [NameInMap("DeltaUpdate")]
        [Validation(Required=false)]
        public bool? DeltaUpdate { get; set; }

    }

}
