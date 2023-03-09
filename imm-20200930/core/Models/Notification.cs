// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Notification : TeaModel {
        [NameInMap("MNS")]
        [Validation(Required=false)]
        public MNS MNS { get; set; }

        [NameInMap("RocketMQ")]
        [Validation(Required=false)]
        public RocketMQ RocketMQ { get; set; }

    }

}
