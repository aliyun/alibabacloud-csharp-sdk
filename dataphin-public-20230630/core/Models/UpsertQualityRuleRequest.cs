// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpsertQualityRuleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpsertCommand")]
        [Validation(Required=false)]
        public UpsertQualityRuleRequestUpsertCommand UpsertCommand { get; set; }
        public class UpsertQualityRuleRequestUpsertCommand : TeaModel {
            [NameInMap("AttributeWithValueList")]
            [Validation(Required=false)]
            public List<UpsertQualityRuleRequestUpsertCommandAttributeWithValueList> AttributeWithValueList { get; set; }
            public class UpsertQualityRuleRequestUpsertCommandAttributeWithValueList : TeaModel {
                [NameInMap("AttributeInfo")]
                [Validation(Required=false)]
                public UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfo AttributeInfo { get; set; }
                public class UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>711484689131</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>attr01</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    [NameInMap("Searchable")]
                    [Validation(Required=false)]
                    public bool? Searchable { get; set; }

                    [NameInMap("ValueConfig")]
                    [Validation(Required=false)]
                    public UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfoValueConfig ValueConfig { get; set; }
                    public class UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfoValueConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>STRING</para>
                        /// </summary>
                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public string DataType { get; set; }

                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfoValueConfigDefaultValue DefaultValue { get; set; }
                        public class UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeInfoValueConfigDefaultValue : TeaModel {
                            [NameInMap("IncludeMaxValue")]
                            [Validation(Required=false)]
                            public bool? IncludeMaxValue { get; set; }

                            [NameInMap("IncludeMinValue")]
                            [Validation(Required=false)]
                            public bool? IncludeMinValue { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("MaxValue")]
                            [Validation(Required=false)]
                            public string MaxValue { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("MinValue")]
                            [Validation(Required=false)]
                            public string MinValue { get; set; }

                            [NameInMap("ValueList")]
                            [Validation(Required=false)]
                            public List<string> ValueList { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>986992</para>
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

                        [NameInMap("ValueEnumList")]
                        [Validation(Required=false)]
                        public List<string> ValueEnumList { get; set; }

                    }

                }

                [NameInMap("AttributeValue")]
                [Validation(Required=false)]
                public UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeValue AttributeValue { get; set; }
                public class UpsertQualityRuleRequestUpsertCommandAttributeWithValueListAttributeValue : TeaModel {
                    [NameInMap("IncludeMaxValue")]
                    [Validation(Required=false)]
                    public bool? IncludeMaxValue { get; set; }

                    [NameInMap("IncludeMinValue")]
                    [Validation(Required=false)]
                    public bool? IncludeMinValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>11</para>
                    /// </summary>
                    [NameInMap("MaxValue")]
                    [Validation(Required=false)]
                    public string MaxValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MinValue")]
                    [Validation(Required=false)]
                    public string MinValue { get; set; }

                    [NameInMap("ValueList")]
                    [Validation(Required=false)]
                    public List<string> ValueList { get; set; }

                }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("CatalogList")]
            [Validation(Required=false)]
            public List<string> CatalogList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EnableErrorArchive")]
            [Validation(Required=false)]
            public bool? EnableErrorArchive { get; set; }

            [NameInMap("FormPropertyList")]
            [Validation(Required=false)]
            public List<UpsertQualityRuleRequestUpsertCommandFormPropertyList> FormPropertyList { get; set; }
            public class UpsertQualityRuleRequestUpsertCommandFormPropertyList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>expression</para>
                /// </summary>
                [NameInMap("ComponentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>col</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRONG</para>
            /// </summary>
            [NameInMap("Strength")]
            [Validation(Required=false)]
            public string Strength { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FIELD_NULL_VALUE_VALIDATE</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            [NameInMap("ValidateConditionList")]
            [Validation(Required=false)]
            public List<UpsertQualityRuleRequestUpsertCommandValidateConditionList> ValidateConditionList { get; set; }
            public class UpsertQualityRuleRequestUpsertCommandValidateConditionList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>268</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public string Metric { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WatchId")]
            [Validation(Required=false)]
            public long? WatchId { get; set; }

        }

    }

}
