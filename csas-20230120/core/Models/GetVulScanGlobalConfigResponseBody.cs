// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetVulScanGlobalConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum download rate of vulnerability patches for a single user terminal device. Unit: Byte/s. A value of 0 indicates no rate limit.</para>
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

        /// <summary>
        /// <para>The vulnerability fix configuration for WUYING Cloud Desktop. This configuration takes effect only for user terminal devices of the WUYING Cloud Desktop type.</para>
        /// </summary>
        [NameInMap("WuyingVulFixConfig")]
        [Validation(Required=false)]
        public GetVulScanGlobalConfigResponseBodyWuyingVulFixConfig WuyingVulFixConfig { get; set; }
        public class GetVulScanGlobalConfigResponseBodyWuyingVulFixConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to prohibit shutdown during the fix process to prevent system exceptions caused by shutdown during patch installation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Shutdown is prohibited.</description></item>
            /// <item><description><b>false</b>: Shutdown is not prohibited.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AntiShutdownSwitch")]
            [Validation(Required=false)]
            public bool? AntiShutdownSwitch { get; set; }

            /// <summary>
            /// <para>Specifies whether to create a snapshot for the Cloud Desktop before the fix process to allow rollback if the fix fails. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: A snapshot is created.</description></item>
            /// <item><description><b>false</b>: No snapshot is created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SnapshotSwitch")]
            [Validation(Required=false)]
            public bool? SnapshotSwitch { get; set; }

        }

    }

}
