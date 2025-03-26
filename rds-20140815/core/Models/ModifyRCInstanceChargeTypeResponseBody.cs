// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyRCInstanceChargeTypeResponseBody : TeaModel {
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public List<string> ExpiredTime { get; set; }

        [NameInMap("FeeOfInstances")]
        [Validation(Required=false)]
        public List<ModifyRCInstanceChargeTypeResponseBodyFeeOfInstances> FeeOfInstances { get; set; }
        public class ModifyRCInstanceChargeTypeResponseBodyFeeOfInstances : TeaModel {
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

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
