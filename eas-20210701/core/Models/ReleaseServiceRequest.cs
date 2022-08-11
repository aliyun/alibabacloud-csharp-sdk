// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ReleaseServiceRequest : TeaModel {
        [NameInMap("TrafficState")]
        [Validation(Required=false)]
        public string TrafficState { get; set; }

        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
