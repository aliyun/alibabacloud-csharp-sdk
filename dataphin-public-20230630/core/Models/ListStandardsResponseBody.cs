// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListStandardsResponseBody : TeaModel {
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

        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListStandardsResponseBodyPageResult PageResult { get; set; }
        public class ListStandardsResponseBodyPageResult : TeaModel {
            [NameInMap("StandardList")]
            [Validation(Required=false)]
            public List<ListStandardsResponseBodyPageResultStandardList> StandardList { get; set; }
            public class ListStandardsResponseBodyPageResultStandardList : TeaModel {
                [NameInMap("AttributeWithValueList")]
                [Validation(Required=false)]
                public List<ListStandardsResponseBodyPageResultStandardListAttributeWithValueList> AttributeWithValueList { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueList : TeaModel {
                    [NameInMap("Attribute")]
                    [Validation(Required=false)]
                    public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttribute Attribute { get; set; }
                    public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttribute : TeaModel {
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
                        public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeMonitorConfig MonitorConfig { get; set; }
                        public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeMonitorConfig : TeaModel {
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
                        public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttribute RefAttribute { get; set; }
                        public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttribute : TeaModel {
                            [NameInMap("AttributeFromInfo")]
                            [Validation(Required=false)]
                            public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttributeAttributeFromInfo AttributeFromInfo { get; set; }
                            public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttributeAttributeFromInfo : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>CUSTOM</para>
                                /// </summary>
                                [NameInMap("AttributeFrom")]
                                [Validation(Required=false)]
                                public string AttributeFrom { get; set; }

                                [NameInMap("StandardReference")]
                                [Validation(Required=false)]
                                public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttributeAttributeFromInfoStandardReference StandardReference { get; set; }
                                public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeRefAttributeAttributeFromInfoStandardReference : TeaModel {
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
                        public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfig ValueConfig { get; set; }
                        public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfig : TeaModel {
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
                            public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRange ValueRange { get; set; }
                            public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRange : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>DATAPHIN_ATTRIBUTE</para>
                                /// </summary>
                                [NameInMap("DataphinAttributeType")]
                                [Validation(Required=false)]
                                public string DataphinAttributeType { get; set; }

                                [NameInMap("LookupTableReference")]
                                [Validation(Required=false)]
                                public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRangeLookupTableReference LookupTableReference { get; set; }
                                public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRangeLookupTableReference : TeaModel {
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
                                public ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRangeMinMaxValueConfig MinMaxValueConfig { get; set; }
                                public class ListStandardsResponseBodyPageResultStandardListAttributeWithValueListAttributeValueConfigValueRangeMinMaxValueConfig : TeaModel {
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
                public ListStandardsResponseBodyPageResultStandardListCreator Creator { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListCreator : TeaModel {
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
                public ListStandardsResponseBodyPageResultStandardListEffectiveTimeConfig EffectiveTimeConfig { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListEffectiveTimeConfig : TeaModel {
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
                public ListStandardsResponseBodyPageResultStandardListLastModifier LastModifier { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListLastModifier : TeaModel {
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
                public ListStandardsResponseBodyPageResultStandardListOwner Owner { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListOwner : TeaModel {
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

                [NameInMap("StandardSet")]
                [Validation(Required=false)]
                public ListStandardsResponseBodyPageResultStandardListStandardSet StandardSet { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListStandardSet : TeaModel {
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
                public ListStandardsResponseBodyPageResultStandardListStandardTemplate StandardTemplate { get; set; }
                public class ListStandardsResponseBodyPageResultStandardListStandardTemplate : TeaModel {
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

            /// <summary>
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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
