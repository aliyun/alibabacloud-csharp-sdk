// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstancesFullStatusRequest : TeaModel {
        [NameInMap("EventPublishTime")]
        [Validation(Required=false)]
        public DescribeInstancesFullStatusRequestEventPublishTime EventPublishTime { get; set; }
        public class DescribeInstancesFullStatusRequestEventPublishTime : TeaModel {
            /// <summary>
            /// <para>The end of the time range during which system events are published. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-07T00:00:00Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>The beginning of the time range during which system events are published. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-30T00:00:00Z</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public DescribeInstancesFullStatusRequestNotBefore NotBefore { get; set; }
        public class DescribeInstancesFullStatusRequestNotBefore : TeaModel {
            /// <summary>
            /// <para>The end of the time range during which O\&amp;M tasks related to scheduled system events are executed. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-30T00:00:00Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>The beginning of the time range during which O\&amp;M tasks related to scheduled system events are executed. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-07T00:00:00Z</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// <para>The IDs of the system events. You can specify up to 100 event IDs in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-bp1hygp5b04o56l0****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public List<string> EventId { get; set; }

        /// <summary>
        /// <para>The type of the system event. This parameter is valid only when InstanceEventType.N is not specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SystemMaintenance.Reboot: The instance is restarted due to system maintenance.</description></item>
        /// <item><description>SystemFailure.Reboot: The instance is restarted due to a system failure.</description></item>
        /// <item><description>InstanceFailure.Reboot: The instance is restarted due to an instance failure.</description></item>
        /// <item><description>InstanceExpiration.Stop: The subscription instance is stopped due to expiration.</description></item>
        /// <item><description>InstanceExpiration.Delete: The subscription instance is released due to expiration.</description></item>
        /// <item><description>AccountUnbalanced.Stop: The pay-as-you-go instance is stopped due to an overdue payment.</description></item>
        /// <item><description>AccountUnbalanced.Delete: The pay-as-you-go instance is released due to an overdue payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceExpiration.Stop</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The health status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OK</description></item>
        /// <item><description>Impaired</description></item>
        /// <item><description>Initializing</description></item>
        /// <item><description>InsufficientData</description></item>
        /// <item><description>NotApplicable</description></item>
        /// </list>
        /// <para>All the values are case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Maintaining</para>
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        /// <summary>
        /// <para>The types of system events. You can specify up to 30 event types in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceExpiration.Stop</para>
        /// </summary>
        [NameInMap("InstanceEventType")]
        [Validation(Required=false)]
        public List<string> InstanceEventType { get; set; }

        /// <summary>
        /// <para>The IDs of the instances. You can specify up to 100 instance IDs in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The lifecycle status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Starting</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Stopped</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
