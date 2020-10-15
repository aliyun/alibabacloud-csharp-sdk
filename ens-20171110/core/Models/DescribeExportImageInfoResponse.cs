// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeExportImageInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("Images")]
        [Validation(Required=true)]
        public DescribeExportImageInfoResponseImages Images { get; set; }
        public class DescribeExportImageInfoResponseImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=true)]
            public List<DescribeExportImageInfoResponseImagesImage> Image { get; set; }
            public class DescribeExportImageInfoResponseImagesImage : TeaModel {
                public string CreationTime { get; set; }
                public string ImageId { get; set; }
                public string ImageName { get; set; }
                public string Architecture { get; set; }
                public string ImageOwnerAlias { get; set; }
                public string Platform { get; set; }
                public string ImageExportStatus { get; set; }
                public string ExportedImageURL { get; set; }
            }
        };

    }

}
