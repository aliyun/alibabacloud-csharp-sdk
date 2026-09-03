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
        /// <para>The list of cloud computer IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEED</para>
        /// </summary>
        [NameInMap("DesktopIds")]
        [Validation(Required=false)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// <para>The display result name.</para>
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
        /// <para>The number of entries per page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by Wuying Workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of resource types. If empty, all resource types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<string> ResourceTypes { get; set; }

        /// <summary>
        /// <para>Filters results by execution result.</para>
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
        /// <para>The region ID used to filter cloud computer information for a specified region.</para>
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
        /// <para>The list of scheduled tasks.</para>
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
