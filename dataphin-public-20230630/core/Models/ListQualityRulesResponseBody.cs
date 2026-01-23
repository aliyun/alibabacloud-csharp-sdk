// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityRulesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListQualityRulesResponseBodyPageResult PageResult { get; set; }
        public class ListQualityRulesResponseBodyPageResult : TeaModel {
            [NameInMap("QualityRuleList")]
            [Validation(Required=false)]
            public List<ListQualityRulesResponseBodyPageResultQualityRuleList> QualityRuleList { get; set; }
            public class ListQualityRulesResponseBodyPageResultQualityRuleList : TeaModel {
                [NameInMap("AttributeWithValueList")]
                [Validation(Required=false)]
                public List<ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueList> AttributeWithValueList { get; set; }
                public class ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueList : TeaModel {
                    [NameInMap("AttributeInfo")]
                    [Validation(Required=false)]
                    public ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeInfo AttributeInfo { get; set; }
                    public class ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-168890138815</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>attr01</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        [NameInMap("Searchable")]
                        [Validation(Required=false)]
                        public bool? Searchable { get; set; }

                        [NameInMap("ValueConfig")]
                        [Validation(Required=false)]
                        public ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeInfoValueConfig ValueConfig { get; set; }
                        public class ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeInfoValueConfig : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>STRING</para>
                            /// </summary>
                            [NameInMap("DataType")]
                            [Validation(Required=false)]
                            public string DataType { get; set; }

                            [NameInMap("DefaultValue")]
                            [Validation(Required=false)]
                            public ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeInfoValueConfigDefaultValue DefaultValue { get; set; }
                            public class ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeInfoValueConfigDefaultValue : TeaModel {
                                [NameInMap("IncludeMaxValue")]
                                [Validation(Required=false)]
                                public bool? IncludeMaxValue { get; set; }

                                [NameInMap("IncludeMinValue")]
                                [Validation(Required=false)]
                                public bool? IncludeMinValue { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("MaxValue")]
                                [Validation(Required=false)]
                                public string MaxValue { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("MinValue")]
                                [Validation(Required=false)]
                                public string MinValue { get; set; }

                                [NameInMap("ValueList")]
                                [Validation(Required=false)]
                                public List<string> ValueList { get; set; }

                            }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>6997283</para>
                            /// </summary>
                            [NameInMap("Length")]
                            [Validation(Required=false)]
                            public int? Length { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CUSTOMIZED</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            [NameInMap("ValueEnumList")]
                            [Validation(Required=false)]
                            public List<string> ValueEnumList { get; set; }

                        }

                    }

                    [NameInMap("AttributeValue")]
                    [Validation(Required=false)]
                    public ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeValue AttributeValue { get; set; }
                    public class ListQualityRulesResponseBodyPageResultQualityRuleListAttributeWithValueListAttributeValue : TeaModel {
                        [NameInMap("IncludeMaxValue")]
                        [Validation(Required=false)]
                        public bool? IncludeMaxValue { get; set; }

                        [NameInMap("IncludeMinValue")]
                        [Validation(Required=false)]
                        public bool? IncludeMinValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("MaxValue")]
                        [Validation(Required=false)]
                        public string MaxValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("MinValue")]
                        [Validation(Required=false)]
                        public string MinValue { get; set; }

                        [NameInMap("ValueList")]
                        [Validation(Required=false)]
                        public List<string> ValueList { get; set; }

                    }

                }

                [NameInMap("CatalogList")]
                [Validation(Required=false)]
                public List<string> CatalogList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EnableErrorArchive")]
                [Validation(Required=false)]
                public bool? EnableErrorArchive { get; set; }

                [NameInMap("FormPropertyList")]
                [Validation(Required=false)]
                public List<ListQualityRulesResponseBodyPageResultQualityRuleListFormPropertyList> FormPropertyList { get; set; }
                public class ListQualityRulesResponseBodyPageResultQualityRuleListFormPropertyList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>expression</para>
                    /// </summary>
                    [NameInMap("ComponentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>col</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ModifierName")]
                [Validation(Required=false)]
                public string ModifierName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ScheduleBindList")]
                [Validation(Required=false)]
                public List<ListQualityRulesResponseBodyPageResultQualityRuleListScheduleBindList> ScheduleBindList { get; set; }
                public class ListQualityRulesResponseBodyPageResultQualityRuleListScheduleBindList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ScheduleId")]
                    [Validation(Required=false)]
                    public long? ScheduleId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("ScheduleName")]
                    [Validation(Required=false)]
                    public string ScheduleName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>STRONG</para>
                /// </summary>
                [NameInMap("Strength")]
                [Validation(Required=false)]
                public string Strength { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CUSTOM</para>
                /// </summary>
                [NameInMap("TemplateScope")]
                [Validation(Required=false)]
                public string TemplateScope { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FIELD_NULL_VALUE_VALIDATE</para>
                /// </summary>
                [NameInMap("TemplateType")]
                [Validation(Required=false)]
                public string TemplateType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("TestRunRuleTaskId")]
                [Validation(Required=false)]
                public long? TestRunRuleTaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("TestRunRuleTaskStatus")]
                [Validation(Required=false)]
                public string TestRunRuleTaskStatus { get; set; }

                [NameInMap("TestRunRuleValidateResult")]
                [Validation(Required=false)]
                public bool? TestRunRuleValidateResult { get; set; }

                [NameInMap("ValidateConditionList")]
                [Validation(Required=false)]
                public List<ListQualityRulesResponseBodyPageResultQualityRuleListValidateConditionList> ValidateConditionList { get; set; }
                public class ListQualityRulesResponseBodyPageResultQualityRuleListValidateConditionList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>268</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Metric")]
                    [Validation(Required=false)]
                    public string Metric { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>AND</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>且</para>
                    /// </summary>
                    [NameInMap("OperatorName")]
                    [Validation(Required=false)]
                    public string OperatorName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("ParentId")]
                    [Validation(Required=false)]
                    public string ParentId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>RELATION</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("ValidateObject")]
                [Validation(Required=false)]
                public ListQualityRulesResponseBodyPageResultQualityRuleListValidateObject ValidateObject { get; set; }
                public class ListQualityRulesResponseBodyPageResultQualityRuleListValidateObject : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TABLE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WatchId")]
                [Validation(Required=false)]
                public long? WatchId { get; set; }

            }

            /// <summary>
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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
