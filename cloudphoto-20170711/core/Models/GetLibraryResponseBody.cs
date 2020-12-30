// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class GetLibraryResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Library")]
        [Validation(Required=false)]
        public GetLibraryResponseBodyLibrary Library { get; set; }
        public class GetLibraryResponseBodyLibrary : TeaModel {
            [NameInMap("AutoCleanConfig")]
            [Validation(Required=false)]
            public GetLibraryResponseBodyLibraryAutoCleanConfig AutoCleanConfig { get; set; }
            public class GetLibraryResponseBodyLibraryAutoCleanConfig : TeaModel {
                [NameInMap("AutoCleanDays")]
                [Validation(Required=false)]
                public int? AutoCleanDays { get; set; }

                [NameInMap("AutoCleanEnabled")]
                [Validation(Required=false)]
                public bool? AutoCleanEnabled { get; set; }

            }
            [NameInMap("Quota")]
            [Validation(Required=false)]
            public GetLibraryResponseBodyLibraryQuota Quota { get; set; }
            public class GetLibraryResponseBodyLibraryQuota : TeaModel {
                [NameInMap("PhotosCount")]
                [Validation(Required=false)]
                public int? PhotosCount { get; set; }

                [NameInMap("TotalTrashQuota")]
                [Validation(Required=false)]
                public long? TotalTrashQuota { get; set; }

                [NameInMap("InactiveSize")]
                [Validation(Required=false)]
                public long? InactiveSize { get; set; }

                [NameInMap("ActiveSize")]
                [Validation(Required=false)]
                public long? ActiveSize { get; set; }

                [NameInMap("FacesCount")]
                [Validation(Required=false)]
                public int? FacesCount { get; set; }

                [NameInMap("VideosCount")]
                [Validation(Required=false)]
                public int? VideosCount { get; set; }

                [NameInMap("UsedQuota")]
                [Validation(Required=false)]
                public long? UsedQuota { get; set; }

                [NameInMap("TotalQuota")]
                [Validation(Required=false)]
                public long? TotalQuota { get; set; }

            }
            [NameInMap("Ctime")]
            [Validation(Required=false)]
            public long? Ctime { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
