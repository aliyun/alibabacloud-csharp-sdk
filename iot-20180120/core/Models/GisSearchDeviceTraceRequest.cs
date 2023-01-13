// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GisSearchDeviceTraceRequest : TeaModel {
        [NameInMap("MapMatch")]
        [Validation(Required=true)]
        public int? MapMatch { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public long? EndTime { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public long? StartTime { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=true)]
        public string DeviceName { get; set; }

    }

}
