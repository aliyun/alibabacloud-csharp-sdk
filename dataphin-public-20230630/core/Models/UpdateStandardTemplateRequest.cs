// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateStandardTemplateRequest : TeaModel {
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
        /// <para>The update command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateStandardTemplateRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateStandardTemplateRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The attribute configuration.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("AttributesConfig")]
            [Validation(Required=false)]
            public UpdateStandardTemplateRequestUpdateCommandAttributesConfig AttributesConfig { get; set; }
            public class UpdateStandardTemplateRequestUpdateCommandAttributesConfig : TeaModel {
                /// <summary>
                /// <para>The list of attributes.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("AttributeList")]
                [Validation(Required=false)]
                public List<UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeList> AttributeList { get; set; }
                public class UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeList : TeaModel {
                    /// <summary>
                    /// <para>The attribute code. This parameter is optional when a common attribute is referenced.</para>
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
                    /// <para>The attribute name. This parameter is optional when a common attribute is referenced.</para>
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
                    public UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeListRefAttribute RefAttribute { get; set; }
                    public class UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeListRefAttribute : TeaModel {
                        /// <summary>
                        /// <para>The attribute source.</para>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("AttributeFromInfo")]
                        [Validation(Required=false)]
                        public UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeListRefAttributeAttributeFromInfo AttributeFromInfo { get; set; }
                        public class UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeListRefAttributeAttributeFromInfo : TeaModel {
                            /// <summary>
                            /// <para>The attribute source. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>SYSTEM: system attribute.</description></item>
                            /// <item><description>CUSTOM: custom attribute.</description></item>
                            /// <item><description>STANDARD: standard.</description></item>
                            /// </list>
                            /// <para>This parameter is required.</para>
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
                            public UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeListRefAttributeAttributeFromInfoStandardReference StandardReference { get; set; }
                            public class UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeListRefAttributeAttributeFromInfoStandardReference : TeaModel {
                                /// <summary>
                                /// <para>The standard ID.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>22</para>
                                /// </summary>
                                [NameInMap("StandardId")]
                                [Validation(Required=false)]
                                public long? StandardId { get; set; }

                                /// <summary>
                                /// <para>The version number.</para>
                                /// <para>This parameter is required.</para>
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
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("AttributeId")]
                        [Validation(Required=false)]
                        public long? AttributeId { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies whether the attribute is required. This parameter is optional when a common attribute is referenced.</para>
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// <para>The attribute type. This parameter is optional when a common attribute is referenced. Valid values:</para>
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
                    /// <para>The value configuration. This parameter is optional when a common attribute is referenced.</para>
                    /// </summary>
                    [NameInMap("ValueConfig")]
                    [Validation(Required=false)]
                    public UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeListValueConfig ValueConfig { get; set; }
                    public class UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeListValueConfig : TeaModel {
                        /// <summary>
                        /// <para>The data type of the attribute value. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>STRING: string.</description></item>
                        /// <item><description>BIGINT: numeric.</description></item>
                        /// <item><description>DOUBLE: floating-point.</description></item>
                        /// <item><description>DATE: date, accurate to the day.</description></item>
                        /// <item><description>DATETIME: date, accurate to milliseconds.</description></item>
                        /// <item><description>BOOLEAN: Boolean.</description></item>
                        /// </list>
                        /// <para>This parameter is required.</para>
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
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CUSTOMIZED</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The value range.</para>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("ValueRange")]
                        [Validation(Required=false)]
                        public UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeListValueConfigValueRange ValueRange { get; set; }
                        public class UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeListValueConfigValueRange : TeaModel {
                            /// <summary>
                            /// <para>The value range. This parameter takes effect when the value source is set to DATAPHIN_ATTRIBUTE. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>BIZ_UNIT: data board.</description></item>
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
                            public UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeListValueConfigValueRangeLookupTableReference LookupTableReference { get; set; }
                            public class UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeListValueConfigValueRangeLookupTableReference : TeaModel {
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
                                /// <para>The ID of the lookup table.</para>
                                /// <para>This parameter is required.</para>
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
                            public UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeListValueConfigValueRangeMinMaxValueConfig MinMaxValueConfig { get; set; }
                            public class UpdateStandardTemplateRequestUpdateCommandAttributesConfigAttributeListValueConfigValueRangeMinMaxValueConfig : TeaModel {
                                /// <summary>
                                /// <para>Specifies whether the maximum value is included.</para>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("IncludeMaxValue")]
                                [Validation(Required=false)]
                                public bool? IncludeMaxValue { get; set; }

                                /// <summary>
                                /// <para>Specifies whether the minimum value is included.</para>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("IncludeMinValue")]
                                [Validation(Required=false)]
                                public bool? IncludeMinValue { get; set; }

                                /// <summary>
                                /// <para>The maximum value.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("MaxValue")]
                                [Validation(Required=false)]
                                public string MaxValue { get; set; }

                                /// <summary>
                                /// <para>The minimum value.</para>
                                /// <para>This parameter is required.</para>
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
                            /// <para>This parameter is required.</para>
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
            /// <para>The code of the standard template. The code must be globally unique. The code cannot be modified if the template is referenced.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The configuration for automatic generation of standard codes.</para>
            /// </summary>
            [NameInMap("CodeRuleConfig")]
            [Validation(Required=false)]
            public UpdateStandardTemplateRequestUpdateCommandCodeRuleConfig CodeRuleConfig { get; set; }
            public class UpdateStandardTemplateRequestUpdateCommandCodeRuleConfig : TeaModel {
                /// <summary>
                /// <para>The automatic generation configuration for standard code rules. This parameter takes effect when the generation method is set to AUTO_GENERATE.</para>
                /// </summary>
                [NameInMap("AutoConfig")]
                [Validation(Required=false)]
                public UpdateStandardTemplateRequestUpdateCommandCodeRuleConfigAutoConfig AutoConfig { get; set; }
                public class UpdateStandardTemplateRequestUpdateCommandCodeRuleConfigAutoConfig : TeaModel {
                    /// <summary>
                    /// <para>The standard code rules.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("CodeRuleList")]
                    [Validation(Required=false)]
                    public List<UpdateStandardTemplateRequestUpdateCommandCodeRuleConfigAutoConfigCodeRuleList> CodeRuleList { get; set; }
                    public class UpdateStandardTemplateRequestUpdateCommandCodeRuleConfigAutoConfigCodeRuleList : TeaModel {
                        /// <summary>
                        /// <para>The auto-increment sequence configuration.</para>
                        /// </summary>
                        [NameInMap("AutoIncrementSequenceConfig")]
                        [Validation(Required=false)]
                        public UpdateStandardTemplateRequestUpdateCommandCodeRuleConfigAutoConfigCodeRuleListAutoIncrementSequenceConfig AutoIncrementSequenceConfig { get; set; }
                        public class UpdateStandardTemplateRequestUpdateCommandCodeRuleConfigAutoConfigCodeRuleListAutoIncrementSequenceConfig : TeaModel {
                            /// <summary>
                            /// <para>The number of digits.</para>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("Digit")]
                            [Validation(Required=false)]
                            public int? Digit { get; set; }

                            /// <summary>
                            /// <para>Specifies whether to pad with zeros.</para>
                            /// <para>This parameter is required.</para>
                            /// </summary>
                            [NameInMap("NeedPaddingZero")]
                            [Validation(Required=false)]
                            public bool? NeedPaddingZero { get; set; }

                            /// <summary>
                            /// <para>The start value.</para>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("StartValue")]
                            [Validation(Required=false)]
                            public long? StartValue { get; set; }

                            /// <summary>
                            /// <para>The step size.</para>
                            /// <para>This parameter is required.</para>
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
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        /// <summary>
                        /// <para>The type of the code rule. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>FIXED_STRING: fixed string.</description></item>
                        /// <item><description>AUTO_INCREMENT: auto-increment sequence.</description></item>
                        /// <item><description>STANDARD_SET_CODE: standard set code.</description></item>
                        /// </list>
                        /// <para>This parameter is required.</para>
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
                    /// <para>Specifies whether strict validation is required.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("NeedStrongValidate")]
                    [Validation(Required=false)]
                    public bool? NeedStrongValidate { get; set; }

                }

                /// <summary>
                /// <para>The standard code generation method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CUSTOMIZED: custom.</description></item>
                /// <item><description>AUTO_GENERATE: automatically generated based on standard code rules.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOMIZED</para>
                /// </summary>
                [NameInMap("GenerateType")]
                [Validation(Required=false)]
                public string GenerateType { get; set; }

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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The list of maintainers.</para>
            /// </summary>
            [NameInMap("MaintainerList")]
            [Validation(Required=false)]
            public List<string> MaintainerList { get; set; }

            /// <summary>
            /// <para>The name of the standard template.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试模板</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The publish information of the standard template.</para>
            /// </summary>
            [NameInMap("PublishInfo")]
            [Validation(Required=false)]
            public UpdateStandardTemplateRequestUpdateCommandPublishInfo PublishInfo { get; set; }
            public class UpdateStandardTemplateRequestUpdateCommandPublishInfo : TeaModel {
                /// <summary>
                /// <para>The publish comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

            }

            /// <summary>
            /// <para>The version number. If this parameter is left empty or set to -1, the latest version is used.</para>
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
