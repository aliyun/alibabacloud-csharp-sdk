// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateRCNodePoolResponseBody : TeaModel {
        [NameInMap("InstanceIdSets")]
        [Validation(Required=false)]
        public List<string> InstanceIdSets { get; set; }

        [NameInMap("NodePoolId")]
        [Validation(Required=false)]
        public string NodePoolId { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
