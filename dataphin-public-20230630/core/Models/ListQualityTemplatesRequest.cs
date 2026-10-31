// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The paged query conditions.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListQualityTemplatesRequestListQuery ListQuery { get; set; }
        public class ListQualityTemplatesRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The rule types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CONSISTENT: Consistency.</description></item>
            /// <item><description>EFFECTIVE: Effectiveness.</description></item>
            /// <item><description>TIMELINESE: Timeliness.</description></item>
            /// <item><description>ACCURATE: Accuracy.</description></item>
            /// <item><description>UNIQUENESS: Uniqueness.</description></item>
            /// <item><description>COMPLETENESS: Completeness.</description></item>
            /// <item><description>STABILITY: Stability.</description></item>
            /// <item><description>CUSTOM: Custom.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("CatalogList")]
            [Validation(Required=false)]
            public List<string> CatalogList { get; set; }

            /// <summary>
            /// <para>Specifies whether the template is owned by the current user.</para>
            /// </summary>
            [NameInMap("CurrentUserOwned")]
            [Validation(Required=false)]
            public bool? CurrentUserOwned { get; set; }

            /// <summary>
            /// <para>The search keyword filter, which supports template names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
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
            /// <para>The number of entries per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The supported data source types, such as MAX_COMPUTE, MYSQL, and HIVE.</para>
            /// </summary>
            [NameInMap("SupportDataSourceTypeList")]
            [Validation(Required=false)]
            public List<string> SupportDataSourceTypeList { get; set; }

            /// <summary>
            /// <para>The template owners.</para>
            /// </summary>
            [NameInMap("TemplateOwnerList")]
            [Validation(Required=false)]
            public List<string> TemplateOwnerList { get; set; }

            /// <summary>
            /// <para>The template sources. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SYSTEM: System template.</description></item>
            /// <item><description>CUSTOM: Custom template.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("TemplateSourceList")]
            [Validation(Required=false)]
            public List<string> TemplateSourceList { get; set; }

            /// <summary>
            /// <para>The templatetype. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FIELD_NULL_VALUE_VALIDATE: Field null value check.</description></item>
            /// <item><description>FIELD_EMPTY_STRING_VALIDATE: Field empty character check.</description></item>
            /// <item><description>FIELD_UNIQUE_VALIDATE: Field uniqueness check.</description></item>
            /// <item><description>FIELD_GROUP_COUNT_VALIDATE: Field unique value count check.</description></item>
            /// <item><description>FIELD_DUPLICATE_VALUE_COUNT_VALIDATE: Field duplicate value count check.</description></item>
            /// <item><description>FUNCTION_TIME_COMPARE: Time function comparison.</description></item>
            /// <item><description>SINGLE_TABLE_TIME_COMPARE: Non-partitioned table time field comparison.</description></item>
            /// <item><description>DOUBLE_TABLE_TIME_COMPARE: Two-table time field comparison.</description></item>
            /// <item><description>FIELD_FORMAT_VALIDATE: Field format check.</description></item>
            /// <item><description>FIELD_LENGTH_VALIDATE: Field length check.</description></item>
            /// <item><description>FIELD_VALUE_RANGE_VALIDATE: Field value range check.</description></item>
            /// <item><description>CODE_TABLE_COMPARE: Lookup table reference comparison.</description></item>
            /// <item><description>STANDARD_CODE_TABLE_COMPARE: Data standard lookup table reference comparison.</description></item>
            /// <item><description>SINGLE_TABLE_FIELD_VALUE_COMPARE: Non-partitioned table field value consistency comparison.</description></item>
            /// <item><description>SINGLE_TABLE_FIELD_STATISTICAL_COMPARE: Non-partitioned table field statistical value consistency comparison.</description></item>
            /// <item><description>SINGLE_TABLE_FIELD_EXP_COMPARE: Non-partitioned table field business logic consistency comparison.</description></item>
            /// <item><description>DOUBLE_TABLE_FIELD_VALUE_COMPARE: Two-table field value consistency comparison.</description></item>
            /// <item><description>DOUBLE_TABLE_FIELD_STATISTICAL_COMPARE: Two-table field statistical value consistency comparison.</description></item>
            /// <item><description>CROSS_DOUBLE_TABLE_FIELD_STATISTICAL_COMPARE: Cross-source two-table field statistical value consistency comparison.</description></item>
            /// <item><description>DOUBLE_TABLE_FIELD_EXP_COMPARE: Two-table field business logic consistency comparison.</description></item>
            /// <item><description>TABLE_STABILITY_VALIDATE: Table stability check.</description></item>
            /// <item><description>TABLE_FLUCTUATION_VALIDATE: Table fluctuation check.</description></item>
            /// <item><description>FIELD_STABILITY_VALIDATE: Field stability check.</description></item>
            /// <item><description>FIELD_FLUCTUATION_VALIDATE: Field fluctuation check.</description></item>
            /// <item><description>CUSTOM_STATISTICAL_VALIDATE: Custom statistical metric check.</description></item>
            /// <item><description>CUSTOM_DATA_DETAILS_VALIDATE: Custom data details check.</description></item>
            /// <item><description>DATASOURCE_AVAILABLE_CHECK: Data source connectivity monitoring.</description></item>
            /// <item><description>TABLE_SCHEMA_CHECK: Table schema change monitoring.</description></item>
            /// <item><description>REAL_TIME_OFFLINE_COMPARE: Real-time and offline comparison.</description></item>
            /// <item><description>REAL_TIME_STATISTICAL_VALIDATE: Real-time statistical value monitoring.</description></item>
            /// <item><description>REAL_TIME_MULTI_CHAIN_COMPARE: Real-time multi-link comparison.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("TemplateTypeList")]
            [Validation(Required=false)]
            public List<string> TemplateTypeList { get; set; }

            /// <summary>
            /// <para>The monitored object types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TABLE: Dataphin table.</description></item>
            /// <item><description>DATASOURCE_TABLE: Global table.</description></item>
            /// <item><description>DATASOURCE: Data source.</description></item>
            /// <item><description>INDEX: Metric.</description></item>
            /// <item><description>REALTIME_LOGICAL_TABLE: Real-time metadata table.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("WatchTypeList")]
            [Validation(Required=false)]
            public List<string> WatchTypeList { get; set; }

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
        /// <para>The ID of the operator user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
