// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20220913.Models
{
    public class ListDataSet2Request : TeaModel {
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        [NameInMap("pageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
