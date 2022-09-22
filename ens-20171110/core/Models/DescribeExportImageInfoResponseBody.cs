// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeExportImageInfoResponseBody : TeaModel {
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeExportImageInfoResponseBodyImages Images { get; set; }
        public class DescribeExportImageInfoResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeExportImageInfoResponseBodyImagesImage> Image { get; set; }
            public class DescribeExportImageInfoResponseBodyImagesImage : TeaModel {
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("ExportedImageURL")]
                [Validation(Required=false)]
                public string ExportedImageURL { get; set; }

                [NameInMap("ImageExportStatus")]
                [Validation(Required=false)]
                public string ImageExportStatus { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
