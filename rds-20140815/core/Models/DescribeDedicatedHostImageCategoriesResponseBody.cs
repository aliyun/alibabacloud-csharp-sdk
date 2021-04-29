// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDedicatedHostImageCategoriesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeDedicatedHostImageCategoriesResponseBodyImages Images { get; set; }
        public class DescribeDedicatedHostImageCategoriesResponseBodyImages : TeaModel {
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostImageCategoriesResponseBodyImagesImages> Images { get; set; }
            public class DescribeDedicatedHostImageCategoriesResponseBodyImagesImages : TeaModel {
                public string ImageCode { get; set; }
                public string ImageName { get; set; }
            }
        };

    }

}
