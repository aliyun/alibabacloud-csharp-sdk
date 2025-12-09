// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCloudAssetMatchOperatorsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of operator types</para>
        /// </summary>
        [NameInMap("MatchTypeOperators")]
        [Validation(Required=false)]
        public List<ListCloudAssetMatchOperatorsResponseBodyMatchTypeOperators> MatchTypeOperators { get; set; }
        public class ListCloudAssetMatchOperatorsResponseBodyMatchTypeOperators : TeaModel {
            /// <summary>
            /// <para>List of operators</para>
            /// </summary>
            [NameInMap("MatchOperators")]
            [Validation(Required=false)]
            public List<ListCloudAssetMatchOperatorsResponseBodyMatchTypeOperatorsMatchOperators> MatchOperators { get; set; }
            public class ListCloudAssetMatchOperatorsResponseBodyMatchTypeOperatorsMatchOperators : TeaModel {
                /// <summary>
                /// <para>Operation data types. Values: </para>
                /// <list type="bullet">
                /// <item><description>LIST type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>For Name as LIST_CONTAINS, the value is: LIST </description></item>
                /// <item><description>For Name as LIST_LENGTH_GT, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as LIST_LENGTH_LT, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as LIST_NOT_CONTAINS, the value is: LIST</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>STRING type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>For Name as STRING_NOT_IN, the value is: LIST </description></item>
                /// <item><description>For Name as STRING_EQ, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as STRING_IN, the value is: LIST </description></item>
                /// <item><description>For Name as STRING_NOT_EQ, the value is: PRIMITIVE</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>BOOLEAN type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>For Name as BOOLEAN_NOT_IN, the value is: LIST </description></item>
                /// <item><description>For Name as BOOLEAN_EQ, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as BOOLEAN_IN, the value is: LIST </description></item>
                /// <item><description>For Name as BOOLEAN_NOT_EQ, the value is: PRIMITIVE</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>FLOAT type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>For Name as FLOAT_NOT_IN, the value is: LIST </description></item>
                /// <item><description>For Name as FLOAT_EQ, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as FLOAT_IN, the value is: LIST </description></item>
                /// <item><description>For Name as FLOAT_NOT_EQ, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as FLOAT_GT, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as FLOAT_GTE, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as FLOAT_LT, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as FLOAT_LTE, the value is: PRIMITIVE</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>DOUBLE type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>For Name as DOUBLE_NOT_IN, the value is: LIST </description></item>
                /// <item><description>For Name as DOUBLE_EQ, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as DOUBLE_IN, the value is: LIST </description></item>
                /// <item><description>For Name as DOUBLE_NOT_EQ, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as DOUBLE_GT, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as DOUBLE_GTE, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as DOUBLE_LT, the value is: PRIMITIVE 8. For Name as DOUBLE_LTE, the value is: PRIMITIVE</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>INTEGER type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>For Name as INTEGER_NOT_IN, the value is: LIST </description></item>
                /// <item><description>For Name as INTEGER_EQ, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as INTEGER_IN, the value is: LIST </description></item>
                /// <item><description>For Name as INTEGER_NOT_EQ, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as INTEGER_GT, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as INTEGER_GTE, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as INTEGER_LT, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as INTEGER_LTE, the value is: PRIMITIVE</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>LONG type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>For Name as LONG_NOT_IN, the value is: LIST </description></item>
                /// <item><description>For Name as LONG_EQ, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as LONG_IN, the value is: LIST </description></item>
                /// <item><description>For Name as LONG_NOT_EQ, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as LONG_GT, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as LONG_GTE, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as LONG_LT, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as LONG_LTE, the value is: PRIMITIVE</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>INTEGER type (repeated):</description></item>
                /// </list>
                /// <ol>
                /// <item><description>For Name as INTEGER_NOT_IN, the value is: LIST </description></item>
                /// <item><description>For Name as INTEGER_EQ, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as INTEGER_IN, the value is: LIST </description></item>
                /// <item><description>For Name as INTEGER_NOT_EQ, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as INTEGER_GT, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as INTEGER_GTE, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as INTEGER_LT, the value is: PRIMITIVE </description></item>
                /// <item><description>For Name as INTEGER_LTE, the value is: PRIMITIVE</description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>PRIMITIVE</para>
                /// </summary>
                [NameInMap("InputPattern")]
                [Validation(Required=false)]
                public string InputPattern { get; set; }

                /// <summary>
                /// <para>Unique name of the operator. Values: - LIST type: </para>
                /// <ol>
                /// <item><description>LIST_CONTAINS: contains </description></item>
                /// <item><description>LIST_LENGTH_GT: length greater than </description></item>
                /// <item><description>LIST_LENGTH_LT: length less than </description></item>
                /// <item><description>LIST_NOT_CONTAINS: does not contain</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>STRING type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>STRING_NOT_IN: not in list </description></item>
                /// <item><description>STRING_EQ: equals </description></item>
                /// <item><description>STRING_IN: in list </description></item>
                /// <item><description>STRING_NOT_EQ: not equal</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>BOOLEAN type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>BOOLEAN_NOT_IN: not in list </description></item>
                /// <item><description>BOOLEAN_EQ: equals </description></item>
                /// <item><description>BOOLEAN_IN: in list </description></item>
                /// <item><description>BOOLEAN_NOT_EQ: not equal</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>FLOAT type: 1. FLOAT_NOT_IN: not in list</description></item>
                /// </list>
                /// <ol start="2">
                /// <item><description>FLOAT_EQ: equals 3. FLOAT_IN: in list </description></item>
                /// <item><description>FLOAT_NOT_EQ: not equal </description></item>
                /// <item><description>FLOAT_GT: greater than </description></item>
                /// <item><description>FLOAT_GTE: greater than or equal to </description></item>
                /// <item><description>FLOAT_LT: less than </description></item>
                /// <item><description>FLOAT_LTE: less than or equal to</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>DOUBLE type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>DOUBLE_NOT_IN: not in list </description></item>
                /// <item><description>DOUBLE_EQ: equals </description></item>
                /// <item><description>DOUBLE_IN: in list </description></item>
                /// <item><description>DOUBLE_NOT_EQ: not equal </description></item>
                /// <item><description>DOUBLE_GT: greater than </description></item>
                /// <item><description>DOUBLE_GTE: greater than or equal to 7
                /// . DOUBLE_LT: less than </description></item>
                /// <item><description>DOUBLE_LTE: less than or equal to</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>INTEGER type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>INTEGER_NOT_IN: not in list </description></item>
                /// <item><description>INTEGER_EQ: equals </description></item>
                /// <item><description>INTEGER_IN: in list </description></item>
                /// <item><description>INTEGER_NOT_EQ: not equal </description></item>
                /// <item><description>INTEGER_GT: greater than </description></item>
                /// <item><description>INTEGER_GTE: greater than or equal to </description></item>
                /// <item><description>INTEGER_LT: less than </description></item>
                /// <item><description>INTEGER_LTE: less than or equal to</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>LONG type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>LONG_NOT_IN: not in list </description></item>
                /// <item><description>LONG_EQ: equals </description></item>
                /// <item><description>LONG_IN: in list </description></item>
                /// <item><description>LONG_NOT_EQ: not equal </description></item>
                /// <item><description>LONG_GT: greater than </description></item>
                /// <item><description>LONG_GTE: greater than or equal to </description></item>
                /// <item><description>LONG_LT: less than </description></item>
                /// <item><description>LONG_LTE: less than or equal to<details></description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>LIST_CONTAINS</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Operator display name. Values: - For LIST type: </para>
                /// <ol>
                /// <item><description>Contains: includes </description></item>
                /// <item><description>SizeGreaterThan: size greater than </description></item>
                /// <item><description>SizeLessThan: size less than </description></item>
                /// <item><description>NotContains: does not include</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>For STRING type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>NotIn: not in the list </description></item>
                /// <item><description>Equals: equals </description></item>
                /// <item><description>In: in the list </description></item>
                /// <item><description>NotEquals: does not equal</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>For BOOLEAN type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>NotIn: not in the list </description></item>
                /// <item><description>Equals: equals </description></item>
                /// <item><description>In: in the list </description></item>
                /// <item><description>NotEquals: does not equal</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>For FLOAT type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>NotIn: not in the list </description></item>
                /// <item><description>Equals: equals </description></item>
                /// <item><description>In: in the list </description></item>
                /// <item><description>NotEquals: does not equal </description></item>
                /// <item><description><remarks>
                /// <para>: greater than </para>
                /// </remarks>
                /// </description></item>
                /// <item><description><remarks>
                /// <para>=: greater than or equal to </para>
                /// </remarks>
                /// </description></item>
                /// <item><description>&lt;: less than </description></item>
                /// <item><description>&lt;=: less than or equal to</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>For DOUBLE type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>NotIn: not in the list </description></item>
                /// <item><description>Equals: equals </description></item>
                /// <item><description>In: in the list </description></item>
                /// <item><description>NotEquals: does not equal </description></item>
                /// <item><description><remarks>
                /// <para>: greater than </para>
                /// </remarks>
                /// </description></item>
                /// <item><description><remarks>
                /// <para>=: greater than or equal to </para>
                /// </remarks>
                /// </description></item>
                /// <item><description>&lt;: less than </description></item>
                /// <item><description>&lt;=: less than or equal to (Note: There seems to be a repetition here, likely meant to be \&quot;&lt;=\&quot; for \&quot;less than or equal to\&quot;)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>For INTEGER type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>NotIn: not in the list </description></item>
                /// <item><description>Equals: equals </description></item>
                /// <item><description>In: in the list </description></item>
                /// <item><description>NotEquals: does not equal </description></item>
                /// <item><description><remarks>
                /// <para>: greater than </para>
                /// </remarks>
                /// </description></item>
                /// <item><description><remarks>
                /// <para>=: greater than or equal to </para>
                /// </remarks>
                /// </description></item>
                /// <item><description>&lt;: less than </description></item>
                /// <item><description>&lt;=: less than or equal to</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>For LONG type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>NotIn: not in the list </description></item>
                /// <item><description>Equals: equals </description></item>
                /// <item><description>In: in the list </description></item>
                /// <item><description>NotEquals: does not equal </description></item>
                /// <item><description><remarks>
                /// <para>: greater than </para>
                /// </remarks>
                /// </description></item>
                /// <item><description><remarks>
                /// <para>=: greater than or equal to </para>
                /// </remarks>
                /// </description></item>
                /// <item><description>&lt;: less than </description></item>
                /// <item><description>&lt;=: less than or equal to</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>For INTEGER type (repeated):</description></item>
                /// </list>
                /// <ol>
                /// <item><description>NotIn: not in the list </description></item>
                /// <item><description>Equals: equals </description></item>
                /// <item><description>In: in the list </description></item>
                /// <item><description>NotEquals: does not equal </description></item>
                /// <item><description><remarks>
                /// <para>: greater than </para>
                /// </remarks>
                /// </description></item>
                /// <item><description><remarks>
                /// <para>=: greater than or equal to </para>
                /// </remarks>
                /// </description></item>
                /// <item><description>&lt;: less than </description></item>
                /// <item><description>&lt;=: less than or equal to</description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>Contains</para>
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// <para>Operator value. Options: - For LIST type: </para>
                /// <ol>
                /// <item><description>CONTAINS: contains </description></item>
                /// <item><description>LENGTH_GT: length greater than </description></item>
                /// <item><description>LENGTH_LT: length less than </description></item>
                /// <item><description>NOT_CONTAINS: does not contain</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>For STRING type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>NOT_IN: not in the list </description></item>
                /// <item><description>EQ: equals </description></item>
                /// <item><description>IN: in the list </description></item>
                /// <item><description>NOT_EQ: does not equal</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>For BOOLEAN type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>NOT_IN: not in the list </description></item>
                /// <item><description>EQ: equals </description></item>
                /// <item><description>IN: in the list </description></item>
                /// <item><description>NOT_EQ: does not equal</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>For FLOAT type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>NOT_IN: not in the list </description></item>
                /// <item><description>EQ: equals </description></item>
                /// <item><description>IN: in the list </description></item>
                /// <item><description>NOT_EQ: does not equal </description></item>
                /// <item><description>GT: greater than </description></item>
                /// <item><description>GTE: greater than or equal to </description></item>
                /// <item><description>LT: less than </description></item>
                /// <item><description>LTE: less than or equal to</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>For DOUBLE type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>NOT_IN: not in the list </description></item>
                /// <item><description>EQ: equals </description></item>
                /// <item><description>IN: in the list </description></item>
                /// <item><description>NOT_EQ: does not equal </description></item>
                /// <item><description>GT: greater than </description></item>
                /// <item><description>GTE: greater than or equal to </description></item>
                /// <item><description>LT: less than </description></item>
                /// <item><description>LTE: less than or equal to</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>For INTEGER type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>NOT_IN: not in the list </description></item>
                /// <item><description>EQ: equals </description></item>
                /// <item><description>IN: in the list </description></item>
                /// <item><description>NOT_EQ: does not equal </description></item>
                /// <item><description>GT: greater than </description></item>
                /// <item><description>GTE: greater than or equal to </description></item>
                /// <item><description>LT: less than </description></item>
                /// <item><description>LTE: less than or equal to</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>For LONG type:</description></item>
                /// </list>
                /// <ol>
                /// <item><description>NOT_IN: not in the list </description></item>
                /// <item><description>EQ: equals </description></item>
                /// <item><description>IN: in the list </description></item>
                /// <item><description>NOT_EQ: does not equal </description></item>
                /// <item><description>GT: greater than </description></item>
                /// <item><description>GTE: greater than or equal to </description></item>
                /// <item><description>LT: less than </description></item>
                /// <item><description>LTE: less than or equal to</description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>CONTAINS</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type used by the operator. Values:</para>
            /// <list type="bullet">
            /// <item><description>LIST </description></item>
            /// <item><description>MAP </description></item>
            /// <item><description>STRING </description></item>
            /// <item><description>BOOLEAN </description></item>
            /// <item><description>FLOAT </description></item>
            /// <item><description>DOUBLE </description></item>
            /// <item><description>INTEGER </description></item>
            /// <item><description>LONG</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LIST</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C699E4E4-F2F4-58FC-A949-457FFE59****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
