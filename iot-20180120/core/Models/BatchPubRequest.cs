// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchPubRequest : TeaModel {
        [NameInMap("DeviceName")]
        [Validation(Required=true)]
        public List<string> DeviceName { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("MessageContent")]
        [Validation(Required=true)]
        public string MessageContent { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("Qos")]
        [Validation(Required=false)]
        public int? Qos { get; set; }

        [NameInMap("TopicShortName")]
        [Validation(Required=true)]
        public string TopicShortName { get; set; }

    }

}
