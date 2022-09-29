// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class GetVehicleRepairPlanAdvanceRequest : TeaModel {
        [NameInMap("CarNumberImage")]
        [Validation(Required=false)]
        public Stream CarNumberImageObject { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("VinCodeImage")]
        [Validation(Required=false)]
        public Stream VinCodeImageObject { get; set; }

    }

}
