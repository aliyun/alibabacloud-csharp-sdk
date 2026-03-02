// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MqMsgDigest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("RetryCount")]
        [Validation(Required=false)]
        public long? RetryCount { get; set; }

        [NameInMap("StoreSize")]
        [Validation(Required=false)]
        public int? StoreSize { get; set; }

        [NameInMap("StoreTime")]
        [Validation(Required=false)]
        public string StoreTime { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
