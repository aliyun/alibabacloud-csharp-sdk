// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateCostCenterRuleRequest : TeaModel {
        /// <summary>
        /// <para>The financial unit ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>485938</para>
        /// </summary>
        [NameInMap("CostCenterId")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        /// <summary>
        /// <para>The rule expression.</para>
        /// </summary>
        [NameInMap("FilterExpression")]
        [Validation(Required=false)]
        public CreateCostCenterRuleRequestFilterExpression FilterExpression { get; set; }
        public class CreateCostCenterRuleRequestFilterExpression : TeaModel {
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
            public CreateCostCenterRuleRequestFilterExpressionFilterValues FilterValues { get; set; }
            public class CreateCostCenterRuleRequestFilterExpressionFilterValues : TeaModel {
                /// <summary>
                /// <para>The filter condition key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TAG-test-xxx-key</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The filter condition key name (deprecated).</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("CodeName")]
                [Validation(Required=false)]
                public string CodeName { get; set; }

                /// <summary>
                /// <para>The association between the code and value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IN</para>
                /// </summary>
                [NameInMap("SelectType")]
                [Validation(Required=false)]
                public string SelectType { get; set; }

                /// <summary>
                /// <para>The list of filter condition values.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The filter condition (deprecated).</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Operand")]
            [Validation(Required=false)]
            public object Operand { get; set; }

            /// <summary>
            /// <para>The conditional expression.</para>
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
        /// <para>The level-1 marketplace ID. If left empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2084210001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}
