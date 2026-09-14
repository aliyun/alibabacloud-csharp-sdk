// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The token for the next query. If NextToken is empty, no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of events.</para>
        /// </summary>
        [NameInMap("ResourceEvents")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyResourceEvents> ResourceEvents { get; set; }
        public class DescribeEventsResponseBodyResourceEvents : TeaModel {
            /// <summary>
            /// <para>The event description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>You can purchase 4296 provisioned IOPS for cost optimization. Based on your usage over the past 7 days, costs are estimated to decrease by 16%</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The end time of the event. This value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1679538083000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The event level. Valid values:</para>
            /// <ol>
            /// <item><description>INFO</description></item>
            /// <item><description>WARN</description></item>
            /// <item><description>CRITICAL</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>INFO</para>
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
            /// <para>The event type. Valid values:</para>
            /// <ol>
            /// <item><description>Notification</description></item>
            /// <item><description>SystemException</description></item>
            /// <item><description>Alert</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>Alert</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The additional properties. Possible fields:</para>
            /// <list type="bullet">
            /// <item><description>EcsInstanceId: the ID of the ECS instance to which the cloud disk is attached.</description></item>
            /// <item><description>Adapter: the mount point of the cloud disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;EcsInstanceId\&quot;:\&quot;i-uf6dkn9qpcw6y94g7ag7\&quot;,\&quot;Adapter\&quot;:\&quot;hda\&quot;}</para>
            /// </summary>
            [NameInMap("ExtraAttributes")]
            [Validation(Required=false)]
            public string ExtraAttributes { get; set; }

            /// <summary>
            /// <para>The recommended action after the event occurs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ModifyDiskSpec: change disk specifications</description></item>
            /// <item><description>CreateSnapshot: create a snapshot</description></item>
            /// <item><description>ResizeDisk: expand disk capacity</description></item>
            /// <item><description>AdjustProvision: adjust provisioned performance</description></item>
            /// <item><description>ModifyInstanceSpec: change instance specifications</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AdjustProvision</para>
            /// </summary>
            [NameInMap("RecommendAction")]
            [Validation(Required=false)]
            public string RecommendAction { get; set; }

            /// <summary>
            /// <para>The parameters for the recommended action after the event occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4296</para>
            /// </summary>
            [NameInMap("RecommendParams")]
            [Validation(Required=false)]
            public string RecommendParams { get; set; }

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
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disk</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The start time of the event. This value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684204822000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The event status. Valid values:</para>
            /// <ol>
            /// <item><description>WillExecute: pending</description></item>
            /// <item><description>Executing: processing</description></item>
            /// <item><description>Executed: processed</description></item>
            /// <item><description>Ignore: ignored</description></item>
            /// <item><description>Expired: expired</description></item>
            /// <item><description>Deleted: deleted</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>WillExecute</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned for the paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
