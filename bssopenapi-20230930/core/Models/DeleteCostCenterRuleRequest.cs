// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DeleteCostCenterRuleRequest : TeaModel {
        /// <summary>
        /// <para>Financial unit ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>637127</para>
        /// </summary>
        [NameInMap("CostCenterId")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        /// <summary>
        /// <para>Rule expression.
        /// <b>This field does not need to be entered during the delete operation.</b></para>
        /// </summary>
        [NameInMap("FilterExpression")]
        [Validation(Required=false)]
        public DeleteCostCenterRuleRequestFilterExpression FilterExpression { get; set; }
        public class DeleteCostCenterRuleRequestFilterExpression : TeaModel {
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
            /// <para>The sub-expression filter conditions.</para>
            /// </summary>
            [NameInMap("FilterValues")]
            [Validation(Required=false)]
            public DeleteCostCenterRuleRequestFilterExpressionFilterValues FilterValues { get; set; }
            public class DeleteCostCenterRuleRequestFilterExpressionFilterValues : TeaModel {
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
                /// <para>The condition filter key name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("CodeName")]
                [Validation(Required=false)]
                public string CodeName { get; set; }

                /// <summary>
                /// <para>The association between Code and value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IN</para>
                /// </summary>
                [NameInMap("SelectType")]
                [Validation(Required=false)]
                public string SelectType { get; set; }

                /// <summary>
                /// <para>The condition filter values.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The filter condition (no longer used).</para>
            /// 
            /// <b>Example:</b>
            /// <para>无</para>
            /// </summary>
            [NameInMap("Operand")]
            [Validation(Required=false)]
            public object Operand { get; set; }

            /// <summary>
            /// <para>The conditional expressions.</para>
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
        /// <para>Level-1 marketplace ID. If empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}
