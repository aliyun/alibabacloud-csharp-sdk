// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CrawlerType : TeaModel {
        /// <summary>
        /// <para>The display name of the metadata crawler.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data Lake Formation</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The supported entity types. The entity types are sorted based on the declaration order.</para>
        /// </summary>
        [NameInMap("SupportedEntityTypes")]
        [Validation(Required=false)]
        public List<CrawlerTypeSupportedEntityTypes> SupportedEntityTypes { get; set; }
        public class CrawlerTypeSupportedEntityTypes : TeaModel {
            /// <summary>
            /// <para>Specifies whether the entity type is optional.</para>
            /// <para>For example, whether the schema level of the MaxCompute crawler type is optional depends on whether the three-layer model is enabled for a MaxCompute project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Optional")]
            [Validation(Required=false)]
            public bool? Optional { get; set; }

            /// <summary>
            /// <para>The subtype of the parent entity. If the subtype does not exist, null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database</para>
            /// </summary>
            [NameInMap("ParentSubType")]
            [Validation(Required=false)]
            public string ParentSubType { get; set; }

            /// <summary>
            /// <para>The identifier of the entity subtype. Valid values: <c>catalog, database, schema, table, and column</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table</para>
            /// </summary>
            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <para>The identifier of the entity type. The value of this parameter varies based on the type of the metadata crawler. Configure this parameter in the <c>${Crawler type}-${Subtype}</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dlf-table</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The identifier of the metadata crawler type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>maxcompute</c></description></item>
        /// <item><description><c>dlf</c></description></item>
        /// <item><description><c>hms</c>: This type of crawler can be used to collect metadata from E-MapReduce (EMR) and CDH Hive clusters.</description></item>
        /// <item><description><c>holo</c></description></item>
        /// <item><description><c>mysql</c></description></item>
        /// <item><description><c>oracle</c></description></item>
        /// <item><description><c>postgresql</c></description></item>
        /// <item><description><c>sqlserver</c></description></item>
        /// <item><description><c>analyticdb_for_mysql</c></description></item>
        /// <item><description><c>ads</c></description></item>
        /// <item><description><c>hybriddb_for_postgresql</c></description></item>
        /// <item><description><c>ots</c></description></item>
        /// <item><description><c>clickhouse</c></description></item>
        /// <item><description><c>starrocks</c>: This type of crawler can be used to query metadata entities only in internal catalogs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dlf</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
