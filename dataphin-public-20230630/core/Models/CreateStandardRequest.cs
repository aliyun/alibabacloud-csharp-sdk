// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateStandardRequest : TeaModel {
        /// <summary>
        /// <para>The create command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateStandardRequestCreateCommand CreateCommand { get; set; }
        public class CreateStandardRequestCreateCommand : TeaModel {
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
            /// <para>The effective period configuration.</para>
            /// </summary>
            [NameInMap("EffectiveTimeConfig")]
            [Validation(Required=false)]
            public CreateStandardRequestCreateCommandEffectiveTimeConfig EffectiveTimeConfig { get; set; }
            public class CreateStandardRequestCreateCommandEffectiveTimeConfig : TeaModel {
                /// <summary>
                /// <para>The end of the effective period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-30 00:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The start of the effective period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The effective period type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>FOREVER: permanent.</description></item>
                /// <item><description>TIME_PERIOD: time period.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TIME_PERIOD</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to generate a standard code based on rules. If this parameter is set to true, the standard code specified in the attribute values is ignored and a new standard code is generated.</para>
            /// </summary>
            [NameInMap("NeedGenerateStandardCode")]
            [Validation(Required=false)]
            public bool? NeedGenerateStandardCode { get; set; }

            /// <summary>
            /// <para>The owner. If this parameter is not specified, the current user is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300000913</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The standard monitoring configuration.</para>
            /// </summary>
            [NameInMap("StandardGeneralMonitorConfig")]
            [Validation(Required=false)]
            public CreateStandardRequestCreateCommandStandardGeneralMonitorConfig StandardGeneralMonitorConfig { get; set; }
            public class CreateStandardRequestCreateCommandStandardGeneralMonitorConfig : TeaModel {
                /// <summary>
                /// <para>The list of standard monitoring configurations.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("StandardMonitorConfigList")]
                [Validation(Required=false)]
                public List<CreateStandardRequestCreateCommandStandardGeneralMonitorConfigStandardMonitorConfigList> StandardMonitorConfigList { get; set; }
                public class CreateStandardRequestCreateCommandStandardGeneralMonitorConfigStandardMonitorConfigList : TeaModel {
                    /// <summary>
                    /// <para>The associated attribute ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>112</para>
                    /// </summary>
                    [NameInMap("AttributeId")]
                    [Validation(Required=false)]
                    public long? AttributeId { get; set; }

                    /// <summary>
                    /// <para>The monitoring configuration for the associated attribute.</para>
                    /// </summary>
                    [NameInMap("AttributeMonitorConfig")]
                    [Validation(Required=false)]
                    public CreateStandardRequestCreateCommandStandardGeneralMonitorConfigStandardMonitorConfigListAttributeMonitorConfig AttributeMonitorConfig { get; set; }
                    public class CreateStandardRequestCreateCommandStandardGeneralMonitorConfigStandardMonitorConfigListAttributeMonitorConfig : TeaModel {
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
                        /// <para>Specifies whether the check is case-sensitive.</para>
                        /// <para>This parameter is required.</para>
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
                        /// <para>This parameter is required.</para>
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
                    /// <para>teset</para>
                    /// </summary>
                    [NameInMap("AttributeName")]
                    [Validation(Required=false)]
                    public string AttributeName { get; set; }

                    /// <summary>
                    /// <para>The rule description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The monitoring configuration ID. If this parameter is left empty, a new monitoring configuration is created. If an existing monitoring configuration ID is specified, the corresponding monitoring configuration is updated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The method used to add the monitoring configuration. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>BY_USER: manually added.</description></item>
                    /// <item><description>BY_SYSTEM_ATTRIBUTE: preset by system attribute.</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BY_SYSTEM_ATTRIBUTE</para>
                    /// </summary>
                    [NameInMap("MonitorFrom")]
                    [Validation(Required=false)]
                    public string MonitorFrom { get; set; }

                    /// <summary>
                    /// <para>The rule template. This parameter is required when the monitoring type is QUALITY.</para>
                    /// </summary>
                    [NameInMap("QualityRuleTemplate")]
                    [Validation(Required=false)]
                    public CreateStandardRequestCreateCommandStandardGeneralMonitorConfigStandardMonitorConfigListQualityRuleTemplate QualityRuleTemplate { get; set; }
                    public class CreateStandardRequestCreateCommandStandardGeneralMonitorConfigStandardMonitorConfigListQualityRuleTemplate : TeaModel {
                        /// <summary>
                        /// <para>The template ID.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>22</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <para>The template name.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CUSTOMIZED</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The template source. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>FROM_SYSTEM: system template.</description></item>
                        /// <item><description>CUSTOMIZED: custom template.</description></item>
                        /// </list>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CUSTOMIZED</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The rule configurations. This parameter is required when the monitoring type is QUALITY.</para>
                    /// </summary>
                    [NameInMap("RuleConfigList")]
                    [Validation(Required=false)]
                    public List<CreateStandardRequestCreateCommandStandardGeneralMonitorConfigStandardMonitorConfigListRuleConfigList> RuleConfigList { get; set; }
                    public class CreateStandardRequestCreateCommandStandardGeneralMonitorConfigStandardMonitorConfigListRuleConfigList : TeaModel {
                        /// <summary>
                        /// <para>The configuration item.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>k1</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The configuration item value.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>v1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The rule name.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// <para>The rule subtype. This parameter is required when the monitoring type is QUALITY. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>BY_ATTRIBUTE: configured based on attributes.</description></item>
                    /// <item><description>CUSTOMIZED: custom configuration.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CUSTOMIZED</para>
                    /// </summary>
                    [NameInMap("RuleSubType")]
                    [Validation(Required=false)]
                    public string RuleSubType { get; set; }

                    /// <summary>
                    /// <para>The rule validation configurations. This parameter is required when the monitoring type is QUALITY.</para>
                    /// </summary>
                    [NameInMap("RuleValidateConfigList")]
                    [Validation(Required=false)]
                    public List<CreateStandardRequestCreateCommandStandardGeneralMonitorConfigStandardMonitorConfigListRuleValidateConfigList> RuleValidateConfigList { get; set; }
                    public class CreateStandardRequestCreateCommandStandardGeneralMonitorConfigStandardMonitorConfigListRuleValidateConfigList : TeaModel {
                        /// <summary>
                        /// <para>The validation configuration ID. This ID is randomly generated by the business and must be unique.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>abc</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The metric. This parameter is required when the validation type is EXPRESSION.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>a</para>
                        /// </summary>
                        [NameInMap("Metric")]
                        [Validation(Required=false)]
                        public string Metric { get; set; }

                        /// <summary>
                        /// <para>The metric name. This parameter is required when the validation type is EXPRESSION.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("MetricName")]
                        [Validation(Required=false)]
                        public string MetricName { get; set; }

                        /// <summary>
                        /// <para>If the validation type is EXPRESSION, valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>EQUAL: equal to.</description></item>
                        /// <item><description>NOT_EQUAL: not equal to.</description></item>
                        /// <item><description>LARGER: greater than.</description></item>
                        /// <item><description>LARGE_OR_EQUAL: greater than or equal to.</description></item>
                        /// <item><description>SMALLER: less than.</description></item>
                        /// <item><description>SMALLER_OR_EQUAL: less than or equal to.</description></item>
                        /// </list>
                        /// <para>If the validation type is RELATION, valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>AND: and.</description></item>
                        /// <item><description>OR: or.</description></item>
                        /// </list>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AND</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <para>The parent validation configuration ID. The parent rule validation type can only be RELATION.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>a</para>
                        /// </summary>
                        [NameInMap("ParentId")]
                        [Validation(Required=false)]
                        public string ParentId { get; set; }

                        /// <summary>
                        /// <para>The rule validation type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>RELATION: relation.</description></item>
                        /// <item><description>EXPRESSION: expression.</description></item>
                        /// </list>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RELATION</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The value to compare.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The monitoring type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>METADATA: metadata monitoring.</description></item>
                    /// <item><description>QUALITY: data quality monitoring.</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>METADATA</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The reference to the standard set.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("StandardSetReference")]
            [Validation(Required=false)]
            public CreateStandardRequestCreateCommandStandardSetReference StandardSetReference { get; set; }
            public class CreateStandardRequestCreateCommandStandardSetReference : TeaModel {
                /// <summary>
                /// <para>The standard set ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            /// <summary>
            /// <para>The standard template to which the standard belongs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("StandardTemplateReference")]
            [Validation(Required=false)]
            public CreateStandardRequestCreateCommandStandardTemplateReference StandardTemplateReference { get; set; }
            public class CreateStandardRequestCreateCommandStandardTemplateReference : TeaModel {
                /// <summary>
                /// <para>The attribute values corresponding to the attributes in the referenced template. If this parameter is left empty, default values are used.</para>
                /// </summary>
                [NameInMap("AttributeValueList")]
                [Validation(Required=false)]
                public List<CreateStandardRequestCreateCommandStandardTemplateReferenceAttributeValueList> AttributeValueList { get; set; }
                public class CreateStandardRequestCreateCommandStandardTemplateReferenceAttributeValueList : TeaModel {
                    /// <summary>
                    /// <para>The attribute ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1011</para>
                    /// </summary>
                    [NameInMap("AttributeId")]
                    [Validation(Required=false)]
                    public long? AttributeId { get; set; }

                    /// <summary>
                    /// <para>The attribute value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The standard template ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The standard template version number. The latest version is used by default.</para>
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
        /// <para>The tenant ID.</para>
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
