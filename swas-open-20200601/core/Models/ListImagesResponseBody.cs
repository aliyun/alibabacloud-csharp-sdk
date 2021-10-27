// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListImagesResponseBody : TeaModel {
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<ListImagesResponseBodyImages> Images { get; set; }
        public class ListImagesResponseBodyImages : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
