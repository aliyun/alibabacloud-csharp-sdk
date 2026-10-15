// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAvailableInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAvailableInstancesResponseBodyData Data { get; set; }
        public class QueryAvailableInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of instance information.</para>
            /// </summary>
            [NameInMap("InstanceList")]
            [Validation(Required=false)]
            public List<QueryAvailableInstancesResponseBodyDataInstanceList> InstanceList { get; set; }
            public class QueryAvailableInstancesResponseBodyDataInstanceList : TeaModel {
                /// <summary>
                /// <para>The creation time. The time is in the ISO 8601 standard in the UTC format (YYYY-MM-DDTHH:mm:ssZ).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The end time. The time is in the ISO 8601 standard in the UTC format (YYYY-MM-DDTHH:mm:ssZ).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The expected release time. The time is in the ISO 8601 standard in the UTC format (YYYY-MM-DDTHH:mm:ssZ).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("ExpectedReleaseTime")]
                [Validation(Required=false)]
                public string ExpectedReleaseTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1049056</para>
                /// </summary>
                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }

                /// <summary>
                /// <para>The owner ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>325352345</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// <para>The product code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>The product type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The release time. The time is in the ISO 8601 standard in the UTC format (YYYY-MM-DDTHH:mm:ssZ).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

                /// <summary>
                /// <para>The renewal status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AutoRenewal: auto-renewal.</description></item>
                /// <item><description>ManualRenewal: manual renewal.</description></item>
                /// <item><description>NotRenewal: no renewal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ManualRenewal</para>
                /// </summary>
                [NameInMap("RenewStatus")]
                [Validation(Required=false)]
                public string RenewStatus { get; set; }

                /// <summary>
                /// <para>The number of auto-renewal epochs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RenewalDuration")]
                [Validation(Required=false)]
                public int? RenewalDuration { get; set; }

                /// <summary>
                /// <para>The unit of the auto-renewal epoch. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>M: month.</description></item>
                /// <item><description>Y: year.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>M</para>
                /// </summary>
                [NameInMap("RenewalDurationUnit")]
                [Validation(Required=false)]
                public string RenewalDurationUnit { get; set; }

                /// <summary>
                /// <para>The seller.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123123</para>
                /// </summary>
                [NameInMap("Seller")]
                [Validation(Required=false)]
                public string Seller { get; set; }

                /// <summary>
                /// <para>The seller ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123123</para>
                /// </summary>
                [NameInMap("SellerId")]
                [Validation(Required=false)]
                public long? SellerId { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Creating - The resource is being created.
                /// WaitForExpire - The service is about to be suspended.
                /// Normal - Normal.
                /// Expired - The service is suspended</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The stop time. The time is in the ISO 8601 standard in the UTC format (YYYY-MM-DDTHH:mm:ssZ).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                /// <summary>
                /// <para>The sub-status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal - The pay-as-you-go module is normal.
                /// WaitForLimit - The pay-as-you-go module is about to be restricted due to overdue payments.
                /// BandwidthLimited - The pay-as-you-go module is restricted due to overdue payments</para>
                /// </summary>
                [NameInMap("SubStatus")]
                [Validation(Required=false)]
                public string SubStatus { get; set; }

                /// <summary>
                /// <para>The subscription type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Subscription: subscription.</description></item>
                /// <item><description>PayAsYouGo: pay-as-you-go.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Subscription</para>
                /// </summary>
                [NameInMap("SubscriptionType")]
                [Validation(Required=false)]
                public string SubscriptionType { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

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
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7C15585-8349-4C62-BEE4-5A391841B9BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
