// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateVulScanGlobalConfigShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The maximum download rate for vulnerability patches on a single user terminal device. Unit: Byte/s. A value of 0 indicates no speed limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1048576</para>
        /// </summary>
        [NameInMap("MaxDownloadSpeed")]
        [Validation(Required=false)]
        public int? MaxDownloadSpeed { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The vulnerability fix configuration for WUYING Workspace. This configuration applies only to user terminal devices of the Cloud Desktop type.</para>
        /// </summary>
        [NameInMap("WuyingVulFixConfig")]
        [Validation(Required=false)]
        [Obsolete]
        public string WuyingVulFixConfigShrink { get; set; }

    }

}
