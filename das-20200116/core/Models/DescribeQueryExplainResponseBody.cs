// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeQueryExplainResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code. A value of 200 indicates success.</para>
        /// 
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
            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Argument")]
            [Validation(Required=false)]
            public string Argument { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("AvgRowSize")]
            [Validation(Required=false)]
            public string AvgRowSize { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("DefinedValues")]
            [Validation(Required=false)]
            public string DefinedValues { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("EstimateCPU")]
            [Validation(Required=false)]
            public string EstimateCPU { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("EstimateExecutions")]
            [Validation(Required=false)]
            public string EstimateExecutions { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("EstimateIO")]
            [Validation(Required=false)]
            public string EstimateIO { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("EstimateRows")]
            [Validation(Required=false)]
            public string EstimateRows { get; set; }

            /// <summary>
            /// <para>The additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The query ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The reserved field for the PostgreSQL engine.</para>
            /// </summary>
            [NameInMap("IndexList")]
            [Validation(Required=false)]
            public List<string> IndexList { get; set; }

            /// <summary>
            /// <para>The index that is actually used in the execution plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIMARY</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The length of the used index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("KeyLen")]
            [Validation(Required=false)]
            public string KeyLen { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("LogicalOp")]
            [Validation(Required=false)]
            public string LogicalOp { get; set; }

            /// <summary>
            /// <para>The reserved field for the PolarDB-X engine.</para>
            /// </summary>
            [NameInMap("LogicalPlanList")]
            [Validation(Required=false)]
            public List<string> LogicalPlanList { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("OutputList")]
            [Validation(Required=false)]
            public string OutputList { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Parallel")]
            [Validation(Required=false)]
            public string Parallel { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Parent")]
            [Validation(Required=false)]
            public string Parent { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("PhysicalOp")]
            [Validation(Required=false)]
            public string PhysicalOp { get; set; }

            /// <summary>
            /// <para>The possible indexes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_idx</para>
            /// </summary>
            [NameInMap("PossibleKeys")]
            [Validation(Required=false)]
            public string PossibleKeys { get; set; }

            /// <summary>
            /// <para>The reserved field for the PostgreSQL engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("QueryPlan")]
            [Validation(Required=false)]
            public string QueryPlan { get; set; }

            /// <summary>
            /// <para>The columns used with the index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_column</para>
            /// </summary>
            [NameInMap("Ref")]
            [Validation(Required=false)]
            public string Ref { get; set; }

            /// <summary>
            /// <para>The number of rows to scan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }

            /// <summary>
            /// <para>The select type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("SelectType")]
            [Validation(Required=false)]
            public string SelectType { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("StmtId")]
            [Validation(Required=false)]
            public string StmtId { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("StmtText")]
            [Validation(Required=false)]
            public string StmtText { get; set; }

            /// <summary>
            /// <para>The table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            /// <summary>
            /// <para>The reserved field for the PostgreSQL engine.</para>
            /// </summary>
            [NameInMap("TableList")]
            [Validation(Required=false)]
            public List<string> TableList { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("TotalSubtreeCost")]
            [Validation(Required=false)]
            public string TotalSubtreeCost { get; set; }

            /// <summary>
            /// <para>The join type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eq_ref</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The reserved field for the SQL Server engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Warnings")]
            [Validation(Required=false)]
            public string Warnings { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// <remarks>
        /// <para>If the request is successful, Successful is returned. If the request fails, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        public string Success { get; set; }

    }

}
