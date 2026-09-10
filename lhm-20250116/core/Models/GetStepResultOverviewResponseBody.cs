// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetStepResultOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetStepResultOverviewResponseBodyData Data { get; set; }
        public class GetStepResultOverviewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of validated fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("checkColumnCount")]
            [Validation(Required=false)]
            public long? CheckColumnCount { get; set; }

            /// <summary>
            /// <para>The metric name of the target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amount</para>
            /// </summary>
            [NameInMap("dstMetricName")]
            [Validation(Required=false)]
            public string DstMetricName { get; set; }

            /// <summary>
            /// <para>Indicates whether the source and target are consistent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Inconsistent.</description></item>
            /// <item><description>1: Consistent.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("isConsistent")]
            [Validation(Required=false)]
            public int? IsConsistent { get; set; }

            /// <summary>
            /// <para>The number of validated metrics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("metricColumnCount")]
            [Validation(Required=false)]
            public long? MetricColumnCount { get; set; }

            /// <summary>
            /// <para>The number of metrics that passed validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("metricPassColumnCount")]
            [Validation(Required=false)]
            public long? MetricPassColumnCount { get; set; }

            /// <summary>
            /// <para>The number of fields that passed validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("passColumnCount")]
            [Validation(Required=false)]
            public long? PassColumnCount { get; set; }

            /// <summary>
            /// <para>The unique ID of the validation result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30001</para>
            /// </summary>
            [NameInMap("resultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <para>The partition name of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=20260116</para>
            /// </summary>
            [NameInMap("sourcePtName")]
            [Validation(Required=false)]
            public string SourcePtName { get; set; }

            /// <summary>
            /// <para>The table name of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_demo</para>
            /// </summary>
            [NameInMap("sourceTable")]
            [Validation(Required=false)]
            public string SourceTable { get; set; }

            /// <summary>
            /// <para>The metric name of the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amount</para>
            /// </summary>
            [NameInMap("srcMetricName")]
            [Validation(Required=false)]
            public string SrcMetricName { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Created.</description></item>
            /// <item><description>1: Running.</description></item>
            /// <item><description>2: Completed.</description></item>
            /// <item><description>3: Stopped.</description></item>
            /// <item><description>4: Canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The partition name of the target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=20260116</para>
            /// </summary>
            [NameInMap("targetPtName")]
            [Validation(Required=false)]
            public string TargetPtName { get; set; }

            /// <summary>
            /// <para>The table name of the target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_demo</para>
            /// </summary>
            [NameInMap("targetTable")]
            [Validation(Required=false)]
            public string TargetTable { get; set; }

        }

        /// <summary>
        /// <para>The fault message code.</para>
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
        /// <para>not supported.pos 10960, line 327, column 26, token IDENTIFIER settings</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512AF06E-3B95-5932-81D8-717B15143359</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed. Check errCode and errMessage for troubleshooting.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
