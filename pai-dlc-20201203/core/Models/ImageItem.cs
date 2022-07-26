// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ImageItem : TeaModel {
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        [NameInMap("AuthorId")]
        [Validation(Required=false)]
        public string AuthorId { get; set; }

        [NameInMap("Framework")]
        [Validation(Required=false)]
        public string Framework { get; set; }

        [NameInMap("ImageProviderType")]
        [Validation(Required=false)]
        public string ImageProviderType { get; set; }

        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("ImageUrlVpc")]
        [Validation(Required=false)]
        public string ImageUrlVpc { get; set; }

    }

}
