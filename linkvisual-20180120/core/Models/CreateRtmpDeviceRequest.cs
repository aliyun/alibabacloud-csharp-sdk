// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class CreateRtmpDeviceRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("PullAuthKey")]
        [Validation(Required=false)]
        public string PullAuthKey { get; set; }

        [NameInMap("PullKeyExpireTime")]
        [Validation(Required=false)]
        public int? PullKeyExpireTime { get; set; }

        [NameInMap("PushAuthKey")]
        [Validation(Required=false)]
        public string PushAuthKey { get; set; }

        [NameInMap("PushKeyExpireTime")]
        [Validation(Required=false)]
        public int? PushKeyExpireTime { get; set; }

        [NameInMap("SubStreamName")]
        [Validation(Required=false)]
        public string SubStreamName { get; set; }

    }

}
