// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataServiceApiCallStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>Search conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListDataServiceApiCallStatisticsRequestListQuery ListQuery { get; set; }
        public class ListDataServiceApiCallStatisticsRequestListQuery : TeaModel {
            /// <summary>
            /// <para>End time. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 20:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Search keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>Sort column. Valid values: CALL_COUNT (call count), ERROR_COUNT (error count), ERROR_RATE (error rate), AVG_RESPONSE_TIME (average response time), and OFFLINE_RATE (offline percentage). Default value: CALL_COUNT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CALL_COUNT</para>
            /// </summary>
            [NameInMap("OrderColumn")]
            [Validation(Required=false)]
            public string OrderColumn { get; set; }

            /// <summary>
            /// <para>Sort order. Valid values: 1 (ascending) and 2 (descending). Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public int? OrderType { get; set; }

            /// <summary>
            /// <para>Page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>Number of entries per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Start time. Format: yyyy-MM-dd HH:mm:ss.</para>
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
        /// <para>Tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>Data service project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102102</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public int? ProjectId { get; set; }

    }

}
