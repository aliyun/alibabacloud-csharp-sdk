// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class QueryCostCenterRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The cost center ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>597745</para>
        /// </summary>
        [NameInMap("CostCenterId")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        /// <summary>
        /// <para>The rule expression.</para>
        /// </summary>
        [NameInMap("FilterExpression")]
        [Validation(Required=false)]
        public QueryCostCenterRuleResponseBodyFilterExpression FilterExpression { get; set; }
        public class QueryCostCenterRuleResponseBodyFilterExpression : TeaModel {
            /// <summary>
            /// <para>The operation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NARY</para>
            /// </summary>
            [NameInMap("ExpressionType")]
            [Validation(Required=false)]
            public string ExpressionType { get; set; }

            /// <summary>
            /// <para>The sub-condition filter.</para>
            /// </summary>
            [NameInMap("FilterValues")]
            [Validation(Required=false)]
            public QueryCostCenterRuleResponseBodyFilterExpressionFilterValues FilterValues { get; set; }
            public class QueryCostCenterRuleResponseBodyFilterExpressionFilterValues : TeaModel {
                /// <summary>
                /// <para>The condition filter key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TAG-test-xxx-key</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The condition filter key name (deprecated).</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("CodeName")]
                [Validation(Required=false)]
                public string CodeName { get; set; }

                /// <summary>
                /// <para>The association between code and value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IN</para>
                /// </summary>
                [NameInMap("SelectType")]
                [Validation(Required=false)]
                public string SelectType { get; set; }

                /// <summary>
                /// <para>The attribute value types corresponding to the module code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>single_float: single value type.</description></item>
                /// <item><description>range_float: range value type.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The filter condition (deprecated).</para>
            /// 
            /// <b>Example:</b>
            /// <para>无</para>
            /// </summary>
            [NameInMap("Operand")]
            [Validation(Required=false)]
            public object Operand { get; set; }

            /// <summary>
            /// <para>The condition expression.</para>
            /// </summary>
            [NameInMap("Operands")]
            [Validation(Required=false)]
            public List<object> Operands { get; set; }

            /// <summary>
            /// <para>The relational expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

        }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tue Nov 12 14:49:43 CST 2024</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Wed Oct 16 10:15:37 CST 2024</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The ID of the cost center auto-allocation rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32048</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The deletion status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: active.</description></item>
        /// <item><description><b>1</b>: inactive.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDeleted")]
        [Validation(Required=false)]
        public int? IsDeleted { get; set; }

        /// <summary>
        /// <para>Response structure metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The owner user of the cost center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1977800748053695</para>
        /// </summary>
        [NameInMap("OwnerAccountId")]
        [Validation(Required=false)]
        public long? OwnerAccountId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UUID</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The root cost center ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RootCostCenterId")]
        [Validation(Required=false)]
        public long? RootCostCenterId { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: active.</description></item>
        /// <item><description>off: inactive.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
