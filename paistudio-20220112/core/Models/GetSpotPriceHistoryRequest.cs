// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetSpotPriceHistoryRequest : TeaModel {
        /// <summary>
        /// <para>The end time for querying historical spot instance prices. Specify the time in ISO 8601 format using UTC+0, as yyyy-MM-ddTHH:mm:ssZ. Default value: empty. An empty value means the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-30T09:36:46Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: asc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>desc: descending order.</para>
        /// </description></item>
        /// <item><description><para>asc: ascending order.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter applies only when you query historical prices for Lingjun instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number of the current page. Default value: <em><b>1</b></em>. This parameter applies only when you query historical prices for Lingjun instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>. This parameter applies only when you query historical prices for Lingjun instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field to sort by. Default value: GmtCreatedTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtCreatedTime</description></item>
        /// </list>
        /// <para>This parameter applies only when you query historical prices for Lingjun instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreatedTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The retention period for the spot instance, in hours. Note that only ECS instance types support this parameter. Default value: 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: Alibaba Cloud guarantees that the instance runs for at least one hour after creation. After one hour, the system compares your bid price with the current market price and checks resource inventory to decide whether to retain or revoke the instance.</para>
        /// </description></item>
        /// <item><description><para>0: Alibaba Cloud does not guarantee one-hour runtime. The system compares your bid price with the current market price and checks resource inventory to decide whether to retain or revoke the instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The start time for querying historical spot instance prices. This time must be no more than seven days before the end time. Specify the time in ISO 8601 format using UTC+0, as yyyy-MM-ddTHH:mm:ssZ. Default value: empty. An empty value means three days before the end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-26T09:36:46Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
