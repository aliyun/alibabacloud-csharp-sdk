// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paged query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListQualityTemplatesResponseBodyPageResult PageResult { get; set; }
        public class ListQualityTemplatesResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The paged list of quality templates.</para>
            /// </summary>
            [NameInMap("QualityTemplateList")]
            [Validation(Required=false)]
            public List<ListQualityTemplatesResponseBodyPageResultQualityTemplateList> QualityTemplateList { get; set; }
            public class ListQualityTemplatesResponseBodyPageResultQualityTemplateList : TeaModel {
                /// <summary>
                /// <para>The template category. Valid values:</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>CONSISTENT</para>
                /// </summary>
                [NameInMap("Catalog")]
                [Validation(Required=false)]
                public string Catalog { get; set; }

                /// <summary>
                /// <para>The display name of the template category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Consistency</para>
                /// </summary>
                [NameInMap("CatalogName")]
                [Validation(Required=false)]
                public string CatalogName { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The user ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The description of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The key-value pairs for rule configuration.</para>
                /// </summary>
                [NameInMap("FormPropertyList")]
                [Validation(Required=false)]
                public List<ListQualityTemplatesResponseBodyPageResultQualityTemplateListFormPropertyList> FormPropertyList { get; set; }
                public class ListQualityTemplatesResponseBodyPageResultQualityTemplateListFormPropertyList : TeaModel {
                    /// <summary>
                    /// <para>The type of the control.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>expression</para>
                    /// </summary>
                    [NameInMap("ComponentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    /// <summary>
                    /// <para>The name of the property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>col</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value of the property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the template is a system template.</para>
                /// </summary>
                [NameInMap("IsSystemTemplate")]
                [Validation(Required=false)]
                public bool? IsSystemTemplate { get; set; }

                /// <summary>
                /// <para>The user ID of the last updater.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <para>The name of the last updater.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ModifierName")]
                [Validation(Required=false)]
                public string ModifierName { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The name of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The user ID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The name of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                /// <summary>
                /// <para>Indicates whether all data source types are supported.</para>
                /// </summary>
                [NameInMap("SupportAllDataSourceType")]
                [Validation(Required=false)]
                public bool? SupportAllDataSourceType { get; set; }

                /// <summary>
                /// <para>The specific data source types that are supported, such as MySQL, Oracle, Microsoft SQL Server, MaxCompute, and Hive.</para>
                /// </summary>
                [NameInMap("SupportDataSourceTypeList")]
                [Validation(Required=false)]
                public List<string> SupportDataSourceTypeList { get; set; }

                /// <summary>
                /// <para>The template type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>FIELD_NULL_VALUE_VALIDATE: Field null value check.</description></item>
                /// <item><description>FIELD_EMPTY_STRING_VALIDATE: Field empty string check.</description></item>
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
                /// <item><description>DATASOURCE_AVAILABLE_CHECK: Data source connectivity check.</description></item>
                /// <item><description>TABLE_SCHEMA_CHECK: Table schema change check.</description></item>
                /// <item><description>REAL_TIME_OFFLINE_COMPARE: Real-time and offline comparison.</description></item>
                /// <item><description>REAL_TIME_STATISTICAL_VALIDATE: Real-time statistical value check.</description></item>
                /// <item><description>REAL_TIME_MULTI_CHAIN_COMPARE: Real-time multi-link comparison.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FIELD_NULL_VALUE_VALIDATE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The display name of the template type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Field null value check</para>
                /// </summary>
                [NameInMap("TypeName")]
                [Validation(Required=false)]
                public string TypeName { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
