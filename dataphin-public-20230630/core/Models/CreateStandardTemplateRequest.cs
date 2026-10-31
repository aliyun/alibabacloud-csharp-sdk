// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateStandardTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The create command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateStandardTemplateRequestCreateCommand CreateCommand { get; set; }
        public class CreateStandardTemplateRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The attribute configuration.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("AttributesConfig")]
            [Validation(Required=false)]
            public CreateStandardTemplateRequestCreateCommandAttributesConfig AttributesConfig { get; set; }
            public class CreateStandardTemplateRequestCreateCommandAttributesConfig : TeaModel {
                /// <summary>
                /// <para>The attribute list.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("AttributeList")]
                [Validation(Required=false)]
                public List<CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeList> AttributeList { get; set; }
                public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeList : TeaModel {
                    /// <summary>
                    /// <para>The attribute code. This parameter is not required when a common attribute is referenced.</para>
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
                    /// <para>The attribute name. This parameter is not required when a common attribute is referenced.</para>
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
                    public CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListRefAttribute RefAttribute { get; set; }
                    public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListRefAttribute : TeaModel {
                        /// <summary>
                        /// <para>The source of the attribute.</para>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("AttributeFromInfo")]
                        [Validation(Required=false)]
                        public CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListRefAttributeAttributeFromInfo AttributeFromInfo { get; set; }
                        public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListRefAttributeAttributeFromInfo : TeaModel {
                            /// <summary>
                            /// <para>The source of the attribute. Valid values: SYSTEM (system attribute), CUSTOM (custom attribute), and STANDARD (standard).</para>
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
                            public CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListRefAttributeAttributeFromInfoStandardReference StandardReference { get; set; }
                            public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListRefAttributeAttributeFromInfoStandardReference : TeaModel {
                                /// <summary>
                                /// <para>The ID of the standard.</para>
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
                        /// <para>The ID of the attribute.</para>
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
                    /// <para>Specifies whether the attribute is required. This parameter is not required when a common attribute is referenced.</para>
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// <para>The attribute type. Valid values: BIZ_ATTRIBUTE (business attribute), TECH_ATTRIBUTE (technical attribute), MANAGEMENT_ATTRIBUTE (management attribute), QUALITY_ATTRIBUTE (quality attribute), MASTER_DATA_ATTRIBUTE (master data attribute), LIFECYCLE_ATTRIBUTE (lifecycle attribute), and SECURITY_ATTRIBUTE (security attribute). This parameter is not required when a common attribute is referenced.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BIZ_ATTRIBUTE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value configuration. This parameter is not required when a common attribute is referenced.</para>
                    /// </summary>
                    [NameInMap("ValueConfig")]
                    [Validation(Required=false)]
                    public CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListValueConfig ValueConfig { get; set; }
                    public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListValueConfig : TeaModel {
                        /// <summary>
                        /// <para>The data type of the attribute value. Valid values: STRING (string), BIGINT (numeric), DOUBLE (floating-point), DATE (date, accurate to the day), DATETIME (date and time, accurate to the millisecond), and BOOLEAN (Boolean).</para>
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
                        /// <para>The length of the attribute value. An empty value or -1 indicates that the length is not limited. Typically, the length is limited only for string types.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Length")]
                        [Validation(Required=false)]
                        public int? Length { get; set; }

                        /// <summary>
                        /// <para>The attribute value type. Valid values: CUSTOMIZED (custom input), SINGLE_ENUM (single enumerated value), MULTIPLE_ENUMS (multiple enumerated values), and RANGE (range value).</para>
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
                        public CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListValueConfigValueRange ValueRange { get; set; }
                        public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListValueConfigValueRange : TeaModel {
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
                            public CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListValueConfigValueRangeLookupTableReference LookupTableReference { get; set; }
                            public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListValueConfigValueRangeLookupTableReference : TeaModel {
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
                            public CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListValueConfigValueRangeMinMaxValueConfig MinMaxValueConfig { get; set; }
                            public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListValueConfigValueRangeMinMaxValueConfig : TeaModel {
                                /// <summary>
                                /// <para>Specifies whether to include the maximum value.</para>
                                /// <para>This parameter is required.</para>
                                /// </summary>
                                [NameInMap("IncludeMaxValue")]
                                [Validation(Required=false)]
                                public bool? IncludeMaxValue { get; set; }

                                /// <summary>
                                /// <para>Specifies whether to include the minimum value.</para>
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
                            /// <para>The value source. Valid values: NONE (no constraint), LIST (obtained from a list), LOOKUP_TABLE (lookup table), MIN_MAX (value between the maximum and minimum values), DATAPHIN_ATTRIBUTE (Dataphin system property), BUILT_IN_DATA_TYPES (built-in data type), BUILT_IN_DATA_CLASSIFICATION (built-in data categorization), and BUILT_IN_DATA_LEVEL (built-in data security classification).</para>
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
            /// <para>The standard template code. It is globally unique and cannot be modified when referenced.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The standard code auto-generation rule configuration.</para>
            /// </summary>
            [NameInMap("CodeRuleConfig")]
            [Validation(Required=false)]
            public CreateStandardTemplateRequestCreateCommandCodeRuleConfig CodeRuleConfig { get; set; }
            public class CreateStandardTemplateRequestCreateCommandCodeRuleConfig : TeaModel {
                /// <summary>
                /// <para>The auto-generation configuration for standard code rules. This configuration takes effect only when the generation method is set to AUTO_GENERATE.</para>
                /// </summary>
                [NameInMap("AutoConfig")]
                [Validation(Required=false)]
                public CreateStandardTemplateRequestCreateCommandCodeRuleConfigAutoConfig AutoConfig { get; set; }
                public class CreateStandardTemplateRequestCreateCommandCodeRuleConfigAutoConfig : TeaModel {
                    /// <summary>
                    /// <para>The standard code rules.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("CodeRuleList")]
                    [Validation(Required=false)]
                    public List<CreateStandardTemplateRequestCreateCommandCodeRuleConfigAutoConfigCodeRuleList> CodeRuleList { get; set; }
                    public class CreateStandardTemplateRequestCreateCommandCodeRuleConfigAutoConfigCodeRuleList : TeaModel {
                        /// <summary>
                        /// <para>The auto-increment sequence configuration.</para>
                        /// </summary>
                        [NameInMap("AutoIncrementSequenceConfig")]
                        [Validation(Required=false)]
                        public CreateStandardTemplateRequestCreateCommandCodeRuleConfigAutoConfigCodeRuleListAutoIncrementSequenceConfig AutoIncrementSequenceConfig { get; set; }
                        public class CreateStandardTemplateRequestCreateCommandCodeRuleConfigAutoConfigCodeRuleListAutoIncrementSequenceConfig : TeaModel {
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
                        /// <para>The type of the code rule. Valid values: FIXED_STRING: Fixed string. AUTO_INCREMENT: Auto-increment sequence. STANDARD_SET_CODE: Standard set code.</para>
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
                    /// <para>Specifies whether strict validation is enabled.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("NeedStrongValidate")]
                    [Validation(Required=false)]
                    public bool? NeedStrongValidate { get; set; }

                }

                /// <summary>
                /// <para>The standard code generation method. Valid values: CUSTOMIZED: Custom. AUTO_GENERATE: Automatically generated based on standard code rules.</para>
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
            /// <para>The standard template description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The maintainers.</para>
            /// </summary>
            [NameInMap("MaintainerList")]
            [Validation(Required=false)]
            public List<string> MaintainerList { get; set; }

            /// <summary>
            /// <para>The standard template name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The release information of the standard template.</para>
            /// </summary>
            [NameInMap("PublishInfo")]
            [Validation(Required=false)]
            public CreateStandardTemplateRequestCreateCommandPublishInfo PublishInfo { get; set; }
            public class CreateStandardTemplateRequestCreateCommandPublishInfo : TeaModel {
                /// <summary>
                /// <para>The release comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

            }

        }

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

    }

}
