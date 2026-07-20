// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListBotInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instances that match the specified conditions under the current account.</para>
        /// </summary>
        [NameInMap("InstanceInfo")]
        [Validation(Required=false)]
        public List<ListBotInstancesResponseBodyInstanceInfo> InstanceInfo { get; set; }
        public class ListBotInstancesResponseBodyInstanceInfo : TeaModel {
            /// <summary>
            /// <para>The Bot protection instance level. If this parameter is empty, the plan does not include a Bot protection instance. If a value is returned, the plan includes a Bot protection instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enterprise_bot: web edition.</para>
            /// </description></item>
            /// <item><description><para>enterprise_bot_with_app: app edition.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enterprise_bot</para>
            /// </summary>
            [NameInMap("BotInstanceLevel")]
            [Validation(Required=false)]
            public string BotInstanceLevel { get; set; }

            /// <summary>
            /// <para>The time when the instance was purchased. The time is in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-12T05:41:51Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

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
            /// <para>The scheduled release time. The time is in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-25T16:00:00Z</para>
            /// </summary>
            [NameInMap("ReserveReleaseTime")]
            [Validation(Required=false)]
            public string ReserveReleaseTime { get; set; }

            /// <summary>
            /// <para>The ID of the associated site plan instance.</para>
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
            /// <item><description><b>online</b>: The instance is running normally.</description></item>
            /// <item><description><b>offline</b>: The instance has expired but has not exceeded the retention period and is unavailable.</description></item>
            /// <item><description><b>disable</b>: The instance has been released.</description></item>
            /// <item><description><b>overdue</b>: The instance has been stopped due to an overdue payment.</description></item>
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
        /// <para>509FD5AF-AB5B-55A9-9568-38D98668E3AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
