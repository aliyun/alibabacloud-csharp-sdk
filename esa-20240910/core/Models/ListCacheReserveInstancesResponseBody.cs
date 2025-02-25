// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCacheReserveInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>List of cache reserve instances.</para>
        /// </summary>
        [NameInMap("InstanceInfo")]
        [Validation(Required=false)]
        public List<ListCacheReserveInstancesResponseBodyInstanceInfo> InstanceInfo { get; set; }
        public class ListCacheReserveInstancesResponseBodyInstanceInfo : TeaModel {
            /// <summary>
            /// <para>Cache reserve capacity. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>512000</para>
            /// </summary>
            [NameInMap("CacheReserveCapacity")]
            [Validation(Required=false)]
            public long? CacheReserveCapacity { get; set; }

            /// <summary>
            /// <para>Cache reserve usage region.</para>
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
            /// <para>Instance purchase time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-12T05:41:51Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Duration of the instance purchase, unit: months.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>Instance expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-05T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-xcdn-96wblslz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Instance status. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: Normal service status.</description></item>
            /// <item><description><b>offline</b>: Expired but not overdue, in an unavailable state.</description></item>
            /// <item><description><b>disable</b>: Released status.</description></item>
            /// <item><description><b>overdue</b>: Overdue and suspended status.</description></item>
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
        /// <para>Page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, default <b>500</b>, range: <b>1~500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65C66B7B-671A-8297-9187-2R5477247B76</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Total pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
