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
        public DescribeDemandsResponseBodyDemands Demands { get; set; }
        public class DescribeDemandsResponseBodyDemands : TeaModel {
            [NameInMap("Demand")]
            [Validation(Required=false)]
            public List<DescribeDemandsResponseBodyDemandsDemand> Demand { get; set; }
            public class DescribeDemandsResponseBodyDemandsDemand : TeaModel {
                public string Comment { get; set; }
                public string DemandId { get; set; }
                public string DemandDescription { get; set; }
                public string DemandTime { get; set; }
                public DescribeDemandsResponseBodyDemandsDemandSupplyInfos SupplyInfos { get; set; }
                public class DescribeDemandsResponseBodyDemandsDemandSupplyInfos : TeaModel {
                    [NameInMap("SupplyInfo")]
                    [Validation(Required=false)]
                    public List<DescribeDemandsResponseBodyDemandsDemandSupplyInfosSupplyInfo> SupplyInfo { get; set; }
                    public class DescribeDemandsResponseBodyDemandsDemandSupplyInfosSupplyInfo : TeaModel {
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

                }
                public string DemandName { get; set; }
                public string InstanceType { get; set; }
                public string InstanceChargeType { get; set; }
                public int? Period { get; set; }
                public string EndTime { get; set; }
                public int? AvailableAmount { get; set; }
                public string StartTime { get; set; }
                public string PeriodUnit { get; set; }
                public string ZoneId { get; set; }
                public int? UsedAmount { get; set; }
                public int? TotalAmount { get; set; }
                public int? DeliveringAmount { get; set; }
                public string InstanceTypeFamily { get; set; }
                public string DemandStatus { get; set; }
            }
        };

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
