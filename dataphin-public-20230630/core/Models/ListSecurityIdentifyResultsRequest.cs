// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListSecurityIdentifyResultsRequest : TeaModel {
        /// <summary>
        /// <para>The search criteria.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListSecurityIdentifyResultsRequestListQuery ListQuery { get; set; }
        public class ListSecurityIdentifyResultsRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The names of the business units.</para>
            /// </summary>
            [NameInMap("BizUnitNameList")]
            [Validation(Required=false)]
            public List<string> BizUnitNameList { get; set; }

            /// <summary>
            /// <para>The data classification ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClassifyId")]
            [Validation(Required=false)]
            public long? ClassifyId { get; set; }

            /// <summary>
            /// <para>The names of the data sources.</para>
            /// </summary>
            [NameInMap("DatasourceNameList")]
            [Validation(Required=false)]
            public List<string> DatasourceNameList { get; set; }

            /// <summary>
            /// <para>The environment identifier of the associated data source, project, or business unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>Specifies whether the item is locked.</para>
            /// </summary>
            [NameInMap("IsLocked")]
            [Validation(Required=false)]
            public bool? IsLocked { get; set; }

            /// <summary>
            /// <para>The keyword filter. Supports matching by table catalog, table name, Chinese table name, or field name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

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
            /// <para>The number of records per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The names of the projects.</para>
            /// </summary>
            [NameInMap("ProjectNameList")]
            [Validation(Required=false)]
            public List<string> ProjectNameList { get; set; }

            /// <summary>
            /// <para>The filter for the effective status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ENABLE: Enabled.</description></item>
            /// <item><description>DISABLE: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
