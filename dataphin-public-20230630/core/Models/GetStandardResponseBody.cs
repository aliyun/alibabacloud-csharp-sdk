// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetStandardResponseBody : TeaModel {
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

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StandardInfo")]
        [Validation(Required=false)]
        public GetStandardResponseBodyStandardInfo StandardInfo { get; set; }
        public class GetStandardResponseBodyStandardInfo : TeaModel {
            [NameInMap("AttributeWithValueList")]
            [Validation(Required=false)]
            public List<GetStandardResponseBodyStandardInfoAttributeWithValueList> AttributeWithValueList { get; set; }
            public class GetStandardResponseBodyStandardInfoAttributeWithValueList : TeaModel {
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public GetStandardResponseBodyStandardInfoAttributeWithValueListAttribute Attribute { get; set; }
                public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttribute : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test_attr</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("EnableMonitorConfig")]
                    [Validation(Required=false)]
                    public bool? EnableMonitorConfig { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1011</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("MonitorConfig")]
                    [Validation(Required=false)]
                    public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeMonitorConfig MonitorConfig { get; set; }
                    public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeMonitorConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>column1</para>
                        /// </summary>
                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        [NameInMap("IsCaseSensitive")]
                        [Validation(Required=false)]
                        public bool? IsCaseSensitive { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>METADATA</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>attr1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("RefAttribute")]
                    [Validation(Required=false)]
                    public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeRefAttribute RefAttribute { get; set; }
                    public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeRefAttribute : TeaModel {
                        [NameInMap("AttributeFromInfo")]
                        [Validation(Required=false)]
                        public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeRefAttributeAttributeFromInfo AttributeFromInfo { get; set; }
                        public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeRefAttributeAttributeFromInfo : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CUSTOM</para>
                            /// </summary>
                            [NameInMap("AttributeFrom")]
                            [Validation(Required=false)]
                            public string AttributeFrom { get; set; }

                            [NameInMap("StandardReference")]
                            [Validation(Required=false)]
                            public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeRefAttributeAttributeFromInfoStandardReference StandardReference { get; set; }
                            public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeRefAttributeAttributeFromInfoStandardReference : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>22</para>
                                /// </summary>
                                [NameInMap("StandardId")]
                                [Validation(Required=false)]
                                public long? StandardId { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("Version")]
                                [Validation(Required=false)]
                                public int? Version { get; set; }

                            }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("AttributeId")]
                        [Validation(Required=false)]
                        public long? AttributeId { get; set; }

                    }

                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BIZ_ATTRIBUTE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("ValueConfig")]
                    [Validation(Required=false)]
                    public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfig ValueConfig { get; set; }
                    public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>STRING</para>
                        /// </summary>
                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public string DataType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
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

                        [NameInMap("ValueRange")]
                        [Validation(Required=false)]
                        public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfigValueRange ValueRange { get; set; }
                        public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfigValueRange : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>DATAPHIN_ATTRIBUTE</para>
                            /// </summary>
                            [NameInMap("DataphinAttributeType")]
                            [Validation(Required=false)]
                            public string DataphinAttributeType { get; set; }

                            [NameInMap("LookupTableReference")]
                            [Validation(Required=false)]
                            public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfigValueRangeLookupTableReference LookupTableReference { get; set; }
                            public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfigValueRangeLookupTableReference : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>col1</para>
                                /// </summary>
                                [NameInMap("Column")]
                                [Validation(Required=false)]
                                public string Column { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>11</para>
                                /// </summary>
                                [NameInMap("LookupTableId")]
                                [Validation(Required=false)]
                                public long? LookupTableId { get; set; }

                            }

                            [NameInMap("MinMaxValueConfig")]
                            [Validation(Required=false)]
                            public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfigValueRangeMinMaxValueConfig MinMaxValueConfig { get; set; }
                            public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfigValueRangeMinMaxValueConfig : TeaModel {
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
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("MinValue")]
                                [Validation(Required=false)]
                                public string MinValue { get; set; }

                            }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>NONE</para>
                            /// </summary>
                            [NameInMap("ValueConstraint")]
                            [Validation(Required=false)]
                            public string ValueConstraint { get; set; }

                            [NameInMap("ValueList")]
                            [Validation(Required=false)]
                            public List<string> ValueList { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zz</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public GetStandardResponseBodyStandardInfoCreator Creator { get; set; }
            public class GetStandardResponseBodyStandardInfoCreator : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>300000913</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>susan</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EffectiveTimeConfig")]
            [Validation(Required=false)]
            public GetStandardResponseBodyStandardInfoEffectiveTimeConfig EffectiveTimeConfig { get; set; }
            public class GetStandardResponseBodyStandardInfoEffectiveTimeConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-12-30 00:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TIME_PERIOD</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("EnglishName")]
            [Validation(Required=false)]
            public string EnglishName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("LastModifier")]
            [Validation(Required=false)]
            public GetStandardResponseBodyStandardInfoLastModifier LastModifier { get; set; }
            public class GetStandardResponseBodyStandardInfoLastModifier : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>300000913</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>susan</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("LookupTableRelations")]
            [Validation(Required=false)]
            public List<GetStandardResponseBodyStandardInfoLookupTableRelations> LookupTableRelations { get; set; }
            public class GetStandardResponseBodyStandardInfoLookupTableRelations : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>zz</para>
                /// </summary>
                [NameInMap("AttributeCode")]
                [Validation(Required=false)]
                public string AttributeCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1122</para>
                /// </summary>
                [NameInMap("AttributeId")]
                [Validation(Required=false)]
                public long? AttributeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AttributeName")]
                [Validation(Required=false)]
                public string AttributeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("LookupTableCode")]
                [Validation(Required=false)]
                public string LookupTableCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("LookupTableId")]
                [Validation(Required=false)]
                public long? LookupTableId { get; set; }

            }

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

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public GetStandardResponseBodyStandardInfoOwner Owner { get; set; }
            public class GetStandardResponseBodyStandardInfoOwner : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>300000913</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>susan</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("Stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }

            [NameInMap("StandardGeneralMonitorConfig")]
            [Validation(Required=false)]
            public GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfig StandardGeneralMonitorConfig { get; set; }
            public class GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfig : TeaModel {
                [NameInMap("StandardMonitorConfigList")]
                [Validation(Required=false)]
                public List<GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigList> StandardMonitorConfigList { get; set; }
                public class GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>112</para>
                    /// </summary>
                    [NameInMap("AttributeId")]
                    [Validation(Required=false)]
                    public long? AttributeId { get; set; }

                    [NameInMap("AttributeMonitorConfig")]
                    [Validation(Required=false)]
                    public GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListAttributeMonitorConfig AttributeMonitorConfig { get; set; }
                    public class GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListAttributeMonitorConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>column1</para>
                        /// </summary>
                        [NameInMap("ColumnName")]
                        [Validation(Required=false)]
                        public string ColumnName { get; set; }

                        [NameInMap("IsCaseSensitive")]
                        [Validation(Required=false)]
                        public bool? IsCaseSensitive { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>METADATA</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>teset</para>
                    /// </summary>
                    [NameInMap("AttributeName")]
                    [Validation(Required=false)]
                    public string AttributeName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BY_SYSTEM_ATTRIBUTE</para>
                    /// </summary>
                    [NameInMap("MonitorFrom")]
                    [Validation(Required=false)]
                    public string MonitorFrom { get; set; }

                    [NameInMap("QualityRuleTemplate")]
                    [Validation(Required=false)]
                    public GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListQualityRuleTemplate QualityRuleTemplate { get; set; }
                    public class GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListQualityRuleTemplate : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>22</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CUSTOMIZED</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CUSTOMIZED</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("RuleConfigList")]
                    [Validation(Required=false)]
                    public List<GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListRuleConfigList> RuleConfigList { get; set; }
                    public class GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListRuleConfigList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>k1</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>v1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CUSTOMIZED</para>
                    /// </summary>
                    [NameInMap("RuleSubType")]
                    [Validation(Required=false)]
                    public string RuleSubType { get; set; }

                    [NameInMap("RuleValidateConfigList")]
                    [Validation(Required=false)]
                    public List<GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListRuleValidateConfigList> RuleValidateConfigList { get; set; }
                    public class GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListRuleValidateConfigList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>abc</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>a</para>
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
                        /// <para>a</para>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>METADATA</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("StandardRelations")]
            [Validation(Required=false)]
            public List<GetStandardResponseBodyStandardInfoStandardRelations> StandardRelations { get; set; }
            public class GetStandardResponseBodyStandardInfoStandardRelations : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>RELATIVE</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("StandardId")]
                [Validation(Required=false)]
                public long? StandardId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("StandardStage")]
                [Validation(Required=false)]
                public string StandardStage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>draft</para>
                /// </summary>
                [NameInMap("StandardStatus")]
                [Validation(Required=false)]
                public string StandardStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            [NameInMap("StandardSet")]
            [Validation(Required=false)]
            public GetStandardResponseBodyStandardInfoStandardSet StandardSet { get; set; }
            public class GetStandardResponseBodyStandardInfoStandardSet : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cc</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/dir1</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("StandardTemplate")]
            [Validation(Required=false)]
            public GetStandardResponseBodyStandardInfoStandardTemplate StandardTemplate { get; set; }
            public class GetStandardResponseBodyStandardInfoStandardTemplate : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("TemplateFrom")]
                [Validation(Required=false)]
                public string TemplateFrom { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>draft</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zz</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
