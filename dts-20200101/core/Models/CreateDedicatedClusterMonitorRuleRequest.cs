// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateDedicatedClusterMonitorRuleRequest : TeaModel {
        /// <summary>
        /// <para>The alert threshold for CPU utilization. Unit: percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("CpuAlarmThreshold")]
        [Validation(Required=false)]
        public long? CpuAlarmThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dts-dasd22******</para>
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// <para>The alert threshold for disk usage. Unit: percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DiskAlarmThreshold")]
        [Validation(Required=false)]
        public long? DiskAlarmThreshold { get; set; }

        /// <summary>
        /// <para>The alert threshold for DTS Unit (DU) usage. Unit: percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DuAlarmThreshold")]
        [Validation(Required=false)]
        public long? DuAlarmThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1162kryivb8****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The alert threshold for memory usage. Unit: percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MemAlarmThreshold")]
        [Validation(Required=false)]
        public long? MemAlarmThreshold { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the alert feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enables the alert feature.</description></item>
        /// <item><description><b>0</b>: disables the alert feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NoticeSwitch")]
        [Validation(Required=false)]
        public long? NoticeSwitch { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The mobile phone number to which alerts are sent. Separate multiple mobile phone numbers with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>186****7654</para>
        /// </summary>
        [NameInMap("Phones")]
        [Validation(Required=false)]
        public string Phones { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the Data Transmission Service (DTS) instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. This parameter is a global parameter and not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The resource group ID. This parameter is a global parameter and not required.</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
