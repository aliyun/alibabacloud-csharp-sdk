// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeMetadataResponseBody : TeaModel {
        /// <summary>
        /// <para>The ASM metadata, including the basic information about ASM.</para>
        /// </summary>
        [NameInMap("MetaData")]
        [Validation(Required=false)]
        public DescribeMetadataResponseBodyMetaData MetaData { get; set; }
        public class DescribeMetadataResponseBodyMetaData : TeaModel {
            /// <summary>
            /// <para>The Kubernetes versions compatible with ASM.</para>
            /// </summary>
            [NameInMap("CompatibilityInfoList")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> CompatibilityInfoList { get; set; }

            /// <summary>
            /// <para>The current version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.14.3.87-g96cf7305-aliyun</para>
            /// </summary>
            [NameInMap("CurrentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// <para>The data of the ASM Playground.</para>
            /// </summary>
            [NameInMap("PlaygroundScene")]
            [Validation(Required=false)]
            public DescribeMetadataResponseBodyMetaDataPlaygroundScene PlaygroundScene { get; set; }
            public class DescribeMetadataResponseBodyMetaDataPlaygroundScene : TeaModel {
                /// <summary>
                /// <para>The observability scenarios.</para>
                /// </summary>
                [NameInMap("observability")]
                [Validation(Required=false)]
                public List<string> Observability { get; set; }

                /// <summary>
                /// <para>Other scenarios.</para>
                /// </summary>
                [NameInMap("other")]
                [Validation(Required=false)]
                public List<string> Other { get; set; }

                /// <summary>
                /// <para>The security scenarios.</para>
                /// </summary>
                [NameInMap("security")]
                [Validation(Required=false)]
                public List<string> Security { get; set; }

                /// <summary>
                /// <para>The traffic management scenarios.</para>
                /// </summary>
                [NameInMap("trafficManagement")]
                [Validation(Required=false)]
                public List<string> TrafficManagement { get; set; }

            }

            /// <summary>
            /// <para>The version information about ASM of a commercial edition.</para>
            /// </summary>
            [NameInMap("ProEdition")]
            [Validation(Required=false)]
            public DescribeMetadataResponseBodyMetaDataProEdition ProEdition { get; set; }
            public class DescribeMetadataResponseBodyMetaDataProEdition : TeaModel {
                /// <summary>
                /// <para>The current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1.14.3.87-g96cf7305-aliyun</para>
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public string CurrentVersion { get; set; }

                /// <summary>
                /// <para>The CRDs of all ASM versions.</para>
                /// </summary>
                [NameInMap("VersionCrds")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> VersionCrds { get; set; }

                /// <summary>
                /// <para>The Istio versions corresponding to the ASM versions.</para>
                /// </summary>
                [NameInMap("VersionRegistry")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> VersionRegistry { get; set; }

                /// <summary>
                /// <para>The list of ASM versions.</para>
                /// </summary>
                [NameInMap("Versions")]
                [Validation(Required=false)]
                public List<string> Versions { get; set; }

            }

            /// <summary>
            /// <para>The regions where ASM instances can be created.</para>
            /// </summary>
            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<string> Regions { get; set; }

            /// <summary>
            /// <para>The custom resource definitions (CRDs) of all ASM versions.</para>
            /// </summary>
            [NameInMap("VersionCrds")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> VersionCrds { get; set; }

            /// <summary>
            /// <para>The Istio versions corresponding to the ASM versions.</para>
            /// </summary>
            [NameInMap("VersionRegistry")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> VersionRegistry { get; set; }

            /// <summary>
            /// <para>The list of ASM versions.</para>
            /// </summary>
            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<string> Versions { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F93DDAD7-6E04-5AC3-86F4-852708******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
