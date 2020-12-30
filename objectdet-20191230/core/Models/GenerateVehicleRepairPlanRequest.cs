// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class GenerateVehicleRepairPlanRequest : TeaModel {
        [NameInMap("DamageImageList")]
        [Validation(Required=false)]
        public List<GenerateVehicleRepairPlanRequestDamageImageList> DamageImageList { get; set; }
        public class GenerateVehicleRepairPlanRequestDamageImageList : TeaModel {
            [NameInMap("CreateTimeStamp")]
            [Validation(Required=false)]
            public string CreateTimeStamp { get; set; }

            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

        }

    }

}
