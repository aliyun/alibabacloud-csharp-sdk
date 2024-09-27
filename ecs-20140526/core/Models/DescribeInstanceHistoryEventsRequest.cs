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
            /// <para>The end of the time range in which to query published system events. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-01T06:32:31Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>The beginning of the time range in which to query published system events. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
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
            /// <para>The latest scheduled end time for the system event. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-01T06:32:31Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>The earliest scheduled start time for the system event. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-30T06:32:31Z</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// <para>The lifecycle state of the system event. This parameter takes effect only when InstanceEventCycleStatus.N is not specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled</description></item>
        /// <item><description>Avoided</description></item>
        /// <item><description>Executing</description></item>
        /// <item><description>Executed</description></item>
        /// <item><description>Canceled</description></item>
        /// <item><description>Failed</description></item>
        /// <item><description>Inquiring</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Executed</para>
        /// </summary>
        [NameInMap("EventCycleStatus")]
        [Validation(Required=false)]
        public string EventCycleStatus { get; set; }

        /// <summary>
        /// <para>The ID of system event N. Valid values of N: 1 to 100. You can repeat this parameter to pass multiple values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-uf64yvznlao4jl2c****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public List<string> EventId { get; set; }

        /// <summary>
        /// <para>The type of the system event. This parameter takes effect only when InstanceEventType.N is not specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SystemMaintenance.Reboot: The instance is restarted due to system maintenance.</description></item>
        /// <item><description>SystemMaintenance.Redeploy: The instance is redeployed due to system maintenance.</description></item>
        /// <item><description>SystemFailure.Reboot: The instance is restarted due to a system error.</description></item>
        /// <item><description>SystemFailure.Redeploy: The instance is redeployed due to a system error.</description></item>
        /// <item><description>SystemFailure.Delete: The instance is released due to an instance creation failure.</description></item>
        /// <item><description>InstanceFailure.Reboot: The instance is restarted due to an instance error.</description></item>
        /// <item><description>InstanceExpiration.Stop: The subscription instance is stopped due to expiration.</description></item>
        /// <item><description>InstanceExpiration.Delete: The subscription instance is released due to expiration.</description></item>
        /// <item><description>AccountUnbalanced.Stop: The pay-as-you-go instance is stopped due to an overdue payment.</description></item>
        /// <item><description>AccountUnbalanced.Delete: The pay-as-you-go instance is released due to an overdue payment.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information, see <a href="https://help.aliyun.com/document_detail/66574.html">Overview</a>. The values of this parameter are applicable only to instance system events, but not to disk system events.</para>
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
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ImpactLevel")]
        [Validation(Required=false)]
        public string ImpactLevel { get; set; }

        /// <summary>
        /// <para>The lifecycle state of system event N. Valid values of N: 1 to 7. You can repeat this parameter to pass multiple values. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Scheduled</description></item>
        /// <item><description>Avoided</description></item>
        /// <item><description>Executing</description></item>
        /// <item><description>Executed</description></item>
        /// <item><description>Canceled</description></item>
        /// <item><description>Failed</description></item>
        /// <item><description>Inquiring</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Executed</para>
        /// </summary>
        [NameInMap("InstanceEventCycleStatus")]
        [Validation(Required=false)]
        public List<string> InstanceEventCycleStatus { get; set; }

        /// <summary>
        /// <para>The type of system event N. Valid values of N: 1 to 30. You can repeat this parameter to pass multiple values. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SystemMaintenance.Reboot: The instance is restarted due to system maintenance.</description></item>
        /// <item><description>SystemMaintenance.Redeploy: The instance is redeployed due to system maintenance.</description></item>
        /// <item><description>SystemFailure.Reboot: The instance is restarted due to a system error.</description></item>
        /// <item><description>SystemFailure.Redeploy: The instance is redeployed due to a system error.</description></item>
        /// <item><description>SystemFailure.Delete: The instance is released due to an instance creation failure.</description></item>
        /// <item><description>InstanceFailure.Reboot: The instance is restarted due to an instance error.</description></item>
        /// <item><description>InstanceExpiration.Stop: The subscription instance is stopped due to expiration.</description></item>
        /// <item><description>InstanceExpiration.Delete: The subscription instance is released due to expiration.</description></item>
        /// <item><description>AccountUnbalanced.Stop: The pay-as-you-go instance is stopped due to an overdue payment.</description></item>
        /// <item><description>AccountUnbalanced.Delete: The pay-as-you-go instance is released due to an overdue payment.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information, see <a href="https://help.aliyun.com/document_detail/66574.html">Overview</a>. The values of this parameter are applicable only to instance system events, but not to disk system events.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SystemMaintenance.Reboot</para>
        /// </summary>
        [NameInMap("InstanceEventType")]
        [Validation(Required=false)]
        public List<string> InstanceEventType { get; set; }

        /// <summary>
        /// <para>The ID of the instance. If this parameter is not specified, the system events of all instances in the specified region are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf678mass4zvr9n1****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
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
        /// <para>The ID of resource N. Valid values of N: 1 to 100. You can repeat this parameter to pass multiple values. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When <c>ResourceType</c> is set to instance, ResourceId.N specifies the ID of instance N.</description></item>
        /// <item><description>When <c>ResourceType</c> is set to ddh, ResourceId.N specifies the ID of dedicated host N.</description></item>
        /// <item><description>When <c>ResourceType</c> is set to managedhost, ResourceId.N specifies the ID of physical machine N from a smart hosting pool.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, the system events of all resources of the type specified by <c>ResourceType</c> in the region specified by <c>RegionId</c> are queried.</para>
        /// <remarks>
        /// <para> We recommend that you use <c>ResourceId.N</c> to specify one or more resource IDs. If you specify both <c>ResourceId.N</c> and <c>InstanceId</c>, <c>ResourceId.N</c> takes precedence by default.</para>
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
        /// <item><description>instance: ECS instance</description></item>
        /// <item><description>ddh: dedicated host</description></item>
        /// <item><description>managehost: physical machine in a smart hosting pool</description></item>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstanceHistoryEventsRequestTag> Tag { get; set; }
        public class DescribeInstanceHistoryEventsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the resource.</para>
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
