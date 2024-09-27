// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDemandsResponseBody : TeaModel {
        /// <summary>
        /// <para>The demands in the region.</para>
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
                /// <para>The number of available instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("AvailableAmount")]
                [Validation(Required=false)]
                public int? AvailableAmount { get; set; }

                /// <summary>
                /// <para>The feedback on the rejected demands.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-for-comment</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The number of instances to be delivered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("DeliveringAmount")]
                [Validation(Required=false)]
                public int? DeliveringAmount { get; set; }

                /// <summary>
                /// <para>The description of the demand.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-DemandDescription</para>
                /// </summary>
                [NameInMap("DemandDescription")]
                [Validation(Required=false)]
                public string DemandDescription { get; set; }

                /// <summary>
                /// <para>The ID of the demand.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ed-bp11n21kq00sl71p****</para>
                /// </summary>
                [NameInMap("DemandId")]
                [Validation(Required=false)]
                public string DemandId { get; set; }

                /// <summary>
                /// <para>The name of the demand.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k8s-node-demand</para>
                /// </summary>
                [NameInMap("DemandName")]
                [Validation(Required=false)]
                public string DemandName { get; set; }

                /// <summary>
                /// <para>The status of the demand or filed resources. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Creating: The demand is being created.</description></item>
                /// <item><description>Active: The filed resources are being supplied.</description></item>
                /// <item><description>Expired: The demand has expired.</description></item>
                /// <item><description>Finished: The filed resources are consumed.</description></item>
                /// <item><description>Refused: The demand is rejected. To view the reason for rejection, see the <c>Comment</c> parameter.</description></item>
                /// <item><description>Cancelled: The demand is canceled. After the demand is canceled, the delivery status of the resources becomes invalid.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("DemandStatus")]
                [Validation(Required=false)]
                public string DemandStatus { get; set; }

                /// <summary>
                /// <para>The time when the demand was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-26T12:00:00Z</para>
                /// </summary>
                [NameInMap("DemandTime")]
                [Validation(Required=false)]
                public string DemandTime { get; set; }

                /// <summary>
                /// <para>The expected end time for the purchase of the filed resources. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-03-03T15:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The billing method of the filed resources. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Prepaid: subscription.</description></item>
                /// <item><description>Postpaid: pay-as-you-go.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Prepaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <para>The instance type of the filed instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g6.xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The instance family of the filed instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g6</para>
                /// </summary>
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// <para>The usage duration of the filed resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                /// <summary>
                /// <para>The unit of the usage duration of the filed resources. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Hour</description></item>
                /// <item><description>Day</description></item>
                /// <item><description></description></item>
                /// <item><description>Month</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Month</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>The expected start time for the purchase of the filed resources. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-27T12:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The delivery status of the filed resources.</para>
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
                        /// <para>The number of delivered instances.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Amount")]
                        [Validation(Required=false)]
                        public int? Amount { get; set; }

                        /// <summary>
                        /// <para>需求单对应的私有池ID。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>crp-bp1fv8sbhelbzjwx****</para>
                        /// </summary>
                        [NameInMap("PrivatePoolId")]
                        [Validation(Required=false)]
                        public string PrivatePoolId { get; set; }

                        /// <summary>
                        /// <para>The end of the time range during which the filed resources are delivered and available. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-03-03T15:00:00Z</para>
                        /// </summary>
                        [NameInMap("SupplyEndTime")]
                        [Validation(Required=false)]
                        public string SupplyEndTime { get; set; }

                        /// <summary>
                        /// <para>The beginning of the time range during which the filed resources are delivered and available. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2019-03-01T14:00:00Z</para>
                        /// </summary>
                        [NameInMap("SupplyStartTime")]
                        [Validation(Required=false)]
                        public string SupplyStartTime { get; set; }

                        /// <summary>
                        /// <para>The delivery status of the filed resource. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Delivered: The filed resource is delivered.</description></item>
                        /// <item><description>Delivering: The filed resource is being delivered.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Delivering</para>
                        /// </summary>
                        [NameInMap("SupplyStatus")]
                        [Validation(Required=false)]
                        public string SupplyStatus { get; set; }

                    }

                }

                /// <summary>
                /// <para>The number of filed instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("TotalAmount")]
                [Validation(Required=false)]
                public int? TotalAmount { get; set; }

                /// <summary>
                /// <para>The number of consumed instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("UsedAmount")]
                [Validation(Required=false)]
                public int? UsedAmount { get; set; }

                /// <summary>
                /// <para>The ID of the zone where the filed resource resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of queried demands.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
