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
            /// <para>The rule type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CONSISTENT: consistency</description></item>
            /// <item><description>EFFECTIVE: validity</description></item>
            /// <item><description>TIMELINESE: timeliness</description></item>
            /// <item><description>ACCURATE: accuracy</description></item>
            /// <item><description>UNIQUENESS: uniqueness</description></item>
            /// <item><description>COMPLETENESS: completeness</description></item>
            /// <item><description>STABILITY: stability</description></item>
            /// <item><description>CUSTOM: custom.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("CatalogList")]
            [Validation(Required=false)]
            public List<string> CatalogList { get; set; }

            /// <summary>
            /// <para>Specifies whether to query only templates owned by the current user.</para>
            /// </summary>
            [NameInMap("CurrentUserOwned")]
            [Validation(Required=false)]
            public bool? CurrentUserOwned { get; set; }

            /// <summary>
            /// <para>The search keyword. Template name filtering is supported.</para>
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
            /// <para>The number of records per page. Default value: 20.</para>
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
            /// <para>The template source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SYSTEM: system template</description></item>
            /// <item><description>CUSTOM: custom template.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("TemplateSourceList")]
            [Validation(Required=false)]
            public List<string> TemplateSourceList { get; set; }

            /// <summary>
            /// <para>The templatetype. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FIELD_NULL_VALUE_VALIDATE: field null value check</description></item>
            /// <item><description>FIELD_EMPTY_STRING_VALIDATE: field empty character string check</description></item>
            /// <item><description>FIELD_UNIQUE_VALIDATE: field uniqueness check</description></item>
            /// <item><description>FIELD_GROUP_COUNT_VALIDATE: field unique value count check</description></item>
            /// <item><description>FIELD_DUPLICATE_VALUE_COUNT_VALIDATE: field duplicate value count check</description></item>
            /// <item><description>FUNCTION_TIME_COMPARE: time function comparison</description></item>
            /// <item><description>SINGLE_TABLE_TIME_COMPARE: non-partitioned table time field comparison</description></item>
            /// <item><description>DOUBLE_TABLE_TIME_COMPARE: two-table time field comparison</description></item>
            /// <item><description>FIELD_FORMAT_VALIDATE: field format check</description></item>
            /// <item><description>FIELD_LENGTH_VALIDATE: field length check</description></item>
            /// <item><description>FIELD_VALUE_RANGE_VALIDATE: field value range check</description></item>
            /// <item><description>CODE_TABLE_COMPARE: lookup table reference comparison</description></item>
            /// <item><description>STANDARD_CODE_TABLE_COMPARE: data standard lookup table reference comparison</description></item>
            /// <item><description>SINGLE_TABLE_FIELD_VALUE_COMPARE: non-partitioned table field value consistency comparison</description></item>
            /// <item><description>SINGLE_TABLE_FIELD_STATISTICAL_COMPARE: non-partitioned table field statistical value consistency comparison</description></item>
            /// <item><description>SINGLE_TABLE_FIELD_EXP_COMPARE: non-partitioned table field business logic consistency comparison</description></item>
            /// <item><description>DOUBLE_TABLE_FIELD_VALUE_COMPARE: two-table field value consistency comparison</description></item>
            /// <item><description>DOUBLE_TABLE_FIELD_STATISTICAL_COMPARE: two-table field statistical value consistency comparison</description></item>
            /// <item><description>CROSS_DOUBLE_TABLE_FIELD_STATISTICAL_COMPARE: cross-source two-table field statistical value consistency comparison</description></item>
            /// <item><description>DOUBLE_TABLE_FIELD_EXP_COMPARE: two-table field business logic consistency comparison</description></item>
            /// <item><description>TABLE_STABILITY_VALIDATE: table stability check</description></item>
            /// <item><description>TABLE_FLUCTUATION_VALIDATE: table fluctuation check</description></item>
            /// <item><description>FIELD_STABILITY_VALIDATE: field stability check</description></item>
            /// <item><description>FIELD_FLUCTUATION_VALIDATE: field fluctuation check</description></item>
            /// <item><description>CUSTOM_STATISTICAL_VALIDATE: custom statistical metric check</description></item>
            /// <item><description>CUSTOM_DATA_DETAILS_VALIDATE: custom data details check</description></item>
            /// <item><description>DATASOURCE_AVAILABLE_CHECK: data source connectivity monitoring</description></item>
            /// <item><description>TABLE_SCHEMA_CHECK: table schema change monitoring</description></item>
            /// <item><description>REAL_TIME_OFFLINE_COMPARE: real-time and offline comparison</description></item>
            /// <item><description>REAL_TIME_STATISTICAL_VALIDATE: real-time statistical value monitoring</description></item>
            /// <item><description>REAL_TIME_MULTI_CHAIN_COMPARE: real-time multi-link comparison.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("TemplateTypeList")]
            [Validation(Required=false)]
            public List<string> TemplateTypeList { get; set; }

            /// <summary>
            /// <para>The monitored object type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TABLE: Dataphin table</description></item>
            /// <item><description>DATASOURCE_TABLE: full-domain table</description></item>
            /// <item><description>DATASOURCE: data source</description></item>
            /// <item><description>INDEX: metric</description></item>
            /// <item><description>REALTIME_LOGICAL_TABLE: real-time meta table.</description></item>
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

    }

}
