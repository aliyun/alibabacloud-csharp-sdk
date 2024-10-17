// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveColumnInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SensitiveColumnList")]
        [Validation(Required=false)]
        public ListSensitiveColumnInfoResponseBodySensitiveColumnList SensitiveColumnList { get; set; }
        public class ListSensitiveColumnInfoResponseBodySensitiveColumnList : TeaModel {
            [NameInMap("SensitiveColumn")]
            [Validation(Required=false)]
            public List<ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumn> SensitiveColumn { get; set; }
            public class ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumn : TeaModel {
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_column</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("DefaultDesensitizationRule")]
                [Validation(Required=false)]
                public ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnDefaultDesensitizationRule DefaultDesensitizationRule { get; set; }
                public class ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnDefaultDesensitizationRule : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>101**</para>
                    /// </summary>
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>183****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public int? InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("IsPlain")]
                [Validation(Required=false)]
                public bool? IsPlain { get; set; }

                [NameInMap("SampleData")]
                [Validation(Required=false)]
                public string SampleData { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_schema</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                [NameInMap("SemiDesensitizationRuleList")]
                [Validation(Required=false)]
                public ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnSemiDesensitizationRuleList SemiDesensitizationRuleList { get; set; }
                public class ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnSemiDesensitizationRuleList : TeaModel {
                    [NameInMap("SemiDesensitizationRule")]
                    [Validation(Required=false)]
                    public List<ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnSemiDesensitizationRuleListSemiDesensitizationRule> SemiDesensitizationRule { get; set; }
                    public class ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnSemiDesensitizationRuleListSemiDesensitizationRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10***</para>
                        /// </summary>
                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public long? RuleId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test01</para>
                        /// </summary>
                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_table</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>S1</para>
                /// </summary>
                [NameInMap("UserSensitivityLevel")]
                [Validation(Required=false)]
                public string UserSensitivityLevel { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
