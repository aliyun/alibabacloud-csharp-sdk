// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateSimulatedSystemEventsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the system event. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>SystemMaintenance.Reboot: The instance is restarted due to system maintenance.</description></item>
        /// <item><description>SystemFailure.Reboot: The instance is restarted due to a system failure.</description></item>
        /// <item><description>InstanceFailure.Reboot: The instance is restarted due to an instance failure.</description></item>
        /// <item><description>SystemMaintenance.Stop: The instance is stopped due to system maintenance.</description></item>
        /// <item><description>SystemMaintenance.Redeploy: The instance is redeployed due to system maintenance.</description></item>
        /// <item><description>SystemFailure.Redeploy: The instance is redeployed due to a system failure.</description></item>
        /// <item><description>SystemFailure.Stop: The instance is stopped due to a system failure.</description></item>
        /// <item><description>InstanceFailure.Reboot: The instance is restarted due to an instance failure.</description></item>
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
        /// <para>The IDs of the ECS instances. You can specify up to 100 instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The scheduled start time of the event. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>If the TriggerRealOps parameter is set to false, you must specify the NotBefore parameter.</para>
        /// </remarks>
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

        /// <summary>
        /// <para>Specifies whether to trigger actual O&amp;M operations. Valid values:<br>- true: Triggers actual O&amp;M operations. The system actually stops or releases the instance. Proceed with caution during testing, or select an instance that does not run business workloads for testing. The O&amp;M event is generated approximately 1 minute after the API call succeeds.<br>- false: Simulates only event notifications and does not affect the actual lifecycle of the instance. This is the default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TriggerRealOps")]
        [Validation(Required=false)]
        public bool? TriggerRealOps { get; set; }

    }

}
