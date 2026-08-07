// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataMaskingRunHistoryRequest : TeaModel {
        /// <summary>
        /// <para>The page number for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
        /// <para>The end time of the task execution to query. The value is a timestamp in milliseconds.</para>
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
        /// <item><description><b>zh_cn</b>: Chinese.</description></item>
        /// <item><description><b>en_us</b>: English.</description></item>
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
        /// <para>If the task contains subtasks, this parameter is set to the current task ID. Otherwise, this parameter is empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>366731</para>
        /// </summary>
        [NameInMap("MainProcessId")]
        [Validation(Required=false)]
        public long? MainProcessId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
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
        /// <para>The type of the source product to which the data to be masked belongs. Valid values: <b>1</b>: MaxCompute, <b>2</b>: OSS, <b>3</b>: ADS, <b>4</b>: OTS, <b>5</b>: RDS, and others.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SrcType")]
        [Validation(Required=false)]
        public int? SrcType { get; set; }

        /// <summary>
        /// <para>The start time of the task execution to query. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1582992000000</para>
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
