// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListDDoSInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Instance details</para>
        /// </summary>
        [NameInMap("InstanceInfo")]
        [Validation(Required=false)]
        public List<ListDDoSInstancesResponseBodyInstanceInfo> InstanceInfo { get; set; }
        public class ListDDoSInstancesResponseBodyInstanceInfo : TeaModel {
            /// <summary>
            /// <para>Time when the instance was purchased</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-01T07:59:07Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>DDoS protection specification for the Chinese mainland</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn_300</para>
            /// </summary>
            [NameInMap("DDoSBurstableDomesticProtection")]
            [Validation(Required=false)]
            public string DDoSBurstableDomesticProtection { get; set; }

            /// <summary>
            /// <para>DDoS protection specification for regions outside the Chinese mainland</para>
            /// 
            /// <b>Example:</b>
            /// <para>overseas_300</para>
            /// </summary>
            [NameInMap("DDoSBurstableOverseasProtection")]
            [Validation(Required=false)]
            public string DDoSBurstableOverseasProtection { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-ddddxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Scheduled release time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-25T16:00:00Z</para>
            /// </summary>
            [NameInMap("ReserveReleaseTime")]
            [Validation(Required=false)]
            public string ReserveReleaseTime { get; set; }

            /// <summary>
            /// <para>Associated site package instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>esa-site-b0s6kmx0r0n4</para>
            /// </summary>
            [NameInMap("SiteInstanceId")]
            [Validation(Required=false)]
            public string SiteInstanceId { get; set; }

            /// <summary>
            /// <para>Instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>online</b>: Normal service status.</para>
            /// </description></item>
            /// <item><description><para><b>offline</b>: Expired but not overdue. Instance is unavailable.</para>
            /// </description></item>
            /// <item><description><para><b>disable</b>: Released.</para>
            /// </description></item>
            /// <item><description><para><b>overdue</b>: Service suspended due to overdue payment.</para>
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
        /// <para>Page number. Default: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of entries per page</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F1DC265-BF10-5C9C-B607-760265C5F365</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of entries</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Total number of pages</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
