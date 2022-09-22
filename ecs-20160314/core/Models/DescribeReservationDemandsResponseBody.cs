// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeReservationDemandsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeReservationDemandsResponseBodyData Data { get; set; }
        public class DescribeReservationDemandsResponseBodyData : TeaModel {
            [NameInMap("DemandOrders")]
            [Validation(Required=false)]
            public List<DescribeReservationDemandsResponseBodyDataDemandOrders> DemandOrders { get; set; }
            public class DescribeReservationDemandsResponseBodyDataDemandOrders : TeaModel {
                [NameInMap("ConfirmType")]
                [Validation(Required=false)]
                public string ConfirmType { get; set; }

                [NameInMap("CouponAuto")]
                [Validation(Required=false)]
                public string CouponAuto { get; set; }

                [NameInMap("CouponType")]
                [Validation(Required=false)]
                public string CouponType { get; set; }

                [NameInMap("DemandId")]
                [Validation(Required=false)]
                public string DemandId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("InstanceCpuCoreCount")]
                [Validation(Required=false)]
                public int? InstanceCpuCoreCount { get; set; }

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

                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                [NameInMap("RecommendResource")]
                [Validation(Required=false)]
                public DescribeReservationDemandsResponseBodyDataDemandOrdersRecommendResource RecommendResource { get; set; }
                public class DescribeReservationDemandsResponseBodyDataDemandOrdersRecommendResource : TeaModel {
                    [NameInMap("CapacityReservations")]
                    [Validation(Required=false)]
                    public List<DescribeReservationDemandsResponseBodyDataDemandOrdersRecommendResourceCapacityReservations> CapacityReservations { get; set; }
                    public class DescribeReservationDemandsResponseBodyDataDemandOrdersRecommendResourceCapacityReservations : TeaModel {
                        [NameInMap("InstanceAmount")]
                        [Validation(Required=false)]
                        public int? InstanceAmount { get; set; }

                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("MatchCriteria")]
                        [Validation(Required=false)]
                        public string MatchCriteria { get; set; }

                        [NameInMap("PlanId")]
                        [Validation(Required=false)]
                        public string PlanId { get; set; }

                        [NameInMap("PrivatePoolOptionsId")]
                        [Validation(Required=false)]
                        public string PrivatePoolOptionsId { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ReservationResource")]
                [Validation(Required=false)]
                public DescribeReservationDemandsResponseBodyDataDemandOrdersReservationResource ReservationResource { get; set; }
                public class DescribeReservationDemandsResponseBodyDataDemandOrdersReservationResource : TeaModel {
                    [NameInMap("CapacityReservations")]
                    [Validation(Required=false)]
                    public List<DescribeReservationDemandsResponseBodyDataDemandOrdersReservationResourceCapacityReservations> CapacityReservations { get; set; }
                    public class DescribeReservationDemandsResponseBodyDataDemandOrdersReservationResourceCapacityReservations : TeaModel {
                        [NameInMap("ApproveCode")]
                        [Validation(Required=false)]
                        public string ApproveCode { get; set; }

                        [NameInMap("ApproveNotes")]
                        [Validation(Required=false)]
                        public string ApproveNotes { get; set; }

                        [NameInMap("InstanceAmount")]
                        [Validation(Required=false)]
                        public int? InstanceAmount { get; set; }

                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("MatchCriteria")]
                        [Validation(Required=false)]
                        public string MatchCriteria { get; set; }

                        [NameInMap("PlanId")]
                        [Validation(Required=false)]
                        public string PlanId { get; set; }

                        [NameInMap("PrivatePoolOptionsId")]
                        [Validation(Required=false)]
                        public string PrivatePoolOptionsId { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

                [NameInMap("ReservedInstanceDescription")]
                [Validation(Required=false)]
                public string ReservedInstanceDescription { get; set; }

                [NameInMap("ReservedInstanceId")]
                [Validation(Required=false)]
                public string ReservedInstanceId { get; set; }

                [NameInMap("ReservedInstanceName")]
                [Validation(Required=false)]
                public string ReservedInstanceName { get; set; }

                [NameInMap("ReservedInstanceOfferingType")]
                [Validation(Required=false)]
                public string ReservedInstanceOfferingType { get; set; }

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

                [NameInMap("SavingPlanSpecType")]
                [Validation(Required=false)]
                public string SavingPlanSpecType { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("ZoneIds")]
                [Validation(Required=false)]
                public string ZoneIds { get; set; }

            }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
