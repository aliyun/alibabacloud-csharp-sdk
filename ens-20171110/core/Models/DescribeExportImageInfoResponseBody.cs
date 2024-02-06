// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeExportImageInfoResponseBody : TeaModel {
        /// <summary>
        /// The returned result. For more information, see the Images parameter described in the JSON-formatted sample success response.
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeExportImageInfoResponseBodyImages Images { get; set; }
        public class DescribeExportImageInfoResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeExportImageInfoResponseBodyImagesImage> Image { get; set; }
            public class DescribeExportImageInfoResponseBodyImagesImage : TeaModel {
                /// <summary>
                /// The architecture of the image. Example: **x86\_64**.
                /// </summary>
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                /// <summary>
                /// The time when the image was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The URL of the exported image.
                /// </summary>
                [NameInMap("ExportedImageURL")]
                [Validation(Required=false)]
                public string ExportedImageURL { get; set; }

                /// <summary>
                /// The export status of the image. Valid values:
                /// 
                /// *   Exporting
                /// *   Exported
                /// *   ExportError
                /// *   Unexported
                /// </summary>
                [NameInMap("ImageExportStatus")]
                [Validation(Required=false)]
                public string ImageExportStatus { get; set; }

                /// <summary>
                /// The ID of the image.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The name of the image.
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// The source of the image. Valid values:
                /// 
                /// *   system: public image
                /// *   self: custom image
                /// </summary>
                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                /// <summary>
                /// The OS.
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
