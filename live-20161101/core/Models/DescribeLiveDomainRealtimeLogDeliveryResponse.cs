// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRealtimeLogDeliveryResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Project")]
        [Validation(Required=true)]
        public string Project { get; set; }

        [NameInMap("Region")]
        [Validation(Required=true)]
        public string Region { get; set; }

        [NameInMap("Logstore")]
        [Validation(Required=true)]
        public string Logstore { get; set; }

        [NameInMap("Status")]
        [Validation(Required=true)]
        public string Status { get; set; }

    }

}
