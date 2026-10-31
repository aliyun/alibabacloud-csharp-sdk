// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetStandardTemplateResponseBody : TeaModel {
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

        /// <summary>
        /// <para>The template details.</para>
        /// </summary>
        [NameInMap("TemplateInfo")]
        [Validation(Required=false)]
        public GetStandardTemplateResponseBodyTemplateInfo TemplateInfo { get; set; }
        public class GetStandardTemplateResponseBodyTemplateInfo : TeaModel {
            /// <summary>
            /// <para>The attribute configuration.</para>
            /// </summary>
            [NameInMap("AttributesConfig")]
            [Validation(Required=false)]
            public GetStandardTemplateResponseBodyTemplateInfoAttributesConfig AttributesConfig { get; set; }
            public class GetStandardTemplateResponseBodyTemplateInfoAttributesConfig : TeaModel {
                /// <summary>
                /// <para>The attribute list.</para>
                /// </summary>
                [NameInMap("AttributeList")]
                [Validation(Required=false)]
                public List<GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeList> AttributeList { get; set; }
                public class GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeList : TeaModel {
                    /// <summary>
                    /// <para>The attribute code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_attr</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

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
                    /// <para>Specifies whether to enable the monitoring configuration.</para>
                    /// </summary>
                    [NameInMap("EnableMonitorConfig")]
                    [Validation(Required=false)]
                    public bool? EnableMonitorConfig { get; set; }

                    /// <summary>
                    /// <para>The ID of the attribute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1011</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The monitoring configuration.</para>
                    /// </summary>
                    [NameInMap("MonitorConfig")]
                    [Validation(Required=false)]
                    public GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListMonitorConfig MonitorConfig { get; set; }
                    public class GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListMonitorConfig : TeaModel {
                        /// <summary>
                        /// <para>The column to be checked.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>column1</para>
                        /// </summary>
                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        /// <summary>
                        /// <para>Specifies whether the check is case-sensitive.</para>
                        /// </summary>
                        [NameInMap("IsCaseSensitive")]
                        [Validation(Required=false)]
                        public bool? IsCaseSensitive { get; set; }

                        /// <summary>
                        /// <para>The monitoring method. Valid values: METADATA (metadata monitoring) and QUALITY (data quality monitoring).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>METADATA</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The attribute name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>attr1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The referenced attribute information.</para>
                    /// </summary>
                    [NameInMap("RefAttribute")]
                    [Validation(Required=false)]
                    public GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListRefAttribute RefAttribute { get; set; }
                    public class GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListRefAttribute : TeaModel {
                        /// <summary>
                        /// <para>The source of the attribute.</para>
                        /// </summary>
                        [NameInMap("AttributeFromInfo")]
                        [Validation(Required=false)]
                        public GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListRefAttributeAttributeFromInfo AttributeFromInfo { get; set; }
                        public class GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListRefAttributeAttributeFromInfo : TeaModel {
                            /// <summary>
                            /// <para>The source of the attribute. Valid values: SYSTEM (system attribute), CUSTOM (custom attribute), and STANDARD (standard).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CUSTOM</para>
                            /// </summary>
                            [NameInMap("AttributeFrom")]
                            [Validation(Required=false)]
                            public string AttributeFrom { get; set; }

                            /// <summary>
                            /// <para>The corresponding standard. This parameter takes effect when the attribute source is set to STANDARD.</para>
                            /// </summary>
                            [NameInMap("StandardReference")]
                            [Validation(Required=false)]
                            public GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListRefAttributeAttributeFromInfoStandardReference StandardReference { get; set; }
                            public class GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListRefAttributeAttributeFromInfoStandardReference : TeaModel {
                                /// <summary>
                                /// <para>The ID of the standard.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>22</para>
                                /// </summary>
                                [NameInMap("StandardId")]
                                [Validation(Required=false)]
                                public long? StandardId { get; set; }

                                /// <summary>
                                /// <para>The version number.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("Version")]
                                [Validation(Required=false)]
                                public int? Version { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The ID of the attribute.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("AttributeId")]
                        [Validation(Required=false)]
                        public long? AttributeId { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies whether the attribute is required.</para>
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// <para>The attribute type. Valid values: BIZ_ATTRIBUTE: business attribute. TECH_ATTRIBUTE: technical attribute. MANAGEMENT_ATTRIBUTE: management attribute. QUALITY_ATTRIBUTE: quality attribute. MASTER_DATA_ATTRIBUTE: master data attribute. LIFECYCLE_ATTRIBUTE: lifecycle attribute. SECURITY_ATTRIBUTE: security attribute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BIZ_ATTRIBUTE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value configuration.</para>
                    /// </summary>
                    [NameInMap("ValueConfig")]
                    [Validation(Required=false)]
                    public GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListValueConfig ValueConfig { get; set; }
                    public class GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListValueConfig : TeaModel {
                        /// <summary>
                        /// <para>The data type of the attribute value. Valid values: STRING: string. BIGINT: integer. DOUBLE: floating-point number. DATE: date accurate to day. DATETIME: date accurate to millisecond. BOOLEAN: Boolean.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>STRING</para>
                        /// </summary>
                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public string DataType { get; set; }

                        /// <summary>
                        /// <para>The default value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        /// <summary>
                        /// <para>The length of the attribute value. An empty value or -1 indicates no length limit. Typically, only string types have a length limit for attribute values.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Length")]
                        [Validation(Required=false)]
                        public int? Length { get; set; }

                        /// <summary>
                        /// <para>The attribute value type. Valid values: CUSTOMIZED: custom input. SINGLE_ENUM: single enum value. MULTIPLE_ENUMS: multiple enum values. RANGE: range value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CUSTOMIZED</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The value range.</para>
                        /// </summary>
                        [NameInMap("ValueRange")]
                        [Validation(Required=false)]
                        public GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListValueConfigValueRange ValueRange { get; set; }
                        public class GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListValueConfigValueRange : TeaModel {
                            /// <summary>
                            /// <para>The value range. This parameter takes effect when the value source is set to DATAPHIN_ATTRIBUTE. Valid values: BIZ_UNIT (business unit), PROJECT (project), USER (user), and USER_GROUP (user group).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>DATAPHIN_ATTRIBUTE</para>
                            /// </summary>
                            [NameInMap("DataphinAttributeType")]
                            [Validation(Required=false)]
                            public string DataphinAttributeType { get; set; }

                            /// <summary>
                            /// <para>The value range. This parameter takes effect when the value source is set to LOOKUP_TABLE.</para>
                            /// </summary>
                            [NameInMap("LookupTableReference")]
                            [Validation(Required=false)]
                            public GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListValueConfigValueRangeLookupTableReference LookupTableReference { get; set; }
                            public class GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListValueConfigValueRangeLookupTableReference : TeaModel {
                                /// <summary>
                                /// <para>The referenced field in the lookup table.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>col1</para>
                                /// </summary>
                                [NameInMap("Column")]
                                [Validation(Required=false)]
                                public string Column { get; set; }

                                /// <summary>
                                /// <para>The ID of the lookup table.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>11</para>
                                /// </summary>
                                [NameInMap("LookupTableId")]
                                [Validation(Required=false)]
                                public long? LookupTableId { get; set; }

                            }

                            /// <summary>
                            /// <para>The value range. This parameter takes effect when the value source is set to MIN_MAX.</para>
                            /// </summary>
                            [NameInMap("MinMaxValueConfig")]
                            [Validation(Required=false)]
                            public GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListValueConfigValueRangeMinMaxValueConfig MinMaxValueConfig { get; set; }
                            public class GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListValueConfigValueRangeMinMaxValueConfig : TeaModel {
                                /// <summary>
                                /// <para>Specifies whether the maximum value is included.</para>
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
                                /// <para>The maximum value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("MaxValue")]
                                [Validation(Required=false)]
                                public string MaxValue { get; set; }

                                /// <summary>
                                /// <para>The minimum value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("MinValue")]
                                [Validation(Required=false)]
                                public string MinValue { get; set; }

                            }

                            /// <summary>
                            /// <para>The value source. Valid values: NONE: no constraint. LIST: obtained from a list. LOOKUP_TABLE: lookup table. MIN_MAX: value between the minimum and maximum values. DATAPHIN_ATTRIBUTE: Dataphin system property. BUILT_IN_DATA_TYPES: built-in data type. BUILT_IN_DATA_CLASSIFICATION: built-in data categorization. BUILT_IN_DATA_LEVEL: built-in data security classification.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>NONE</para>
                            /// </summary>
                            [NameInMap("ValueConstraint")]
                            [Validation(Required=false)]
                            public string ValueConstraint { get; set; }

                            /// <summary>
                            /// <para>The value range. This parameter takes effect when the value source is set to LIST.</para>
                            /// </summary>
                            [NameInMap("ValueList")]
                            [Validation(Required=false)]
                            public List<string> ValueList { get; set; }

                        }

                    }

                }

            }

            /// <summary>
            /// <para>The code of the standard template. It is globally unique and cannot be modified when referenced.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The configuration of the automatic generation rule for standard codes.</para>
            /// </summary>
            [NameInMap("CodeRuleConfig")]
            [Validation(Required=false)]
            public GetStandardTemplateResponseBodyTemplateInfoCodeRuleConfig CodeRuleConfig { get; set; }
            public class GetStandardTemplateResponseBodyTemplateInfoCodeRuleConfig : TeaModel {
                /// <summary>
                /// <para>The automatic generation configuration for standard code rules. This parameter takes effect when the generation method is set to AUTO_GENERATE.</para>
                /// </summary>
                [NameInMap("AutoConfig")]
                [Validation(Required=false)]
                public GetStandardTemplateResponseBodyTemplateInfoCodeRuleConfigAutoConfig AutoConfig { get; set; }
                public class GetStandardTemplateResponseBodyTemplateInfoCodeRuleConfigAutoConfig : TeaModel {
                    /// <summary>
                    /// <para>The standard code rules.</para>
                    /// </summary>
                    [NameInMap("CodeRuleList")]
                    [Validation(Required=false)]
                    public List<GetStandardTemplateResponseBodyTemplateInfoCodeRuleConfigAutoConfigCodeRuleList> CodeRuleList { get; set; }
                    public class GetStandardTemplateResponseBodyTemplateInfoCodeRuleConfigAutoConfigCodeRuleList : TeaModel {
                        /// <summary>
                        /// <para>The configuration of the auto-increment sequence.</para>
                        /// </summary>
                        [NameInMap("AutoIncrementSequenceConfig")]
                        [Validation(Required=false)]
                        public GetStandardTemplateResponseBodyTemplateInfoCodeRuleConfigAutoConfigCodeRuleListAutoIncrementSequenceConfig AutoIncrementSequenceConfig { get; set; }
                        public class GetStandardTemplateResponseBodyTemplateInfoCodeRuleConfigAutoConfigCodeRuleListAutoIncrementSequenceConfig : TeaModel {
                            /// <summary>
                            /// <para>The number of digits.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("Digit")]
                            [Validation(Required=false)]
                            public int? Digit { get; set; }

                            /// <summary>
                            /// <para>Specifies whether to pad the sequence with zeros.</para>
                            /// </summary>
                            [NameInMap("NeedPaddingZero")]
                            [Validation(Required=false)]
                            public bool? NeedPaddingZero { get; set; }

                            /// <summary>
                            /// <para>The start value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("StartValue")]
                            [Validation(Required=false)]
                            public long? StartValue { get; set; }

                            /// <summary>
                            /// <para>The step size.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Step")]
                            [Validation(Required=false)]
                            public int? Step { get; set; }

                        }

                        /// <summary>
                        /// <para>The position index of the code rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        /// <summary>
                        /// <para>The type of the code rule. Valid values: FIXED_STRING (fixed string), AUTO_INCREMENT (auto-increment sequence), and STANDARD_SET_CODE (standard set code).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FIXED_STRING</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The format or value of the code rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies whether to enable strict validation.</para>
                    /// </summary>
                    [NameInMap("NeedStrongValidate")]
                    [Validation(Required=false)]
                    public bool? NeedStrongValidate { get; set; }

                }

                /// <summary>
                /// <para>The generation method for standard codes. Valid values: CUSTOMIZED (custom) and AUTO_GENERATE (automatically generated based on standard code rules).</para>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOMIZED</para>
                /// </summary>
                [NameInMap("GenerateType")]
                [Validation(Required=false)]
                public string GenerateType { get; set; }

            }

            /// <summary>
            /// <para>The creation time in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public GetStandardTemplateResponseBodyTemplateInfoCreator Creator { get; set; }
            public class GetStandardTemplateResponseBodyTemplateInfoCreator : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000913</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>susan</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The description of the standard template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the standard template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The last modifier.</para>
            /// </summary>
            [NameInMap("LastModifier")]
            [Validation(Required=false)]
            public GetStandardTemplateResponseBodyTemplateInfoLastModifier LastModifier { get; set; }
            public class GetStandardTemplateResponseBodyTemplateInfoLastModifier : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000913</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>susan</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The maintainers.</para>
            /// </summary>
            [NameInMap("MaintainerList")]
            [Validation(Required=false)]
            public List<GetStandardTemplateResponseBodyTemplateInfoMaintainerList> MaintainerList { get; set; }
            public class GetStandardTemplateResponseBodyTemplateInfoMaintainerList : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000913</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>susan</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The modification time in the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the standard template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The source of the standard template. Valid values: CUSTOM: custom standard template. SYSTEM: built-in standard template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("TemplateFrom")]
            [Validation(Required=false)]
            public string TemplateFrom { get; set; }

            /// <summary>
            /// <para>uniqueId</para>
            /// 
            /// <b>Example:</b>
            /// <para>1101</para>
            /// </summary>
            [NameInMap("UniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
