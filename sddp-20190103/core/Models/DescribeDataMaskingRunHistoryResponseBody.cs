// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataMaskingRunHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The execution information about the de-identification task.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataMaskingRunHistoryResponseBodyItems> Items { get; set; }
        public class DescribeDataMaskingRunHistoryResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The number of rows that are in conflict with the data to be de-identified in the destination table to which the data to be de-identified is moved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ConflictCount")]
            [Validation(Required=false)]
            public long? ConflictCount { get; set; }

            /// <summary>
            /// <para>The type of the service to which the de-identified data belongs. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>4</b>, and <b>5</b>. The value 1 indicates MaxCompute. The value 2 indicates OSS. The value indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DstType")]
            [Validation(Required=false)]
            public int? DstType { get; set; }

            /// <summary>
            /// <para>The service that stores the de-identified data. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("DstTypeCode")]
            [Validation(Required=false)]
            public string DstTypeCode { get; set; }

            /// <summary>
            /// <para>The end time of the de-identification task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582251233000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The error code that is returned when the de-identification task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>masking_task_not_found</para>
            /// </summary>
            [NameInMap("FailCode")]
            [Validation(Required=false)]
            public string FailCode { get; set; }

            /// <summary>
            /// <para>The reason why the de-identification task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error</para>
            /// </summary>
            [NameInMap("FailMsg")]
            [Validation(Required=false)]
            public string FailMsg { get; set; }

            /// <summary>
            /// <para>Indicates whether a file is available for download.</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HasDownloadFile")]
            [Validation(Required=false)]
            public int? HasDownloadFile { get; set; }

            /// <summary>
            /// <para>The number of created subtasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("HasSubProcess")]
            [Validation(Required=false)]
            public int? HasSubProcess { get; set; }

            /// <summary>
            /// <para>The ID of the task execution record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The number of rows that are de-identified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaskingCount")]
            [Validation(Required=false)]
            public long? MaskingCount { get; set; }

            /// <summary>
            /// <para>The progress of the de-identification task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public int? Percentage { get; set; }

            /// <summary>
            /// <para>The number of times that the de-identification task is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunIndex")]
            [Validation(Required=false)]
            public int? RunIndex { get; set; }

            /// <summary>
            /// <para>The name of the source table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("SrcTableName")]
            [Validation(Required=false)]
            public string SrcTableName { get; set; }

            /// <summary>
            /// <para>The type of the service to which the data to be de-identified belongs. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>4</b>, and <b>5</b>. The value 1 indicates MaxCompute. The value 2 indicates OSS. The value indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public int? SrcType { get; set; }

            /// <summary>
            /// <para>The service to which the data to be de-identified belongs. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("SrcTypeCode")]
            [Validation(Required=false)]
            public string SrcTypeCode { get; set; }

            /// <summary>
            /// <para>The time when the de-identification task was executed. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582251233000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the de-identification task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>-1</b>: waiting</description></item>
            /// <item><description><b>0</b>: being executed</description></item>
            /// <item><description><b>1</b>: executed</description></item>
            /// <item><description><b>2</b>: failed to be executed</description></item>
            /// <item><description><b>3</b>: terminated</description></item>
            /// <item><description><b>4</b>: partially failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The ID of the identification task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mt4HBgtw1B******</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The mode in which the de-identification task is executed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: manual</description></item>
            /// <item><description><b>2</b>: scheduled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-4******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
