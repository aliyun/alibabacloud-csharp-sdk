// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ParseBatchTaskDependencyRequest : TeaModel {
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
        /// <para>The parse request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ParseCommand")]
        [Validation(Required=false)]
        public ParseBatchTaskDependencyRequestParseCommand ParseCommand { get; set; }
        public class ParseBatchTaskDependencyRequestParseCommand : TeaModel {
            /// <summary>
            /// <para>The SQL code to be parsed.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select * from t_test limit 1;</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The catalog for a database SQL node. This parameter takes effect only for data source types that require a catalog, such as Presto.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql_catalog</para>
            /// </summary>
            [NameInMap("DataSourceCatalog")]
            [Validation(Required=false)]
            public string DataSourceCatalog { get; set; }

            /// <summary>
            /// <para>The data source ID for a database SQL node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12131111</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

            /// <summary>
            /// <para>The schema for a database SQL node. This parameter takes effect only for data source types that require a schema, such as Oracle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>erp</para>
            /// </summary>
            [NameInMap("DataSourceSchema")]
            [Validation(Required=false)]
            public string DataSourceSchema { get; set; }

            /// <summary>
            /// <para>Specifies whether to include dependency information for input tables that have no corresponding nodes. Default value: false.</para>
            /// </summary>
            [NameInMap("IncludeAllInputTables")]
            [Validation(Required=false)]
            public bool? IncludeAllInputTables { get; set; }

            /// <summary>
            /// <para>Specifies whether to query data lineage when querying upstream dependencies. Default value: false.</para>
            /// </summary>
            [NameInMap("NeedQueryLineages")]
            [Validation(Required=false)]
            public bool? NeedQueryLineages { get; set; }

            /// <summary>
            /// <para>The node type, such as MAX_COMPUTE_SQL.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute_SQL</para>
            /// </summary>
            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131211211</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

    }

}
