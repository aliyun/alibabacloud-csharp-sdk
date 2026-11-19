// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetTableColumnLineageByTaskIdRequest : TeaModel {
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
        /// <para>The data structure used to query table column lineage.</para>
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
            /// <para>The environment to which the node belongs, such as DEV or PROD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("TaskEnv")]
            [Validation(Required=false)]
            public string TaskEnv { get; set; }

            /// <summary>
            /// <para>The ID of the node used to filter the query.</para>
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
