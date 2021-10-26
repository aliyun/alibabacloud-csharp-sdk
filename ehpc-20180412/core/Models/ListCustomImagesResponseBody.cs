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
                public string Description { get; set; }
                public string ImageId { get; set; }
                public string ImageName { get; set; }
                public string ImageOwnerAlias { get; set; }
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
                public string PostInstallScript { get; set; }
                public string PricingCycle { get; set; }
                public string ProductCode { get; set; }
                public int? Size { get; set; }
                public string SkuCode { get; set; }
                public string Status { get; set; }
                public string Uid { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
