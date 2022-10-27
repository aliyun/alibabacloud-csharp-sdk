// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCustomImagesResponseBody : TeaModel {
        [NameInMap("Images")]
        [Validation(Required=false)]
        public ListCustomImagesResponseBodyImages Images { get; set; }
        public class ListCustomImagesResponseBodyImages : TeaModel {
            [NameInMap("ImageInfo")]
            [Validation(Required=false)]
            public List<ListCustomImagesResponseBodyImagesImageInfo> ImageInfo { get; set; }
            public class ListCustomImagesResponseBodyImagesImageInfo : TeaModel {
                [NameInMap("BaseOsTag")]
                [Validation(Required=false)]
                public ListCustomImagesResponseBodyImagesImageInfoBaseOsTag BaseOsTag { get; set; }
                public class ListCustomImagesResponseBodyImagesImageInfoBaseOsTag : TeaModel {
                    [NameInMap("Architecture")]
                    [Validation(Required=false)]
                    public string Architecture { get; set; }

                    [NameInMap("OsTag")]
                    [Validation(Required=false)]
                    public string OsTag { get; set; }

                    [NameInMap("Platform")]
                    [Validation(Required=false)]
                    public string Platform { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public ListCustomImagesResponseBodyImagesImageInfoOsTag OsTag { get; set; }
                public class ListCustomImagesResponseBodyImagesImageInfoOsTag : TeaModel {
                    [NameInMap("Architecture")]
                    [Validation(Required=false)]
                    public string Architecture { get; set; }

                    [NameInMap("BaseOsTag")]
                    [Validation(Required=false)]
                    public string BaseOsTag { get; set; }

                    [NameInMap("OsTag")]
                    [Validation(Required=false)]
                    public string OsTag { get; set; }

                    [NameInMap("Platform")]
                    [Validation(Required=false)]
                    public string Platform { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                [NameInMap("PostInstallScript")]
                [Validation(Required=false)]
                public string PostInstallScript { get; set; }

                [NameInMap("PricingCycle")]
                [Validation(Required=false)]
                public string PricingCycle { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                [NameInMap("SkuCode")]
                [Validation(Required=false)]
                public string SkuCode { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
