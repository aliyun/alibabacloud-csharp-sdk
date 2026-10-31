// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListStandardsResponseBody : TeaModel {
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
        /// <para>The paged query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListStandardsResponseBodyPageResult PageResult { get; set; }
        public class ListStandardsResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The standard list.</para>
            /// </summary>
            [NameInMap("StandardList")]
            [Validation(Required=false)]
            public List<ListStandardsResponseBodyPageResultStandardList> StandardList { get; set; }
            public class ListStandardsResponseBodyPageResultStandardList : TeaModel {
                /// <summary>
                /// <para>The attribute value configuration.</para>
                /// </summary>
                [NameInMap("AttributeWithValueList")]
                [Validation(Required=false)]
                public List<ListStandardsResponseBodyPageResultStandardListAttributeWithValueList> AttributeWithValueList { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueList : TeaModel {
                    /// <summary>
                    /// <para>The attribute details.</para>
                    /// </summary>
                    [NameInMap("Attribute")]
                    [Validation(Required=false)]
                    public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttribute Attribute { get; set; }
                    public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttribute : TeaModel {
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
                        public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeMonitorConfig MonitorConfig { get; set; }
                        public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeMonitorConfig : TeaModel {
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
                            /// </summary>
                            [NameInMap("IsCaseSensitive")]
                            [Validation(Required=false)]
                            public bool? IsCaseSensitive { get; set; }

                            /// <summary>
                            /// <para>The monitoring method. Valid values: METADATA: metadata monitoring. QUALITY: data quality monitoring.</para>
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
                        public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttribute RefAttribute { get; set; }
                        public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttribute : TeaModel {
                            /// <summary>
                            /// <para>The source of the attribute.</para>
                            /// </summary>
                            [NameInMap("AttributeFromInfo")]
                            [Validation(Required=false)]
                            public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttributeAttributeFromInfo AttributeFromInfo { get; set; }
                            public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttributeAttributeFromInfo : TeaModel {
                                /// <summary>
                                /// <para>The source of the attribute. Valid values: SYSTEM: system attribute. CUSTOM: custom attribute. STANDARD: standard.</para>
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
                                public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttributeAttributeFromInfoStandardReference StandardReference { get; set; }
                                public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttributeAttributeFromInfoStandardReference : TeaModel {
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
                        public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfig ValueConfig { get; set; }
                        public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfig : TeaModel {
                            /// <summary>
                            /// <para>The data type of the attribute value. Valid values: STRING: string. BIGINT: numeric type. DOUBLE: floating-point type. DATE: date accurate to day. DATETIME: date accurate to millisecond. BOOLEAN: Boolean type.</para>
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
                            /// <para>The length of the attribute value. An empty value or -1 indicates that the length is not limited. Typically, only the string type limits the length of the attribute value.</para>
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
                            public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRange ValueRange { get; set; }
                            public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRange : TeaModel {
                                /// <summary>
                                /// <para>The value range. This parameter takes effect when the value source is set to DATAPHIN_ATTRIBUTE. Valid values: BIZ_UNIT: data block. PROJECT: project. USER: user. USER_GROUP: user group.</para>
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
                                public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRangeLookupTableReference LookupTableReference { get; set; }
                                public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRangeLookupTableReference : TeaModel {
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
                                public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRangeMinMaxValueConfig MinMaxValueConfig { get; set; }
                                public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRangeMinMaxValueConfig : TeaModel {
                                    /// <summary>
                                    /// <para>Specifies whether to include the maximum value.</para>
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
                                /// <para>The value source. Valid values: NONE: no constraint. LIST: obtained from a list. LOOKUP_TABLE: lookup table. MIN_MAX: obtained between the maximum and minimum values. DATAPHIN_ATTRIBUTE: Dataphin system property. BUILT_IN_DATA_TYPES: built-in data type. BUILT_IN_DATA_CLASSIFICATION: built-in data categorization. BUILT_IN_DATA_LEVEL: built-in data security classification.</para>
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
                /// <para>The code of the standard.</para>
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
                public ListStandardsResponseBodyPageResultStandardListCreator Creator { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListCreator : TeaModel {
                    /// <summary>
                    /// <para>The ID of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300000913</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the user.</para>
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
                public ListStandardsResponseBodyPageResultStandardListEffectiveTimeConfig EffectiveTimeConfig { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListEffectiveTimeConfig : TeaModel {
                    /// <summary>
                    /// <para>The end time of the effective period. The format is YYYY-MM-DD HH:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-12-30 00:00:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The start time of the effective period. The format is YYYY-MM-DD HH:mm:ss.</para>
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
                    /// <item><description>FOREVER: Permanent.</description></item>
                    /// <item><description>TIME_PERIOD: Time period.</description></item>
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
                /// <para>The standard ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The user who last updated the standard.</para>
                /// </summary>
                [NameInMap("LastModifier")]
                [Validation(Required=false)]
                public ListStandardsResponseBodyPageResultStandardListLastModifier LastModifier { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListLastModifier : TeaModel {
                    /// <summary>
                    /// <para>The ID of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300000913</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>susan</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The last modified time. The format is YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The name of the standard.</para>
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
                public ListStandardsResponseBodyPageResultStandardListOwner Owner { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListOwner : TeaModel {
                    /// <summary>
                    /// <para>The ID of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300000913</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>susan</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The stage of the standard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("Stage")]
                [Validation(Required=false)]
                public string Stage { get; set; }

                /// <summary>
                /// <para>The standard set that the current standard depends on.</para>
                /// </summary>
                [NameInMap("StandardSet")]
                [Validation(Required=false)]
                public ListStandardsResponseBodyPageResultStandardListStandardSet StandardSet { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListStandardSet : TeaModel {
                    /// <summary>
                    /// <para>The code of the standard set.</para>
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
                    /// <para>The ID of the standard set.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the standard set.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The standard template that the current standard depends on.</para>
                /// </summary>
                [NameInMap("StandardTemplate")]
                [Validation(Required=false)]
                public ListStandardsResponseBodyPageResultStandardListStandardTemplate StandardTemplate { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListStandardTemplate : TeaModel {
                    /// <summary>
                    /// <para>The code of the standard template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1121</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The ID of the standard template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the standard template.</para>
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
                    /// <item><description>SYSTEM: Built-in standard template.</description></item>
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
                /// <para>The type of the standard.</para>
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
            /// <para>The total number of records.</para>
            /// 
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

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
