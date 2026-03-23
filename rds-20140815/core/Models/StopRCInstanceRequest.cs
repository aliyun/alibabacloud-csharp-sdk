// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class StopRCInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcefully stop the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
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
        /// <para>The stop mode to use when stopping the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>StopCharging: economical mode. When economical mode is enabled:</para>
        /// <list type="bullet">
        /// <item><description>Computing resources are no longer billed.</description></item>
        /// <item><description>System disk and data disk continue to be billed.</description></item>
        /// <item><description>Because computing resources are revoked, the instance might fail to start due to insufficient inventory. In this case, try again later or change the instance type.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>KeepCharging: normal stop mode. The instance continues to incur charges after it is stopped.</para>
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
