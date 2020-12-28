// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCustomImagesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<ListCustomImagesResponseBodyImages> Images { get; set; }
        public class ListCustomImagesResponseBodyImages : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("PostInstallScript")]
            [Validation(Required=false)]
            public string PostInstallScript { get; set; }

            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }

            [NameInMap("OsTag")]
            [Validation(Required=false)]
            public ListCustomImagesResponseBodyImagesOsTag OsTag { get; set; }
            public class ListCustomImagesResponseBodyImagesOsTag : TeaModel {
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }
                [NameInMap("BaseOsTag")]
                [Validation(Required=false)]
                public string BaseOsTag { get; set; }
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }
            };

            [NameInMap("SkuCode")]
            [Validation(Required=false)]
            public string SkuCode { get; set; }

            [NameInMap("PricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("BaseOsTag")]
            [Validation(Required=false)]
            public ListCustomImagesResponseBodyImagesBaseOsTag BaseOsTag { get; set; }
            public class ListCustomImagesResponseBodyImagesBaseOsTag : TeaModel {
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }
            };

            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

        }

    }

}
