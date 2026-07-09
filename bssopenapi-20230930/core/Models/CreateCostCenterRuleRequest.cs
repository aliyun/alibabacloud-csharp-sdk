// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateCostCenterRuleRequest : TeaModel {
        /// <summary>
        /// <para>Financial unit ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>485938</para>
        /// </summary>
        [NameInMap("CostCenterId")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        /// <summary>
        /// <para>Rule expression</para>
        /// </summary>
        [NameInMap("FilterExpression")]
        [Validation(Required=false)]
        public CreateCostCenterRuleRequestFilterExpression FilterExpression { get; set; }
        public class CreateCostCenterRuleRequestFilterExpression : TeaModel {
            /// <summary>
            /// <para>Operation type</para>
            /// 
            /// <b>Example:</b>
            /// <para>NARY</para>
            /// </summary>
            [NameInMap("ExpressionType")]
            [Validation(Required=false)]
            public string ExpressionType { get; set; }

            /// <summary>
            /// <para>Sub-condition filter</para>
            /// </summary>
            [NameInMap("FilterValues")]
            [Validation(Required=false)]
            public CreateCostCenterRuleRequestFilterExpressionFilterValues FilterValues { get; set; }
            public class CreateCostCenterRuleRequestFilterExpressionFilterValues : TeaModel {
                /// <summary>
                /// <para>Condition filter key</para>
                /// 
                /// <b>Example:</b>
                /// <para>TAG-test-xxx-key</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Condition filter key name (deprecated)</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("CodeName")]
                [Validation(Required=false)]
                public string CodeName { get; set; }

                /// <summary>
                /// <para>Association relationship between code and value</para>
                /// 
                /// <b>Example:</b>
                /// <para>IN</para>
                /// </summary>
                [NameInMap("SelectType")]
                [Validation(Required=false)]
                public string SelectType { get; set; }

                /// <summary>
                /// <para>Condition filter value list</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>Filter condition (deprecated)</para>
            /// 
            /// <b>Example:</b>
            /// <para>无</para>
            /// </summary>
            [NameInMap("Operand")]
            [Validation(Required=false)]
            public object Operand { get; set; }

            /// <summary>
            /// <para>Condition expression</para>
            /// </summary>
            [NameInMap("Operands")]
            [Validation(Required=false)]
            public List<object> Operands { get; set; }

            /// <summary>
            /// <para>Relational expression</para>
            /// 
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

        }

        /// <summary>
        /// <para>First-level marketplace ID. If left empty, the ID of the marketplace to which the current user belongs is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2084210001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}
