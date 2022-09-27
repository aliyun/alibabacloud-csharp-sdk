// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20210728.Models
{
    public class QueryTraceMuRequest : TeaModel {
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public long? CreateTimeEnd { get; set; }

        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public long? CreateTimeStart { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public long? MessageId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
