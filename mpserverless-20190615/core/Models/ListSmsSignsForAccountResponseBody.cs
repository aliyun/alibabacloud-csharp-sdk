// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class ListSmsSignsForAccountResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SmsSigns")]
        [Validation(Required=false)]
        public List<ListSmsSignsForAccountResponseBodySmsSigns> SmsSigns { get; set; }
        public class ListSmsSignsForAccountResponseBodySmsSigns : TeaModel {
            [NameInMap("SignName")]
            [Validation(Required=false)]
            public string SignName { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
