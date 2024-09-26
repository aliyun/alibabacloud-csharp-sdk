// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsServiceLogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data migration or synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1yr56py103****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. You can call the <a href="https://help.aliyun.com/document_detail/209718.html">DescribePreCheckStatus</a> operation to query the execution time of the subtasks.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>To obtain the logs that are generated for DTS subtasks within a specific period of time, you can call the <a href="https://help.aliyun.com/document_detail/209718.html">DescribePreCheckStatus</a> operation to query the execution time of the subtasks.</description></item>
        /// <item><description>Specify the time in the 13-digit UNIX timestamp format. Unit: milliseconds. You can use a search engine to obtain a UNIX timestamp converter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1620897227000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The keyword that is passed to specify the query content.</para>
        /// <remarks>
        /// <para> Fuzzy match is used and the keyword is case-sensitive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>state = IDLE</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The value must be an integer that is greater than 0 and less than or equal to the maximum value supported by the integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of log entries to return on each page. Valid values: <b>20</b>, <b>50</b>, <b>100</b>, <b>500</b>, and <b>1000</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>To obtain the logs that are generated for Data Transmission Service (DTS) subtasks within a specific period of time, you can call the <a href="https://help.aliyun.com/document_detail/209718.html">DescribePreCheckStatus</a> operation to query the execution time of the subtasks.</description></item>
        /// <item><description>Specify the time in the 13-digit UNIX timestamp format. Unit: milliseconds. You can use a search engine to obtain a UNIX timestamp converter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1620896327000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The log level. Separate multiple log levels with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: displays the logs that are generated when the DTS task runs as expected.</description></item>
        /// <item><description><b>WARN</b>: displays the logs about severe issues that stop the DTS task from running.</description></item>
        /// <item><description><b>ERROR</b>: displays the logs about unexpected issues that stop specific processes form running.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL,WARN,ERROR</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of a DTS subtask. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DATA_LOAD</b>: full migration or full synchronization</description></item>
        /// <item><description><b>ONLINE_WRITER</b>: incremental migration</description></item>
        /// <item><description><b>SYNC_WRITER</b>: incremental synchronization</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC_WRITER</para>
        /// </summary>
        [NameInMap("SubJobType")]
        [Validation(Required=false)]
        public string SubJobType { get; set; }

        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
