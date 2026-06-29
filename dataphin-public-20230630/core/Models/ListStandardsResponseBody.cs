// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListStandardsResponseBody : TeaModel {
        /// <summary>
        /// <para>Backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Details of the backend response error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Paginated query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListStandardsResponseBodyPageResult PageResult { get; set; }
        public class ListStandardsResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>Standard list.</para>
            /// </summary>
            [NameInMap("StandardList")]
            [Validation(Required=false)]
            public List<ListStandardsResponseBodyPageResultStandardList> StandardList { get; set; }
            public class ListStandardsResponseBodyPageResultStandardList : TeaModel {
                /// <summary>
                /// <para>Attribute value configuration list.</para>
                /// </summary>
                [NameInMap("AttributeWithValueList")]
                [Validation(Required=false)]
                public List<ListStandardsResponseBodyPageResultStandardListAttributeWithValueList> AttributeWithValueList { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueList : TeaModel {
                    /// <summary>
                    /// <para>Attribute details.</para>
                    /// </summary>
                    [NameInMap("Attribute")]
                    [Validation(Required=false)]
                    public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttribute Attribute { get; set; }
                    public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttribute : TeaModel {
                        /// <summary>
                        /// <para>Attribute code.</para>
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
                        /// <para>Whether to enable monitor configuration.</para>
                        /// </summary>
                        [NameInMap("EnableMonitorConfig")]
                        [Validation(Required=false)]
                        public bool? EnableMonitorConfig { get; set; }

                        /// <summary>
                        /// <para>Attribute ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1011</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <para>Monitor configuration.</para>
                        /// </summary>
                        [NameInMap("MonitorConfig")]
                        [Validation(Required=false)]
                        public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeMonitorConfig MonitorConfig { get; set; }
                        public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeMonitorConfig : TeaModel {
                            /// <summary>
                            /// <para>Column to check.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>column1</para>
                            /// </summary>
                            [NameInMap("ColumnName")]
                            [Validation(Required=false)]
                            public string ColumnName { get; set; }

                            /// <summary>
                            /// <para>Whether case-sensitive.</para>
                            /// </summary>
                            [NameInMap("IsCaseSensitive")]
                            [Validation(Required=false)]
                            public bool? IsCaseSensitive { get; set; }

                            /// <summary>
                            /// <para>Monitor type: METADATA for metadata monitoring, QUALITY for data quality monitoring.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>METADATA</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <para>Attribute name.</para>
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
                        public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttribute RefAttribute { get; set; }
                        public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttribute : TeaModel {
                            /// <summary>
                            /// <para>Attribute source.</para>
                            /// </summary>
                            [NameInMap("AttributeFromInfo")]
                            [Validation(Required=false)]
                            public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttributeAttributeFromInfo AttributeFromInfo { get; set; }
                            public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttributeAttributeFromInfo : TeaModel {
                                /// <summary>
                                /// <para>Attribute source: SYSTEM for system attribute, CUSTOM for custom attribute, STANDARD for standard.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>CUSTOM</para>
                                /// </summary>
                                [NameInMap("AttributeFrom")]
                                [Validation(Required=false)]
                                public string AttributeFrom { get; set; }

                                /// <summary>
                                /// <para>Corresponding standard, effective when attribute source is STANDARD.</para>
                                /// </summary>
                                [NameInMap("StandardReference")]
                                [Validation(Required=false)]
                                public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttributeAttributeFromInfoStandardReference StandardReference { get; set; }
                                public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttributeAttributeFromInfoStandardReference : TeaModel {
                                    /// <summary>
                                    /// <para>Standard ID.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>22</para>
                                    /// </summary>
                                    [NameInMap("StandardId")]
                                    [Validation(Required=false)]
                                    public long? StandardId { get; set; }

                                    /// <summary>
                                    /// <para>Version number.</para>
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
                            /// 
                            /// <b>Example:</b>
                            /// <para>123</para>
                            /// </summary>
                            [NameInMap("AttributeId")]
                            [Validation(Required=false)]
                            public long? AttributeId { get; set; }

                        }

                        /// <summary>
                        /// <para>Whether it is required.</para>
                        /// </summary>
                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        /// <summary>
                        /// <para>Attribute type: BIZ_ATTRIBUTE for business attribute, TECH_ATTRIBUTE for technical attribute, MANAGEMENT_ATTRIBUTE for management attribute, QUALITY_ATTRIBUTE for quality attribute, MASTER_DATA_ATTRIBUTE for master data attribute, LIFECYCLE_ATTRIBUTE for lifecycle attribute, SECURITY_ATTRIBUTE for security attribute.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>BIZ_ATTRIBUTE</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>Value configuration.</para>
                        /// </summary>
                        [NameInMap("ValueConfig")]
                        [Validation(Required=false)]
                        public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfig ValueConfig { get; set; }
                        public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfig : TeaModel {
                            /// <summary>
                            /// <para>Data type of the attribute value: STRING for string, BIGINT for numeric type, DOUBLE for floating-point type, DATE for date accurate to day, DATETIME for date accurate to milliseconds, BOOLEAN for boolean.</para>
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
                            /// <para>Attribute value length. If empty or -1, the length is not limited. Typically, only string types limit the attribute value length.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Length")]
                            [Validation(Required=false)]
                            public int? Length { get; set; }

                            /// <summary>
                            /// <para>Attribute value type: CUSTOMIZED for custom input, SINGLE_ENUM for single enumeration value, MULTIPLE_ENUMS for multiple enumeration values, RANGE for range value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>CUSTOMIZED</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>Value range.</para>
                            /// </summary>
                            [NameInMap("ValueRange")]
                            [Validation(Required=false)]
                            public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRange ValueRange { get; set; }
                            public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRange : TeaModel {
                                /// <summary>
                                /// <para>Value range, effective when value constraint is DATAPHIN_ATTRIBUTE: BIZ_UNIT for data business unit, PROJECT for project, USER for user, USER_GROUP for user group.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>DATAPHIN_ATTRIBUTE</para>
                                /// </summary>
                                [NameInMap("DataphinAttributeType")]
                                [Validation(Required=false)]
                                public string DataphinAttributeType { get; set; }

                                /// <summary>
                                /// <para>Value range, effective when value constraint is LOOKUP_TABLE.</para>
                                /// </summary>
                                [NameInMap("LookupTableReference")]
                                [Validation(Required=false)]
                                public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRangeLookupTableReference LookupTableReference { get; set; }
                                public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRangeLookupTableReference : TeaModel {
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
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>11</para>
                                    /// </summary>
                                    [NameInMap("LookupTableId")]
                                    [Validation(Required=false)]
                                    public long? LookupTableId { get; set; }

                                }

                                /// <summary>
                                /// <para>Value range, effective when value constraint is MIN_MAX.</para>
                                /// </summary>
                                [NameInMap("MinMaxValueConfig")]
                                [Validation(Required=false)]
                                public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRangeMinMaxValueConfig MinMaxValueConfig { get; set; }
                                public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRangeMinMaxValueConfig : TeaModel {
                                    /// <summary>
                                    /// <para>Whether to include the maximum value.</para>
                                    /// </summary>
                                    [NameInMap("IncludeMaxValue")]
                                    [Validation(Required=false)]
                                    public bool? IncludeMaxValue { get; set; }

                                    /// <summary>
                                    /// <para>Whether to include the minimum value.</para>
                                    /// </summary>
                                    [NameInMap("IncludeMinValue")]
                                    [Validation(Required=false)]
                                    public bool? IncludeMinValue { get; set; }

                                    /// <summary>
                                    /// <para>Maximum value.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>100</para>
                                    /// </summary>
                                    [NameInMap("MaxValue")]
                                    [Validation(Required=false)]
                                    public string MaxValue { get; set; }

                                    /// <summary>
                                    /// <para>Minimum value.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>0</para>
                                    /// </summary>
                                    [NameInMap("MinValue")]
                                    [Validation(Required=false)]
                                    public string MinValue { get; set; }

                                }

                                /// <summary>
                                /// <para>Value constraint: NONE for no constraint, LIST for obtaining from a list, LOOKUP_TABLE for lookup table, MIN_MAX for values between minimum and maximum, DATAPHIN_ATTRIBUTE for Dataphin system attribute, BUILT_IN_DATA_TYPES for built-in data types, BUILT_IN_DATA_CLASSIFICATION for built-in data classification, BUILT_IN_DATA_LEVEL for built-in data security level.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>NONE</para>
                                /// </summary>
                                [NameInMap("ValueConstraint")]
                                [Validation(Required=false)]
                                public string ValueConstraint { get; set; }

                                /// <summary>
                                /// <para>Value range, effective when value constraint is LIST.</para>
                                /// </summary>
                                [NameInMap("ValueList")]
                                [Validation(Required=false)]
                                public List<string> ValueList { get; set; }

                            }

                        }

                    }

                    /// <summary>
                    /// <para>Attribute value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Standard code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zz</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Creator.</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public ListStandardsResponseBodyPageResultStandardListCreator Creator { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListCreator : TeaModel {
                    /// <summary>
                    /// <para>User ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300000913</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>User name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>susan</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

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
                /// <para>Effective time configuration.</para>
                /// </summary>
                [NameInMap("EffectiveTimeConfig")]
                [Validation(Required=false)]
                public ListStandardsResponseBodyPageResultStandardListEffectiveTimeConfig EffectiveTimeConfig { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListEffectiveTimeConfig : TeaModel {
                    /// <summary>
                    /// <para>End time of the effective period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-12-30 00:00:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>Start time of the effective period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-06-30 00:00:00</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>Effective time type: FOREVER for permanent, TIME_PERIOD for a time period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TIME_PERIOD</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Standard English name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("EnglishName")]
                [Validation(Required=false)]
                public string EnglishName { get; set; }

                /// <summary>
                /// <para>Standard ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Last modifier.</para>
                /// </summary>
                [NameInMap("LastModifier")]
                [Validation(Required=false)]
                public ListStandardsResponseBodyPageResultStandardListLastModifier LastModifier { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListLastModifier : TeaModel {
                    /// <summary>
                    /// <para>User ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300000913</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>User name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>susan</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>Last modified time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>Standard name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Owner.</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public ListStandardsResponseBodyPageResultStandardListOwner Owner { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListOwner : TeaModel {
                    /// <summary>
                    /// <para>User ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300000913</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>User name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>susan</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>Stage of the standard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("Stage")]
                [Validation(Required=false)]
                public string Stage { get; set; }

                /// <summary>
                /// <para>Standard set that the current standard depends on.</para>
                /// </summary>
                [NameInMap("StandardSet")]
                [Validation(Required=false)]
                public ListStandardsResponseBodyPageResultStandardListStandardSet StandardSet { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListStandardSet : TeaModel {
                    /// <summary>
                    /// <para>Standard set code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cc</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>Directory of the standard set.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/dir1</para>
                    /// </summary>
                    [NameInMap("Directory")]
                    [Validation(Required=false)]
                    public string Directory { get; set; }

                    /// <summary>
                    /// <para>Standard set ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>Standard set name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>Standard template that the current standard depends on.</para>
                /// </summary>
                [NameInMap("StandardTemplate")]
                [Validation(Required=false)]
                public ListStandardsResponseBodyPageResultStandardListStandardTemplate StandardTemplate { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListStandardTemplate : TeaModel {
                    /// <summary>
                    /// <para>Standard template code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1121</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>Standard template ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>Standard template name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Standard template source: CUSTOM for custom standard templates, SYSTEM for system built-in standard templates.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SYSTEM</para>
                    /// </summary>
                    [NameInMap("TemplateFrom")]
                    [Validation(Required=false)]
                    public string TemplateFrom { get; set; }

                    /// <summary>
                    /// <para>Version number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public int? Version { get; set; }

                }

                /// <summary>
                /// <para>Status of the standard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>draft</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Standard type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zz</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>Total number of records.</para>
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
        /// <para>Whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
