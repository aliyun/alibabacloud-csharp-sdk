// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetClusterAddonInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether associated cloud resources are automatically cleaned up.</para>
        /// </summary>
        [NameInMap("CleanupCloudResources")]
        [Validation(Required=false)]
        public bool? CleanupCloudResources { get; set; }

        /// <summary>
        /// <para>The schema of custom parameters for the add-on.</para>
        /// </summary>
        [NameInMap("ConfigSchema")]
        [Validation(Required=false)]
        public List<GetClusterAddonInstanceResponseBodyConfigSchema> ConfigSchema { get; set; }
        public class GetClusterAddonInstanceResponseBodyConfigSchema : TeaModel {
            /// <summary>
            /// <para>The application version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d0ead1f4e28de0f9e3c86588409a88a4</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>The configuration version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d0ead1f4e28de0f9e3c86588409a88a4</para>
            /// </summary>
            [NameInMap("ConfigVersion")]
            [Validation(Required=false)]
            public string ConfigVersion { get; set; }

            /// <summary>
            /// <para>The add-on name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edge-csi-lite</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The custom parameters of the add-on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;k1&quot;:&quot;v1&quot;}</para>
            /// </summary>
            [NameInMap("Params")]
            [Validation(Required=false)]
            public string Params { get; set; }

        }

        /// <summary>
        /// <para>The add-on name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edge-csi-lite</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The current component instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b>: Running normally.</description></item>
        /// <item><description><b>deleting</b>: Stopping.</description></item>
        /// <item><description><b>enabling</b>: Starting.</description></item>
        /// <item><description><b>upgrading</b>: In upgrade or configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

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

}
