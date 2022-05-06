// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class QueryNotifyRequest : TeaModel {
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        [NameInMap("WithConfirmed")]
        [Validation(Required=false)]
        public bool? WithConfirmed { get; set; }

    }

}
