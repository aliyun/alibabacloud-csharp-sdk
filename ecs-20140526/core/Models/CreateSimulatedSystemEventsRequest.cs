// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateSimulatedSystemEventsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the system event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SystemMaintenance.Reboot: The instance is restarted due to system maintenance.</description></item>
        /// <item><description>SystemFailure.Reboot: The instance is restarted due to a system error.</description></item>
        /// <item><description>InstanceFailure.Reboot: The instance is restarted due to an instance error.</description></item>
        /// <item><description>SystemMaintenance.Stop: The instance is stopped due to system maintenance.</description></item>
        /// <item><description>SystemMaintenance.Redeploy: The instance is redeployed due to system maintenance.</description></item>
        /// <item><description>SystemFailure.Redeploy: The instance is redeployed due to a system error.</description></item>
        /// <item><description>SystemFailure.Stop: The instance is stopped due to a system error.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SystemMaintenance.Reboot</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The IDs of the instances. You can specify up to 100 instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1gtjxuuvwj17zr****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The scheduled start time of the event. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>For events that occur due to system errors or instance errors, the simulated events of such events enter the <c>Executing</c> state when the simulated events are created. The value of <c>NotBefore</c> is the time when the simulated events enter the <c>Executed</c> state.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-12-01T06:32:31Z</para>
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public string NotBefore { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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

    }

}
