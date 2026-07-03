// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListResponseRuleFieldsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of response rule fields.</para>
        /// </summary>
        [NameInMap("ListResponseRuleFields")]
        [Validation(Required=false)]
        public List<ListResponseRuleFieldsResponseBodyListResponseRuleFields> ListResponseRuleFields { get; set; }
        public class ListResponseRuleFieldsResponseBodyListResponseRuleFields : TeaModel {
            /// <summary>
            /// <para>The data type of the automated response rule condition field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The whitelisted field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appname</para>
            /// </summary>
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <para>The name of the rule field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OriginIP,ConsoleLog,CPUTime,Duration,ErrorCode,ErrorMessage,ResponseSize,ResponseStatus,RoutineName,ClientRequestID,LogTimestamp,FetchStatus,SubRequestID</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The normalization object type to which the field belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alert</para>
            /// </summary>
            [NameInMap("FieldNormalization")]
            [Validation(Required=false)]
            public string FieldNormalization { get; set; }

            /// <summary>
            /// <para>The list of optional enumeration values for the field. This parameter is not returned if no enumeration values are available.</para>
            /// </summary>
            [NameInMap("RightValue")]
            [Validation(Required=false)]
            public List<ListResponseRuleFieldsResponseBodyListResponseRuleFieldsRightValue> RightValue { get; set; }
            public class ListResponseRuleFieldsResponseBodyListResponseRuleFieldsRightValue : TeaModel {
                /// <summary>
                /// <para>The right-side value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev_selectdb_cluster</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The display name of the enumeration value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("ValueName")]
                [Validation(Required=false)]
                public string ValueName { get; set; }

            }

            /// <summary>
            /// <para>The English descriptions of the operators.</para>
            /// </summary>
            [NameInMap("SupportOperators")]
            [Validation(Required=false)]
            public List<ListResponseRuleFieldsResponseBodyListResponseRuleFieldsSupportOperators> SupportOperators { get; set; }
            public class ListResponseRuleFieldsResponseBodyListResponseRuleFieldsSupportOperators : TeaModel {
                /// <summary>
                /// <para>Indicates whether a right-side value is required. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Required.</description></item>
                /// <item><description>false: Not required.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasRightValue")]
                [Validation(Required=false)]
                public string HasRightValue { get; set; }

                /// <summary>
                /// <para>The position of the operator in the operator list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <para>The aggregation method for the dispatch rule condition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>=</c>: equal to</description></item>
                /// <item><description><c>&lt;&gt;</c>: not equal to</description></item>
                /// <item><description><c>in</c>: contains</description></item>
                /// <item><description><c>not in</c>: does not contain</description></item>
                /// <item><description><c>REGEXP</c>: matches the regular expression</description></item>
                /// <item><description><c>NOT REGEXP</c>: does not match the regular expression</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BETWEEN</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The display name of the operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>autotest-operator</para>
                /// </summary>
                [NameInMap("OperatorName")]
                [Validation(Required=false)]
                public string OperatorName { get; set; }

                /// <summary>
                /// <para>The data types supported by the current operator, separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("SupportDataType")]
                [Validation(Required=false)]
                public string SupportDataType { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. Valid values: leave this parameter empty for the first query or if no more results exist. If a next query exists, set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
