// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateStandardTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Create command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateStandardTemplateRequestCreateCommand CreateCommand { get; set; }
        public class CreateStandardTemplateRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>Attribute configuration.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("AttributesConfig")]
            [Validation(Required=false)]
            public CreateStandardTemplateRequestCreateCommandAttributesConfig AttributesConfig { get; set; }
            public class CreateStandardTemplateRequestCreateCommandAttributesConfig : TeaModel {
                /// <summary>
                /// <para>Attribute list.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("AttributeList")]
                [Validation(Required=false)]
                public List<CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeList> AttributeList { get; set; }
                public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeList : TeaModel {
                    /// <summary>
                    /// <para>Attribute code. Not required when referencing a public attribute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_attr</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>Description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Attribute name. Not required when referencing a public attribute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>attr1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Referenced attribute information.</para>
                    /// </summary>
                    [NameInMap("RefAttribute")]
                    [Validation(Required=false)]
                    public CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListRefAttribute RefAttribute { get; set; }
                    public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListRefAttribute : TeaModel {
                        /// <summary>
                        /// <para>Attribute source.</para>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("AttributeFromInfo")]
                        [Validation(Required=false)]
                        public CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListRefAttributeAttributeFromInfo AttributeFromInfo { get; set; }
                        public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListRefAttributeAttributeFromInfo : TeaModel {
                            /// <summary>
                            /// <para>Attribute source type. Valid values: SYSTEM (system attribute), CUSTOM (custom attribute), and STANDARD (standard).</para>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CUSTOM</para>
                            /// </summary>
                            [NameInMap("AttributeFrom")]
                            [Validation(Required=false)]
                            public string AttributeFrom { get; set; }

                            /// <summary>
                            /// <para>Standard reference. Effective when the attribute source is STANDARD.</para>
                            /// </summary>
                            [NameInMap("StandardReference")]
                            [Validation(Required=false)]
                            public CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListRefAttributeAttributeFromInfoStandardReference StandardReference { get; set; }
                            public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListRefAttributeAttributeFromInfoStandardReference : TeaModel {
                                /// <summary>
                                /// <para>Standard ID.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>22</para>
                                /// </summary>
                                [NameInMap("StandardId")]
                                [Validation(Required=false)]
                                public long? StandardId { get; set; }

                                /// <summary>
                                /// <para>Version number.</para>
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
                        /// <para>Attribute ID.</para>
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
                    /// <para>Specifies whether the attribute is required. Not required when referencing a public attribute.</para>
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// <para>Attribute type. Valid values: BIZ_ATTRIBUTE (business attribute), TECH_ATTRIBUTE (technical attribute), MANAGEMENT_ATTRIBUTE (management attribute), QUALITY_ATTRIBUTE (quality attribute), MASTER_DATA_ATTRIBUTE (master data attribute), LIFECYCLE_ATTRIBUTE (lifecycle attribute), and SECURITY_ATTRIBUTE (security attribute). Not required when referencing a public attribute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BIZ_ATTRIBUTE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>Value configuration. Not required when referencing a public attribute.</para>
                    /// </summary>
                    [NameInMap("ValueConfig")]
                    [Validation(Required=false)]
                    public CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListValueConfig ValueConfig { get; set; }
                    public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListValueConfig : TeaModel {
                        /// <summary>
                        /// <para>Data type of the attribute value. Valid values: STRING (string), BIGINT (numeric), DOUBLE (floating point), DATE (date with day precision), DATETIME (date with millisecond precision), and BOOLEAN (boolean).</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>STRING</para>
                        /// </summary>
                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public string DataType { get; set; }

                        /// <summary>
                        /// <para>Default value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        /// <summary>
                        /// <para>Attribute value length. An empty value or -1 indicates no length limit. Usually only the string type has a length limit for attribute values.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Length")]
                        [Validation(Required=false)]
                        public int? Length { get; set; }

                        /// <summary>
                        /// <para>Attribute value type. Valid values: CUSTOMIZED (custom input), SINGLE_ENUM (single enumeration value), MULTIPLE_ENUMS (multiple enumeration values), and RANGE (range value).</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CUSTOMIZED</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>Value range.</para>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("ValueRange")]
                        [Validation(Required=false)]
                        public CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListValueConfigValueRange ValueRange { get; set; }
                        public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListValueConfigValueRange : TeaModel {
                            /// <summary>
                            /// <para>Dataphin attribute type. Effective when the value source is DATAPHIN_ATTRIBUTE. Valid values: BIZ_UNIT (data domain), PROJECT (project), USER (user), and USER_GROUP (user group).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>DATAPHIN_ATTRIBUTE</para>
                            /// </summary>
                            [NameInMap("DataphinAttributeType")]
                            [Validation(Required=false)]
                            public string DataphinAttributeType { get; set; }

                            /// <summary>
                            /// <para>Lookup table reference. Effective when the value source is LOOKUP_TABLE.</para>
                            /// </summary>
                            [NameInMap("LookupTableReference")]
                            [Validation(Required=false)]
                            public CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListValueConfigValueRangeLookupTableReference LookupTableReference { get; set; }
                            public class CreateStandardTemplateRequestCreateCommandAttributesConfigAttributeListValueConfigValueRangeLookupTableReference : TeaModel {
                                /// <summary>
                                /// <para>Referenced lookup table column.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>col1</para>
                                /// </summary>
                                [NameInMap("Column")]
                                [Validation(Required=false)]
                                public string Column { get; set; }

                                /// <summary>
                                /// <para>Lookup table ID.</para>
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
                            /// <para>Min-max value configuration. Effective when the value source is MIN_MAX.</para>
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
                                /// <para>Maximum value.</para>
                                /// <para>This parameter is required.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("MaxValue")]
                                [Validation(Required=false)]
                                public string MaxValue { get; set; }

                                /// <summary>
                                /// <para>Minimum value.</para>
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
                            /// <para>Value source. Valid values: NONE (no constraint), LIST (from a list), LOOKUP_TABLE (lookup table), MIN_MAX (between minimum and maximum values), DATAPHIN_ATTRIBUTE (Dataphin system attribute), BUILT_IN_DATA_TYPES (built-in data types), BUILT_IN_DATA_CLASSIFICATION (built-in data classification), and BUILT_IN_DATA_LEVEL (built-in data security level).</para>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>NONE</para>
                            /// </summary>
                            [NameInMap("ValueConstraint")]
                            [Validation(Required=false)]
                            public string ValueConstraint { get; set; }

                            /// <summary>
                            /// <para>Value list. Effective when the value source is LIST.</para>
                            /// </summary>
                            [NameInMap("ValueList")]
                            [Validation(Required=false)]
                            public List<string> ValueList { get; set; }

                        }

                    }

                }

            }

            /// <summary>
            /// <para>Standard template code. Globally unique. Cannot be modified when referenced.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Standard code auto-generation rule configuration.</para>
            /// </summary>
            [NameInMap("CodeRuleConfig")]
            [Validation(Required=false)]
            public CreateStandardTemplateRequestCreateCommandCodeRuleConfig CodeRuleConfig { get; set; }
            public class CreateStandardTemplateRequestCreateCommandCodeRuleConfig : TeaModel {
                /// <summary>
                /// <para>Standard code rule auto-generation configuration. Effective when the generation method is AUTO_GENERATE.</para>
                /// </summary>
                [NameInMap("AutoConfig")]
                [Validation(Required=false)]
                public CreateStandardTemplateRequestCreateCommandCodeRuleConfigAutoConfig AutoConfig { get; set; }
                public class CreateStandardTemplateRequestCreateCommandCodeRuleConfigAutoConfig : TeaModel {
                    /// <summary>
                    /// <para>Standard code rules.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("CodeRuleList")]
                    [Validation(Required=false)]
                    public List<CreateStandardTemplateRequestCreateCommandCodeRuleConfigAutoConfigCodeRuleList> CodeRuleList { get; set; }
                    public class CreateStandardTemplateRequestCreateCommandCodeRuleConfigAutoConfigCodeRuleList : TeaModel {
                        /// <summary>
                        /// <para>Auto-increment sequence configuration.</para>
                        /// </summary>
                        [NameInMap("AutoIncrementSequenceConfig")]
                        [Validation(Required=false)]
                        public CreateStandardTemplateRequestCreateCommandCodeRuleConfigAutoConfigCodeRuleListAutoIncrementSequenceConfig AutoIncrementSequenceConfig { get; set; }
                        public class CreateStandardTemplateRequestCreateCommandCodeRuleConfigAutoConfigCodeRuleListAutoIncrementSequenceConfig : TeaModel {
                            /// <summary>
                            /// <para>Number of digits.</para>
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
                            /// <para>Start value.</para>
                            /// <para>This parameter is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("StartValue")]
                            [Validation(Required=false)]
                            public long? StartValue { get; set; }

                            /// <summary>
                            /// <para>Step.</para>
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
                        /// <para>Code rule position index.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        /// <summary>
                        /// <para>Code rule type. Valid values: FIXED_STRING (fixed string), AUTO_INCREMENT (auto-increment sequence), and STANDARD_SET_CODE (standard set code).</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FIXED_STRING</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>Code rule format or value.</para>
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
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("NeedStrongValidate")]
                    [Validation(Required=false)]
                    public bool? NeedStrongValidate { get; set; }

                }

                /// <summary>
                /// <para>Standard code generation method. Valid values: CUSTOMIZED (custom) and AUTO_GENERATE (auto-generate based on standard code rules).</para>
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
            /// <para>Standard template description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Maintainers.</para>
            /// </summary>
            [NameInMap("MaintainerList")]
            [Validation(Required=false)]
            public List<string> MaintainerList { get; set; }

            /// <summary>
            /// <para>Standard template name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试模板</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Standard template publish information.</para>
            /// </summary>
            [NameInMap("PublishInfo")]
            [Validation(Required=false)]
            public CreateStandardTemplateRequestCreateCommandPublishInfo PublishInfo { get; set; }
            public class CreateStandardTemplateRequestCreateCommandPublishInfo : TeaModel {
                /// <summary>
                /// <para>Publish comment.</para>
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
        /// <para>Tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
