// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCacheReserveInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cache reserve instances.</para>
        /// </summary>
        [NameInMap("InstanceInfo")]
        [Validation(Required=false)]
        public List<ListCacheReserveInstancesResponseBodyInstanceInfo> InstanceInfo { get; set; }
        public class ListCacheReserveInstancesResponseBodyInstanceInfo : TeaModel {
            /// <summary>
            /// <para>The capacity of the cache reserve instance. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>512000</para>
            /// </summary>
            [NameInMap("CacheReserveCapacity")]
            [Validation(Required=false)]
            public long? CacheReserveCapacity { get; set; }

            /// <summary>
            /// <para>The region where the cache reserve instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HK</para>
            /// </summary>
            [NameInMap("CacheReserveRegion")]
            [Validation(Required=false)]
            public string CacheReserveRegion { get; set; }

            /// <summary>
            /// <para>The billing type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PREPAY: subscription.</description></item>
            /// <item><description>POSTPAY: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The creation time of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-12T05:41:51Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The subscription duration of the instance. Unit: months.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The time when the instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-05T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-xcdn-96wblslz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: The instance is running normally.</description></item>
            /// <item><description><b>offline</b>: The instance has expired but has not exceeded the retention period and is unavailable.</description></item>
            /// <item><description><b>disable</b>: The instance has been released.</description></item>
            /// <item><description><b>overdue</b>: The instance is stopped due to an overdue payment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>500</b>. Valid values: <b>1</b> to <b>500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65C66B7B-671A-8297-9187-2R5477247B76</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
