// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCacheReserveInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The cache reserve instances.</para>
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
            public string CacheReserveCapacity { get; set; }

            /// <summary>
            /// <para>The region in which the cache reserve instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HK</para>
            /// </summary>
            [NameInMap("CacheReserveRegion")]
            [Validation(Required=false)]
            public string CacheReserveRegion { get; set; }

            /// <summary>
            /// <para>The time when the cache reserve instance was purchased.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-12T05:41:51Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The subscription period of the cache reserve instance. Unit: months.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The time when the cache reserve instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-05T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The ID of the cache reserve instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-xcdn-96wblslz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status of the cache reserve instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>online: The instance is in service.</description></item>
            /// <item><description>offline: The instance has expired within an allowable period. In this state, the plan is unavailable.</description></item>
            /// <item><description>disable: The instance is released.</description></item>
            /// <item><description>overdue: The service was stopped due to overdue payments.</description></item>
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
        /// <para>The number of entries per page. Default value: <b>500</b>. Valid values: <b>1 to 500</b>.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
