// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
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
        /// <para>The events.</para>
        /// </summary>
        [NameInMap("ResourceEvents")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyResourceEvents> ResourceEvents { get; set; }
        public class DescribeEventsResponseBodyResourceEvents : TeaModel {
            /// <summary>
            /// <para>The description of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>need snapshot</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The end time of the event, expressed as the number of milliseconds after Jan 1, 1970 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1679538083000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The level of the event. Valid values:</para>
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
            /// <para>The name of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoSnapshot: indicates the event that is triggered because no snapshot is created for a disk to protect data on the disk.</description></item>
            /// <item><description>BurstIOTriggered: indicates the event that is triggered when a burst I/O operation is performed on a disk.</description></item>
            /// <item><description>CostOptimizationNeeded: indicates the event that is triggered when cost optimization is required.</description></item>
            /// <item><description>DiskSpecNotMatchedWithInstance: indicates the event that is triggered because the specifications of a disk do not match the instance to which the disk is attached.</description></item>
            /// <item><description>DiskIONo4kAligned: indicates the event that is triggered because the physical and logical sectors involved in a read or write operation are not 4K aligned.</description></item>
            /// <item><description>DiskIOHang: indicates the event that is triggered when an I/O hang occurs on a disk.</description></item>
            /// <item><description>InstanceIOPSExceedInstanceMaxLimit: indicates the event that is triggered when the number of IOPS on an instance reaches the upper limit.</description></item>
            /// <item><description>InstanceBPSExceedInstanceMaxLimit: indicates the event that is triggered when the number of BPS on an instance reaches the upper limit.</description></item>
            /// <item><description>DiskIOPSExceedInstanceMaxLimit: indicates the event that is triggered when the number of IOPS on a disk reaches the upper limit for the associated instance.</description></item>
            /// <item><description>DiskBPSExceedInstanceMaxLimit: indicates the event that is triggered when the number of BPS on a disk reaches the upper limit for the associated instance.</description></item>
            /// <item><description>DiskIOPSExceedDiskMaxLimit: indicates the event that is triggered when the number of IOPS on a disk reaches the upper limit for the disk.</description></item>
            /// <item><description>DiskBPSExceedDiskMaxLimit: indicates the event that is triggered when the number of BPS on a disk reaches the upper limit for the disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DiskIOHang</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The type of the event. Valid values:</para>
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
            /// <para>The recommended action after the event occurred. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ModifyDiskSpec</description></item>
            /// <item><description>CreateSnapshot</description></item>
            /// <item><description>ResizeDisk</description></item>
            /// <item><description>AdjustProvision</description></item>
            /// <item><description>ModifyInstanceSpec</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AdjustProvision</para>
            /// </summary>
            [NameInMap("RecommendAction")]
            [Validation(Required=false)]
            public string RecommendAction { get; set; }

            /// <summary>
            /// <para>The codes of the parameters for the recommended action after the event occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4296</para>
            /// </summary>
            [NameInMap("RecommendParams")]
            [Validation(Required=false)]
            public string RecommendParams { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The type of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disk</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The start time of the event, expressed as the number of milliseconds after Jan 1, 1970 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684204822000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the event. Valid values:</para>
            /// <ol>
            /// <item><description>WillExecute</description></item>
            /// <item><description>Executing</description></item>
            /// <item><description>Executed</description></item>
            /// <item><description>Ignore</description></item>
            /// <item><description>Expired</description></item>
            /// <item><description>Deleted</description></item>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
