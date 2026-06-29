// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListResourcePermissionOperationLogRequest : TeaModel {
        /// <summary>
        /// <para>The paged request parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListResourcePermissionOperationLogRequestListQuery ListQuery { get; set; }
        public class ListResourcePermissionOperationLogRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The search keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx测试</para>
            /// </summary>
            [NameInMap("SearchText")]
            [Validation(Required=false)]
            public string SearchText { get; set; }

            /// <summary>
            /// <para>The tab name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TABLE: table</description></item>
            /// <item><description>DATASOURCE: datasource.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("TabType")]
            [Validation(Required=false)]
            public string TabType { get; set; }

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

    }

}
