// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListDataCheckReportStepByJobIdResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListDataCheckReportStepByJobIdResponseBodyData> Data { get; set; }
        public class ListDataCheckReportStepByJobIdResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>R[1-&gt;1000)</para>
            /// </summary>
            [NameInMap("boundary")]
            [Validation(Required=false)]
            public string Boundary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("checkColumCount")]
            [Validation(Required=false)]
            public long? CheckColumCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("dstCount")]
            [Validation(Required=false)]
            public string DstCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SELECT * FROM dst_table;</para>
            /// </summary>
            [NameInMap("dstSql")]
            [Validation(Required=false)]
            public string DstSql { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("errMessage")]
            [Validation(Required=false)]
            public string ErrMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-01-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("gmtEnd")]
            [Validation(Required=false)]
            public string GmtEnd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-01-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("gmtStart")]
            [Validation(Required=false)]
            public string GmtStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isConsistent")]
            [Validation(Required=false)]
            public int? IsConsistent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("metricColumCount")]
            [Validation(Required=false)]
            public long? MetricColumCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("metricPassColumCount")]
            [Validation(Required=false)]
            public long? MetricPassColumCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("passColumCount")]
            [Validation(Required=false)]
            public long? PassColumCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30001</para>
            /// </summary>
            [NameInMap("resultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds=20260116</para>
            /// </summary>
            [NameInMap("sourcePtName")]
            [Validation(Required=false)]
            public string SourcePtName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("srcCount")]
            [Validation(Required=false)]
            public string SrcCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SELECT * FROM src_table;</para>
            /// </summary>
            [NameInMap("srcSql")]
            [Validation(Required=false)]
            public string SrcSql { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("stepId")]
            [Validation(Required=false)]
            public string StepId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds=20260116</para>
            /// </summary>
            [NameInMap("targetPtName")]
            [Validation(Required=false)]
            public string TargetPtName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
