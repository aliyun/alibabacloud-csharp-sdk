// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceHistoryEventsRequest : TeaModel {
        [NameInMap("EventPublishTime")]
        [Validation(Required=false)]
        public DescribeInstanceHistoryEventsRequestEventPublishTime EventPublishTime { get; set; }
        public class DescribeInstanceHistoryEventsRequestEventPublishTime : TeaModel {
            /// <summary>
            /// <para>The end time of the publication time of the system event. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
            /// <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-01T06:32:31Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>The start time of the publication time of the system event. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
            /// <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-30T06:32:31Z</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public DescribeInstanceHistoryEventsRequestNotBefore NotBefore { get; set; }
        public class DescribeInstanceHistoryEventsRequestNotBefore : TeaModel {
            /// <summary>
            /// <para>The end time of the scheduled execution time of the system event. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
            /// <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-01T06:32:31Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>The start time of the scheduled execution time of the system event. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
            /// <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-30T06:32:31Z</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// <para>The lifecycle status of the system event. The EventCycleStatus parameter is valid only when the InstanceEventCycleStatus.N parameter is not specified. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Scheduled: The event is waiting to be executed.</description></item>
        /// <item><description>Avoided: The event is avoided.</description></item>
        /// <item><description>Executing: The event is being executed.</description></item>
        /// <item><description>Executed: The event execution is completed.</description></item>
        /// <item><description>Canceled: The event is canceled.</description></item>
        /// <item><description>Failed: The event execution failed.</description></item>
        /// <item><description>Inquiring: The event is in the inquiring state.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Executed</para>
        /// </summary>
        [NameInMap("EventCycleStatus")]
        [Validation(Required=false)]
        public string EventCycleStatus { get; set; }

        /// <summary>
        /// <para>The IDs of one or more system events. Valid values of N: 1 to 100. Specify multiple values in a repeated list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-uf64yvznlao4jl2c****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public List<string> EventId { get; set; }

        /// <summary>
        /// <para>The type of the system event. The EventType parameter is valid only when the InstanceEventType.N parameter is not specified. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>SystemMaintenance.Reboot: The instance is restarted due to system maintenance.</description></item>
        /// <item><description>SystemMaintenance.Redeploy: The instance is redeployed due to system maintenance.</description></item>
        /// <item><description>SystemFailure.Reboot: The instance is restarted due to a system failure.</description></item>
        /// <item><description>SystemFailure.Redeploy: The instance is redeployed due to a system failure.</description></item>
        /// <item><description>SystemFailure.Delete: The instance is released due to an instance creation failure.</description></item>
        /// <item><description>InstanceFailure.Reboot: The instance is restarted due to an instance failure.</description></item>
        /// <item><description>InstanceExpiration.Stop: The subscription instance is stopped due to expiration.</description></item>
        /// <item><description>InstanceExpiration.Delete: The subscription instance is released due to expiration.</description></item>
        /// <item><description>AccountUnbalanced.Stop: The pay-as-you-go instance is stopped due to an overdue payment.</description></item>
        /// <item><description>AccountUnbalanced.Delete: The pay-as-you-go instance is released due to an overdue payment.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about event types, see <a href="https://help.aliyun.com/document_detail/66574.html">Overview of system events</a>. The value of this parameter can only be an instance system event, not a disk system event.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SystemMaintenance.Reboot</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ImpactLevel")]
        [Validation(Required=false)]
        public string ImpactLevel { get; set; }

        /// <summary>
        /// <para>The lifecycle statuses of one or more system events. Valid values of N: 1 to 7. Specify multiple values in a repeated list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled: The event is waiting to be executed.</description></item>
        /// <item><description>Avoided: The event is avoided.</description></item>
        /// <item><description>Executing: The event is being executed.</description></item>
        /// <item><description>Executed: The event execution is completed.</description></item>
        /// <item><description>Canceled: The event is canceled.</description></item>
        /// <item><description>Failed: The event execution failed.</description></item>
        /// <item><description>Inquiring: The event is in the inquiring state.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Executed</para>
        /// </summary>
        [NameInMap("InstanceEventCycleStatus")]
        [Validation(Required=false)]
        public List<string> InstanceEventCycleStatus { get; set; }

        /// <summary>
        /// <para>The types of one or more system events. Valid values of N: 1 to 30. Specify multiple values in a repeated list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SystemMaintenance.Reboot: The instance is restarted due to system maintenance.</description></item>
        /// <item><description>SystemMaintenance.Redeploy: The instance is redeployed due to system maintenance.</description></item>
        /// <item><description>SystemFailure.Reboot: The instance is restarted due to a system failure.</description></item>
        /// <item><description>SystemFailure.Redeploy: The instance is redeployed due to a system failure.</description></item>
        /// <item><description>SystemFailure.Delete: The instance is released due to an instance creation failure.</description></item>
        /// <item><description>InstanceFailure.Reboot: The instance is restarted due to an instance failure.</description></item>
        /// <item><description>InstanceExpiration.Stop: The subscription instance is stopped due to expiration.</description></item>
        /// <item><description>InstanceExpiration.Delete: The subscription instance is released due to expiration.</description></item>
        /// <item><description>AccountUnbalanced.Stop: The pay-as-you-go instance is stopped due to an overdue payment.</description></item>
        /// <item><description>AccountUnbalanced.Delete: The pay-as-you-go instance is released due to an overdue payment.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about event types, see <a href="https://help.aliyun.com/document_detail/66574.html">Overview of system events</a>. The value of this parameter can only be an instance system event, not a disk system event.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SystemMaintenance.Reboot</para>
        /// </summary>
        [NameInMap("InstanceEventType")]
        [Validation(Required=false)]
        public List<string> InstanceEventType { get; set; }

        /// <summary>
        /// <para>The instance ID. If you do not specify this parameter, the system events of all instances in the specified region are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf678mass4zvr9n1****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for paging. Valid values: 10 to 100.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If the specified value is greater than 0 and less than 10, the default value is 10.</description></item>
        /// <item><description>If the specified value is greater than 100, the default value is 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the NextToken value returned from the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1c9fa9de5752***</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter will be deprecated soon. Use the MaxResults or NextToken parameter for pagination.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter will be deprecated soon. Use the MaxResults or NextToken parameter for pagination.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the resource. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of one or more resources. Valid values of N: 1 to 100. Specify multiple values in a repeated list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When <c>ResourceType</c> is set to <c>instance</c>, the resource ID is the ECS instance ID.</description></item>
        /// <item><description>When <c>ResourceType</c> is set to <c>ddh</c>, the resource ID is the dedicated host ID.</description></item>
        /// <item><description>When <c>ResourceType</c> is set to <c>managedhost</c>, the resource ID is the physical machine ID in an intelligent fully managed resource pool.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the system events of all resources of the specified resource type (<c>ResourceType</c>) in the specified region (<c>RegionId</c>) are queried.</para>
        /// <remarks>
        /// <para>Use the <c>ResourceId.N</c> parameter to specify one or more resource IDs. If you specify both the <c>ResourceId.N</c> and <c>InstanceId</c> parameters, the <c>ResourceId.N</c> parameter takes precedence by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf678mass4zvr9n1****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance: ECS instance.</description></item>
        /// <item><description>ddh: dedicated host.</description></item>
        /// <item><description>managedhost: physical machine in an intelligent fully managed resource pool.</description></item>
        /// </list>
        /// <para>Default value: instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tags supported by the system event.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstanceHistoryEventsRequestTag> Tag { get; set; }
        public class DescribeInstanceHistoryEventsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
