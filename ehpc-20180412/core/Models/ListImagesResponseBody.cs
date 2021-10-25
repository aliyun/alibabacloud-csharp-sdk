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
        public ListImagesResponseBodyOsTags OsTags { get; set; }
        public class ListImagesResponseBodyOsTags : TeaModel {
            [NameInMap("OsInfo")]
            [Validation(Required=false)]
            public List<ListImagesResponseBodyOsTagsOsInfo> OsInfo { get; set; }
            public class ListImagesResponseBodyOsTagsOsInfo : TeaModel {
                public string Version { get; set; }
                public string BaseOsTag { get; set; }
                public string Platform { get; set; }
                public string OsTag { get; set; }
                public string ImageId { get; set; }
                public string Architecture { get; set; }
            }
        };

    }

}
