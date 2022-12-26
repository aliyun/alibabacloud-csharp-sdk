// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInterceptionImageResponseBody : TeaModel {
        [NameInMap("ImageList")]
        [Validation(Required=false)]
        public List<ListInterceptionImageResponseBodyImageList> ImageList { get; set; }
        public class ListInterceptionImageResponseBodyImageList : TeaModel {
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("ImageUuid")]
            [Validation(Required=false)]
            public string ImageUuid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
