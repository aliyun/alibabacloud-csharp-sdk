// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class GetVehicleRepairPlanResponseBody : TeaModel {
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVehicleRepairPlanResponseBodyData Data { get; set; }
        public class GetVehicleRepairPlanResponseBodyData : TeaModel {
            [NameInMap("RepairParts")]
            [Validation(Required=false)]
            public List<GetVehicleRepairPlanResponseBodyDataRepairParts> RepairParts { get; set; }
            public class GetVehicleRepairPlanResponseBodyDataRepairParts : TeaModel {
                public string RelationType { get; set; }
                public string PartsStdCode { get; set; }
                public bool? PartNameMatch { get; set; }
                public string RepairFee { get; set; }
                public string OutStandardPartsName { get; set; }
                public string PartsStdName { get; set; }
                public string RepairTypeName { get; set; }
                public string RepairType { get; set; }
                public bool? OeMatch { get; set; }
                public string OutStandardPartsId { get; set; }
                public string GarageType { get; set; }
            }
            [NameInMap("FrameNo")]
            [Validation(Required=false)]
            public string FrameNo { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
