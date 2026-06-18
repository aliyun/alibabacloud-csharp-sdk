// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCacheReserveInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of cache reserve instances.</para>
        /// </summary>
        [NameInMap("InstanceInfo")]
        [Validation(Required=false)]
        public List<ListCacheReserveInstancesResponseBodyInstanceInfo> InstanceInfo { get; set; }
        public class ListCacheReserveInstancesResponseBodyInstanceInfo : TeaModel {
            /// <summary>
            /// <para>The cache reserve capacity, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>512000</para>
            /// </summary>
            [NameInMap("CacheReserveCapacity")]
            [Validation(Required=false)]
            public long? CacheReserveCapacity { get; set; }

            /// <summary>
            /// <para>The region where the cache reserve instance is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HK</para>
            /// </summary>
            [NameInMap("CacheReserveRegion")]
            [Validation(Required=false)]
            public string CacheReserveRegion { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-12T05:41:51Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The purchase duration of the instance, in months.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The expiration time of the instance.</para>
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
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>online</b>: The instance is running normally.</para>
            /// </description></item>
            /// <item><description><para><b>offline</b>: The instance has expired and is unavailable but remains within the grace period.</para>
            /// </description></item>
            /// <item><description><para><b>disable</b>: The instance is disabled.</para>
            /// </description></item>
            /// <item><description><para><b>overdue</b>: The instance is suspended due to an overdue payment.</para>
            /// </description></item>
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
        /// <para>The page number of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
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
