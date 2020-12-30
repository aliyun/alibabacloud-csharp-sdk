// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListStackResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("StackList")]
        [Validation(Required=false)]
        public ListStackResponseBodyStackList StackList { get; set; }
        public class ListStackResponseBodyStackList : TeaModel {
            [NameInMap("Stack")]
            [Validation(Required=false)]
            public List<ListStackResponseBodyStackListStack> Stack { get; set; }
            public class ListStackResponseBodyStackListStack : TeaModel {
                public string Status { get; set; }
                public string Version { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
