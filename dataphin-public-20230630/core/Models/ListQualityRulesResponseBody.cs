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
            /// <para>The list of quality rules returned by page.</para>
            /// </summary>
            [NameInMap("QualityRuleList")]
            [Validation(Required=false)]
            public List<ListQualityRulesResponseBodyPageResultQualityRuleList> QualityRuleList { get; set; }
            public class ListQualityRulesResponseBodyPageResultQualityRuleList : TeaModel {
                /// <summary>
                /// <para>The rule business attribute configurations.</para>
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
                        /// <para>Indicates whether the attribute is enabled.</para>
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
                        /// <para>Indicates whether the attribute is required.</para>
                        /// </summary>
                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the attribute is searchable.</para>
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
                            /// <para>The attribute field type. Valid values:</para>
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
                            /// <para>The attribute default value.</para>
                            /// </summary>
                            [NameInMap("DefaultValue")]
                            [Validation(Required=false)]
                            public ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeInfoValueConfigDefaultValue DefaultValue { get; set; }
                            public class ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeInfoValueConfigDefaultValue : TeaModel {
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
                                /// <para>The maximum value. This applies to range interval attributes.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("MaxValue")]
                                [Validation(Required=false)]
                                public string MaxValue { get; set; }

                                /// <summary>
                                /// <para>The minimum value. This applies to range interval attributes.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("MinValue")]
                                [Validation(Required=false)]
                                public string MinValue { get; set; }

                                /// <summary>
                                /// <para>The list of attribute values. This applies to attributes with the input method set to custom input, single-select dropdown, or multi-select dropdown.</para>
                                /// </summary>
                                [NameInMap("ValueList")]
                                [Validation(Required=false)]
                                public List<string> ValueList { get; set; }

                            }

                            /// <summary>
                            /// <para>The attribute field length. This constrains the maximum length of text-type attribute values.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>6997283</para>
                            /// </summary>
                            [NameInMap("Length")]
                            [Validation(Required=false)]
                            public int? Length { get; set; }

                            /// <summary>
                            /// <para>The attribute value input method. Valid values:</para>
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
                            /// <para>The attribute option values. This applies only to attributes with the input method set to single-select dropdown or multi-select dropdown.</para>
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
                    public ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeValue AttributeValue { get; set; }
                    public class ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeValue : TeaModel {
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
                        /// <para>The maximum value. This applies to range interval attributes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("MaxValue")]
                        [Validation(Required=false)]
                        public string MaxValue { get; set; }

                        /// <summary>
                        /// <para>The minimum value. This applies to range interval attributes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("MinValue")]
                        [Validation(Required=false)]
                        public string MinValue { get; set; }

                        /// <summary>
                        /// <para>The list of attribute values. This applies to attributes with the input method set to custom input, single-select dropdown, or multi-select dropdown.</para>
                        /// </summary>
                        [NameInMap("ValueList")]
                        [Validation(Required=false)]
                        public List<string> ValueList { get; set; }

                    }

                }

                /// <summary>
                /// <para>The rule category. Valid values:</para>
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
                /// </summary>
                [NameInMap("CatalogList")]
                [Validation(Required=false)]
                public List<string> CatalogList { get; set; }

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
                /// <para>Indicates whether exception archiving is enabled.</para>
                /// </summary>
                [NameInMap("EnableErrorArchive")]
                [Validation(Required=false)]
                public bool? EnableErrorArchive { get; set; }

                /// <summary>
                /// <para>The rule configuration key-value pairs. These vary by templatetype: different templatetypes return different form key-value pair configurations.</para>
                /// </summary>
                [NameInMap("FormPropertyList")]
                [Validation(Required=false)]
                public List<ListQualityRulesResponseBodyPageResultQualityRuleListFormPropertyList> FormPropertyList { get; set; }
                public class ListQualityRulesResponseBodyPageResultQualityRuleListFormPropertyList : TeaModel {
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
                /// <para>The quality rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ID of the user who last modified the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <para>The name of the user who last modified the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ModifierName")]
                [Validation(Required=false)]
                public string ModifierName { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The quality rule name.</para>
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
                    /// <para>The schedule ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ScheduleId")]
                    [Validation(Required=false)]
                    public long? ScheduleId { get; set; }

                    /// <summary>
                    /// <para>The schedule name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("ScheduleName")]
                    [Validation(Required=false)]
                    public string ScheduleName { get; set; }

                }

                /// <summary>
                /// <para>The quality rule status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ENABLE</description></item>
                /// <item><description>DISABLE.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The rule strength. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>STRONG</description></item>
                /// <item><description>WEAK.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>STRONG</para>
                /// </summary>
                [NameInMap("Strength")]
                [Validation(Required=false)]
                public string Strength { get; set; }

                /// <summary>
                /// <para>The template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// <para>The template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The templatetype group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SYSTEM: system preset.</description></item>
                /// <item><description>CUSTOM: custom template.</description></item>
                /// <item><description>TEMPLATE: union of SYSTEM and CUSTOM.</description></item>
                /// <item><description>CUSTOM_SQL: custom SQL template.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOM</para>
                /// </summary>
                [NameInMap("TemplateScope")]
                [Validation(Required=false)]
                public string TemplateScope { get; set; }

                /// <summary>
                /// <para>The templatetype. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>FIELD_NULL_VALUE_VALIDATE: field null value validation.</description></item>
                /// <item><description>FIELD_EMPTY_STRING_VALIDATE: field empty character string validation.</description></item>
                /// <item><description>FIELD_UNIQUE_VALIDATE: field uniqueness validation.</description></item>
                /// <item><description>FIELD_GROUP_COUNT_VALIDATE: field unique value count validation.</description></item>
                /// <item><description>FIELD_DUPLICATE_VALUE_COUNT_VALIDATE: field duplicate value count validation.</description></item>
                /// <item><description>FUNCTION_TIME_COMPARE: time function comparison.</description></item>
                /// <item><description>SINGLE_TABLE_TIME_COMPARE: non-partitioned table time field comparison.</description></item>
                /// <item><description>DOUBLE_TABLE_TIME_COMPARE: two-table time field comparison.</description></item>
                /// <item><description>FIELD_FORMAT_VALIDATE: field format validation.</description></item>
                /// <item><description>FIELD_LENGTH_VALIDATE: field length validation.</description></item>
                /// <item><description>FIELD_VALUE_RANGE_VALIDATE: field value range validation.</description></item>
                /// <item><description>CODE_TABLE_COMPARE: lookup table reference comparison.</description></item>
                /// <item><description>STANDARD_CODE_TABLE_COMPARE: data standard lookup table reference comparison.</description></item>
                /// <item><description>SINGLE_TABLE_FIELD_VALUE_COMPARE: non-partitioned table field value consistency comparison.</description></item>
                /// <item><description>SINGLE_TABLE_FIELD_STATISTICAL_COMPARE: non-partitioned table field statistical value consistency comparison.</description></item>
                /// <item><description>SINGLE_TABLE_FIELD_EXP_COMPARE: non-partitioned table field business logic consistency comparison.</description></item>
                /// <item><description>DOUBLE_TABLE_FIELD_VALUE_COMPARE: two-table field value consistency comparison.</description></item>
                /// <item><description>DOUBLE_TABLE_FIELD_STATISTICAL_COMPARE: two-table field statistical value consistency comparison.</description></item>
                /// <item><description>CROSS_DOUBLE_TABLE_FIELD_STATISTICAL_COMPARE: cross-source two-table field statistical value consistency comparison.</description></item>
                /// <item><description>DOUBLE_TABLE_FIELD_EXP_COMPARE: two-table field business logic consistency comparison.</description></item>
                /// <item><description>TABLE_STABILITY_VALIDATE: table stability validation.</description></item>
                /// <item><description>TABLE_FLUCTUATION_VALIDATE: table fluctuation validation.</description></item>
                /// <item><description>FIELD_STABILITY_VALIDATE: field stability validation.</description></item>
                /// <item><description>FIELD_FLUCTUATION_VALIDATE: field fluctuation validation.</description></item>
                /// <item><description>CUSTOM_STATISTICAL_VALIDATE: custom statistical metric validation.</description></item>
                /// <item><description>CUSTOM_DATA_DETAILS_VALIDATE: custom data details validation.</description></item>
                /// <item><description>DATASOURCE_AVAILABLE_CHECK: data source connectivity check.</description></item>
                /// <item><description>TABLE_SCHEMA_CHECK: table schema change detection.</description></item>
                /// <item><description>REAL_TIME_OFFLINE_COMPARE: real-time and offline comparison.</description></item>
                /// <item><description>REAL_TIME_STATISTICAL_VALIDATE: real-time statistical value monitoring.</description></item>
                /// <item><description>REAL_TIME_MULTI_CHAIN_COMPARE: real-time multi-link comparison, and more.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FIELD_NULL_VALUE_VALIDATE</para>
                /// </summary>
                [NameInMap("TemplateType")]
                [Validation(Required=false)]
                public string TemplateType { get; set; }

                /// <summary>
                /// <para>The ID of the most recent trial run task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("TestRunRuleTaskId")]
                [Validation(Required=false)]
                public long? TestRunRuleTaskId { get; set; }

                /// <summary>
                /// <para>The status of the most recent trial run task. Valid values: NOT_RUN, WAITING, RUNNING, SUCCESS, FAILED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("TestRunRuleTaskStatus")]
                [Validation(Required=false)]
                public string TestRunRuleTaskStatus { get; set; }

                /// <summary>
                /// <para>Indicates whether the trial run validation passed.</para>
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
                    /// <para>The metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

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
                    /// <para>The operator name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>且</para>
                    /// </summary>
                    [NameInMap("OperatorName")]
                    [Validation(Required=false)]
                    public string OperatorName { get; set; }

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
                    /// <item><description>RELATION: relation.</description></item>
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
                /// <para>The validation object.</para>
                /// </summary>
                [NameInMap("ValidateObject")]
                [Validation(Required=false)]
                public ListQualityRulesResponseBodyPageResultQualityRuleListValidateObject ValidateObject { get; set; }
                public class ListQualityRulesResponseBodyPageResultQualityRuleListValidateObject : TeaModel {
                    /// <summary>
                    /// <para>The validation object name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The validation object type. Valid values: UNKNOWN, TABLE, COLUMN, DATASOURCE, DATASOURCE_TABLE, REALTIME, INDEX, CHAIN.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TABLE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The ID of the monitoring to which the rule belongs.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
