// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGrayMigrationDeviceRequest : TeaModel {
        [NameInMap("DeviceNames")]
        [Validation(Required=false)]
        public List<string> DeviceNames { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
