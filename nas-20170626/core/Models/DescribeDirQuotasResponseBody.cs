// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDirQuotasResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("DirQuotaInfos")]
        [Validation(Required=false)]
        public List<DescribeDirQuotasResponseBodyDirQuotaInfos> DirQuotaInfos { get; set; }
        public class DescribeDirQuotasResponseBodyDirQuotaInfos : TeaModel {
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("DirInode")]
            [Validation(Required=false)]
            public string DirInode { get; set; }

            [NameInMap("UserQuotaInfos")]
            [Validation(Required=false)]
            public List<DescribeDirQuotasResponseBodyDirQuotaInfosUserQuotaInfos> UserQuotaInfos { get; set; }
            public class DescribeDirQuotasResponseBodyDirQuotaInfosUserQuotaInfos : TeaModel {
                [NameInMap("FileCountReal")]
                [Validation(Required=false)]
                public long? FileCountReal { get; set; }

                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

                [NameInMap("FileCountLimit")]
                [Validation(Required=false)]
                public long? FileCountLimit { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("SizeLimit")]
                [Validation(Required=false)]
                public long? SizeLimit { get; set; }

                [NameInMap("QuotaType")]
                [Validation(Required=false)]
                public string QuotaType { get; set; }

                [NameInMap("SizeReal")]
                [Validation(Required=false)]
                public long? SizeReal { get; set; }

            }

        }

    }

}
