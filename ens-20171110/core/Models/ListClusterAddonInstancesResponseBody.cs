// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListClusterAddonInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>List of addon information.</para>
        /// </summary>
        [NameInMap("Addons")]
        [Validation(Required=false)]
        public List<ListClusterAddonInstancesResponseBodyAddons> Addons { get; set; }
        public class ListClusterAddonInstancesResponseBodyAddons : TeaModel {
            /// <summary>
            /// <para>Whether to automatically clean up associated cloud resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CleanupCloudResources")]
            [Validation(Required=false)]
            public bool? CleanupCloudResources { get; set; }

            /// <summary>
            /// <para>List of custom parameter schemas for the addon.</para>
            /// </summary>
            [NameInMap("ConfigSchema")]
            [Validation(Required=false)]
            public List<ListClusterAddonInstancesResponseBodyAddonsConfigSchema> ConfigSchema { get; set; }
            public class ListClusterAddonInstancesResponseBodyAddonsConfigSchema : TeaModel {
                /// <summary>
                /// <para>Application version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7380581386597434629002</para>
                /// </summary>
                [NameInMap("AppVersion")]
                [Validation(Required=false)]
                public string AppVersion { get; set; }

                /// <summary>
                /// <para>Configuration version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4572581386436834662215</para>
                /// </summary>
                [NameInMap("ConfigVersion")]
                [Validation(Required=false)]
                public string ConfigVersion { get; set; }

                /// <summary>
                /// <para>Component name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edge-csi-lite</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Custom parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;key1&quot;: &quot;val1&quot;}</para>
                /// </summary>
                [NameInMap("Params")]
                [Validation(Required=false)]
                public string Params { get; set; }

            }

            /// <summary>
            /// <para>Addon name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Current addon status. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>enabling</b>: Enabling.</description></item>
            /// <item><description><b>enabled</b>: Enabled.</description></item>
            /// <item><description><b>disabling</b>: Disabling.</description></item>
            /// <item><description><b>disabled</b>: Disabled.</description></item>
            /// <item><description><b>upgrading</b>: Upgrading.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>125B04C7-3D0D-4245-AF96-14E3758E3F06</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
