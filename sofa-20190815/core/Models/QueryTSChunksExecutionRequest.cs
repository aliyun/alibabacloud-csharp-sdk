// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryTSChunksExecutionRequest : TeaModel {
        [NameInMap("ExecuteHandler")]
        [Validation(Required=false)]
        public string ExecuteHandler { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobRequestId")]
        [Validation(Required=false)]
        public string JobRequestId { get; set; }

    }

}
