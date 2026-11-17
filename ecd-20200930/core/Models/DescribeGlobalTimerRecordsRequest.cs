// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeGlobalTimerRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The batch ID of the scheduled task execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccg-****</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// <para>The list of cloud desktop IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEED</para>
        /// </summary>
        [NameInMap("DesktopIds")]
        [Validation(Required=false)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// <para>The display name of the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAILED</para>
        /// </summary>
        [NameInMap("DisplayResultName")]
        [Validation(Required=false)]
        public string DisplayResultName { get; set; }

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
        /// <para>The maximum number of entries per page in a paging query.</para>
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
        /// <para>The token that is used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions supported by Elastic Desktop Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of resource types. If this parameter is left empty, all resource types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<string> ResourceTypes { get; set; }

        /// <summary>
        /// <para>Filters the results by execution result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEED</para>
        /// </summary>
        [NameInMap("ResultCategory")]
        [Validation(Required=false)]
        public string ResultCategory { get; set; }

        /// <summary>
        /// <para>Specifies whether the task can be retried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Retryable")]
        [Validation(Required=false)]
        public bool? Retryable { get; set; }

        /// <summary>
        /// <para>The search region ID. This parameter is used to filter cloud desktop information in a specified region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("SearchRegionId")]
        [Validation(Required=false)]
        public string SearchRegionId { get; set; }

        /// <summary>
        /// <para>The execution result of the scheduled task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("TimerResult")]
        [Validation(Required=false)]
        public string TimerResult { get; set; }

        /// <summary>
        /// <para>The list of scheduled task types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("TimerTypes")]
        [Validation(Required=false)]
        public List<string> TimerTypes { get; set; }

        /// <summary>
        /// <para>The list of Wuying server IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAILED</para>
        /// </summary>
        [NameInMap("WuyingServerIds")]
        [Validation(Required=false)]
        public List<string> WuyingServerIds { get; set; }

    }

}
