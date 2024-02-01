// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class CreateStreamPushJobRequest : TeaModel {
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("JobType")]
        [Validation(Required=false)]
        public int? JobType { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("PushUrl")]
        [Validation(Required=false)]
        public string PushUrl { get; set; }

        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public int? StreamType { get; set; }

    }

}
