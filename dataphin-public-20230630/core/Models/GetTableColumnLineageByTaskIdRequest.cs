// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetTableColumnLineageByTaskIdRequest : TeaModel {
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
        /// <para>Data structure for querying table column lineage.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TableColumnLineageByTaskIdQuery")]
        [Validation(Required=false)]
        public GetTableColumnLineageByTaskIdRequestTableColumnLineageByTaskIdQuery TableColumnLineageByTaskIdQuery { get; set; }
        public class GetTableColumnLineageByTaskIdRequestTableColumnLineageByTaskIdQuery : TeaModel {
            /// <summary>
            /// <para>Specifies whether to return tables that do not exist in the asset inventory. If this parameter is not specified, non-existent tables are not returned.</para>
            /// </summary>
            [NameInMap("NeedNotExistObject")]
            [Validation(Required=false)]
            public bool? NeedNotExistObject { get; set; }

            /// <summary>
            /// <para>Environment of the task to query: DEV or PROD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("TaskEnv")]
            [Validation(Required=false)]
            public string TaskEnv { get; set; }

            /// <summary>
            /// <para>Task (node) ID used to filter the query.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_123</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
