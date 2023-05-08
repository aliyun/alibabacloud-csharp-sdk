// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeMetadataResponseBody : TeaModel {
        /// <summary>
        /// The metadata of ASM, which contains basic information about ASM.
        /// </summary>
        [NameInMap("MetaData")]
        [Validation(Required=false)]
        public DescribeMetadataResponseBodyMetaData MetaData { get; set; }
        public class DescribeMetadataResponseBodyMetaData : TeaModel {
            /// <summary>
            /// The current version.
            /// </summary>
            [NameInMap("CurrentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// The version information about ASM of a commercial edition.
            /// </summary>
            [NameInMap("ProEdition")]
            [Validation(Required=false)]
            public DescribeMetadataResponseBodyMetaDataProEdition ProEdition { get; set; }
            public class DescribeMetadataResponseBodyMetaDataProEdition : TeaModel {
                /// <summary>
                /// The current version.
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public string CurrentVersion { get; set; }

                /// <summary>
                /// The CRDs of the versions.
                /// </summary>
                [NameInMap("VersionCrds")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> VersionCrds { get; set; }

                /// <summary>
                /// The ASM version and the corresponding Istio version.
                /// </summary>
                [NameInMap("VersionRegistry")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> VersionRegistry { get; set; }

                /// <summary>
                /// The supported versions.
                /// </summary>
                [NameInMap("Versions")]
                [Validation(Required=false)]
                public List<string> Versions { get; set; }

            }

            /// <summary>
            /// The regions where ASM instances can be created.
            /// </summary>
            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<string> Regions { get; set; }

            /// <summary>
            /// The Custom Resource Definitions (CRDs) of the versions.
            /// </summary>
            [NameInMap("VersionCrds")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> VersionCrds { get; set; }

            /// <summary>
            /// The ASM version and the corresponding Istio version.
            /// </summary>
            [NameInMap("VersionRegistry")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> VersionRegistry { get; set; }

            /// <summary>
            /// The supported versions.
            /// </summary>
            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<string> Versions { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
