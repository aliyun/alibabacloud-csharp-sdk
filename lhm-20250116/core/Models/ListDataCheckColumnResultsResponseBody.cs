// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListDataCheckColumnResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListDataCheckColumnResultsResponseBodyData> Data { get; set; }
        public class ListDataCheckColumnResultsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual difference.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.00</para>
            /// </summary>
            [NameInMap("actualThreshold")]
            [Validation(Required=false)]
            public string ActualThreshold { get; set; }

            /// <summary>
            /// <para>The execution result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: no record.</description></item>
            /// <item><description>1: passed.</description></item>
            /// <item><description>2: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("checkResult")]
            [Validation(Required=false)]
            public int? CheckResult { get; set; }

            /// <summary>
            /// <para>The comparison rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUM</para>
            /// </summary>
            [NameInMap("checkRule")]
            [Validation(Required=false)]
            public string CheckRule { get; set; }

            /// <summary>
            /// <para>The alias of the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dst</para>
            /// </summary>
            [NameInMap("dstAlias")]
            [Validation(Required=false)]
            public string DstAlias { get; set; }

            /// <summary>
            /// <para>The field name of the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amount</para>
            /// </summary>
            [NameInMap("dstColumnName")]
            [Validation(Required=false)]
            public string DstColumnName { get; set; }

            /// <summary>
            /// <para>The field type of the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>decimal(38,18)</para>
            /// </summary>
            [NameInMap("dstColumnType")]
            [Validation(Required=false)]
            public string DstColumnType { get; set; }

            /// <summary>
            /// <para>The metric key of the destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dst_sum_amount</para>
            /// </summary>
            [NameInMap("dstMetricColumn")]
            [Validation(Required=false)]
            public string DstMetricColumn { get; set; }

            /// <summary>
            /// <para>The result value of the destination field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000.00</para>
            /// </summary>
            [NameInMap("dstResult")]
            [Validation(Required=false)]
            public string DstResult { get; set; }

            /// <summary>
            /// <para>The expected threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.00</para>
            /// </summary>
            [NameInMap("expectThreshold")]
            [Validation(Required=false)]
            public string ExpectThreshold { get; set; }

            /// <summary>
            /// <para>The validation result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: inconsistent.</description></item>
            /// <item><description>1: consistent.</description></item>
            /// <item><description>2: manually repaired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("isConsistent")]
            [Validation(Required=false)]
            public int? IsConsistent { get; set; }

            /// <summary>
            /// <para>The alias of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>src</para>
            /// </summary>
            [NameInMap("srcAlias")]
            [Validation(Required=false)]
            public string SrcAlias { get; set; }

            /// <summary>
            /// <para>The field name of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amount</para>
            /// </summary>
            [NameInMap("srcColumnName")]
            [Validation(Required=false)]
            public string SrcColumnName { get; set; }

            /// <summary>
            /// <para>The field type of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>decimal(38,18)</para>
            /// </summary>
            [NameInMap("srcColumnType")]
            [Validation(Required=false)]
            public string SrcColumnType { get; set; }

            /// <summary>
            /// <para>The metric key of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>src_sum_amount</para>
            /// </summary>
            [NameInMap("srcMetricColumn")]
            [Validation(Required=false)]
            public string SrcMetricColumn { get; set; }

            /// <summary>
            /// <para>The result value of the source field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000.00</para>
            /// </summary>
            [NameInMap("srcResult")]
            [Validation(Required=false)]
            public string SrcResult { get; set; }

            /// <summary>
            /// <para>The step ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("stepId")]
            [Validation(Required=false)]
            public long? StepId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>not supported.pos 3222, line 112, column 14, token IDENTIFIER settings</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The page number that indicates the requested page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>016D6CE5-51C6-5767-A8F9-D2818FC56509</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
