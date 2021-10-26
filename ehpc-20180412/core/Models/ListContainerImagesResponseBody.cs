// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListContainerImagesResponseBody : TeaModel {
        [NameInMap("DBInfo")]
        [Validation(Required=false)]
        public string DBInfo { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public ListContainerImagesResponseBodyImages Images { get; set; }
        public class ListContainerImagesResponseBodyImages : TeaModel {
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<ListContainerImagesResponseBodyImagesImages> Images { get; set; }
            public class ListContainerImagesResponseBodyImagesImages : TeaModel {
                public string ImageId { get; set; }
                public string Repository { get; set; }
                public string Status { get; set; }
                public string System { get; set; }
                public string Tag { get; set; }
                public string Type { get; set; }
                public string UpdateDateTime { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
