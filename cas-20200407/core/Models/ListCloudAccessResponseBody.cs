// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCloudAccessResponseBody : TeaModel {
        [NameInMap("CloudAccessList")]
        [Validation(Required=false)]
        public List<ListCloudAccessResponseBodyCloudAccessList> CloudAccessList { get; set; }
        public class ListCloudAccessResponseBodyCloudAccessList : TeaModel {
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public long? AccessId { get; set; }

            [NameInMap("CloudName")]
            [Validation(Required=false)]
            public string CloudName { get; set; }

            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

        }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
