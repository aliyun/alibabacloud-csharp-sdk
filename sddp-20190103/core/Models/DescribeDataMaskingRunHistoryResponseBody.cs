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
        /// <para>A list of data masking task details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataMaskingRunHistoryResponseBodyItems> Items { get; set; }
        public class DescribeDataMaskingRunHistoryResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The number of data conflicts. This is the number of rows to be inserted into the destination table that conflict with existing data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ConflictCount")]
            [Validation(Required=false)]
            public long? ConflictCount { get; set; }

            /// <summary>
            /// <para>The type of service to which the masked data is destined. Valid values: <b>1</b> for MaxCompute, <b>2</b> for OSS, <b>3</b> for ADS, <b>4</b> for OTS, and <b>5</b> for RDS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DstType")]
            [Validation(Required=false)]
            public int? DstType { get; set; }

            /// <summary>
            /// <para>The type of the destination service. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("DstTypeCode")]
            [Validation(Required=false)]
            public string DstTypeCode { get; set; }

            /// <summary>
            /// <para>The time when the execution ended. This is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582251233000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The error code returned when the task fails. This parameter has a value only if the task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>masking_task_not_found</para>
            /// </summary>
            [NameInMap("FailCode")]
            [Validation(Required=false)]
            public string FailCode { get; set; }

            /// <summary>
            /// <para>The reason the task failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error</para>
            /// </summary>
            [NameInMap("FailMsg")]
            [Validation(Required=false)]
            public string FailMsg { get; set; }

            /// <summary>
            /// <para>Indicates whether a download file is available.</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Yes.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: No.</para>
            /// </description></item>
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
            /// <para>The ID of the execution record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The number of masked rows.</para>
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
            /// <para>The number of times the task has been executed.</para>
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
            /// <para>The type of service to which the source data belongs. Valid values: <b>1</b> for MaxCompute, <b>2</b> for OSS, <b>3</b> for ADS, <b>4</b> for OTS, and <b>5</b> for RDS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public int? SrcType { get; set; }

            /// <summary>
            /// <para>The type of the source service. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("SrcTypeCode")]
            [Validation(Required=false)]
            public string SrcTypeCode { get; set; }

            /// <summary>
            /// <para>The time when the execution started. This is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582251233000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The execution status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>-<b>1</b>: pending.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: running.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: successful.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: failed.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: stopped by user.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: partially failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mt4HBgtw1B******</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The execution method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: manual.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: scheduled.</para>
            /// </description></item>
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
