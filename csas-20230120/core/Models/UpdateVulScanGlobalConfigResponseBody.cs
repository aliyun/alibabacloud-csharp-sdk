// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateVulScanGlobalConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum download rate for vulnerability patches on a single user terminal device. Unit: Byte/s. A value of 0 indicates no speed limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1048576</para>
        /// </summary>
        [NameInMap("MaxDownloadSpeed")]
        [Validation(Required=false)]
        public int? MaxDownloadSpeed { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D7EC0AF-DB2A-5D9C-90EC-F090A6BAAEA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The vulnerability fix configuration for WUYING Workspace. This configuration applies only to user terminal devices of the Cloud Desktop type.</para>
        /// </summary>
        [NameInMap("WuyingVulFixConfig")]
        [Validation(Required=false)]
        [Obsolete]
        public UpdateVulScanGlobalConfigResponseBodyWuyingVulFixConfig WuyingVulFixConfig { get; set; }
        public class UpdateVulScanGlobalConfigResponseBodyWuyingVulFixConfig : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>Specifies whether to prohibit shutdown during the fix process to prevent system exceptions caused by shutting down during patch installation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Prohibit shutdown.</description></item>
            /// <item><description><b>false</b>: Do not prohibit shutdown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AntiShutdownSwitch")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? AntiShutdownSwitch { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>Specifies whether to create a snapshot for the cloud desktop before the fix for rollback in case of fix failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Create a snapshot.</description></item>
            /// <item><description><b>false</b>: Do not create a snapshot.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SnapshotSwitch")]
            [Validation(Required=false)]
            [Obsolete]
            public bool? SnapshotSwitch { get; set; }

        }

    }

}
