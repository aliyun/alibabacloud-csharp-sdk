// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class CreateReservationDemandRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ConfirmType")]
        [Validation(Required=false)]
        public string ConfirmType { get; set; }

        [NameInMap("CouponAuto")]
        [Validation(Required=false)]
        public bool? CouponAuto { get; set; }

        [NameInMap("CouponType")]
        [Validation(Required=false)]
        public string CouponType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        [NameInMap("InstanceCpuCoreCount")]
        [Validation(Required=false)]
        public int? InstanceCpuCoreCount { get; set; }

        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public string InstanceTypes { get; set; }

        [NameInMap("MatchCriteria")]
        [Validation(Required=false)]
        public string MatchCriteria { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public List<CreateReservationDemandRequestPrivatePoolOptions> PrivatePoolOptions { get; set; }
        public class CreateReservationDemandRequestPrivatePoolOptions : TeaModel {
            [NameInMap("InstanceAmount")]
            [Validation(Required=false)]
            public int? InstanceAmount { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ReservedInstanceDescription")]
        [Validation(Required=false)]
        public string ReservedInstanceDescription { get; set; }

        [NameInMap("ReservedInstanceName")]
        [Validation(Required=false)]
        public string ReservedInstanceName { get; set; }

        [NameInMap("ReservedInstanceOfferingType")]
        [Validation(Required=false)]
        public string ReservedInstanceOfferingType { get; set; }

        [NameInMap("ReservedInstanceScope")]
        [Validation(Required=false)]
        public string ReservedInstanceScope { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("ResourceSupplyType")]
        [Validation(Required=false)]
        public string ResourceSupplyType { get; set; }

        [NameInMap("SavingPlanDescription")]
        [Validation(Required=false)]
        public string SavingPlanDescription { get; set; }

        [NameInMap("SavingPlanHourFee")]
        [Validation(Required=false)]
        public float? SavingPlanHourFee { get; set; }

        [NameInMap("SavingPlanId")]
        [Validation(Required=false)]
        public string SavingPlanId { get; set; }

        [NameInMap("SavingPlanInstanceTypeFamilyGroup")]
        [Validation(Required=false)]
        public string SavingPlanInstanceTypeFamilyGroup { get; set; }

        [NameInMap("SavingPlanName")]
        [Validation(Required=false)]
        public string SavingPlanName { get; set; }

        [NameInMap("SavingPlanPayMode")]
        [Validation(Required=false)]
        public string SavingPlanPayMode { get; set; }

        [NameInMap("SavingPlanSavingType")]
        [Validation(Required=false)]
        public string SavingPlanSavingType { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateReservationDemandRequestTag> Tag { get; set; }
        public class CreateReservationDemandRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ZoneIds")]
        [Validation(Required=false)]
        public string ZoneIds { get; set; }

    }

}
