// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class InstallClusterAddonsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Addons")]
        [Validation(Required=false)]
        public List<InstallClusterAddonsRequestAddons> Addons { get; set; }
        public class InstallClusterAddonsRequestAddons : TeaModel {
            [NameInMap("ConfigSchema")]
            [Validation(Required=false)]
            public List<InstallClusterAddonsRequestAddonsConfigSchema> ConfigSchema { get; set; }
            public class InstallClusterAddonsRequestAddonsConfigSchema : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>859e9d595b2974ed79c444658d1dea89</para>
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4155709cd12a09bdb8cbaca71bf03233</para>
                /// </summary>
                [NameInMap("ConfigVersion")]
                [Validation(Required=false)]
                public string ConfigVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>edge-csi-lite</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;k1&quot;:&quot;v1&quot;}</para>
                /// </summary>
                [NameInMap("Params")]
                [Validation(Required=false)]
                public Dictionary<string, object> Params { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>edge-csi-lite</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eck-xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
