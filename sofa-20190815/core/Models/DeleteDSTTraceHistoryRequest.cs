// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteDSTTraceHistoryRequest : TeaModel {
        [NameInMap("DeleteAll")]
        [Validation(Required=false)]
        public bool? DeleteAll { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
