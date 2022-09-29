// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class GetVehicleRepairPlanResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVehicleRepairPlanResponseBodyData Data { get; set; }
        public class GetVehicleRepairPlanResponseBodyData : TeaModel {
            [NameInMap("FrameNo")]
            [Validation(Required=false)]
            public string FrameNo { get; set; }

            [NameInMap("RepairParts")]
            [Validation(Required=false)]
            public List<GetVehicleRepairPlanResponseBodyDataRepairParts> RepairParts { get; set; }
            public class GetVehicleRepairPlanResponseBodyDataRepairParts : TeaModel {
                [NameInMap("GarageType")]
                [Validation(Required=false)]
                public string GarageType { get; set; }

                [NameInMap("OeMatch")]
                [Validation(Required=false)]
                public bool? OeMatch { get; set; }

                [NameInMap("OutStandardPartsId")]
                [Validation(Required=false)]
                public string OutStandardPartsId { get; set; }

                [NameInMap("OutStandardPartsName")]
                [Validation(Required=false)]
                public string OutStandardPartsName { get; set; }

                [NameInMap("PartNameMatch")]
                [Validation(Required=false)]
                public bool? PartNameMatch { get; set; }

                [NameInMap("PartsStdCode")]
                [Validation(Required=false)]
                public string PartsStdCode { get; set; }

                [NameInMap("PartsStdName")]
                [Validation(Required=false)]
                public string PartsStdName { get; set; }

                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                [NameInMap("RepairFee")]
                [Validation(Required=false)]
                public string RepairFee { get; set; }

                [NameInMap("RepairType")]
                [Validation(Required=false)]
                public string RepairType { get; set; }

                [NameInMap("RepairTypeName")]
                [Validation(Required=false)]
                public string RepairTypeName { get; set; }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
