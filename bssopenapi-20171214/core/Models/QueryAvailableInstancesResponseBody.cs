// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAvailableInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAvailableInstancesResponseBodyData Data { get; set; }
        public class QueryAvailableInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The instances returned.</para>
            /// </summary>
            [NameInMap("InstanceList")]
            [Validation(Required=false)]
            public List<QueryAvailableInstancesResponseBodyDataInstanceList> InstanceList { get; set; }
            public class QueryAvailableInstancesResponseBodyDataInstanceList : TeaModel {
                /// <summary>
                /// <para>The time when the specified instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the instance was expired.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The time when the specified instance was expected to be released.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("ExpectedReleaseTime")]
                [Validation(Required=false)]
                public string ExpectedReleaseTime { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1049056</para>
                /// </summary>
                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }

                /// <summary>
                /// <para>The ID of the instance owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>325352345</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// <para>The code of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>The type of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The time when the instance was released.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

                /// <summary>
                /// <para>The renewal status of the specified instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AutoRenewal: The instance is automatically renewed.</description></item>
                /// <item><description>ManualRenewal: The instance is manually renewed.</description></item>
                /// <item><description>NotRenewal: The instance is not renewed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ManualRenewal</para>
                /// </summary>
                [NameInMap("RenewStatus")]
                [Validation(Required=false)]
                public string RenewStatus { get; set; }

                /// <summary>
                /// <para>The number of auto-renewal cycles.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RenewalDuration")]
                [Validation(Required=false)]
                public int? RenewalDuration { get; set; }

                /// <summary>
                /// <para>The unit of the auto-renewal cycle. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>M: month</description></item>
                /// <item><description>Y: year</description></item>
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
                /// <para>The ID of the seller.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123123</para>
                /// </summary>
                [NameInMap("SellerId")]
                [Validation(Required=false)]
                public long? SellerId { get; set; }

                /// <summary>
                /// <para>The status of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Creating: The instance is being created. WaitForExpire: The instance is about to expire. Normal: The instance can properly run. Expired: The instance is expired.</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the specified instance was suspended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                /// <summary>
                /// <para>The sub-status of the specified instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal: The pay-as-you-go module can properly run. WaitForLimit: The pay-as-you-go module is about to be limited due to overdue payments. BandwidthLimited: The pay-as-you-go module is limited due to overdue payments.</para>
                /// </summary>
                [NameInMap("SubStatus")]
                [Validation(Required=false)]
                public string SubStatus { get; set; }

                /// <summary>
                /// <para>The billing method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Subscription: subscription</description></item>
                /// <item><description>PayAsYouGo: pay-as-you-go</description></item>
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
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
