// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetResourceCenterServiceStatusResponseBody : TeaModel {
        [NameInMap("InitialStatus")]
        [Validation(Required=false)]
        public string InitialStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

    }

}
