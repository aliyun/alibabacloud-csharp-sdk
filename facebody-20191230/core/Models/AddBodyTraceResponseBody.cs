// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class AddBodyTraceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddBodyTraceResponseBodyData Data { get; set; }
        public class AddBodyTraceResponseBodyData : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
