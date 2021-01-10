// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SaveDSTTraceCollectionRequest : TeaModel {
        [NameInMap("CollectedDescription")]
        [Validation(Required=false)]
        public string CollectedDescription { get; set; }

        [NameInMap("CollectedName")]
        [Validation(Required=false)]
        public string CollectedName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
