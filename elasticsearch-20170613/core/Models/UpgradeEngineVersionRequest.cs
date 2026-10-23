// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpgradeEngineVersionRequest : TeaModel {
        /// <summary>
        /// <para>The list of plug-in configurations to install or uninstall during the version upgrade.</para>
        /// </summary>
        [NameInMap("plugins")]
        [Validation(Required=false)]
        public List<UpgradeEngineVersionRequestPlugins> Plugins { get; set; }
        public class UpgradeEngineVersionRequestPlugins : TeaModel {
            /// <summary>
            /// <para>Specifies whether to install or uninstall the plug-in. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Installs the plug-in.</description></item>
            /// <item><description>false: Uninstalls the plug-in.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

            /// <summary>
            /// <para>The file version of the plug-in. For more information, see the response of ListUserPlugin.</para>
            /// </summary>
            [NameInMap("fileVersion")]
            [Validation(Required=false)]
            public string FileVersion { get; set; }

            /// <summary>
            /// <para>The name of the plug-in.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The Elasticsearch version corresponding to the plug-in, such as 7.16.2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7.16.2</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The upgrade type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>engineVersion: Major engine version upgrade. This is the default value.</description></item>
        /// <item><description>aliVersion: Kernel version upgrade.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate the token on the client side. The token must be unique across different requests and can be up to 64 ASCII characters in length.</para>
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
        /// <item><description>true: Performs the check.</description></item>
        /// <item><description>false: Does not perform the check. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Warning:  The version upgrade check includes checks on the cluster YML file, plug-in configurations, cluster status, indexes, and resources. Perform a pre-upgrade check before the upgrade to prevent upgrade issues.</para>
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
        /// <item><description>blue_green: Blue-green deployment.</description></item>
        /// <item><description>normal: In-place update.</description></item>
        /// <item><description>intelligent: Intelligent update.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>blue_green</para>
        /// </summary>
        [NameInMap("updateStrategy")]
        [Validation(Required=false)]
        public string UpdateStrategy { get; set; }

    }

}
