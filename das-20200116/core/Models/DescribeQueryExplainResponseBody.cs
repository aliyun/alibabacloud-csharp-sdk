// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeQueryExplainResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>List<ExplainedSqlDO></para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeQueryExplainResponseBodyData> Data { get; set; }
        public class DescribeQueryExplainResponseBodyData : TeaModel {
            [NameInMap("Argument")]
            [Validation(Required=false)]
            public string Argument { get; set; }

            [NameInMap("AvgRowSize")]
            [Validation(Required=false)]
            public string AvgRowSize { get; set; }

            [NameInMap("DefinedValues")]
            [Validation(Required=false)]
            public string DefinedValues { get; set; }

            [NameInMap("EstimateCPU")]
            [Validation(Required=false)]
            public string EstimateCPU { get; set; }

            [NameInMap("EstimateExecutions")]
            [Validation(Required=false)]
            public string EstimateExecutions { get; set; }

            [NameInMap("EstimateIO")]
            [Validation(Required=false)]
            public string EstimateIO { get; set; }

            [NameInMap("EstimateRows")]
            [Validation(Required=false)]
            public string EstimateRows { get; set; }

            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IndexList")]
            [Validation(Required=false)]
            public List<string> IndexList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PRIMARY</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("KeyLen")]
            [Validation(Required=false)]
            public string KeyLen { get; set; }

            [NameInMap("LogicalOp")]
            [Validation(Required=false)]
            public string LogicalOp { get; set; }

            [NameInMap("LogicalPlanList")]
            [Validation(Required=false)]
            public List<string> LogicalPlanList { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("OutputList")]
            [Validation(Required=false)]
            public string OutputList { get; set; }

            [NameInMap("Parallel")]
            [Validation(Required=false)]
            public string Parallel { get; set; }

            [NameInMap("Parent")]
            [Validation(Required=false)]
            public string Parent { get; set; }

            [NameInMap("PhysicalOp")]
            [Validation(Required=false)]
            public string PhysicalOp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_idx</para>
            /// </summary>
            [NameInMap("PossibleKeys")]
            [Validation(Required=false)]
            public string PossibleKeys { get; set; }

            [NameInMap("QueryPlan")]
            [Validation(Required=false)]
            public string QueryPlan { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_column</para>
            /// </summary>
            [NameInMap("Ref")]
            [Validation(Required=false)]
            public string Ref { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("SelectType")]
            [Validation(Required=false)]
            public string SelectType { get; set; }

            [NameInMap("StmtId")]
            [Validation(Required=false)]
            public string StmtId { get; set; }

            [NameInMap("StmtText")]
            [Validation(Required=false)]
            public string StmtText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            [NameInMap("TableList")]
            [Validation(Required=false)]
            public List<string> TableList { get; set; }

            [NameInMap("TotalSubtreeCost")]
            [Validation(Required=false)]
            public string TotalSubtreeCost { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eq_ref</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Warnings")]
            [Validation(Required=false)]
            public string Warnings { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
