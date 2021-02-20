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
                public string Architecture { get; set; }
                public string CreationTime { get; set; }
                public string ExportedImageURL { get; set; }
                public string ImageExportStatus { get; set; }
                public string ImageId { get; set; }
                public string ImageName { get; set; }
                public string ImageOwnerAlias { get; set; }
                public string Platform { get; set; }
            }
        };

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
