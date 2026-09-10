// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetDataCheckConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The data list returned by the operation. For the structure of each element, see the child field descriptions.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetDataCheckConfigResponseBodyData> Data { get; set; }
        public class GetDataCheckConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The check algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("algorithm")]
            [Validation(Required=false)]
            public int? Algorithm { get; set; }

            /// <summary>
            /// <para>The batch size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("batchSize")]
            [Validation(Required=false)]
            public int? BatchSize { get; set; }

            /// <summary>
            /// <para>The check type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("checkType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>The comparison type. Valid values: =, !=, &gt;, &lt;, &gt;=, &lt;=, contains, does not contain, and ==.</para>
            /// 
            /// <b>Example:</b>
            /// <para>=</para>
            /// </summary>
            [NameInMap("comparator")]
            [Validation(Required=false)]
            public string Comparator { get; set; }

            /// <summary>
            /// <para>The reserved field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The group data volume comparison threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("groupCountThreshold")]
            [Validation(Required=false)]
            public float? GroupCountThreshold { get; set; }

            /// <summary>
            /// <para>The primary key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether a full table count is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("isFullTableCount")]
            [Validation(Required=false)]
            public int? IsFullTableCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the check is skipped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("isSkipped")]
            [Validation(Required=false)]
            public int? IsSkipped { get; set; }

            /// <summary>
            /// <para>The metric type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CUSTOM_METRIC_NUM: built-in NUM mode.</description></item>
            /// <item><description>CUSTOM_METRIC_LEN: built-in LEN mode.</description></item>
            /// <item><description>CUSTOM_METRIC_MIX: built-in MIX mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM_METRIC_MIX</para>
            /// </summary>
            [NameInMap("metricType")]
            [Validation(Required=false)]
            public string MetricType { get; set; }

            /// <summary>
            /// <para>Indicates whether all columns are checked on the source side. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No.</description></item>
            /// <item><description>1: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sourceCheckAllColumn")]
            [Validation(Required=false)]
            public int? SourceCheckAllColumn { get; set; }

            /// <summary>
            /// <para>The source table columns. You can specify multiple columns separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("sourceColumns")]
            [Validation(Required=false)]
            public string SourceColumns { get; set; }

            /// <summary>
            /// <para>The source comparison key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("sourceCompareKey")]
            [Validation(Required=false)]
            public string SourceCompareKey { get; set; }

            /// <summary>
            /// <para>The name of the source datasource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_demo</para>
            /// </summary>
            [NameInMap("sourceDataSource")]
            [Validation(Required=false)]
            public string SourceDataSource { get; set; }

            /// <summary>
            /// <para>The GROUP BY clause for the source table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("sourceGroupClause")]
            [Validation(Required=false)]
            public string SourceGroupClause { get; set; }

            /// <summary>
            /// <para>The hint for the source side.</para>
            /// </summary>
            [NameInMap("sourceHint")]
            [Validation(Required=false)]
            public string SourceHint { get; set; }

            /// <summary>
            /// <para>The ID of the source datasource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <para>The source partition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=20260116</para>
            /// </summary>
            [NameInMap("sourcePartition")]
            [Validation(Required=false)]
            public string SourcePartition { get; set; }

            /// <summary>
            /// <para>The SQL statement for the source side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM t;</para>
            /// </summary>
            [NameInMap("sourceSql")]
            [Validation(Required=false)]
            public string SourceSql { get; set; }

            /// <summary>
            /// <para>The source table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_demo</para>
            /// </summary>
            [NameInMap("sourceTable")]
            [Validation(Required=false)]
            public string SourceTable { get; set; }

            /// <summary>
            /// <para>The type of the source datasource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hive</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The WHERE clause for the source table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a &gt; 0 and col_b = \&quot;x\&quot;</para>
            /// </summary>
            [NameInMap("sourceWhereClause")]
            [Validation(Required=false)]
            public string SourceWhereClause { get; set; }

            /// <summary>
            /// <para>Indicates whether all columns are checked on the target side. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No.</description></item>
            /// <item><description>1: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("targetCheckAllColumn")]
            [Validation(Required=false)]
            public int? TargetCheckAllColumn { get; set; }

            /// <summary>
            /// <para>The target table columns. You can specify multiple columns separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("targetColumns")]
            [Validation(Required=false)]
            public string TargetColumns { get; set; }

            /// <summary>
            /// <para>The target comparison key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("targetCompareKey")]
            [Validation(Required=false)]
            public string TargetCompareKey { get; set; }

            /// <summary>
            /// <para>The target datasource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_demo</para>
            /// </summary>
            [NameInMap("targetDataSource")]
            [Validation(Required=false)]
            public string TargetDataSource { get; set; }

            /// <summary>
            /// <para>The GROUP BY clause for the target table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a,col_b</para>
            /// </summary>
            [NameInMap("targetGroupClause")]
            [Validation(Required=false)]
            public string TargetGroupClause { get; set; }

            /// <summary>
            /// <para>The hint for the target side.</para>
            /// </summary>
            [NameInMap("targetHint")]
            [Validation(Required=false)]
            public string TargetHint { get; set; }

            /// <summary>
            /// <para>The ID of the target datasource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2001</para>
            /// </summary>
            [NameInMap("targetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The target partition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=20260116</para>
            /// </summary>
            [NameInMap("targetPartition")]
            [Validation(Required=false)]
            public string TargetPartition { get; set; }

            /// <summary>
            /// <para>The SQL statement for the target side.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM t;</para>
            /// </summary>
            [NameInMap("targetSql")]
            [Validation(Required=false)]
            public string TargetSql { get; set; }

            /// <summary>
            /// <para>The target table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_demo</para>
            /// </summary>
            [NameInMap("targetTable")]
            [Validation(Required=false)]
            public string TargetTable { get; set; }

            /// <summary>
            /// <para>The type of the target datasource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hive</para>
            /// </summary>
            [NameInMap("targetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The WHERE clause for the target table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>col_a &gt; 0 and col_b = \&quot;x\&quot;</para>
            /// </summary>
            [NameInMap("targetWhereClause")]
            [Validation(Required=false)]
            public string TargetWhereClause { get; set; }

            /// <summary>
            /// <para>The configuration details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lhm|lhm_dw|*</para>
            /// </summary>
            [NameInMap("taskConfigInfo")]
            [Validation(Required=false)]
            public string TaskConfigInfo { get; set; }

            /// <summary>
            /// <para>The batch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The total data volume comparison threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("totalCountThreshold")]
            [Validation(Required=false)]
            public float? TotalCountThreshold { get; set; }

        }

        /// <summary>
        /// <para>The error code. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success. A value of false indicates failure. If the call fails, check the values of errCode and errMessage for troubleshooting.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
