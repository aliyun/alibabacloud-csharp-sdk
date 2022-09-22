// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class ModifyInstanceChargeTypeResponseBody : TeaModel {
        [NameInMap("FeeOfInstances")]
        [Validation(Required=false)]
        public ModifyInstanceChargeTypeResponseBodyFeeOfInstances FeeOfInstances { get; set; }
        public class ModifyInstanceChargeTypeResponseBodyFeeOfInstances : TeaModel {
            [NameInMap("FeeOfInstance")]
            [Validation(Required=false)]
            public List<ModifyInstanceChargeTypeResponseBodyFeeOfInstancesFeeOfInstance> FeeOfInstance { get; set; }
            public class ModifyInstanceChargeTypeResponseBodyFeeOfInstancesFeeOfInstance : TeaModel {
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("Fee")]
                [Validation(Required=false)]
                public string Fee { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
