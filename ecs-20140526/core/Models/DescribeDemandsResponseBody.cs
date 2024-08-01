// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDemandsResponseBody : TeaModel {
        /// <summary>
        /// The demands in the region.
        /// </summary>
        [NameInMap("Demands")]
        [Validation(Required=false)]
        public DescribeDemandsResponseBodyDemands Demands { get; set; }
        public class DescribeDemandsResponseBodyDemands : TeaModel {
            [NameInMap("Demand")]
            [Validation(Required=false)]
            public List<DescribeDemandsResponseBodyDemandsDemand> Demand { get; set; }
            public class DescribeDemandsResponseBodyDemandsDemand : TeaModel {
                /// <summary>
                /// The number of available instances.
                /// </summary>
                [NameInMap("AvailableAmount")]
                [Validation(Required=false)]
                public int? AvailableAmount { get; set; }

                /// <summary>
                /// The feedback on the rejected demands.
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// The number of instances to be delivered.
                /// </summary>
                [NameInMap("DeliveringAmount")]
                [Validation(Required=false)]
                public int? DeliveringAmount { get; set; }

                /// <summary>
                /// The description of the demand.
                /// </summary>
                [NameInMap("DemandDescription")]
                [Validation(Required=false)]
                public string DemandDescription { get; set; }

                /// <summary>
                /// The ID of the demand.
                /// </summary>
                [NameInMap("DemandId")]
                [Validation(Required=false)]
                public string DemandId { get; set; }

                /// <summary>
                /// The name of the demand.
                /// </summary>
                [NameInMap("DemandName")]
                [Validation(Required=false)]
                public string DemandName { get; set; }

                /// <summary>
                /// The status of the demand or filed resources. Valid values:
                /// 
                /// *   Creating: The demand is being created.
                /// *   Active: The filed resources are being supplied.
                /// *   Expired: The demand has expired.
                /// *   Finished: The filed resources are consumed.
                /// *   Refused: The demand is rejected. To view the reason for rejection, see the `Comment` parameter.
                /// *   Cancelled: The demand is canceled. After the demand is canceled, the delivery status of the resources becomes invalid.
                /// </summary>
                [NameInMap("DemandStatus")]
                [Validation(Required=false)]
                public string DemandStatus { get; set; }

                /// <summary>
                /// The time when the demand was created. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("DemandTime")]
                [Validation(Required=false)]
                public string DemandTime { get; set; }

                /// <summary>
                /// The expected end time for the purchase of the filed resources. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The billing method of the filed resources. Valid values:
                /// 
                /// *   Prepaid: subscription.
                /// *   Postpaid: pay-as-you-go.
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// The instance type of the filed instance.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The instance family of the filed instance.
                /// </summary>
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// The usage duration of the filed resources.
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                /// <summary>
                /// The unit of the usage duration of the filed resources. Valid values:
                /// 
                /// *   Hour
                /// *   Day
                /// *
                /// *   Month
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// The expected start time for the purchase of the filed resources. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The delivery status of the filed resources.
                /// </summary>
                [NameInMap("SupplyInfos")]
                [Validation(Required=false)]
                public DescribeDemandsResponseBodyDemandsDemandSupplyInfos SupplyInfos { get; set; }
                public class DescribeDemandsResponseBodyDemandsDemandSupplyInfos : TeaModel {
                    [NameInMap("SupplyInfo")]
                    [Validation(Required=false)]
                    public List<DescribeDemandsResponseBodyDemandsDemandSupplyInfosSupplyInfo> SupplyInfo { get; set; }
                    public class DescribeDemandsResponseBodyDemandsDemandSupplyInfosSupplyInfo : TeaModel {
                        /// <summary>
                        /// The number of delivered instances.
                        /// </summary>
                        [NameInMap("Amount")]
                        [Validation(Required=false)]
                        public int? Amount { get; set; }

                        /// <summary>
                        /// 需求单对应的私有池ID。
                        /// </summary>
                        [NameInMap("PrivatePoolId")]
                        [Validation(Required=false)]
                        public string PrivatePoolId { get; set; }

                        /// <summary>
                        /// The end of the time range during which the filed resources are delivered and available. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                        /// </summary>
                        [NameInMap("SupplyEndTime")]
                        [Validation(Required=false)]
                        public string SupplyEndTime { get; set; }

                        /// <summary>
                        /// The beginning of the time range during which the filed resources are delivered and available. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                        /// </summary>
                        [NameInMap("SupplyStartTime")]
                        [Validation(Required=false)]
                        public string SupplyStartTime { get; set; }

                        /// <summary>
                        /// The delivery status of the filed resource. Valid values:
                        /// 
                        /// *   Delivered: The filed resource is delivered.
                        /// *   Delivering: The filed resource is being delivered.
                        /// </summary>
                        [NameInMap("SupplyStatus")]
                        [Validation(Required=false)]
                        public string SupplyStatus { get; set; }

                    }

                }

                /// <summary>
                /// The number of filed instances.
                /// </summary>
                [NameInMap("TotalAmount")]
                [Validation(Required=false)]
                public int? TotalAmount { get; set; }

                /// <summary>
                /// The number of consumed instances.
                /// </summary>
                [NameInMap("UsedAmount")]
                [Validation(Required=false)]
                public int? UsedAmount { get; set; }

                /// <summary>
                /// The ID of the zone where the filed resource resides.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of queried demands.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
