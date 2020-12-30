// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class GetVehicleRepairPlanRequest : TeaModel {
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("CarNumberImage")]
        [Validation(Required=false)]
        public string CarNumberImage { get; set; }

        [NameInMap("VinCodeImage")]
        [Validation(Required=false)]
        public string VinCodeImage { get; set; }

    }

}
