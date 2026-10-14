// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListTablesRequest : TeaModel {
        /// <summary>
        /// <para>The paged query conditions.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListTablesRequestListQuery ListQuery { get; set; }
        public class ListTablesRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The asset catalog: project name and business unit name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LD_test01_dev</para>
            /// </summary>
            [NameInMap("Catalog")]
            [Validation(Required=false)]
            public string Catalog { get; set; }

            /// <summary>
            /// <para>The supported keyword: table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The ID of the owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

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
            /// <para>The table types. If you do not specify this parameter or pass an empty list, all table types are queried. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PHYSICAL_TABLE: Physical table of the compute source.</description></item>
            /// <item><description>PHYSICAL_VIEW: View of the compute source.</description></item>
            /// <item><description>PHYSICAL_MATERIALIZED_VIEW: Materialized view of the compute source.</description></item>
            /// <item><description>STREAM_TABLE: Meta table.</description></item>
            /// <item><description>MIRROR_TABLE: Mirror table.</description></item>
            /// <item><description>DIM: Logical dimension table.</description></item>
            /// <item><description>FACT: Logical fact table.</description></item>
            /// <item><description>SUM_BIZ_UNIT: Logical aggregate table.</description></item>
            /// <item><description>LOGIC_VIEW: Logical view.</description></item>
            /// <item><description>DATASOURCE_TABLE: Data source table.</description></item>
            /// <item><description>DATASOURCE_VIEW: Data source view.</description></item>
            /// <item><description>DATASOURCE_MATERIALIZED_VIEW: Data source materialized view.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SubTypes")]
            [Validation(Required=false)]
            public List<string> SubTypes { get; set; }

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

    }

}
