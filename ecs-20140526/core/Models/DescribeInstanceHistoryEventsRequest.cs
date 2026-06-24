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
            /// <para>查询系统事件发布时间的结束时间。按照<a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>标准表示，并需要使用UTC +0时间，格式为yyyy-MM-ddTHH:mm:ssZ。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-01T06:32:31Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>查询系统事件发布时间的开始时间。按照<a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>标准表示，并需要使用UTC +0时间，格式为yyyy-MM-ddTHH:mm:ssZ。</para>
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
            /// <para>查询系统事件计划执行时间的结束时间。按照<a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>标准表示，并需要使用UTC +0时间，格式为yyyy-MM-ddTHH:mm:ssZ。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-01T06:32:31Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>查询系统事件计划执行时间的开始时间。按照<a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>标准表示，并需要使用UTC +0时间，格式为yyyy-MM-ddTHH:mm:ssZ。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-30T06:32:31Z</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// <para>The lifecycle status of the system event. EventCycleStatus takes effect only when the InstanceEventCycleStatus.N parameter is not specified. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Scheduled: the event is waiting to be executed.</description></item>
        /// <item><description>Avoided: the event has been avoided.</description></item>
        /// <item><description>Executing: the event is being executed.</description></item>
        /// <item><description>Executed: the event has been executed.</description></item>
        /// <item><description>Canceled: the event has been canceled.</description></item>
        /// <item><description>Failed: the event execution failed.</description></item>
        /// <item><description>Inquiring: the event is being inquired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Executed</para>
        /// </summary>
        [NameInMap("EventCycleStatus")]
        [Validation(Required=false)]
        public string EventCycleStatus { get; set; }

        /// <summary>
        /// <para>One or more system event IDs. Valid values of N: 1 to 100. Specify multiple values in a repeated list format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-uf64yvznlao4jl2c****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public List<string> EventId { get; set; }

        /// <summary>
        /// <para>The type of the system event. EventType takes effect only when the InstanceEventType.N parameter is not specified. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>SystemMaintenance.Reboot: the instance is restarted due to system maintenance.</description></item>
        /// <item><description>SystemMaintenance.Redeploy: the instance is redeployed due to system maintenance.</description></item>
        /// <item><description>SystemFailure.Reboot: the instance is restarted due to a system error.</description></item>
        /// <item><description>SystemFailure.Redeploy: the instance is redeployed due to a system error.</description></item>
        /// <item><description>SystemFailure.Delete: the instance is released due to an instance creation failure.</description></item>
        /// <item><description>InstanceFailure.Reboot: the instance is restarted due to an instance error.</description></item>
        /// <item><description>InstanceExpiration.Stop: the instance is stopped because the subscription has expired.</description></item>
        /// <item><description>InstanceExpiration.Delete: the instance is released because the subscription has expired.</description></item>
        /// <item><description>AccountUnbalanced.Stop: the pay-as-you-go instance is stopped due to an overdue payment.</description></item>
        /// <item><description>AccountUnbalanced.Delete: the pay-as-you-go instance is released due to an overdue payment.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about event types, see <a href="https://help.aliyun.com/document_detail/66574.html">System event overview</a>. The value of this parameter can only be an instance system event, not a disk system event.</para>
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
        /// <para>This parameter is not yet available for use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ImpactLevel")]
        [Validation(Required=false)]
        public string ImpactLevel { get; set; }

        /// <summary>
        /// <para>One or more lifecycle statuses of the system event. Valid values of N: 1 to 7. Specify multiple values in a repeated list format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled: the event is waiting to be executed.</description></item>
        /// <item><description>Avoided: the event has been avoided.</description></item>
        /// <item><description>Executing: the event is being executed.</description></item>
        /// <item><description>Executed: the event has been executed.</description></item>
        /// <item><description>Canceled: the event has been canceled.</description></item>
        /// <item><description>Failed: the event execution failed.</description></item>
        /// <item><description>Inquiring: the event is being inquired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Executed</para>
        /// </summary>
        [NameInMap("InstanceEventCycleStatus")]
        [Validation(Required=false)]
        public List<string> InstanceEventCycleStatus { get; set; }

        /// <summary>
        /// <para>One or more types of the system event. Valid values of N: 1 to 30. Specify multiple values in a repeated list format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SystemMaintenance.Reboot: the instance is restarted due to system maintenance.</description></item>
        /// <item><description>SystemMaintenance.Redeploy: the instance is redeployed due to system maintenance.</description></item>
        /// <item><description>SystemFailure.Reboot: the instance is restarted due to a system error.</description></item>
        /// <item><description>SystemFailure.Redeploy: the instance is redeployed due to a system error.</description></item>
        /// <item><description>SystemFailure.Delete: the instance is released due to an instance creation failure.</description></item>
        /// <item><description>InstanceFailure.Reboot: the instance is restarted due to an instance error.</description></item>
        /// <item><description>InstanceExpiration.Stop: the instance is stopped because the subscription has expired.</description></item>
        /// <item><description>InstanceExpiration.Delete: the instance is released because the subscription has expired.</description></item>
        /// <item><description>AccountUnbalanced.Stop: the pay-as-you-go instance is stopped due to an overdue payment.</description></item>
        /// <item><description>AccountUnbalanced.Delete: the pay-as-you-go instance is released due to an overdue payment.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about event types, see <a href="https://help.aliyun.com/document_detail/66574.html">System event overview</a>. The value of this parameter can only be an instance system event, not a disk system event.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SystemMaintenance.Reboot</para>
        /// </summary>
        [NameInMap("InstanceEventType")]
        [Validation(Required=false)]
        public List<string> InstanceEventType { get; set; }

        /// <summary>
        /// <para>The instance ID. If this parameter is not specified, the system events of all instances in the specified region are queried.</para>
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
        /// <item><description>When the specified value is greater than 0 but less than 10, the default value is 10.</description></item>
        /// <item><description>When the specified value is greater than 100, the default value is 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the NextToken value returned in the previous API call.</para>
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
        /// <para>This parameter will be deprecated. Use MaxResults and NextToken for pagination instead.</para>
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
        /// <para>This parameter will be deprecated. Use MaxResults and NextToken for pagination instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the resource. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
        /// <para>One or more resource IDs. Valid values of N: 1 to 100. Specify multiple values in a repeated list format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When <c>ResourceType=instance</c>, the resource ID indicates the ECS instance ID.</description></item>
        /// <item><description>When <c>ResourceType=ddh</c>, the resource ID indicates the dedicated host ID.</description></item>
        /// <item><description>When <c>ResourceType=managedhost</c>, the resource ID indicates the physical machine ID in an intelligent fully managed resource pool.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, the system events of all resources in the specified region (<c>RegionId</c>) and of the specified resource type (<c>ResourceType</c>) are queried.</para>
        /// <remarks>
        /// <para>We recommend that you use the <c>ResourceId.N</c> parameter to specify one or more resource IDs. If you specify both <c>ResourceId.N</c> and <c>InstanceId</c>, the <c>ResourceId.N</c> parameter takes precedence by default.</para>
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
        /// <para>The type of the resource. Valid values:</para>
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
        /// <para>The list of tags supported by system events.</para>
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
