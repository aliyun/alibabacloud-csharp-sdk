// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class FindPrepublishesByParentIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PrepublishList")]
        [Validation(Required=false)]
        public FindPrepublishesByParentIdResponseBodyPrepublishList PrepublishList { get; set; }
        public class FindPrepublishesByParentIdResponseBodyPrepublishList : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<FindPrepublishesByParentIdResponseBodyPrepublishListItems> Items { get; set; }
            public class FindPrepublishesByParentIdResponseBodyPrepublishListItems : TeaModel {
                public long? GmtCreateTimestamp { get; set; }
                public string DeviceModelId { get; set; }
                public string GmtModify { get; set; }
                public string IsActive { get; set; }
                public string VersionId { get; set; }
                public string BarrierCount { get; set; }
                public string IsTotalPrepublish { get; set; }
                public long? GmtModifyTimestamp { get; set; }
                public string ParentId { get; set; }
                public string GmtCreate { get; set; }
                public string Name { get; set; }
                public long? Id { get; set; }
                public string VersionType { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
