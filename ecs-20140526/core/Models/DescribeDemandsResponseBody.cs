// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDemandsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Demands")]
        [Validation(Required=false)]
        public List<DescribeDemandsResponseBodyDemands> Demands { get; set; }
        public class DescribeDemandsResponseBodyDemands : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("DemandId")]
            [Validation(Required=false)]
            public string DemandId { get; set; }

            [NameInMap("DemandDescription")]
            [Validation(Required=false)]
            public string DemandDescription { get; set; }

            [NameInMap("DemandTime")]
            [Validation(Required=false)]
            public string DemandTime { get; set; }

            [NameInMap("SupplyInfos")]
            [Validation(Required=false)]
            public List<DescribeDemandsResponseBodyDemandsSupplyInfos> SupplyInfos { get; set; }
            public class DescribeDemandsResponseBodyDemandsSupplyInfos : TeaModel {
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                [NameInMap("SupplyEndTime")]
                [Validation(Required=false)]
                public string SupplyEndTime { get; set; }

                [NameInMap("SupplyStatus")]
                [Validation(Required=false)]
                public string SupplyStatus { get; set; }

                [NameInMap("SupplyStartTime")]
                [Validation(Required=false)]
                public string SupplyStartTime { get; set; }

            }

            [NameInMap("DemandName")]
            [Validation(Required=false)]
            public string DemandName { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("AvailableAmount")]
            [Validation(Required=false)]
            public int? AvailableAmount { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("UsedAmount")]
            [Validation(Required=false)]
            public int? UsedAmount { get; set; }

            [NameInMap("TotalAmount")]
            [Validation(Required=false)]
            public int? TotalAmount { get; set; }

            [NameInMap("DeliveringAmount")]
            [Validation(Required=false)]
            public int? DeliveringAmount { get; set; }

            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            [NameInMap("DemandStatus")]
            [Validation(Required=false)]
            public string DemandStatus { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
