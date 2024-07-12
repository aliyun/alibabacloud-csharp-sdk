// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class FindUserAvailbleResourcesRequest : TeaModel {
        [NameInMap("bussinessCode")]
        [Validation(Required=false)]
        public string BussinessCode { get; set; }

        [NameInMap("currPage")]
        [Validation(Required=false)]
        public int? CurrPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
