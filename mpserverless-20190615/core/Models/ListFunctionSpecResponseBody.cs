// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class ListFunctionSpecResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MemoryList")]
        [Validation(Required=false)]
        public List<ListFunctionSpecResponseBodyMemoryList> MemoryList { get; set; }
        public class ListFunctionSpecResponseBodyMemoryList : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("RuntimeList")]
        [Validation(Required=false)]
        public List<ListFunctionSpecResponseBodyRuntimeList> RuntimeList { get; set; }
        public class ListFunctionSpecResponseBodyRuntimeList : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
