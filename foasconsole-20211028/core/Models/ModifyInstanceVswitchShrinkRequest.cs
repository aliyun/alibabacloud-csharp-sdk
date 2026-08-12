// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class ModifyInstanceVswitchShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The vSwitch IDs in the secondary zone for zone-disaster recovery. This parameter is required if zone-disaster recovery is enabled for your workspace.</para>
        /// </summary>
        [NameInMap("HaVSwitchIds")]
        [Validation(Required=false)]
        public string HaVSwitchIdsShrink { get; set; }

        /// <summary>
        /// <para>The order instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sc_flinkserverless_public_cn-7e22ae****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IDs of the vSwitches to use after the modification.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIdsShrink { get; set; }

    }

}
