// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class CheckDeviceResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("Plans")]
        [Validation(Required=false)]
        public CheckDeviceResponseBodyPlans Plans { get; set; }
        public class CheckDeviceResponseBodyPlans : TeaModel {
            [NameInMap("PlanDto")]
            [Validation(Required=false)]
            public List<CheckDeviceResponseBodyPlansPlanDto> PlanDto { get; set; }
            public class CheckDeviceResponseBodyPlansPlanDto : TeaModel {
                public string EndTime { get; set; }
                public long? Id { get; set; }
                public string Name { get; set; }
                public string StartTime { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

    }

}
