// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DeleteCostCenterRuleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>637127</para>
        /// </summary>
        [NameInMap("CostCenterId")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        [NameInMap("FilterExpression")]
        [Validation(Required=false)]
        public DeleteCostCenterRuleRequestFilterExpression FilterExpression { get; set; }
        public class DeleteCostCenterRuleRequestFilterExpression : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>NARY</para>
            /// </summary>
            [NameInMap("ExpressionType")]
            [Validation(Required=false)]
            public string ExpressionType { get; set; }

            [NameInMap("FilterValues")]
            [Validation(Required=false)]
            public DeleteCostCenterRuleRequestFilterExpressionFilterValues FilterValues { get; set; }
            public class DeleteCostCenterRuleRequestFilterExpressionFilterValues : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TAG-test-xxx-key</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("CodeName")]
                [Validation(Required=false)]
                public string CodeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IN</para>
                /// </summary>
                [NameInMap("SelectType")]
                [Validation(Required=false)]
                public string SelectType { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("Operand")]
            [Validation(Required=false)]
            public object Operand { get; set; }

            [NameInMap("Operands")]
            [Validation(Required=false)]
            public List<object> Operands { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}
