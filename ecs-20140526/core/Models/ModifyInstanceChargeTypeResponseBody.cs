// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceChargeTypeResponseBody : TeaModel {
        [NameInMap("FeeOfInstances")]
        [Validation(Required=false)]
        public List<ModifyInstanceChargeTypeResponseBodyFeeOfInstances> FeeOfInstances { get; set; }
        public class ModifyInstanceChargeTypeResponseBodyFeeOfInstances : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            [NameInMap("Fee")]
            [Validation(Required=false)]
            public string Fee { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}
