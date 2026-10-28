// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetSpotPriceHistoryRequest : TeaModel {
        /// <summary>
        /// <para>The end time for querying the historical prices of spot instances. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. Default value: null, which indicates the current time.</para>
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
        /// <item><description>desc: descending order.</description></item>
        /// <item><description>asc: ascending order.</description></item>
        /// </list>
        /// <para>This parameter takes effect only when you query the historical prices of Lingjun instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <em><b>1</b></em>. This parameter takes effect only when you query the historical prices of Lingjun instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>. This parameter takes effect only when you query the historical prices of Lingjun instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field used for sorting. Default value: GmtCreatedTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtCreatedTime</description></item>
        /// </list>
        /// <para>This parameter takes effect only when you query the historical prices of Lingjun instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreatedTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The protection period of the spot instance. Unit: hours. Note that only ECS instance types support Settings for the protection period of spot instances. Default value: 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: After the spot instance is created, Alibaba Cloud ensures that the instance runs for 1 hour without automatic release. After 1 hour, the system automatically compares the bid price with the marketplace price and checks resource inventory to determine whether to retain or revoke the instance.</description></item>
        /// <item><description>0: After the spot instance is created, Alibaba Cloud does not guarantee that the instance runs for 1 hour. The system automatically compares the bid price with the marketplace price and checks resource inventory to determine whether to retain or revoke the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The start time for querying the historical prices of spot instances. The maximum value cannot exceed 7 days before the specified end time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. Default value: null, which indicates 3 days before the end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-26T09:36:46Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
