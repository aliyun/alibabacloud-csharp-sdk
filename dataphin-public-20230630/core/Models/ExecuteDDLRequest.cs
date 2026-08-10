// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ExecuteDDLRequest : TeaModel {
        /// <summary>
        /// <para>The request context information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public ExecuteDDLRequestContext Context { get; set; }
        public class ExecuteDDLRequestContext : TeaModel {
            /// <summary>
            /// <para>The current operating environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEV: development environment.</description></item>
            /// <item><description>PROD: production environment.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The ID of the project to which the integration pipeline task belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>The one-click table creation parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DDLCommand")]
        [Validation(Required=false)]
        public ExecuteDDLRequestDDLCommand DDLCommand { get; set; }
        public class ExecuteDDLRequestDDLCommand : TeaModel {
            /// <summary>
            /// <para>The identifier of the data source, compute source, or dataset used for table creation.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DatasourceId")]
            [Validation(Required=false)]
            public ExecuteDDLRequestDDLCommandDatasourceId DatasourceId { get; set; }
            public class ExecuteDDLRequestDDLCommandDatasourceId : TeaModel {
                /// <summary>
                /// <para>The catalog of the data source or compute cluster. This parameter is required only in OneCatalog scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dummy_cdm_dev</para>
                /// </summary>
                [NameInMap("Catalog")]
                [Validation(Required=false)]
                public string Catalog { get; set; }

                /// <summary>
                /// <para>The data source category. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DATA_SOURCE: physical data source.</description></item>
                /// <item><description>PROJECT_COMPUTE_SOURCE: compute source bound to a project.</description></item>
                /// <item><description>ONE_CATALOG: compute source or data source in multi-engine mode (OneCatalog).</description></item>
                /// <item><description>DATA_SET: dataset.</description></item>
                /// </list>
                /// <para>This parameter is optional. The system automatically infers the category based on other fields if this parameter is not specified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_SOURCE</para>
                /// </summary>
                [NameInMap("DsCategory")]
                [Validation(Required=false)]
                public string DsCategory { get; set; }

                /// <summary>
                /// <para>The ID of the data source, compute source, or dataset. This parameter is optional when DsCategory is set to PROJECT_COMPUTE_SOURCE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("DsId")]
                [Validation(Required=false)]
                public string DsId { get; set; }

                /// <summary>
                /// <para>The environment. Valid values:</para>
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
                /// <para>The catalog type when DsCategory is set to ONE_CATALOG. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>COMPUTE_CLUSTER: compute cluster.</description></item>
                /// <item><description>DATA_SOURCE: physical data source.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COMPUTE_CLUSTER</para>
                /// </summary>
                [NameInMap("OneCatalogType")]
                [Validation(Required=false)]
                public string OneCatalogType { get; set; }

                /// <summary>
                /// <para>The ID of the project bound to the compute source. This parameter is required only when DsCategory is set to PROJECT_COMPUTE_SOURCE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The dataset version. This parameter is required only when DsCategory is set to DATA_SET.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The DDL statement for table creation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE TABLE test (id bigint)</para>
            /// </summary>
            [NameInMap("Ddl")]
            [Validation(Required=false)]
            public string Ddl { get; set; }

            /// <summary>
            /// <para>Specifies whether to drop the table if it already exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DropTable")]
            [Validation(Required=false)]
            public bool? DropTable { get; set; }

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
