// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityRulesResponseBody : TeaModel {
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
        public ListQualityRulesResponseBodyPageResult PageResult { get; set; }
        public class ListQualityRulesResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The paged quality rule task list.</para>
            /// </summary>
            [NameInMap("QualityRuleList")]
            [Validation(Required=false)]
            public List<ListQualityRulesResponseBodyPageResultQualityRuleList> QualityRuleList { get; set; }
            public class ListQualityRulesResponseBodyPageResultQualityRuleList : TeaModel {
                /// <summary>
                /// <para>The business attribute configuration of the rule.</para>
                /// </summary>
                [NameInMap("AttributeWithValueList")]
                [Validation(Required=false)]
                public List<ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueList> AttributeWithValueList { get; set; }
                public class ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueList : TeaModel {
                    /// <summary>
                    /// <para>The attribute details.</para>
                    /// </summary>
                    [NameInMap("AttributeInfo")]
                    [Validation(Required=false)]
                    public ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeInfo AttributeInfo { get; set; }
                    public class ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeInfo : TeaModel {
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
                        /// <para>Specifies whether the attribute is enabled.</para>
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// <para>The attribute ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-168890138815</para>
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
                        public ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeInfoValueConfig ValueConfig { get; set; }
                        public class ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeInfoValueConfig : TeaModel {
                            /// <summary>
                            /// <para>The attribute field type. Valid values: STRING (text), BIGINT (integer), DOUBLE (floating-point number), BOOLEAN (boolean), DATE (date), and DATETIME (datetime).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>STRING</para>
                            /// </summary>
                            [NameInMap("DataType")]
                            [Validation(Required=false)]
                            public string DataType { get; set; }

                            /// <summary>
                            /// <para>The default value of the attribute.</para>
                            /// </summary>
                            [NameInMap("DefaultValue")]
                            [Validation(Required=false)]
                            public ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeInfoValueConfigDefaultValue DefaultValue { get; set; }
                            public class ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeInfoValueConfigDefaultValue : TeaModel {
                                /// <summary>
                                /// <para>Specifies whether the maximum value is included.</para>
                                /// </summary>
                                [NameInMap("IncludeMaxValue")]
                                [Validation(Required=false)]
                                public bool? IncludeMaxValue { get; set; }

                                /// <summary>
                                /// <para>Specifies whether the minimum value is included.</para>
                                /// </summary>
                                [NameInMap("IncludeMinValue")]
                                [Validation(Required=false)]
                                public bool? IncludeMinValue { get; set; }

                                /// <summary>
                                /// <para>The maximum value. This parameter applies to range attributes.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("MaxValue")]
                                [Validation(Required=false)]
                                public string MaxValue { get; set; }

                                /// <summary>
                                /// <para>The minimum value. This parameter applies to range attributes.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("MinValue")]
                                [Validation(Required=false)]
                                public string MinValue { get; set; }

                                /// <summary>
                                /// <para>The attribute value list. This parameter applies to attributes whose input method is custom input, single-select drop-down list, or multi-select drop-down list.</para>
                                /// </summary>
                                [NameInMap("ValueList")]
                                [Validation(Required=false)]
                                public List<string> ValueList { get; set; }

                            }

                            /// <summary>
                            /// <para>The attribute field length. You can use this parameter to constrain the maximum length of text attribute values.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>6997283</para>
                            /// </summary>
                            [NameInMap("Length")]
                            [Validation(Required=false)]
                            public int? Length { get; set; }

                            /// <summary>
                            /// <para>The attribute value input method. Valid values: CUSTOMIZED (custom input), SINGLE_ENUM (single-select drop-down list), MULTIPLE_ENUMS (multi-select drop-down list), and RANGE (range).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CUSTOMIZED</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>The attribute option values. This parameter applies only to attributes whose input method is a single-select or multi-select drop-down list.</para>
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
                    public ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeValue AttributeValue { get; set; }
                    public class ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeValue : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether the maximum value is included.</para>
                        /// </summary>
                        [NameInMap("IncludeMaxValue")]
                        [Validation(Required=false)]
                        public bool? IncludeMaxValue { get; set; }

                        /// <summary>
                        /// <para>Specifies whether the minimum value is included.</para>
                        /// </summary>
                        [NameInMap("IncludeMinValue")]
                        [Validation(Required=false)]
                        public bool? IncludeMinValue { get; set; }

                        /// <summary>
                        /// <para>The maximum value. This parameter applies to range attributes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("MaxValue")]
                        [Validation(Required=false)]
                        public string MaxValue { get; set; }

                        /// <summary>
                        /// <para>The minimum value. This parameter applies to range attributes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("MinValue")]
                        [Validation(Required=false)]
                        public string MinValue { get; set; }

                        /// <summary>
                        /// <para>The attribute value list. This parameter applies to attributes whose input method is custom input, single-select drop-down list, or multi-select drop-down list.</para>
                        /// </summary>
                        [NameInMap("ValueList")]
                        [Validation(Required=false)]
                        public List<string> ValueList { get; set; }

                    }

                }

                /// <summary>
                /// <para>The rule category. Valid values: CONSISTENT (consistency), EFFECTIVE (validity), TIMELINESE (timeliness), ACCURATE (accuracy), UNIQUENESS (uniqueness), COMPLETENESS (completeness), STABILITY (stability), and CUSTOM (custom).</para>
                /// </summary>
                [NameInMap("CatalogList")]
                [Validation(Required=false)]
                public List<string> CatalogList { get; set; }

                /// <summary>
                /// <para>The creation time. The format is YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The creator name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

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
                /// <para>Specifies whether error archiving is enabled.</para>
                /// </summary>
                [NameInMap("EnableErrorArchive")]
                [Validation(Required=false)]
                public bool? EnableErrorArchive { get; set; }

                /// <summary>
                /// <para>The rule configuration key-value pairs. Different template types return different form key-value pair configurations.</para>
                /// </summary>
                [NameInMap("FormPropertyList")]
                [Validation(Required=false)]
                public List<ListQualityRulesResponseBodyPageResultQualityRuleListFormPropertyList> FormPropertyList { get; set; }
                public class ListQualityRulesResponseBodyPageResultQualityRuleListFormPropertyList : TeaModel {
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
                    /// <para>The attribute value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the quality rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ID of the user who last modified the quality rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <para>The name of the user who last modified the quality rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ModifierName")]
                [Validation(Required=false)]
                public string ModifierName { get; set; }

                /// <summary>
                /// <para>The modification time. The format is YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The name of the quality rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of schedules bound to the rule.</para>
                /// </summary>
                [NameInMap("ScheduleBindList")]
                [Validation(Required=false)]
                public List<ListQualityRulesResponseBodyPageResultQualityRuleListScheduleBindList> ScheduleBindList { get; set; }
                public class ListQualityRulesResponseBodyPageResultQualityRuleListScheduleBindList : TeaModel {
                    /// <summary>
                    /// <para>The ID of the schedule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ScheduleId")]
                    [Validation(Required=false)]
                    public long? ScheduleId { get; set; }

                    /// <summary>
                    /// <para>The name of the schedule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("ScheduleName")]
                    [Validation(Required=false)]
                    public string ScheduleName { get; set; }

                }

                /// <summary>
                /// <para>The SQL preview text of the saved rule. The text may contain multiple SQL statements. If preview is not supported or generation fails, null is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select count(*) from test_table;</para>
                /// </summary>
                [NameInMap("Sql")]
                [Validation(Required=false)]
                public string Sql { get; set; }

                /// <summary>
                /// <para>The status of the quality rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ENABLE: Enabled.</description></item>
                /// <item><description>DISABLE: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The strength of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>STRONG: Strong rule.</description></item>
                /// <item><description>WEAK: Weak rule.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>STRONG</para>
                /// </summary>
                [NameInMap("Strength")]
                [Validation(Required=false)]
                public string Strength { get; set; }

                /// <summary>
                /// <para>The ID of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// <para>The name of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The template type group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SYSTEM: System preset template.</description></item>
                /// <item><description>CUSTOM: Custom template.</description></item>
                /// <item><description>TEMPLATE: Union of SYSTEM and CUSTOM.</description></item>
                /// <item><description>CUSTOM_SQL: Custom SQL template.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOM</para>
                /// </summary>
                [NameInMap("TemplateScope")]
                [Validation(Required=false)]
                public string TemplateScope { get; set; }

                /// <summary>
                /// <para>The template type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>FIELD_NULL_VALUE_VALIDATE: Field null value check.</description></item>
                /// <item><description>FIELD_EMPTY_STRING_VALIDATE: Field empty character string check.</description></item>
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
                [NameInMap("TemplateType")]
                [Validation(Required=false)]
                public string TemplateType { get; set; }

                /// <summary>
                /// <para>The ID of the last test run task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("TestRunRuleTaskId")]
                [Validation(Required=false)]
                public long? TestRunRuleTaskId { get; set; }

                /// <summary>
                /// <para>The status of the last test run task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NOT_RUN: Not run.</description></item>
                /// <item><description>WAITING: Waiting.</description></item>
                /// <item><description>RUNNING: Running.</description></item>
                /// <item><description>SUCCESS: Succeeded.</description></item>
                /// <item><description>FAILED: Failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("TestRunRuleTaskStatus")]
                [Validation(Required=false)]
                public string TestRunRuleTaskStatus { get; set; }

                /// <summary>
                /// <para>Indicates whether the test run validation passed.</para>
                /// </summary>
                [NameInMap("TestRunRuleValidateResult")]
                [Validation(Required=false)]
                public bool? TestRunRuleValidateResult { get; set; }

                /// <summary>
                /// <para>The list of validation conditions.</para>
                /// </summary>
                [NameInMap("ValidateConditionList")]
                [Validation(Required=false)]
                public List<ListQualityRulesResponseBodyPageResultQualityRuleListValidateConditionList> ValidateConditionList { get; set; }
                public class ListQualityRulesResponseBodyPageResultQualityRuleListValidateConditionList : TeaModel {
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
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// <para>The operator. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>EQUAL: Equal to.</description></item>
                    /// <item><description>NOT_EQUAL: Not equal to.</description></item>
                    /// <item><description>LARGER: Greater than.</description></item>
                    /// <item><description>SMALLER: Less than.</description></item>
                    /// <item><description>LARGE_OR_EQUAL: Greater than or equal to.</description></item>
                    /// <item><description>SMALLER_OR_EQUAL: Less than or equal to.</description></item>
                    /// <item><description>AND: AND.</description></item>
                    /// <item><description>OR: OR.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AND</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The name of the operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AND</para>
                    /// </summary>
                    [NameInMap("OperatorName")]
                    [Validation(Required=false)]
                    public string OperatorName { get; set; }

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
                    /// <para>The condition type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>RELATION: Relation.</description></item>
                    /// <item><description>EXPRESSION: Expression.</description></item>
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
                /// <para>The validation object.</para>
                /// </summary>
                [NameInMap("ValidateObject")]
                [Validation(Required=false)]
                public ListQualityRulesResponseBodyPageResultQualityRuleListValidateObject ValidateObject { get; set; }
                public class ListQualityRulesResponseBodyPageResultQualityRuleListValidateObject : TeaModel {
                    /// <summary>
                    /// <para>The name of the validation object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The validation object type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>UNKNOWN: Unknown.</description></item>
                    /// <item><description>TABLE: Table.</description></item>
                    /// <item><description>COLUMN: Column.</description></item>
                    /// <item><description>DATASOURCE: Data source.</description></item>
                    /// <item><description>DATASOURCE_TABLE: Data source table.</description></item>
                    /// <item><description>REALTIME: Real-time.</description></item>
                    /// <item><description>INDEX: Index.</description></item>
                    /// <item><description>CHAIN: Chain.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TABLE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The ID of the quality watchtask to which the rule belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WatchId")]
                [Validation(Required=false)]
                public long? WatchId { get; set; }

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
