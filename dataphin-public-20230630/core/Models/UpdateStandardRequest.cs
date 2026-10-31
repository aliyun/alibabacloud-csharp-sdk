// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateStandardRequest : TeaModel {
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

        /// <summary>
        /// <para>The update command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateStandardRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateStandardRequestUpdateCommand : TeaModel {
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
            public UpdateStandardRequestUpdateCommandEffectiveTimeConfig EffectiveTimeConfig { get; set; }
            public class UpdateStandardRequestUpdateCommandEffectiveTimeConfig : TeaModel {
                /// <summary>
                /// <para>The end time of the effective period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-30 00:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The start time of the effective period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The effective period type. Valid values: FOREVER (permanent) and TIME_PERIOD (time period).</para>
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
            /// <para>Specifies whether to generate standard codes based on rules. If this parameter is set to true, invalid standard codes entered in the attribute values are regenerated.</para>
            /// </summary>
            [NameInMap("NeedGenerateStandardCode")]
            [Validation(Required=false)]
            public bool? NeedGenerateStandardCode { get; set; }

            /// <summary>
            /// <para>The owner. If this parameter is not specified, the current user is used as the owner.</para>
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
            public UpdateStandardRequestUpdateCommandStandardGeneralMonitorConfig StandardGeneralMonitorConfig { get; set; }
            public class UpdateStandardRequestUpdateCommandStandardGeneralMonitorConfig : TeaModel {
                /// <summary>
                /// <para>The standard monitoring configuration list.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("StandardMonitorConfigList")]
                [Validation(Required=false)]
                public List<UpdateStandardRequestUpdateCommandStandardGeneralMonitorConfigStandardMonitorConfigList> StandardMonitorConfigList { get; set; }
                public class UpdateStandardRequestUpdateCommandStandardGeneralMonitorConfigStandardMonitorConfigList : TeaModel {
                    /// <summary>
                    /// <para>The ID of the associated attribute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>112</para>
                    /// </summary>
                    [NameInMap("AttributeId")]
                    [Validation(Required=false)]
                    public long? AttributeId { get; set; }

                    /// <summary>
                    /// <para>The monitoring configuration of the associated attribute.</para>
                    /// </summary>
                    [NameInMap("AttributeMonitorConfig")]
                    [Validation(Required=false)]
                    public UpdateStandardRequestUpdateCommandStandardGeneralMonitorConfigStandardMonitorConfigListAttributeMonitorConfig AttributeMonitorConfig { get; set; }
                    public class UpdateStandardRequestUpdateCommandStandardGeneralMonitorConfigStandardMonitorConfigListAttributeMonitorConfig : TeaModel {
                        /// <summary>
                        /// <para>The field to be checked.</para>
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
                        /// <item><description>METADATA: Metadata monitoring.</description></item>
                        /// <item><description>QUALITY: Data quality monitoring.</description></item>
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
                    /// <para>The addition method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>BY_USER: Manual addition.</description></item>
                    /// <item><description>BY_SYSTEM_ATTRIBUTE: Preset by system attributes.</description></item>
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
                    public UpdateStandardRequestUpdateCommandStandardGeneralMonitorConfigStandardMonitorConfigListQualityRuleTemplate QualityRuleTemplate { get; set; }
                    public class UpdateStandardRequestUpdateCommandStandardGeneralMonitorConfigStandardMonitorConfigListQualityRuleTemplate : TeaModel {
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
                        /// <item><description>FROM_SYSTEM: System template.</description></item>
                        /// <item><description>CUSTOMIZED: Custom template.</description></item>
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
                    /// <para>The rule configuration. This parameter is required when the monitoring type is QUALITY.</para>
                    /// </summary>
                    [NameInMap("RuleConfigList")]
                    [Validation(Required=false)]
                    public List<UpdateStandardRequestUpdateCommandStandardGeneralMonitorConfigStandardMonitorConfigListRuleConfigList> RuleConfigList { get; set; }
                    public class UpdateStandardRequestUpdateCommandStandardGeneralMonitorConfigStandardMonitorConfigListRuleConfigList : TeaModel {
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
                        /// <para>The value of the configuration item.</para>
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
                    /// <para>The rule subtype. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>BY_ATTRIBUTE: Attribute-based configuration.</description></item>
                    /// <item><description>CUSTOMIZED: Custom configuration.
                    /// This parameter is required when the monitoring type is QUALITY.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CUSTOMIZED</para>
                    /// </summary>
                    [NameInMap("RuleSubType")]
                    [Validation(Required=false)]
                    public string RuleSubType { get; set; }

                    /// <summary>
                    /// <para>The rule validation configuration. This parameter is required when the monitoring type is QUALITY.</para>
                    /// </summary>
                    [NameInMap("RuleValidateConfigList")]
                    [Validation(Required=false)]
                    public List<UpdateStandardRequestUpdateCommandStandardGeneralMonitorConfigStandardMonitorConfigListRuleValidateConfigList> RuleValidateConfigList { get; set; }
                    public class UpdateStandardRequestUpdateCommandStandardGeneralMonitorConfigStandardMonitorConfigListRuleValidateConfigList : TeaModel {
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
                        /// <para>The operator. If the validation type is EXPRESSION, valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>EQUAL: Equal to.</description></item>
                        /// <item><description>NOT_EQUAL: Not equal to.</description></item>
                        /// <item><description>LARGER: Greater than.</description></item>
                        /// <item><description>LARGE_OR_EQUAL: Greater than or equal to.</description></item>
                        /// <item><description>SMALLER: Less than.</description></item>
                        /// <item><description>SMALLER_OR_EQUAL: Less than or equal to.
                        /// If the validation type is RELATION, valid values:</description></item>
                        /// <item><description>AND: And.</description></item>
                        /// <item><description>OR: Or.</description></item>
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
                        /// <item><description>RELATION: Relationship.</description></item>
                        /// <item><description>EXPRESSION: Expression.</description></item>
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
                        /// <para>The value to be compared.</para>
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
                    /// <item><description>METADATA: Metadata monitoring.</description></item>
                    /// <item><description>QUALITY: Data quality monitoring.</description></item>
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
            /// <para>The lookup table.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("StandardId")]
            [Validation(Required=false)]
            public long? StandardId { get; set; }

            /// <summary>
            /// <para>The reference to the standard set to which the current standard belongs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("StandardSetReference")]
            [Validation(Required=false)]
            public UpdateStandardRequestUpdateCommandStandardSetReference StandardSetReference { get; set; }
            public class UpdateStandardRequestUpdateCommandStandardSetReference : TeaModel {
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
            /// <para>The status of the standard.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>draft</para>
            /// </summary>
            [NameInMap("StandardStatus")]
            [Validation(Required=false)]
            public string StandardStatus { get; set; }

            /// <summary>
            /// <para>The reference to the standard template to which the standard belongs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("StandardTemplateReference")]
            [Validation(Required=false)]
            public UpdateStandardRequestUpdateCommandStandardTemplateReference StandardTemplateReference { get; set; }
            public class UpdateStandardRequestUpdateCommandStandardTemplateReference : TeaModel {
                /// <summary>
                /// <para>The attribute values for the attribute list in the referenced template. If this parameter is left empty, the default values are used.</para>
                /// </summary>
                [NameInMap("AttributeValueList")]
                [Validation(Required=false)]
                public List<UpdateStandardRequestUpdateCommandStandardTemplateReferenceAttributeValueList> AttributeValueList { get; set; }
                public class UpdateStandardRequestUpdateCommandStandardTemplateReferenceAttributeValueList : TeaModel {
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
                /// <para>The version number of the standard template. By default, the latest version is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

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
