// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RunRCInstancesResponseBody : TeaModel {
        [NameInMap("InstanceIdSets")]
        [Validation(Required=false)]
        public RunRCInstancesResponseBodyInstanceIdSets InstanceIdSets { get; set; }
        public class RunRCInstancesResponseBodyInstanceIdSets : TeaModel {
            [NameInMap("InstanceIdSet")]
            [Validation(Required=false)]
            public List<string> InstanceIdSet { get; set; }

        }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
