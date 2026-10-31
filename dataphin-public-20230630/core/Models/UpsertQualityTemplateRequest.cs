// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpsertQualityTemplateRequest : TeaModel {
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
        /// <para>The upsert command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpsertCommand")]
        [Validation(Required=false)]
        public UpsertQualityTemplateRequestUpsertCommand UpsertCommand { get; set; }
        public class UpsertQualityTemplateRequestUpsertCommand : TeaModel {
            /// <summary>
            /// <para>The category of the template. Valid values: CONSISTENT (consistency), EFFECTIVE (effectiveness), TIMELINESE (timeliness), ACCURATE (accuracy), UNIQUENESS (uniqueness), COMPLETENESS (completeness), STABILITY (stability), and CUSTOM (custom).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONSISTENT</para>
            /// </summary>
            [NameInMap("Catalog")]
            [Validation(Required=false)]
            public string Catalog { get; set; }

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
            public List<UpsertQualityTemplateRequestUpsertCommandFormPropertyList> FormPropertyList { get; set; }
            public class UpsertQualityTemplateRequestUpsertCommandFormPropertyList : TeaModel {
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
            /// <para>The template ID. If this parameter is specified, the template is updated. If this parameter is not specified, a new template is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the template owner.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The supported data source types, such as MySQL, Oracle, Microsoft SQL Server, MaxCompute, and Hive.</para>
            /// </summary>
            [NameInMap("SupportDataSourceTypeList")]
            [Validation(Required=false)]
            public List<string> SupportDataSourceTypeList { get; set; }

            /// <summary>
            /// <para>The templatetype. Valid values: FIELD_NULL_VALUE_VALIDATE (field null value check), FIELD_EMPTY_STRING_VALIDATE (field empty character check), FIELD_UNIQUE_VALIDATE (field uniqueness check), FIELD_GROUP_COUNT_VALIDATE (field unique value count check), FIELD_DUPLICATE_VALUE_COUNT_VALIDATE (field duplicate value count check), FUNCTION_TIME_COMPARE (time function comparison), SINGLE_TABLE_TIME_COMPARE (non-partitioned table time field comparison), DOUBLE_TABLE_TIME_COMPARE (two-table time field comparison), FIELD_FORMAT_VALIDATE (field format check), FIELD_LENGTH_VALIDATE (field length check), FIELD_VALUE_RANGE_VALIDATE (field value range check), CODE_TABLE_COMPARE (lookup table reference comparison), STANDARD_CODE_TABLE_COMPARE (data standard lookup table reference comparison), SINGLE_TABLE_FIELD_VALUE_COMPARE (non-partitioned table field value consistency comparison), SINGLE_TABLE_FIELD_STATISTICAL_COMPARE (non-partitioned table field statistical value consistency comparison), SINGLE_TABLE_FIELD_EXP_COMPARE (non-partitioned table field business logic consistency comparison), DOUBLE_TABLE_FIELD_VALUE_COMPARE (two-table field value consistency comparison), DOUBLE_TABLE_FIELD_STATISTICAL_COMPARE (two-table field statistical value consistency comparison), CROSS_DOUBLE_TABLE_FIELD_STATISTICAL_COMPARE (cross-source two-table field statistical value consistency comparison), DOUBLE_TABLE_FIELD_EXP_COMPARE (two-table field business logic consistency comparison), TABLE_STABILITY_VALIDATE (table stability check), TABLE_FLUCTUATION_VALIDATE (table fluctuation check), FIELD_STABILITY_VALIDATE (field stability check), FIELD_FLUCTUATION_VALIDATE (field fluctuation check), CUSTOM_STATISTICAL_VALIDATE (custom statistical metric check), CUSTOM_DATA_DETAILS_VALIDATE (custom data details check), DATASOURCE_AVAILABLE_CHECK (data source connectivity monitoring), TABLE_SCHEMA_CHECK (table schema change monitoring), REAL_TIME_OFFLINE_COMPARE (real-time and offline comparison), REAL_TIME_STATISTICAL_VALIDATE (real-time statistical value monitoring), and REAL_TIME_MULTI_CHAIN_COMPARE (real-time multi-link comparison).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FIELD_NULL_VALUE_VALIDATE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
