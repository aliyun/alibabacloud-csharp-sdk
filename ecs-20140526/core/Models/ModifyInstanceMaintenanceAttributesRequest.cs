// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceMaintenanceAttributesRequest : TeaModel {
        /// <summary>
        /// <para>The maintenance action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Stop: The instance is stopped (that is, the instance goes down).</description></item>
        /// <item><description>AutoRecover: The instance is automatically recovered.</description></item>
        /// <item><description>AutoRedeploy: The instance is redeployed upon downtime, with possible data disk loss.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AutoRecover</para>
        /// </summary>
        [NameInMap("ActionOnMaintenance")]
        [Validation(Required=false)]
        public string ActionOnMaintenance { get; set; }

        /// <summary>
        /// <para>The instance ID. Valid values of N: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The list of maintenance time windows.</para>
        /// </summary>
        [NameInMap("MaintenanceWindow")]
        [Validation(Required=false)]
        public List<ModifyInstanceMaintenanceAttributesRequestMaintenanceWindow> MaintenanceWindow { get; set; }
        public class ModifyInstanceMaintenanceAttributesRequestMaintenanceWindow : TeaModel {
            /// <summary>
            /// <para>The end time of the time window. The time must be on the hour. Minutes and seconds cannot be specified. The start time and end time must be specified together, and the interval between them must be 1 to 23 hours. The time is in the UTC+8 time zone and in the <c>HH:mm:ss</c> format. Valid values of N: 1. Only one time window can be specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The start time of the time window. The time must be on the hour. Minutes and seconds cannot be specified. The start time and end time must be specified together, and the interval between them must be 1 to 23 hours. The time is in the UTC+8 time zone and in the <c>HH:mm:ss</c> format. Valid values of N: 1. Only one time window can be specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to send an event notification before instance downtime maintenance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: An event notification is sent.</description></item>
        /// <item><description>false: No event notification is sent.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NotifyOnMaintenance")]
        [Validation(Required=false)]
        public bool? NotifyOnMaintenance { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
