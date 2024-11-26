// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yuqing20220301.Models
{
    public class QueryProductInstanceListResponseBody : TeaModel {
        [NameInMap("instanceList")]
        [Validation(Required=false)]
        public List<ProductInstance> InstanceList { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
