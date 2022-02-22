// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DescribePodEventsRequest : TeaModel {
        [NameInMap("AppInstId")]
        [Validation(Required=false)]
        public string AppInstId { get; set; }

        [NameInMap("DeployOrderId")]
        [Validation(Required=false)]
        public long? DeployOrderId { get; set; }

    }

}
