// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ConsumerInfo : TeaModel {
        [NameInMap("consumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
