// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateSecurityIdentifyResultRequest : TeaModel {
        /// <summary>
        /// <para>The create request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateSecurityIdentifyResultRequestCreateCommand CreateCommand { get; set; }
        public class CreateSecurityIdentifyResultRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The classification ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClassifyId")]
            [Validation(Required=false)]
            public long? ClassifyId { get; set; }

            /// <summary>
            /// <para>The deduplication strategy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>COVER_ALL: overwrites all online tags.</description></item>
            /// <item><description>COVER_UNLOCKED: overwrites only unlocked online tags.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COVER_ALL</para>
            /// </summary>
            [NameInMap("ConflictStrategy")]
            [Validation(Required=false)]
            public string ConflictStrategy { get; set; }

            /// <summary>
            /// <para>The datasource environment identifier. This parameter is required only for datasource tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("DatasourceEnv")]
            [Validation(Required=false)]
            public string DatasourceEnv { get; set; }

            /// <summary>
            /// <para>The datasource name. This parameter is required only for datasource tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DatasourceName")]
            [Validation(Required=false)]
            public string DatasourceName { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.
            /// Default value: true.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The field name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>col1</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>Specifies whether the table is a datasource table. Default value: false (treated as a Dataphin table).</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDatasourceTable")]
            [Validation(Required=false)]
            public bool? IsDatasourceTable { get; set; }

            /// <summary>
            /// <para>The table catalog. For a datasource table, specify the database or schema name. For a Dataphin physical table, specify the project name in English. For a Dataphin logical table, specify the business unit name in English.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TableCatalog")]
            [Validation(Required=false)]
            public string TableCatalog { get; set; }

            /// <summary>
            /// <para>The table name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t_test</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

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
