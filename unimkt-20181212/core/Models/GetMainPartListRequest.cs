// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class GetMainPartListRequest : TeaModel {
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("MainName")]
        [Validation(Required=false)]
        public string MainName { get; set; }

        [NameInMap("MainType")]
        [Validation(Required=false)]
        public int? MainType { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ParentMainId")]
        [Validation(Required=false)]
        public long? ParentMainId { get; set; }

    }

}
