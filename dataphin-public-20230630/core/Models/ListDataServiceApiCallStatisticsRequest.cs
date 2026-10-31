// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataServiceApiCallStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The search conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListDataServiceApiCallStatisticsRequestListQuery ListQuery { get; set; }
        public class ListDataServiceApiCallStatisticsRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The end time. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 20:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The search keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The column by which to sort the results. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CALL_COUNT: the number of calls.</description></item>
            /// <item><description>ERROR_COUNT: the number of exceptions.</description></item>
            /// <item><description>ERROR_RATE: the error rate.</description></item>
            /// <item><description>AVG_RESPONSE_TIME: the average response time.</description></item>
            /// <item><description>OFFLINE_RATE: the offline percentage.
            /// Default value: CALL_COUNT.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CALL_COUNT</para>
            /// </summary>
            [NameInMap("OrderColumn")]
            [Validation(Required=false)]
            public string OrderColumn { get; set; }

            /// <summary>
            /// <para>The sort order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: ascending order.</description></item>
            /// <item><description>2: descending order.
            /// Default value: 1.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public int? OrderType { get; set; }

            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The start time. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 08:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The data service project ID.</para>
        /// <remarks>
        /// <para>If this parameter is not specified:</para>
        /// <list type="bullet">
        /// <item><description>Super administrators can query data of all service projects.</description></item>
        /// <item><description>Users other than super administrators can query data of service projects where they have the service project administrator or O&amp;M user permissions.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>102102</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public int? ProjectId { get; set; }

    }

}
