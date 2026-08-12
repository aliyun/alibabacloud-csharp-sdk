// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ToggleAutoMinorVersionUpgradeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic minor version upgrades. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables automatic upgrades.</para>
        /// </description></item>
        /// <item><description><para>false: Disables automatic upgrades.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUpgrade")]
        [Validation(Required=false)]
        public bool? AutoUpgrade { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
