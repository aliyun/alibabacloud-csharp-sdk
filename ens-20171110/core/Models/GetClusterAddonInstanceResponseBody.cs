// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetClusterAddonInstanceResponseBody : TeaModel {
        [NameInMap("CleanupCloudResources")]
        [Validation(Required=false)]
        public bool? CleanupCloudResources { get; set; }

        [NameInMap("ConfigSchema")]
        [Validation(Required=false)]
        public List<GetClusterAddonInstanceResponseBodyConfigSchema> ConfigSchema { get; set; }
        public class GetClusterAddonInstanceResponseBodyConfigSchema : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>d0ead1f4e28de0f9e3c86588409a88a4</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d0ead1f4e28de0f9e3c86588409a88a4</para>
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
            public string Params { get; set; }

        }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
