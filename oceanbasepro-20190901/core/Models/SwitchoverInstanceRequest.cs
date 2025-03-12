// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class SwitchoverInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Whether to force the switchover.</para>
        /// <list type="bullet">
        /// <item><description>true: Force the switchover.</description></item>
        /// <item><description>false: Do not force the switchover.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Forced")]
        [Validation(Required=false)]
        public bool? Forced { get; set; }

        /// <summary>
        /// <para>The instance ID of the primary/standby instance. You can set the default value to the instance ID of the instance to be switched to the primary instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance ID of the instance to be switched to the primary instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob4bv8o7sp****</para>
        /// </summary>
        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

    }

}
