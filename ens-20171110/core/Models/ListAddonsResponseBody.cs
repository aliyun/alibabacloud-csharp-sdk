// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListAddonsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of component information.</para>
        /// </summary>
        [NameInMap("Addons")]
        [Validation(Required=false)]
        public List<ListAddonsResponseBodyAddons> Addons { get; set; }
        public class ListAddonsResponseBodyAddons : TeaModel {
            /// <summary>
            /// <para>Specifies whether to clear resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CleanupCloudResources")]
            [Validation(Required=false)]
            public bool? CleanupCloudResources { get; set; }

            /// <summary>
            /// <para>The schema of the custom parameters of the component.</para>
            /// </summary>
            [NameInMap("ConfigSchema")]
            [Validation(Required=false)]
            public List<ListAddonsResponseBodyAddonsConfigSchema> ConfigSchema { get; set; }
            public class ListAddonsResponseBodyAddonsConfigSchema : TeaModel {
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
                /// <para>The version of the configuration file.</para>
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
                /// <para>The custom configurations of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;key1&quot;:&quot;val1&quot;}</para>
                /// </summary>
                [NameInMap("Params")]
                [Validation(Required=false)]
                public Dictionary<string, object> Params { get; set; }

            }

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
            /// <para>The component version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>Id of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0003E8B-B930-4F59-ADC0-0E209A9012A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
