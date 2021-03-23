// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class FindPrepublishesByVersionIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PrepublishList")]
        [Validation(Required=false)]
        public List<FindPrepublishesByVersionIdResponseBodyPrepublishList> PrepublishList { get; set; }
        public class FindPrepublishesByVersionIdResponseBodyPrepublishList : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("VersionType")]
            [Validation(Required=false)]
            public string VersionType { get; set; }

            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

            [NameInMap("BarrierCount")]
            [Validation(Required=false)]
            public string BarrierCount { get; set; }

            [NameInMap("DeviceModelId")]
            [Validation(Required=false)]
            public string DeviceModelId { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            [NameInMap("IsActive")]
            [Validation(Required=false)]
            public string IsActive { get; set; }

            [NameInMap("IsTotalPrepublish")]
            [Validation(Required=false)]
            public string IsTotalPrepublish { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }

            [NameInMap("DeviceModelName")]
            [Validation(Required=false)]
            public string DeviceModelName { get; set; }

            [NameInMap("PassedCount")]
            [Validation(Required=false)]
            public string PassedCount { get; set; }

            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=false)]
            public long? GmtCreateTimestamp { get; set; }

            [NameInMap("GmtModifyTimestamp")]
            [Validation(Required=false)]
            public long? GmtModifyTimestamp { get; set; }

        }

    }

}
