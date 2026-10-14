// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class InstallClusterAddonsRequest : TeaModel {
        /// <summary>
        /// <para>The component information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Addons")]
        [Validation(Required=false)]
        public List<InstallClusterAddonsRequestAddons> Addons { get; set; }
        public class InstallClusterAddonsRequestAddons : TeaModel {
            /// <summary>
            /// <para>The schema for the custom parameters of the component.</para>
            /// </summary>
            [NameInMap("ConfigSchema")]
            [Validation(Required=false)]
            public List<InstallClusterAddonsRequestAddonsConfigSchema> ConfigSchema { get; set; }
            public class InstallClusterAddonsRequestAddonsConfigSchema : TeaModel {
                /// <summary>
                /// <para>The application version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>859e9d595b2974ed79c444658d1dea89</para>
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// <para>The configuration version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4155709cd12a09bdb8cbaca71bf03233</para>
                /// </summary>
                [NameInMap("ConfigVersion")]
                [Validation(Required=false)]
                public string ConfigVersion { get; set; }

                /// <summary>
                /// <para>The component name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edge-csi-lite</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The custom parameters of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;k1&quot;:&quot;v1&quot;}</para>
                /// </summary>
                [NameInMap("Params")]
                [Validation(Required=false)]
                public Dictionary<string, object> Params { get; set; }

            }

            /// <summary>
            /// <para>The plug-in name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edge-csi-lite</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The cluster ID.</para>
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
