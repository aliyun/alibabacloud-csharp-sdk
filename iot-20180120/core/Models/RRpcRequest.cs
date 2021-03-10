// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class RRpcRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=true)]
        public string DeviceName { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=true)]
        public int? Timeout { get; set; }

        [NameInMap("RequestBase64Byte")]
        [Validation(Required=true)]
        public string RequestBase64Byte { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
