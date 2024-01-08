// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class CreateLocalRecordDownloadByTimeJobRequest : TeaModel {
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public int? BeginTime { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("Speed")]
        [Validation(Required=false)]
        public float? Speed { get; set; }

    }

}
