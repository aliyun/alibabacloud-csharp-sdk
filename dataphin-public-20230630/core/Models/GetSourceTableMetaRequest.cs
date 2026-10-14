// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetSourceTableMetaRequest : TeaModel {
        /// <summary>
        /// <para>The request context.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public GetSourceTableMetaRequestContext Context { get; set; }
        public class GetSourceTableMetaRequestContext : TeaModel {
            /// <summary>
            /// <para>The current operation environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEV: development environment.</description></item>
            /// <item><description>PROD: production environment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The ID of the project to which the integration pipeline task belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

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
        /// <para>The query conditions for the integration source table.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public GetSourceTableMetaRequestQuery Query { get; set; }
        public class GetSourceTableMetaRequestQuery : TeaModel {
            /// <summary>
            /// <para>The catalog name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hive_catalog</para>
            /// </summary>
            [NameInMap("Catalog")]
            [Validation(Required=false)]
            public string Catalog { get; set; }

            /// <summary>
            /// <para>The identifier of the data source or compute source. If QueryMode is set to DATA_SOURCE, specify the physical data source ID. If QueryMode is set to PROJECT_COMPUTE_SOURCE, specify the data source ID bound to the compute source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The query mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DATA_SOURCE: physical data source. This is the default value. It includes direct queries and automatic routing of external data source metadata.</description></item>
            /// <item><description>PROJECT_COMPUTE_SOURCE: tables under the project or compute source. The data source is parsed based on the compute source of the project specified by Context.ProjectId.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_SOURCE</para>
            /// </summary>
            [NameInMap("QueryMode")]
            [Validation(Required=false)]
            public string QueryMode { get; set; }

            /// <summary>
            /// <para>The schema name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The table name. The schema.table format is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ods_user_info</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

    }

}
