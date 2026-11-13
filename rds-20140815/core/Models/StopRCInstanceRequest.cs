// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class StopRCInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to force shutdown. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Forces the instance to shut down.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Shuts down the instance normally.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public bool? ForceStop { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-m5sc1271fv344a1r****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The stop mode configured when the instance is stopped. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>StopCharging: economical mode. After economical mode is enabled:</para>
        /// <list type="bullet">
        /// <item><description>Billing for compute resources is suspended.</description></item>
        /// <item><description>Billing for the system cloud disk and data cloud disks continues.</description></item>
        /// <item><description>Because compute resources are reclaimed, the instance may fail to start due to insufficient resources. In this case, try again later or change the instance type.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>KeepCharging: standard mode. The instance continues to be billed after it is stopped.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KeepCharging</para>
        /// </summary>
        [NameInMap("StoppedMode")]
        [Validation(Required=false)]
        public string StoppedMode { get; set; }

    }

}
