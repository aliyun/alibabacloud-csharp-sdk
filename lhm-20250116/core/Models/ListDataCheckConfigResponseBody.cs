// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListDataCheckConfigResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListDataCheckConfigResponseBodyData> Data { get; set; }
        public class ListDataCheckConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("algorithm")]
            [Validation(Required=false)]
            public int? Algorithm { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("batchSize")]
            [Validation(Required=false)]
            public int? BatchSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("checkType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>=</para>
            /// </summary>
            [NameInMap("comparator")]
            [Validation(Required=false)]
            public string Comparator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("groupCountThreshold")]
            [Validation(Required=false)]
            public float? GroupCountThreshold { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isFullTableCount")]
            [Validation(Required=false)]
            public int? IsFullTableCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("isSkipped")]
            [Validation(Required=false)]
            public int? IsSkipped { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CUSTOM_METRIC_MIX</para>
            /// </summary>
            [NameInMap("metricType")]
            [Validation(Required=false)]
            public string MetricType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sourceCheckAllColumn")]
            [Validation(Required=false)]
            public int? SourceCheckAllColumn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("sourceColumns")]
            [Validation(Required=false)]
            public string SourceColumns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("sourceCompareKey")]
            [Validation(Required=false)]
            public string SourceCompareKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds_demo</para>
            /// </summary>
            [NameInMap("sourceDataSource")]
            [Validation(Required=false)]
            public string SourceDataSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("sourceGroupClause")]
            [Validation(Required=false)]
            public string SourceGroupClause { get; set; }

            [NameInMap("sourceHint")]
            [Validation(Required=false)]
            public string SourceHint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds=20260116</para>
            /// </summary>
            [NameInMap("sourcePartition")]
            [Validation(Required=false)]
            public string SourcePartition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SELECT * FROM t;</para>
            /// </summary>
            [NameInMap("sourceSql")]
            [Validation(Required=false)]
            public string SourceSql { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>table_demo</para>
            /// </summary>
            [NameInMap("sourceTable")]
            [Validation(Required=false)]
            public string SourceTable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Hive</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>col_a &gt; 0 and col_b = \&quot;x\&quot;</para>
            /// </summary>
            [NameInMap("sourceWhereClause")]
            [Validation(Required=false)]
            public string SourceWhereClause { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("targetCheckAllColumn")]
            [Validation(Required=false)]
            public int? TargetCheckAllColumn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("targetColumns")]
            [Validation(Required=false)]
            public string TargetColumns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("targetCompareKey")]
            [Validation(Required=false)]
            public string TargetCompareKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds_demo</para>
            /// </summary>
            [NameInMap("targetDataSource")]
            [Validation(Required=false)]
            public string TargetDataSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("targetGroupClause")]
            [Validation(Required=false)]
            public string TargetGroupClause { get; set; }

            [NameInMap("targetHint")]
            [Validation(Required=false)]
            public string TargetHint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2001</para>
            /// </summary>
            [NameInMap("targetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds=20260116</para>
            /// </summary>
            [NameInMap("targetPartition")]
            [Validation(Required=false)]
            public string TargetPartition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SELECT * FROM t;</para>
            /// </summary>
            [NameInMap("targetSql")]
            [Validation(Required=false)]
            public string TargetSql { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>table_demo</para>
            /// </summary>
            [NameInMap("targetTable")]
            [Validation(Required=false)]
            public string TargetTable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hive</para>
            /// </summary>
            [NameInMap("targetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>col_a &gt; 0 and col_b = \&quot;x\&quot;</para>
            /// </summary>
            [NameInMap("targetWhereClause")]
            [Validation(Required=false)]
            public string TargetWhereClause { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lhm|lhm_dw|*</para>
            /// </summary>
            [NameInMap("taskConfigInfo")]
            [Validation(Required=false)]
            public string TaskConfigInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("totalCountThreshold")]
            [Validation(Required=false)]
            public float? TotalCountThreshold { get; set; }

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
