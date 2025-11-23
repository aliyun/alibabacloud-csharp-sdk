// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveColumnInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the request ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the sensitive field.</para>
        /// </summary>
        [NameInMap("SensitiveColumnList")]
        [Validation(Required=false)]
        public ListSensitiveColumnInfoResponseBodySensitiveColumnList SensitiveColumnList { get; set; }
        public class ListSensitiveColumnInfoResponseBodySensitiveColumnList : TeaModel {
            [NameInMap("SensitiveColumn")]
            [Validation(Required=false)]
            public List<ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumn> SensitiveColumn { get; set; }
            public class ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumn : TeaModel {
                /// <summary>
                /// <para>The name of the category.</para>
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <para>The name of the sensitive field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_column</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The information about the default masking algorithm.</para>
                /// </summary>
                [NameInMap("DefaultDesensitizationRule")]
                [Validation(Required=false)]
                public ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnDefaultDesensitizationRule DefaultDesensitizationRule { get; set; }
                public class ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnDefaultDesensitizationRule : TeaModel {
                    /// <summary>
                    /// <para>The masking algorithm ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101**</para>
                    /// </summary>
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                    /// <summary>
                    /// <para>The masking algorithm name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>183****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public int? InstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether the sensitive field is displayed in plaintext.</para>
                /// 
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("IsPlain")]
                [Validation(Required=false)]
                public bool? IsPlain { get; set; }

                /// <summary>
                /// <para>The sample data.</para>
                /// </summary>
                [NameInMap("SampleData")]
                [Validation(Required=false)]
                public string SampleData { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_schema</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The sensitivity level of the field. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Low</description></item>
                /// <item><description>Medium</description></item>
                /// <item><description>High</description></item>
                /// </list>
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                /// <summary>
                /// <para>The list of partial masking algorithms.</para>
                /// </summary>
                [NameInMap("SemiDesensitizationRuleList")]
                [Validation(Required=false)]
                public ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnSemiDesensitizationRuleList SemiDesensitizationRuleList { get; set; }
                public class ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnSemiDesensitizationRuleList : TeaModel {
                    [NameInMap("SemiDesensitizationRule")]
                    [Validation(Required=false)]
                    public List<ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnSemiDesensitizationRuleListSemiDesensitizationRule> SemiDesensitizationRule { get; set; }
                    public class ListSensitiveColumnInfoResponseBodySensitiveColumnListSensitiveColumnSemiDesensitizationRuleListSemiDesensitizationRule : TeaModel {
                        /// <summary>
                        /// <para>The ID of the partial masking algorithm.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10***</para>
                        /// </summary>
                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public long? RuleId { get; set; }

                        /// <summary>
                        /// <para>The partial masking algorithm name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test01</para>
                        /// </summary>
                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_table</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The user-defined sensitivity level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S1</para>
                /// </summary>
                [NameInMap("UserSensitivityLevel")]
                [Validation(Required=false)]
                public string UserSensitivityLevel { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
