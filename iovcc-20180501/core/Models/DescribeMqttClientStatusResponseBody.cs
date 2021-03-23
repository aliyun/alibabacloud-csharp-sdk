// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeMqttClientStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ClientStatus")]
        [Validation(Required=false)]
        public DescribeMqttClientStatusResponseBodyClientStatus ClientStatus { get; set; }
        public class DescribeMqttClientStatusResponseBodyClientStatus : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("LastUpdate")]
            [Validation(Required=false)]
            public long? LastUpdate { get; set; }
            [NameInMap("CleanSession")]
            [Validation(Required=false)]
            public string CleanSession { get; set; }
        };

    }

}
