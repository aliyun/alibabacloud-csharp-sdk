// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetStandardResponseBody : TeaModel {
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
        /// <para>The standard details.</para>
        /// </summary>
        [NameInMap("StandardInfo")]
        [Validation(Required=false)]
        public GetStandardResponseBodyStandardInfo StandardInfo { get; set; }
        public class GetStandardResponseBodyStandardInfo : TeaModel {
            /// <summary>
            /// <para>The attribute value configurations.</para>
            /// </summary>
            [NameInMap("AttributeWithValueList")]
            [Validation(Required=false)]
            public List<GetStandardResponseBodyStandardInfoAttributeWithValueList> AttributeWithValueList { get; set; }
            public class GetStandardResponseBodyStandardInfoAttributeWithValueList : TeaModel {
                /// <summary>
                /// <para>The attribute details.</para>
                /// </summary>
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public GetStandardResponseBodyStandardInfoAttributeWithValueListAttribute Attribute { get; set; }
                public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttribute : TeaModel {
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
                    /// <para>Indicates whether the monitoring configuration is enabled.</para>
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
                    public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeMonitorConfig MonitorConfig { get; set; }
                    public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeMonitorConfig : TeaModel {
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
                    public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeRefAttribute RefAttribute { get; set; }
                    public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeRefAttribute : TeaModel {
                        /// <summary>
                        /// <para>The attribute source.</para>
                        /// </summary>
                        [NameInMap("AttributeFromInfo")]
                        [Validation(Required=false)]
                        public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeRefAttributeAttributeFromInfo AttributeFromInfo { get; set; }
                        public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeRefAttributeAttributeFromInfo : TeaModel {
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
                            public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeRefAttributeAttributeFromInfoStandardReference StandardReference { get; set; }
                            public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeRefAttributeAttributeFromInfoStandardReference : TeaModel {
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
                    public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfig ValueConfig { get; set; }
                    public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfig : TeaModel {
                        /// <summary>
                        /// <para>The data type of the attribute value. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>STRING: string.</description></item>
                        /// <item><description>BIGINT: numeric type.</description></item>
                        /// <item><description>DOUBLE: floating-point type.</description></item>
                        /// <item><description>DATE: date, accurate to the day.</description></item>
                        /// <item><description>DATETIME: date, accurate to milliseconds.</description></item>
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
                        /// <para>The length of the attribute value. If empty or -1, the length is not limited. Typically, only string types have a length limit for attribute values.</para>
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
                        public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfigValueRange ValueRange { get; set; }
                        public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfigValueRange : TeaModel {
                            /// <summary>
                            /// <para>The value range. This parameter takes effect when the value source is set to DATAPHIN_ATTRIBUTE. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>BIZ_UNIT: business unit.</description></item>
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
                            public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfigValueRangeLookupTableReference LookupTableReference { get; set; }
                            public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfigValueRangeLookupTableReference : TeaModel {
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
                            public GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfigValueRangeMinMaxValueConfig MinMaxValueConfig { get; set; }
                            public class GetStandardResponseBodyStandardInfoAttributeWithValueListAttributeValueConfigValueRangeMinMaxValueConfig : TeaModel {
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
            /// <para>The standard code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zz</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public GetStandardResponseBodyStandardInfoCreator Creator { get; set; }
            public class GetStandardResponseBodyStandardInfoCreator : TeaModel {
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
            public GetStandardResponseBodyStandardInfoEffectiveTimeConfig EffectiveTimeConfig { get; set; }
            public class GetStandardResponseBodyStandardInfoEffectiveTimeConfig : TeaModel {
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
                /// <para>The effective period type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>FOREVER: permanent.</description></item>
                /// <item><description>TIME_PERIOD: time period.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TIME_PERIOD</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The English name of the standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("EnglishName")]
            [Validation(Required=false)]
            public string EnglishName { get; set; }

            /// <summary>
            /// <para>The lookup table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The last modifier.</para>
            /// </summary>
            [NameInMap("LastModifier")]
            [Validation(Required=false)]
            public GetStandardResponseBodyStandardInfoLastModifier LastModifier { get; set; }
            public class GetStandardResponseBodyStandardInfoLastModifier : TeaModel {
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
            /// <para>The list of associated lookup tables.</para>
            /// </summary>
            [NameInMap("LookupTableRelations")]
            [Validation(Required=false)]
            public List<GetStandardResponseBodyStandardInfoLookupTableRelations> LookupTableRelations { get; set; }
            public class GetStandardResponseBodyStandardInfoLookupTableRelations : TeaModel {
                /// <summary>
                /// <para>The attribute name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zz</para>
                /// </summary>
                [NameInMap("AttributeCode")]
                [Validation(Required=false)]
                public string AttributeCode { get; set; }

                /// <summary>
                /// <para>The attribute ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1122</para>
                /// </summary>
                [NameInMap("AttributeId")]
                [Validation(Required=false)]
                public long? AttributeId { get; set; }

                /// <summary>
                /// <para>The attribute name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AttributeName")]
                [Validation(Required=false)]
                public string AttributeName { get; set; }

                /// <summary>
                /// <para>The lookup table code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("LookupTableCode")]
                [Validation(Required=false)]
                public string LookupTableCode { get; set; }

                /// <summary>
                /// <para>The lookup table ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("LookupTableId")]
                [Validation(Required=false)]
                public long? LookupTableId { get; set; }

            }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The standard name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The owner.</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public GetStandardResponseBodyStandardInfoOwner Owner { get; set; }
            public class GetStandardResponseBodyStandardInfoOwner : TeaModel {
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
            /// <para>The stage to which the standard belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("Stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }

            /// <summary>
            /// <para>The standard monitoring configuration.</para>
            /// </summary>
            [NameInMap("StandardGeneralMonitorConfig")]
            [Validation(Required=false)]
            public GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfig StandardGeneralMonitorConfig { get; set; }
            public class GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfig : TeaModel {
                /// <summary>
                /// <para>The list of standard monitoring configurations.</para>
                /// </summary>
                [NameInMap("StandardMonitorConfigList")]
                [Validation(Required=false)]
                public List<GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigList> StandardMonitorConfigList { get; set; }
                public class GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigList : TeaModel {
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
                    /// <para>The monitoring configuration of the associated attribute.</para>
                    /// </summary>
                    [NameInMap("AttributeMonitorConfig")]
                    [Validation(Required=false)]
                    public GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListAttributeMonitorConfig AttributeMonitorConfig { get; set; }
                    public class GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListAttributeMonitorConfig : TeaModel {
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
                    /// <para>The monitoring configuration ID. If empty, a new monitoring configuration is created. If an existing monitoring configuration ID is specified, the corresponding monitoring configuration is updated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The method by which the monitoring configuration is added. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>BY_USER: manually added.</description></item>
                    /// <item><description>BY_SYSTEM_ATTRIBUTE: preset by system attribute.</description></item>
                    /// </list>
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
                    public GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListQualityRuleTemplate QualityRuleTemplate { get; set; }
                    public class GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListQualityRuleTemplate : TeaModel {
                        /// <summary>
                        /// <para>The template ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>22</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <para>The template name.</para>
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
                    public List<GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListRuleConfigList> RuleConfigList { get; set; }
                    public class GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListRuleConfigList : TeaModel {
                        /// <summary>
                        /// <para>The configuration item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>k1</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The configuration item value.</para>
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
                    /// <item><description>BY_ATTRIBUTE: configured based on attributes.</description></item>
                    /// <item><description>CUSTOMIZED: custom configuration.</description></item>
                    /// </list>
                    /// <para>This parameter is required when the monitoring type is QUALITY.</para>
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
                    public List<GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListRuleValidateConfigList> RuleValidateConfigList { get; set; }
                    public class GetStandardResponseBodyStandardInfoStandardGeneralMonitorConfigStandardMonitorConfigListRuleValidateConfigList : TeaModel {
                        /// <summary>
                        /// <para>The validation configuration ID. This ID is randomly generated by the business and must be unique.</para>
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
                        /// 
                        /// <b>Example:</b>
                        /// <para>RELATION</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The comparison value.</para>
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
            /// <para>The list of associated standards.</para>
            /// </summary>
            [NameInMap("StandardRelations")]
            [Validation(Required=false)]
            public List<GetStandardResponseBodyStandardInfoStandardRelations> StandardRelations { get; set; }
            public class GetStandardResponseBodyStandardInfoStandardRelations : TeaModel {
                /// <summary>
                /// <para>The association type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RELATIVE.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RELATIVE</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                /// <summary>
                /// <para>The standard ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("StandardId")]
                [Validation(Required=false)]
                public long? StandardId { get; set; }

                /// <summary>
                /// <para>The stage of the standard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("StandardStage")]
                [Validation(Required=false)]
                public string StandardStage { get; set; }

                /// <summary>
                /// <para>The standard status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>draft</para>
                /// </summary>
                [NameInMap("StandardStatus")]
                [Validation(Required=false)]
                public string StandardStatus { get; set; }

                /// <summary>
                /// <para>The standard version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>The standard set on which the current standard depends.</para>
            /// </summary>
            [NameInMap("StandardSet")]
            [Validation(Required=false)]
            public GetStandardResponseBodyStandardInfoStandardSet StandardSet { get; set; }
            public class GetStandardResponseBodyStandardInfoStandardSet : TeaModel {
                /// <summary>
                /// <para>The standard set code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cc</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The folder to which the standard set belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dir1</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The standard set ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The standard set name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The standard template on which the current standard depends.</para>
            /// </summary>
            [NameInMap("StandardTemplate")]
            [Validation(Required=false)]
            public GetStandardResponseBodyStandardInfoStandardTemplate StandardTemplate { get; set; }
            public class GetStandardResponseBodyStandardInfoStandardTemplate : TeaModel {
                /// <summary>
                /// <para>The standard template code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1121</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The standard template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The standard template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The source of the standard template. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CUSTOM: Custom standard template.</description></item>
                /// <item><description>SYSTEM: System built-in standard template.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM</para>
                /// </summary>
                [NameInMap("TemplateFrom")]
                [Validation(Required=false)]
                public string TemplateFrom { get; set; }

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

            /// <summary>
            /// <para>The status of the standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>draft</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The standard type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zz</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
