// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpsertQualityRuleRequest : TeaModel {
        /// <summary>
        /// <para>Tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The upsert command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpsertCommand")]
        [Validation(Required=false)]
        public UpsertQualityRuleRequestUpsertCommand UpsertCommand { get; set; }
        public class UpsertQualityRuleRequestUpsertCommand : TeaModel {
            /// <summary>
            /// <para>The rule business attribute configuration.</para>
            /// </summary>
            [NameInMap("AttributeWithValueList")]
            [Validation(Required=false)]
            public List<UpsertQualityRuleRequestUpsertCommandAttributeWithValueList> AttributeWithValueList { get; set; }
            public class UpsertQualityRuleRequestUpsertCommandAttributeWithValueList : TeaModel {
                /// <summary>
                /// <para>The attribute details.</para>
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
                    /// <para>Specifies whether to enable the attribute.</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The attribute ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>711484689131</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The attribute name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>attr01</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the attribute is required.</para>
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the attribute is searchable.</para>
                    /// </summary>
                    [NameInMap("Searchable")]
                    [Validation(Required=false)]
                    public bool? Searchable { get; set; }

                    /// <summary>
                    /// <para>The attribute value configuration details.</para>
                    /// </summary>
                    [NameInMap("ValueConfig")]
                    [Validation(Required=false)]
                    public UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfoValueConfig ValueConfig { get; set; }
                    public class UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfoValueConfig : TeaModel {
                        /// <summary>
                        /// <para>The attribute field type. Valid values: STRING (Text), BIGINT (Integer), DOUBLE (Floating-point), BOOLEAN (Boolean), DATE (Date), DATETIME (Datetime).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>STRING</para>
                        /// </summary>
                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public string DataType { get; set; }

                        /// <summary>
                        /// <para>The attribute default value.</para>
                        /// </summary>
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfoValueConfigDefaultValue DefaultValue { get; set; }
                        public class UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfoValueConfigDefaultValue : TeaModel {
                            /// <summary>
                            /// <para>Specifies whether to include the maximum value.</para>
                            /// </summary>
                            [NameInMap("IncludeMaxValue")]
                            [Validation(Required=false)]
                            public bool? IncludeMaxValue { get; set; }

                            /// <summary>
                            /// <para>Specifies whether to include the minimum value.</para>
                            /// </summary>
                            [NameInMap("IncludeMinValue")]
                            [Validation(Required=false)]
                            public bool? IncludeMinValue { get; set; }

                            /// <summary>
                            /// <para>The maximum value. Applicable to range interval attributes.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("MaxValue")]
                            [Validation(Required=false)]
                            public string MaxValue { get; set; }

                            /// <summary>
                            /// <para>The minimum value. Applicable to range interval attributes.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("MinValue")]
                            [Validation(Required=false)]
                            public string MinValue { get; set; }

                            /// <summary>
                            /// <para>The attribute value list. Applicable to attributes with the custom input, single-select dropdown, or multi-select dropdown input method.</para>
                            /// </summary>
                            [NameInMap("ValueList")]
                            [Validation(Required=false)]
                            public List<string> ValueList { get; set; }

                        }

                        /// <summary>
                        /// <para>The attribute field length. Used to constrain the maximum length of text-type attribute values.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>986992</para>
                        /// </summary>
                        [NameInMap("Length")]
                        [Validation(Required=false)]
                        public int? Length { get; set; }

                        /// <summary>
                        /// <para>The attribute value input method. Valid values: CUSTOMIZED (Custom input), SINGLE_ENUM (Single-select dropdown), MULTIPLE_ENUMS (Multi-select dropdown), RANGE (Range interval).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CUSTOMIZED</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The attribute option values. Only applicable to attributes with the single-select dropdown or multi-select dropdown input method.</para>
                        /// </summary>
                        [NameInMap("ValueEnumList")]
                        [Validation(Required=false)]
                        public List<string> ValueEnumList { get; set; }

                    }

                }

                /// <summary>
                /// <para>The attribute value.</para>
                /// </summary>
                [NameInMap("AttributeValue")]
                [Validation(Required=false)]
                public UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeValue AttributeValue { get; set; }
                public class UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeValue : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to include the maximum value.</para>
                    /// </summary>
                    [NameInMap("IncludeMaxValue")]
                    [Validation(Required=false)]
                    public bool? IncludeMaxValue { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to include the minimum value.</para>
                    /// </summary>
                    [NameInMap("IncludeMinValue")]
                    [Validation(Required=false)]
                    public bool? IncludeMinValue { get; set; }

                    /// <summary>
                    /// <para>The maximum value. Applicable to range interval attributes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11</para>
                    /// </summary>
                    [NameInMap("MaxValue")]
                    [Validation(Required=false)]
                    public string MaxValue { get; set; }

                    /// <summary>
                    /// <para>The minimum value. Applicable to range interval attributes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MinValue")]
                    [Validation(Required=false)]
                    public string MinValue { get; set; }

                    /// <summary>
                    /// <para>The attribute value list. Applicable to attributes with the custom input, single-select dropdown, or multi-select dropdown input method.</para>
                    /// </summary>
                    [NameInMap("ValueList")]
                    [Validation(Required=false)]
                    public List<string> ValueList { get; set; }

                }

            }

            /// <summary>
            /// <para>The rule category. Valid values: CONSISTENT (Consistency), EFFECTIVE (Effectiveness), TIMELINESE (Timeliness), ACCURATE (Accuracy), UNIQUENESS (Uniqueness), COMPLETENESS (Completeness), STABILITY (Stability), CUSTOM (Custom).</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("CatalogList")]
            [Validation(Required=false)]
            public List<string> CatalogList { get; set; }

            /// <summary>
            /// <para>The description of the quality rule.</para>
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
            /// <para>The rule configuration key-value pairs. The configuration varies based on the template type. Different template types return different form key-value pair configurations.</para>
            /// </summary>
            [NameInMap("FormPropertyList")]
            [Validation(Required=false)]
            public List<UpsertQualityRuleRequestUpsertCommandFormPropertyList> FormPropertyList { get; set; }
            public class UpsertQualityRuleRequestUpsertCommandFormPropertyList : TeaModel {
                /// <summary>
                /// <para>The component type.</para>
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
            /// <para>Rule ID. A non-empty value indicates a modification, and an empty value indicates a creation.</para>
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
            /// <para>The rule strength. Valid values: STRONG, WEAK.</para>
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
            /// <para>The template type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FIELD_NULL_VALUE_VALIDATE: Field null value validation</description></item>
            /// <item><description>FIELD_EMPTY_STRING_VALIDATE: Field empty string validation</description></item>
            /// <item><description>FIELD_UNIQUE_VALIDATE: Field uniqueness validation</description></item>
            /// <item><description>FIELD_GROUP_COUNT_VALIDATE: Field unique value count validation</description></item>
            /// <item><description>FIELD_DUPLICATE_VALUE_COUNT_VALIDATE: Field duplicate value count validation</description></item>
            /// <item><description>FUNCTION_TIME_COMPARE: Time function comparison</description></item>
            /// <item><description>SINGLE_TABLE_TIME_COMPARE: Single-table time field comparison</description></item>
            /// <item><description>DOUBLE_TABLE_TIME_COMPARE: Cross-table time field comparison</description></item>
            /// <item><description>FIELD_FORMAT_VALIDATE: Field format validation</description></item>
            /// <item><description>FIELD_LENGTH_VALIDATE: Field length validation</description></item>
            /// <item><description>FIELD_VALUE_RANGE_VALIDATE: Field value range validation</description></item>
            /// <item><description>CODE_TABLE_COMPARE: Code table reference comparison</description></item>
            /// <item><description>STANDARD_CODE_TABLE_COMPARE: Data standard code table reference comparison</description></item>
            /// <item><description>SINGLE_TABLE_FIELD_VALUE_COMPARE: Single-table field value consistency comparison</description></item>
            /// <item><description>SINGLE_TABLE_FIELD_STATISTICAL_COMPARE: Single-table field statistical value consistency comparison</description></item>
            /// <item><description>SINGLE_TABLE_FIELD_EXP_COMPARE: Single-table field business logic consistency comparison</description></item>
            /// <item><description>DOUBLE_TABLE_FIELD_VALUE_COMPARE: Cross-table field value consistency comparison</description></item>
            /// <item><description>DOUBLE_TABLE_FIELD_STATISTICAL_COMPARE: Cross-table field statistical value consistency comparison</description></item>
            /// <item><description>CROSS_DOUBLE_TABLE_FIELD_STATISTICAL_COMPARE: Cross-source cross-table field statistical value consistency comparison</description></item>
            /// <item><description>DOUBLE_TABLE_FIELD_EXP_COMPARE: Cross-table field business logic consistency comparison</description></item>
            /// <item><description>TABLE_STABILITY_VALIDATE: Table stability validation</description></item>
            /// <item><description>TABLE_FLUCTUATION_VALIDATE: Table fluctuation validation</description></item>
            /// <item><description>FIELD_STABILITY_VALIDATE: Field stability validation</description></item>
            /// <item><description>FIELD_FLUCTUATION_VALIDATE: Field fluctuation validation</description></item>
            /// <item><description>CUSTOM_STATISTICAL_VALIDATE: Custom statistical metric validation</description></item>
            /// <item><description>CUSTOM_DATA_DETAILS_VALIDATE: Custom data details validation</description></item>
            /// <item><description>DATASOURCE_AVAILABLE_CHECK: Data source connectivity check</description></item>
            /// <item><description>TABLE_SCHEMA_CHECK: Table schema change monitoring</description></item>
            /// <item><description>REAL_TIME_OFFLINE_COMPARE: Real-time offline comparison</description></item>
            /// <item><description>REAL_TIME_STATISTICAL_VALIDATE: Real-time statistical value monitoring</description></item>
            /// <item><description>REAL_TIME_MULTI_CHAIN_COMPARE: Real-time multi-chain comparison, etc.</description></item>
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
                /// <para>The ID of the condition node.</para>
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
                /// <para>The operator. Valid values: EQUAL, NOT_EQUAL, LARGER, SMALLER, LARGE_OR_EQUAL, SMALLER_OR_EQUAL, AND, OR.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The ID of the parent condition node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <para>The condition type. Valid values: RELATION, EXPRESSION.</para>
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
            /// <para>The ID of the associated monitor.</para>
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
