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
        /// <para>The details of the backend exception.</para>
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
        /// <para>Indicates whether the request was successful.</para>
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
                /// <para>The list of attributes.</para>
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
                    /// <para>Indicates whether monitoring configuration is enabled.</para>
                    /// </summary>
                    [NameInMap("EnableMonitorConfig")]
                    [Validation(Required=false)]
                    public bool? EnableMonitorConfig { get; set; }

                    /// <summary>
                    /// <para>The attribute ID.</para>
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
                        /// <para>The field to check.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>column1</para>
                        /// </summary>
                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the check is case-sensitive.</para>
                        /// </summary>
                        [NameInMap("IsCaseSensitive")]
                        [Validation(Required=false)]
                        public bool? IsCaseSensitive { get; set; }

                        /// <summary>
                        /// <para>The monitoring method. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>METADATA: metadata monitoring.</description></item>
                        /// <item><description>QUALITY: data quality monitoring.</description></item>
                        /// </list>
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
                        /// <para>The attribute source.</para>
                        /// </summary>
                        [NameInMap("AttributeFromInfo")]
                        [Validation(Required=false)]
                        public GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListRefAttributeAttributeFromInfo AttributeFromInfo { get; set; }
                        public class GetStandardTemplateResponseBodyTemplateInfoAttributesConfigAttributeListRefAttributeAttributeFromInfo : TeaModel {
                            /// <summary>
                            /// <para>The attribute source. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>SYSTEM: system attribute.</description></item>
                            /// <item><description>CUSTOM: custom attribute.</description></item>
                            /// <item><description>STANDARD: standard.</description></item>
                            /// </list>
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
                                /// <para>The standard ID.</para>
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
                        /// <para>The attribute ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("AttributeId")]
                        [Validation(Required=false)]
                        public long? AttributeId { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether the attribute is required.</para>
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// <para>The attribute type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>BIZ_ATTRIBUTE: business attribute.</description></item>
                    /// <item><description>TECH_ATTRIBUTE: technical attribute.</description></item>
                    /// <item><description>MANAGEMENT_ATTRIBUTE: management attribute.</description></item>
                    /// <item><description>QUALITY_ATTRIBUTE: quality attribute.</description></item>
                    /// <item><description>MASTER_DATA_ATTRIBUTE: master data attribute.</description></item>
                    /// <item><description>LIFECYCLE_ATTRIBUTE: lifecycle attribute.</description></item>
                    /// <item><description>SECURITY_ATTRIBUTE: security attribute.</description></item>
                    /// </list>
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
                        /// <para>The data type of the attribute value. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>STRING: string.</description></item>
                        /// <item><description>BIGINT: numeric.</description></item>
                        /// <item><description>DOUBLE: floating-point.</description></item>
                        /// <item><description>DATE: date, accurate to the day.</description></item>
                        /// <item><description>DATETIME: date, accurate to the millisecond.</description></item>
                        /// <item><description>BOOLEAN: Boolean.</description></item>
                        /// </list>
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
                        /// <para>The length of the attribute value. If this parameter is left empty or set to -1, the length is not limited. Typically, only string types have a length limit for attribute values.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Length")]
                        [Validation(Required=false)]
                        public int? Length { get; set; }

                        /// <summary>
                        /// <para>The attribute value type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>CUSTOMIZED: custom input.</description></item>
                        /// <item><description>SINGLE_ENUM: single enumeration value.</description></item>
                        /// <item><description>MULTIPLE_ENUMS: multiple enumeration values.</description></item>
                        /// <item><description>RANGE: range value.</description></item>
                        /// </list>
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
                            /// <para>The value range. This parameter takes effect when the value source is set to DATAPHIN_ATTRIBUTE. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>BIZ_UNIT: data domain.</description></item>
                            /// <item><description>PROJECT: project.</description></item>
                            /// <item><description>USER: user.</description></item>
                            /// <item><description>USER_GROUP: user group.</description></item>
                            /// </list>
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
                                /// <para>The referenced lookup table field.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>col1</para>
                                /// </summary>
                                [NameInMap("Column")]
                                [Validation(Required=false)]
                                public string Column { get; set; }

                                /// <summary>
                                /// <para>The lookup table ID.</para>
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
                            /// <para>The value source. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>NONE: no constraint.</description></item>
                            /// <item><description>LIST: obtained from a list.</description></item>
                            /// <item><description>LOOKUP_TABLE: lookup table.</description></item>
                            /// <item><description>MIN_MAX: value between the minimum and maximum.</description></item>
                            /// <item><description>DATAPHIN_ATTRIBUTE: Dataphin system property.</description></item>
                            /// <item><description>BUILT_IN_DATA_TYPES: built-in data types.</description></item>
                            /// <item><description>BUILT_IN_DATA_CLASSIFICATION: built-in data categorization.</description></item>
                            /// <item><description>BUILT_IN_DATA_LEVEL: built-in data security classification.</description></item>
                            /// </list>
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
            /// <para>The code of the standard template. This value is globally unique and cannot be modified when references exist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The auto-generation rule configuration for the standard code.</para>
            /// </summary>
            [NameInMap("CodeRuleConfig")]
            [Validation(Required=false)]
            public GetStandardTemplateResponseBodyTemplateInfoCodeRuleConfig CodeRuleConfig { get; set; }
            public class GetStandardTemplateResponseBodyTemplateInfoCodeRuleConfig : TeaModel {
                /// <summary>
                /// <para>The auto-generation configuration for the standard code rule. This parameter takes effect when the generation method is set to AUTO_GENERATE.</para>
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
                        /// <para>The auto-increment sequence configuration.</para>
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
                            /// <para>Indicates whether zero-padding is required.</para>
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
                        /// <para>The code rule type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>FIXED_STRING: fixed string.</description></item>
                        /// <item><description>AUTO_INCREMENT: auto-increment sequence.</description></item>
                        /// <item><description>STANDARD_SET_CODE: standard set code.</description></item>
                        /// </list>
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
                    /// <para>Indicates whether strong validation is required.</para>
                    /// </summary>
                    [NameInMap("NeedStrongValidate")]
                    [Validation(Required=false)]
                    public bool? NeedStrongValidate { get; set; }

                }

                /// <summary>
                /// <para>The standard code generation method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CUSTOMIZED: custom.</description></item>
                /// <item><description>AUTO_GENERATE: automatically generated based on the standard code rule.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOMIZED</para>
                /// </summary>
                [NameInMap("GenerateType")]
                [Validation(Required=false)]
                public string GenerateType { get; set; }

            }

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
            /// <para>The standard template ID.</para>
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
            /// <para>The list of maintainers.</para>
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
            /// <para>The modification time.</para>
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
            /// <para>测试模板</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The source of the standard template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CUSTOM: custom standard template.</description></item>
            /// <item><description>SYSTEM: system built-in standard template.</description></item>
            /// </list>
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
