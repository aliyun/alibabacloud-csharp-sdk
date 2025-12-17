// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeGlobalTimerRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the batch in which the scheduled task is executed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccg-****</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// <para>The cloud computer IDs.</para>
        /// </summary>
        [NameInMap("DesktopIds")]
        [Validation(Required=false)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled task group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccg-0cvfvf6u1enx1****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of the execution result. You can specify this parameter to filter the execution results.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FAILED: The execution is successful.</description></item>
        /// <item><description>FAILED: The execution failed.</description></item>
        /// <item><description>RUNNING: The execution is in progress.</description></item>
        /// <item><description>SKIPPED: The execution is skipped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEED</para>
        /// </summary>
        [NameInMap("ResultCategory")]
        [Validation(Required=false)]
        public string ResultCategory { get; set; }

        /// <summary>
        /// <para>The ID of the searched region. You can specify this parameter to filter cloud computers in specific regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("SearchRegionId")]
        [Validation(Required=false)]
        public string SearchRegionId { get; set; }

        /// <summary>
        /// <para>The execution result of the scheduled task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CONNECTED_NOT_RUN: The cloud computer is connected, but the scheduled task is not executed.</description></item>
        /// <item><description>PAUSED: The scheduled task is suspended.</description></item>
        /// <item><description>COMPLETED: The scheduled task is executed.</description></item>
        /// <item><description>FAILED: The scheduled task failed to be executed.</description></item>
        /// <item><description>RUNNING: The scheduled task is being executed.</description></item>
        /// <item><description>TERMINATED: The scheduled task is stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("TimerResult")]
        [Validation(Required=false)]
        public string TimerResult { get; set; }

        /// <summary>
        /// <para>The scheduled tasks.</para>
        /// </summary>
        [NameInMap("TimerTypes")]
        [Validation(Required=false)]
        public List<string> TimerTypes { get; set; }

    }

}
