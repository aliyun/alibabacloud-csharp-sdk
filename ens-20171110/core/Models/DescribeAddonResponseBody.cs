// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeAddonResponseBody : TeaModel {
        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Addons")]
        [Validation(Required=false)]
        public List<DescribeAddonResponseBodyAddons> Addons { get; set; }
        public class DescribeAddonResponseBodyAddons : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CleanupCloudResources")]
            [Validation(Required=false)]
            public string CleanupCloudResources { get; set; }

            [NameInMap("ConfigSchema")]
            [Validation(Required=false)]
            public List<DescribeAddonResponseBodyAddonsConfigSchema> ConfigSchema { get; set; }
            public class DescribeAddonResponseBodyAddonsConfigSchema : TeaModel {
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
                /// <para>{&quot;key1&quot;:&quot;val1&quot;}</para>
                /// </summary>
                [NameInMap("Params")]
                [Validation(Required=false)]
                public object Params { get; set; }

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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
