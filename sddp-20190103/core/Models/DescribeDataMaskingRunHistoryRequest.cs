// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataMaskingRunHistoryRequest : TeaModel {
        /// <summary>
        /// <para>The page number to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
        /// <para>The end time to query for task executions. This is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1583856000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the main task.</para>
        /// <remarks>
        /// <para>If a task has subtasks, this parameter specifies the ID of the main task. Otherwise, this parameter is empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>366731</para>
        /// </summary>
        [NameInMap("MainProcessId")]
        [Validation(Required=false)]
        public long? MainProcessId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The start time to query for task executions. This is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1582992000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The execution status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>-1</b>: pending.</para>
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
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The ID of the data masking task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mt4HBgtw1B******</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
