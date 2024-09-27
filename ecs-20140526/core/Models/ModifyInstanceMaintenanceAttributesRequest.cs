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
        /// <item><description>Stop: stops the instance.</description></item>
        /// <item><description>AutoRecover: automatically recovers the instance.</description></item>
        /// <item><description>AutoRedeploy: redeploys the instance, which may damage the data disks attached to the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AutoRecover</para>
        /// </summary>
        [NameInMap("ActionOnMaintenance")]
        [Validation(Required=false)]
        public string ActionOnMaintenance { get; set; }

        /// <summary>
        /// <para>The ID of instance N. Valid values of N: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The maintenance windows.</para>
        /// </summary>
        [NameInMap("MaintenanceWindow")]
        [Validation(Required=false)]
        public List<ModifyInstanceMaintenanceAttributesRequestMaintenanceWindow> MaintenanceWindow { get; set; }
        public class ModifyInstanceMaintenanceAttributesRequestMaintenanceWindow : TeaModel {
            /// <summary>
            /// <para>The end time of the maintenance window. The time must be on the hour. You must configure both StartTime and EndTime. The value of EndTime must be 1 to 23 hours later than the value of StartTime. Specify the time in the <c>HH:mm:ss</c> format. The time must be in UTC+8. Set the value of N to 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The start time of the maintenance window. The time must be on the hour. You must configure both StartTime and EndTime. The value of EndTime must be 1 to 23 hours later than the value of StartTime. Specify the time in the <c>HH:mm:ss</c> format. The time must be in UTC+8. Set the value of N to 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to send an event notification before maintenance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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

    }

}
