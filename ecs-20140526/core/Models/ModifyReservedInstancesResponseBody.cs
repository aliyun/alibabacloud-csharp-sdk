// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyReservedInstancesResponseBody : TeaModel {
        [NameInMap("ReservedInstanceIdSets")]
        [Validation(Required=false)]
        public List<string> ReservedInstanceIdSets { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
