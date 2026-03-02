// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MicroServiceDigest : TeaModel {
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("laneMqGroupInfos")]
        [Validation(Required=false)]
        public LaneMqGroupInfo LaneMqGroupInfos { get; set; }

    }

}
