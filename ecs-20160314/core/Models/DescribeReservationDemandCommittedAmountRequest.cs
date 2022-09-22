// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeReservationDemandCommittedAmountRequest : TeaModel {
        [NameInMap("DemandPlan")]
        [Validation(Required=false)]
        public List<DescribeReservationDemandCommittedAmountRequestDemandPlan> DemandPlan { get; set; }
        public class DescribeReservationDemandCommittedAmountRequestDemandPlan : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        [NameInMap("InstanceFamily")]
        [Validation(Required=false)]
        public string InstanceFamily { get; set; }

        [NameInMap("InstanceFamilySet")]
        [Validation(Required=false)]
        public string InstanceFamilySet { get; set; }

        [NameInMap("OfferingType")]
        [Validation(Required=false)]
        public string OfferingType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("PlanType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("PurchaseMethod")]
        [Validation(Required=false)]
        public string PurchaseMethod { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
