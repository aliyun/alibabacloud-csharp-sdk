// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpsertQualityRuleRequest : TeaModel {
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

        /// <summary>
        /// <para>The update command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpsertCommand")]
        [Validation(Required=false)]
        public UpsertQualityRuleRequestUpsertCommand UpsertCommand { get; set; }
        public class UpsertQualityRuleRequestUpsertCommand : TeaModel {
            /// <summary>
            /// <para>The exception archive mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ONLY_ERROR_FIELD: Archives only the exception fields.</description></item>
            /// <item><description>FULL_RECORD: Archives the complete record.</description></item>
            /// </list>
            /// <para>Default value: ONLY_ERROR_FIELD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ONLY_ERROR_FIELD</para>
            /// </summary>
            [NameInMap("ArchiveMode")]
            [Validation(Required=false)]
            public string ArchiveMode { get; set; }

            /// <summary>
            /// <para>The exception archive storage type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FILE_SYSTEM: File system.</description></item>
            /// <item><description>CUSTOM_TABLE: Custom table.</description></item>
            /// </list>
            /// <para>Default value: FILE_SYSTEM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FILE_SYSTEM</para>
            /// </summary>
            [NameInMap("ArchiveStoreType")]
            [Validation(Required=false)]
            public string ArchiveStoreType { get; set; }

            /// <summary>
            /// <para>The rule business property configuration.</para>
            /// </summary>
            [NameInMap("AttributeWithValueList")]
            [Validation(Required=false)]
            public List<UpsertQualityRuleRequestUpsertCommandAttributeWithValueList> AttributeWithValueList { get; set; }
            public class UpsertQualityRuleRequestUpsertCommandAttributeWithValueList : TeaModel {
                /// <summary>
                /// <para>The property details.</para>
                /// </summary>
                [NameInMap("AttributeInfo")]
                [Validation(Required=false)]
                public UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfo AttributeInfo { get; set; }
                public class UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfo : TeaModel {
                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the property is enabled.</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The property ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>711484689131</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The property name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>attr01</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the property is required.</para>
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the property is searchable.</para>
                    /// </summary>
                    [NameInMap("Searchable")]
                    [Validation(Required=false)]
                    public bool? Searchable { get; set; }

                    /// <summary>
                    /// <para>The property value configuration details.</para>
                    /// </summary>
                    [NameInMap("ValueConfig")]
                    [Validation(Required=false)]
                    public UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfoValueConfig ValueConfig { get; set; }
                    public class UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfoValueConfig : TeaModel {
                        /// <summary>
                        /// <para>The property field data type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>STRING: text.</description></item>
                        /// <item><description>BIGINT: integer.</description></item>
                        /// <item><description>DOUBLE: floating-point.</description></item>
                        /// <item><description>BOOLEAN: Boolean.</description></item>
                        /// <item><description>DATE: date.</description></item>
                        /// <item><description>DATETIME: datetime.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>STRING</para>
                        /// </summary>
                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public string DataType { get; set; }

                        /// <summary>
                        /// <para>The property default value.</para>
                        /// </summary>
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfoValueConfigDefaultValue DefaultValue { get; set; }
                        public class UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfoValueConfigDefaultValue : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether the maximum value is included.</para>
                            /// </summary>
                            [NameInMap("IncludeMaxValue")]
                            [Validation(Required=false)]
                            public bool? IncludeMaxValue { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the minimum value is included.</para>
                            /// </summary>
                            [NameInMap("IncludeMinValue")]
                            [Validation(Required=false)]
                            public bool? IncludeMinValue { get; set; }

                            /// <summary>
                            /// <para>The maximum value. This parameter applies to range interval properties.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("MaxValue")]
                            [Validation(Required=false)]
                            public string MaxValue { get; set; }

                            /// <summary>
                            /// <para>The minimum value. This parameter applies to range interval properties.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("MinValue")]
                            [Validation(Required=false)]
                            public string MinValue { get; set; }

                            /// <summary>
                            /// <para>The property value list. This parameter applies to properties whose input method is custom input, single-select dropdown, or multi-select dropdown.</para>
                            /// </summary>
                            [NameInMap("ValueList")]
                            [Validation(Required=false)]
                            public List<string> ValueList { get; set; }

                        }

                        /// <summary>
                        /// <para>The property field length. You can use this parameter to constrain the maximum length of text-type property values.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>986992</para>
                        /// </summary>
                        [NameInMap("Length")]
                        [Validation(Required=false)]
                        public int? Length { get; set; }

                        /// <summary>
                        /// <para>The property value input method. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>CUSTOMIZED: custom input.</description></item>
                        /// <item><description>SINGLE_ENUM: single-select dropdown.</description></item>
                        /// <item><description>MULTIPLE_ENUMS: multi-select dropdown.</description></item>
                        /// <item><description>RANGE: range interval.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CUSTOMIZED</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The property option values. This parameter applies only to properties whose input method is single-select dropdown or multi-select dropdown.</para>
                        /// </summary>
                        [NameInMap("ValueEnumList")]
                        [Validation(Required=false)]
                        public List<string> ValueEnumList { get; set; }

                    }

                }

                /// <summary>
                /// <para>The property value.</para>
                /// </summary>
                [NameInMap("AttributeValue")]
                [Validation(Required=false)]
                public UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeValue AttributeValue { get; set; }
                public class UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeValue : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the maximum value is included.</para>
                    /// </summary>
                    [NameInMap("IncludeMaxValue")]
                    [Validation(Required=false)]
                    public bool? IncludeMaxValue { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the minimum value is included.</para>
                    /// </summary>
                    [NameInMap("IncludeMinValue")]
                    [Validation(Required=false)]
                    public bool? IncludeMinValue { get; set; }

                    /// <summary>
                    /// <para>The maximum value. This parameter applies to range interval properties.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11</para>
                    /// </summary>
                    [NameInMap("MaxValue")]
                    [Validation(Required=false)]
                    public string MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value. This parameter applies to range interval properties.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MinValue")]
                    [Validation(Required=false)]
                    public string MinValue { get; set; }

                    /// <summary>
                    /// <para>The property value list. This parameter applies to properties whose input method is custom input, single-select dropdown, or multi-select dropdown.</para>
                    /// </summary>
                    [NameInMap("ValueList")]
                    [Validation(Required=false)]
                    public List<string> ValueList { get; set; }

                }

            }

            /// <summary>
            /// <para>The rule catalog. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CONSISTENT: consistency.</description></item>
            /// <item><description>EFFECTIVE: validity.</description></item>
            /// <item><description>TIMELINESE: timeliness.</description></item>
            /// <item><description>ACCURATE: accuracy.</description></item>
            /// <item><description>UNIQUENESS: uniqueness.</description></item>
            /// <item><description>COMPLETENESS: completeness.</description></item>
            /// <item><description>STABILITY: stability.</description></item>
            /// <item><description>CUSTOM: custom.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("CatalogList")]
            [Validation(Required=false)]
            public List<string> CatalogList { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable error archiving.</para>
            /// </summary>
            [NameInMap("EnableErrorArchive")]
            [Validation(Required=false)]
            public bool? EnableErrorArchive { get; set; }

            /// <summary>
            /// <para>The rule configuration key-value pairs. These are related to the templatetype. Different template types return different form key-value pair configurations.</para>
            /// </summary>
            [NameInMap("FormPropertyList")]
            [Validation(Required=false)]
            public List<UpsertQualityRuleRequestUpsertCommandFormPropertyList> FormPropertyList { get; set; }
            public class UpsertQualityRuleRequestUpsertCommandFormPropertyList : TeaModel {
                /// <summary>
                /// <para>The control type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>expression</para>
                /// </summary>
                [NameInMap("ComponentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The property value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The rule ID. If this parameter is not empty, the operation updates the rule. If this parameter is empty, the operation creates a rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the quality rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The rule strength. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STRONG</description></item>
            /// <item><description>WEAK</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRONG</para>
            /// </summary>
            [NameInMap("Strength")]
            [Validation(Required=false)]
            public string Strength { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>The templatetype. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FIELD_NULL_VALUE_VALIDATE: field null value check.</description></item>
            /// <item><description>FIELD_EMPTY_STRING_VALIDATE: field empty string check.</description></item>
            /// <item><description>FIELD_UNIQUE_VALIDATE: field uniqueness check.</description></item>
            /// <item><description>FIELD_GROUP_COUNT_VALIDATE: field unique value count check.</description></item>
            /// <item><description>FIELD_DUPLICATE_VALUE_COUNT_VALIDATE: field duplicate value count check.</description></item>
            /// <item><description>FUNCTION_TIME_COMPARE: time function comparison.</description></item>
            /// <item><description>SINGLE_TABLE_TIME_COMPARE: single-table time field comparison.</description></item>
            /// <item><description>DOUBLE_TABLE_TIME_COMPARE: two-table time field comparison.</description></item>
            /// <item><description>FIELD_FORMAT_VALIDATE: field format check.</description></item>
            /// <item><description>FIELD_LENGTH_VALIDATE: field length check.</description></item>
            /// <item><description>FIELD_VALUE_RANGE_VALIDATE: field value range check.</description></item>
            /// <item><description>CODE_TABLE_COMPARE: lookup table reference comparison.</description></item>
            /// <item><description>STANDARD_CODE_TABLE_COMPARE: data standard lookup table reference comparison.</description></item>
            /// <item><description>SINGLE_TABLE_FIELD_VALUE_COMPARE: single-table field value consistency comparison.</description></item>
            /// <item><description>SINGLE_TABLE_FIELD_STATISTICAL_COMPARE: single-table field statistical value consistency comparison.</description></item>
            /// <item><description>SINGLE_TABLE_FIELD_EXP_COMPARE: single-table field business logic consistency comparison.</description></item>
            /// <item><description>DOUBLE_TABLE_FIELD_VALUE_COMPARE: two-table field value consistency comparison.</description></item>
            /// <item><description>DOUBLE_TABLE_FIELD_STATISTICAL_COMPARE: two-table field statistical value consistency comparison.</description></item>
            /// <item><description>CROSS_DOUBLE_TABLE_FIELD_STATISTICAL_COMPARE: cross-source two-table field statistical value consistency comparison.</description></item>
            /// <item><description>DOUBLE_TABLE_FIELD_EXP_COMPARE: two-table field business logic consistency comparison.</description></item>
            /// <item><description>TABLE_STABILITY_VALIDATE: table stability check.</description></item>
            /// <item><description>TABLE_FLUCTUATION_VALIDATE: table fluctuation check.</description></item>
            /// <item><description>FIELD_STABILITY_VALIDATE: field stability check.</description></item>
            /// <item><description>FIELD_FLUCTUATION_VALIDATE: field fluctuation check.</description></item>
            /// <item><description>CUSTOM_STATISTICAL_VALIDATE: custom statistical metric check.</description></item>
            /// <item><description>CUSTOM_DATA_DETAILS_VALIDATE: custom data details check.</description></item>
            /// <item><description>DATASOURCE_AVAILABLE_CHECK: datasource connectivity monitoring.</description></item>
            /// <item><description>TABLE_SCHEMA_CHECK: table schema change monitoring.</description></item>
            /// <item><description>REAL_TIME_OFFLINE_COMPARE: real-time and offline comparison.</description></item>
            /// <item><description>REAL_TIME_STATISTICAL_VALIDATE: real-time statistical value monitoring.</description></item>
            /// <item><description>REAL_TIME_MULTI_CHAIN_COMPARE: real-time multi-link comparison.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FIELD_NULL_VALUE_VALIDATE</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>The validation conditions.</para>
            /// </summary>
            [NameInMap("ValidateConditionList")]
            [Validation(Required=false)]
            public List<UpsertQualityRuleRequestUpsertCommandValidateConditionList> ValidateConditionList { get; set; }
            public class UpsertQualityRuleRequestUpsertCommandValidateConditionList : TeaModel {
                /// <summary>
                /// <para>The condition node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>268</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public string Metric { get; set; }

                /// <summary>
                /// <para>The operator. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>EQUAL</description></item>
                /// <item><description>NOT_EQUAL</description></item>
                /// <item><description>LARGER</description></item>
                /// <item><description>SMALLER</description></item>
                /// <item><description>LARGE_OR_EQUAL</description></item>
                /// <item><description>SMALLER_OR_EQUAL</description></item>
                /// <item><description>AND</description></item>
                /// <item><description>OR</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The parent condition node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <para>The condition type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RELATION: relationship.</description></item>
                /// <item><description>EXPRESSION: expression.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RELATION</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the associated watch.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WatchId")]
            [Validation(Required=false)]
            public long? WatchId { get; set; }

        }

    }

}
