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
            [NameInMap("enable")]
            [Validation(Required=false)]
            public string Enable { get; set; }

            [NameInMap("fileVersion")]
            [Validation(Required=false)]
            public string FileVersion { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>engineVersion</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6.7</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The moderation results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The monitoring type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>checkClusterHealth: Cluster Health Status</description></item>
        /// <item><description>checkConfigCompatible: Configuration Compatibility Status</description></item>
        /// <item><description>checkClusterResource: resource space status</description></item>
        /// <item><description>checkClusterSnapshot: Whether a snapshot exists</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("updateStrategy")]
        [Validation(Required=false)]
        public string UpdateStrategy { get; set; }

    }

}
