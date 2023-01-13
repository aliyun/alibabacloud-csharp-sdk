// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class DetachDestinationRequest : TeaModel {
        [NameInMap("DestinationId")]
        [Validation(Required=true)]
        public long? DestinationId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ParserId")]
        [Validation(Required=true)]
        public long? ParserId { get; set; }

    }

}
