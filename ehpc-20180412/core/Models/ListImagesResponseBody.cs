// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListImagesResponseBody : TeaModel {
        /// <summary>
        /// The list of images that are supported by E-HPC.
        /// </summary>
        [NameInMap("OsTags")]
        [Validation(Required=false)]
        public ListImagesResponseBodyOsTags OsTags { get; set; }
        public class ListImagesResponseBodyOsTags : TeaModel {
            [NameInMap("OsInfo")]
            [Validation(Required=false)]
            public List<ListImagesResponseBodyOsTagsOsInfo> OsInfo { get; set; }
            public class ListImagesResponseBodyOsTagsOsInfo : TeaModel {
                /// <summary>
                /// The architecture of the operating system. Valid values:
                /// 
                /// *   i386
                /// *   x86\_64
                /// </summary>
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                /// <summary>
                /// The image tag of the operating system. The tag is used only for management nodes.
                /// </summary>
                [NameInMap("BaseOsTag")]
                [Validation(Required=false)]
                public string BaseOsTag { get; set; }

                /// <summary>
                /// The ID of the image.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                [NameInMap("OSNameEn")]
                [Validation(Required=false)]
                public string OSNameEn { get; set; }

                /// <summary>
                /// The image tag of the cluster.
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                /// <summary>
                /// The operating system. Valid values:
                /// 
                /// *   CentOS
                /// *   windows
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// The version of the operating system.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
