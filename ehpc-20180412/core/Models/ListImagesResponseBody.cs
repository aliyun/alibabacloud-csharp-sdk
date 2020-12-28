// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListImagesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OsTags")]
        [Validation(Required=false)]
        public List<ListImagesResponseBodyOsTags> OsTags { get; set; }
        public class ListImagesResponseBodyOsTags : TeaModel {
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

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

        }

    }

}
