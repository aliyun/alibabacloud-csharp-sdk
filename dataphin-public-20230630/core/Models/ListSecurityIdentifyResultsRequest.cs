// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListSecurityIdentifyResultsRequest : TeaModel {
        /// <summary>
        /// <para>Query conditions.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListSecurityIdentifyResultsRequestListQuery ListQuery { get; set; }
        public class ListSecurityIdentifyResultsRequestListQuery : TeaModel {
            /// <summary>
            /// <para>Business unit names.</para>
            /// </summary>
            [NameInMap("BizUnitNameList")]
            [Validation(Required=false)]
            public List<string> BizUnitNameList { get; set; }

            /// <summary>
            /// <para>Data classification ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClassifyId")]
            [Validation(Required=false)]
            public long? ClassifyId { get; set; }

            /// <summary>
            /// <para>Data source names.</para>
            /// </summary>
            [NameInMap("DatasourceNameList")]
            [Validation(Required=false)]
            public List<string> DatasourceNameList { get; set; }

            /// <summary>
            /// <para>Environment identifier of the data source, project, or business unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>Whether it is locked.</para>
            /// </summary>
            [NameInMap("IsLocked")]
            [Validation(Required=false)]
            public bool? IsLocked { get; set; }

            /// <summary>
            /// <para>Keyword filter. Supports matching by table catalog, table name, table display name, and field name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

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
            /// <para>Number of records per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Project names.</para>
            /// </summary>
            [NameInMap("ProjectNameList")]
            [Validation(Required=false)]
            public List<string> ProjectNameList { get; set; }

            /// <summary>
            /// <para>Effective status filter: ENABLE or DISABLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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

    }

}
