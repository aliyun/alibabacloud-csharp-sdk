// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeEventsRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the event. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-01T04:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The event level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INFO</b>: Notification.</description></item>
        /// <item><description><b>WARN</b>: Warning.</description></item>
        /// <item><description><b>CRITICAL</b>: Critical.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WARN</para>
        /// </summary>
        [NameInMap("EventLevel")]
        [Validation(Required=false)]
        public string EventLevel { get; set; }

        /// <summary>
        /// <para>The event name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSnapshot: data protection</description></item>
        /// <item><description>BurstIOTriggered: burst I/O</description></item>
        /// <item><description>CostOptimizationNeeded: cost optimization</description></item>
        /// <item><description>DiskSpecNotMatchedWithInstance: instance and disk specification mismatch</description></item>
        /// <item><description>DiskIONo4kAligned: non-4K aligned read/write</description></item>
        /// <item><description>DiskIOHang: disk IOHang occurred</description></item>
        /// <item><description>InstanceIOPSExceedInstanceMaxLimit: instance IOPS reached the upper limit</description></item>
        /// <item><description>InstanceBPSExceedInstanceMaxLimit: instance BPS reached the upper limit</description></item>
        /// <item><description>DiskIOPSExceedInstanceMaxLimit: disk IOPS reached the instance upper limit</description></item>
        /// <item><description>DiskBPSExceedInstanceMaxLimit: disk BPS reached the instance upper limit</description></item>
        /// <item><description>DiskIOPSExceedDiskMaxLimit: disk IOPS reached the disk upper limit</description></item>
        /// <item><description>DiskBPSExceedDiskMaxLimit: disk BPS reached the disk upper limit</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DiskIOHang</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paged query. If you specify this parameter, the <c>MaxResults</c> and <c>NextToken</c> parameters are used together for the query.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the NextToken value returned in the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to query the list of regions supported by EBS Lens.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>disk: cloud disk</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>disk</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The start time of the event. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-01T03:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The event status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>WillExecute: pending </description></item>
        /// <item><description>Executing: processing</description></item>
        /// <item><description>Executed: processed</description></item>
        /// <item><description>Ignore: ignored</description></item>
        /// <item><description>Expired: expired</description></item>
        /// <item><description>Deleted: deleted</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WillExecute</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
