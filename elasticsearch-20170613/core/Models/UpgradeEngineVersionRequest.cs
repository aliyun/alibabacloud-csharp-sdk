// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpgradeEngineVersionRequest : TeaModel {
        [NameInMap("plugins")]
        [Validation(Required=false)]
        public List<UpgradeEngineVersionRequestPlugins> Plugins { get; set; }
        public class UpgradeEngineVersionRequestPlugins : TeaModel {
            /// <summary>
            /// <para>Specifies whether to install or uninstall the plug-in. A value of true indicates install, and a value of false indicates uninstall.</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

            /// <summary>
            /// <para>The fileVersion of the plug-in. Refer to the response of ListUserPlugin.</para>
            /// </summary>
            [NameInMap("fileVersion")]
            [Validation(Required=false)]
            public string FileVersion { get; set; }

            /// <summary>
            /// <para>The plug-in name.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The Elasticsearch version for the plug-in, such as 7.16.2.</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The upgrade type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>engineVersion (default): major engine version upgrade.</description></item>
        /// <item><description>aliVersion: kernel version upgrade.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>engineVersion</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The version after the upgrade. If type is set to engineVersion, the value is the instance version, such as 6.7. If type is set to aliVersion, the value is the kernel version, such as ali1.2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6.7</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a pre-upgrade check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a check.</description></item>
        /// <item><description>false (default): does not perform a check.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Warning:  The version upgrade check involves checks on cluster YML, plug-in configurations, cluster status, indexes, and resources. Perform a pre-upgrade check before upgrading. Otherwise, upgrade issues may occur.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The update strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>blue_green: blue-green deployment.</description></item>
        /// <item><description>normal: in-place update.</description></item>
        /// <item><description>intelligent: intelligent update.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("updateStrategy")]
        [Validation(Required=false)]
        public string UpdateStrategy { get; set; }

    }

}
