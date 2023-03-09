// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20170718.Models
{
    public class GetFxUsersListRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("CustomerRebateType")]
        [Validation(Required=false)]
        public int? CustomerRebateType { get; set; }

        [NameInMap("IsSub")]
        [Validation(Required=false)]
        public int? IsSub { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ParentUid")]
        [Validation(Required=false)]
        public long? ParentUid { get; set; }

    }

}
