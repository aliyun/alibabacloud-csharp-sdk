// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class FetchLibrariesResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Libraries")]
        [Validation(Required=false)]
        public List<FetchLibrariesResponseBodyLibraries> Libraries { get; set; }
        public class FetchLibrariesResponseBodyLibraries : TeaModel {
            [NameInMap("Ctime")]
            [Validation(Required=false)]
            public long? Ctime { get; set; }

            [NameInMap("LibraryId")]
            [Validation(Required=false)]
            public string LibraryId { get; set; }

            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public long? TotalQuota { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
