// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListDDoSInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance details.</para>
        /// </summary>
        [NameInMap("InstanceInfo")]
        [Validation(Required=false)]
        public List<ListDDoSInstancesResponseBodyInstanceInfo> InstanceInfo { get; set; }
        public class ListDDoSInstancesResponseBodyInstanceInfo : TeaModel {
            /// <summary>
            /// <para>The creation time of the instance. The time is displayed in UTC and formatted in accordance with the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-01T07:59:07Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The specifications of the DDoS instance in the Chinese mainland.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn_300</para>
            /// </summary>
            [NameInMap("DDoSBurstableDomesticProtection")]
            [Validation(Required=false)]
            public string DDoSBurstableDomesticProtection { get; set; }

            /// <summary>
            /// <para>The specifications of the DDoS instance outside the Chinese mainland.</para>
            /// 
            /// <b>Example:</b>
            /// <para>overseas_300</para>
            /// </summary>
            [NameInMap("DDoSBurstableOverseasProtection")]
            [Validation(Required=false)]
            public string DDoSBurstableOverseasProtection { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-ddddxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The scheduled release time. The time is displayed in UTC and formatted in accordance with the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-25T16:00:00Z</para>
            /// </summary>
            [NameInMap("ReserveReleaseTime")]
            [Validation(Required=false)]
            public string ReserveReleaseTime { get; set; }

            /// <summary>
            /// <para>The ID of the associated website plan instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esa-site-b0s6kmx0r0n4</para>
            /// </summary>
            [NameInMap("SiteInstanceId")]
            [Validation(Required=false)]
            public string SiteInstanceId { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: the instance is in normal service status.</description></item>
            /// <item><description><b>offline</b>: the instance has expired but is not overdue, and is in an unavailable state.</description></item>
            /// <item><description><b>disable</b>: the instance is released.</description></item>
            /// <item><description><b>overdue</b>: the instance is stopped due to an overdue payment.</description></item>
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
        /// <para>The current page number, which is the same as the PageNumber request parameter.</para>
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
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F1DC265-BF10-5C9C-B607-760265C5F365</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
