// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataMaskingRunHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of data masking task information.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataMaskingRunHistoryResponseBodyItems> Items { get; set; }
        public class DescribeDataMaskingRunHistoryResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The number of data conflict rows, which indicates the number of rows where the masked data to be inserted into the destination table conflicts with the existing data in the destination table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ConflictCount")]
            [Validation(Required=false)]
            public long? ConflictCount { get; set; }

            /// <summary>
            /// <para>The type of the destination product where the masked data is stored. Valid values: <b>1</b>: MaxCompute, <b>2</b>: OSS, <b>3</b>: ADS, <b>4</b>: OTS, <b>5</b>: RDS, and others.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DstType")]
            [Validation(Required=false)]
            public int? DstType { get; set; }

            /// <summary>
            /// <para>The type of the destination product. Valid values: <b>MaxCompute, OSS, ADS, OTS, RDS</b>, and others.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("DstTypeCode")]
            [Validation(Required=false)]
            public string DstTypeCode { get; set; }

            /// <summary>
            /// <para>The end time of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582251233000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The error code for the task execution failure. This parameter has a value only when the task execution fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>masking_task_not_found</para>
            /// </summary>
            [NameInMap("FailCode")]
            [Validation(Required=false)]
            public string FailCode { get; set; }

            /// <summary>
            /// <para>The reason for the task execution failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error</para>
            /// </summary>
            [NameInMap("FailMsg")]
            [Validation(Required=false)]
            public string FailMsg { get; set; }

            /// <summary>
            /// <para>Indicates whether a download file exists. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Yes.</description></item>
            /// <item><description><b>0</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HasDownloadFile")]
            [Validation(Required=false)]
            public int? HasDownloadFile { get; set; }

            /// <summary>
            /// <para>The number of subtasks that have been created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("HasSubProcess")]
            [Validation(Required=false)]
            public int? HasSubProcess { get; set; }

            /// <summary>
            /// <para>The ID of the execution record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The number of rows masked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaskingCount")]
            [Validation(Required=false)]
            public long? MaskingCount { get; set; }

            /// <summary>
            /// <para>The execution progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public int? Percentage { get; set; }

            /// <summary>
            /// <para>The sequence number of the task execution.</para>
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
            /// <para>The type of the source product to which the data to be masked belongs. Valid values: <b>1</b>: MaxCompute, <b>2</b>: OSS, <b>3</b>: ADS, <b>4</b>: OTS, <b>5</b>: RDS, and others.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public int? SrcType { get; set; }

            /// <summary>
            /// <para>The type of the source product. Valid values: <b>MaxCompute, OSS, ADS, OTS, RDS</b>, and others.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("SrcTypeCode")]
            [Validation(Required=false)]
            public string SrcTypeCode { get; set; }

            /// <summary>
            /// <para>The execution time. The value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582251233000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The task execution status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>-1</b>: Waiting for execution.</description></item>
            /// <item><description><b>0</b>: Running.</description></item>
            /// <item><description><b>1</b>: Executed successfully.</description></item>
            /// <item><description><b>2</b>: Execution failed.</description></item>
            /// <item><description><b>3</b>: Terminated by user.</description></item>
            /// <item><description><b>4</b>: Partially failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mt4HBgtw1B******</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The execution mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Manual.</description></item>
            /// <item><description><b>2</b>: Scheduled.</description></item>
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
        /// <para>The number of entries per page in the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-4******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
